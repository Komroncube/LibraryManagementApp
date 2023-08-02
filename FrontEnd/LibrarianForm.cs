using BackEndService.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class LibrarianForm : Form
    {
        LibrarianService libser = new LibrarianService();
        bool isediting;
        private DataTable librariangridview;
        public LibrarianForm()
        {
            InitializeComponent();
            List<Librarian> librarianlist = libser.GetAll();

            //gridview table
            librariangridview = new DataTable();
            librariangridview.Columns.Add("Id");
            librariangridview.Columns.Add("First name");
            librariangridview.Columns.Add("Last name");
            librariangridview.Columns.Add("Phone number");
            librariangridview.Columns.Add("Username");
            librariangridview.Columns.Add("Password");
            foreach (var item in librarianlist)
            {
                librariangridview.Rows.Add(item.Id.ToString(), item.FirstName, item.LastName, item.PhoneNumber, item.UserName, item.Password);
            }
            dataview.DataSource = librariangridview;
            dataview.Columns[0].Visible = false;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            firstname_lbl.ForeColor = Color.Cyan;
            lastname_lbl.ForeColor = Color.Cyan;
            phone_lbl.ForeColor = Color.Cyan;
            username_lbl.ForeColor = Color.Cyan;
            password_lbl.ForeColor = Color.Cyan;
            firstname_input.Clear();
            lastname_input.Clear();
            phone_input.Clear();
            username_input.Clear();
            password_input.Clear();
        }
        private bool isValid()
        {
            bool isvalid = true;
            string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{4,}$";
            if (firstname_input.Text == "")
            {
                firstname_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (lastname_input.Text == "")
            {
                lastname_lbl.ForeColor = Color.Red; ;
                isvalid = false;
            }
            if (phone_input.Text == "" || phone_input.Text.Length != 12)
            {
                phone_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (username_input.Text == "" || libser.isExist(username_input.Text))
            {
                username_lbl.ForeColor = Color.Red;
                isvalid = false;
                MessageBox.Show("Username must be unique");
            }
            if (username_input.Text == "" || !Regex.IsMatch(password_input.Text, regexPattern))
            {
                password_lbl.ForeColor = Color.Red;
                isvalid = false;
                MessageBox.Show("Password should have contain\n" +
                    "* at least one lowercase character\n" +
                    "* at least one uppercase character\n" +
                    "* at least one numerical digit\n" +
                    "* minimum length of 4");
            }
            return isvalid;

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
            isediting = true;
            var items = librariangridview.Rows[dataview.CurrentCell.RowIndex].ItemArray;
            firstname_input.Text = items[1].ToString();
            lastname_input.Text = items[2].ToString();
            phone_input.Text = items[3].ToString();
            username_input.Text = items[4].ToString();
            password_input.Text = items[5].ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isediting == false)
                {
                    Guid delitem = Guid.Parse(librariangridview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString());

                    librariangridview.Rows[dataview.CurrentCell.RowIndex].Delete();
                    libser.Delete(delitem);
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
                    librariangridview.Rows[dataview.CurrentCell.RowIndex]["First name"] = firstname_input.Text.Trim();
                    librariangridview.Rows[dataview.CurrentCell.RowIndex]["Last name"] = lastname_input.Text.Trim();
                    librariangridview.Rows[dataview.CurrentCell.RowIndex]["Phone number"] = phone_input.Text.Trim();
                    librariangridview.Rows[dataview.CurrentCell.RowIndex]["Username"] = username_input.Text.Trim();
                    librariangridview.Rows[dataview.CurrentCell.RowIndex]["Password"] = password_input.Text.Trim();

                    libser.Update(new Librarian()
                    {
                        Id = Guid.Parse(librariangridview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString()),
                        FirstName = firstname_input.Text.Trim(),
                        LastName = lastname_input.Text.Trim(),
                        PhoneNumber = phone_input.Text.Trim(),
                        UserName = username_input.Text.Trim(),
                        Password = password_input.Text.Trim(),
                    });
                    isediting = false;
                }
                else
                {
                    var lib = new Librarian()
                    {
                        FirstName = firstname_input.Text.Trim(),
                        LastName = lastname_input.Text.Trim(),
                        PhoneNumber = phone_input.Text.Trim(),
                        UserName = username_input.Text.Trim(),
                        Password = password_input.Text.Trim(),
                    };
                    libser.Create(lib);
                    librariangridview.Rows.Add(lib.Id, lib.FirstName, lib.LastName, lib.PhoneNumber, lib.UserName, lib.Password);
                }
                ClearFields();
            }
        }
    }
}
