using BackEndService.Enums;
using System.Data;

namespace FrontEnd
{
    public partial class StudentForm : Form
    {
        private DataTable studentlistview;
        bool isediting;
        public StudentForm()
        {
            InitializeComponent();
            List<Student> studentlist = new StudentService().GetAll();

            //gridview table
            studentlistview = new DataTable();
            studentlistview.Columns.Add("Id");
            studentlistview.Columns.Add("First name");
            studentlistview.Columns.Add("Last name");
            studentlistview.Columns.Add("Phone number");
            studentlistview.Columns.Add("Faculty");
            foreach (var item in studentlist)
            {
                studentlistview.Rows.Add(item.Id.ToString(), item.FirstName, item.LastName, item.PhoneNumber, EnumService.EnumToString(item.Faculty));
            }
            dataview.DataSource = studentlistview;
            dataview.Columns[0].Visible = false;


            //combobox
            foreach (Faculty item in Enum.GetValues(typeof(Faculty)))
            {
                faculty.Items.Add(EnumService.EnumToString(item));
            }
            faculty.SelectedIndex = -1;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {

            ClearFields();
        }



        private void ClearFields()
        {
            first_lbl.ForeColor = Color.Black;
            last_lbl.ForeColor = Color.Black;
            phone_lbl.ForeColor = Color.Black;
            fac_lbl.ForeColor = Color.Black;
            firstname_input.Clear();
            lastname_input.Clear();
            phone_input.Clear();
            faculty.SelectedIndex = -1;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
            isediting = true;
            var items = studentlistview.Rows[dataview.CurrentCell.RowIndex].ItemArray;
            firstname_input.Text = items[1].ToString();
            lastname_input.Text = items[2].ToString();
            phone_input.Text = items[3].ToString();
            faculty.SelectedItem = items[4].ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isediting == false)
                {
                    Guid delitem = Guid.Parse(studentlistview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString());

                    studentlistview.Rows[dataview.CurrentCell.RowIndex].Delete();
                    new StudentService().Delete(ParseRowToStudent());
                }

            }
            catch
            {

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {


            if (isValid())
            {
                if (isediting)
                {
                    studentlistview.Rows[dataview.CurrentCell.RowIndex]["First name"] = firstname_input.Text.Trim();
                    studentlistview.Rows[dataview.CurrentCell.RowIndex]["Last name"] = lastname_input.Text.Trim();
                    studentlistview.Rows[dataview.CurrentCell.RowIndex]["Phone number"] = phone_input.Text.Trim();
                    studentlistview.Rows[dataview.CurrentCell.RowIndex]["Faculty"] = faculty.SelectedItem.ToString();
                    new StudentService().Update(ParseRowToStudent());
                    isediting = false;
                }
                else
                {
                    var std = new Student()
                    {
                        FirstName = firstname_input.Text.Trim(),
                        LastName = lastname_input.Text.Trim(),
                        PhoneNumber = phone_input.Text.Trim(),
                        Faculty = EnumService.StringToEnum(faculty.SelectedItem.ToString())
                    };
                    new StudentService().Create(std);
                    studentlistview.Rows.Add(std.Id, std.FirstName, std.LastName, std.PhoneNumber, faculty.Text);
                }
                ClearFields();

            }
        }

        private bool isValid()
        {
            bool isvalid = true;
            if (firstname_input.Text == "")
            {
                first_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (lastname_input.Text == "")
            {
                last_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (phone_input.Text == "" || phone_input.Text.Length != 12)
            {
                phone_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (faculty.SelectedIndex == -1)
            {
                fac_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            return isvalid;
        }
        private Student ParseRowToStudent()
        {
            var items = studentlistview.Rows[dataview.CurrentCell.RowIndex].ItemArray;
            var std = new Student()
            {
                Id = Guid.Parse(items[0].ToString()),
                FirstName = items[1].ToString(),
                LastName = items[2].ToString(),
                PhoneNumber = items[3].ToString(),
                Faculty = EnumService.StringToEnum(items[4].ToString())
            };
            return std;
        }
    }
}
