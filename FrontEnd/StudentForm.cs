using System.Data;

namespace FrontEnd
{
    public partial class StudentForm : Form
    {
        private DataTable studentlistview;
        private List<Student> studentlist;
        public StudentForm()
        {
            InitializeComponent();
            studentlist=StudentService
            studentlistview = new DataTable();
            studentlistview.Columns.Add("Id");
            studentlistview.Columns.Add("First name");
            studentlistview.Columns.Add("Last name");
            studentlistview.Columns.Add("Phone number");
            studentlistview.Columns.Add("Faculty");
            dataview.DataSource = studentlistview;

        }
    }
}
