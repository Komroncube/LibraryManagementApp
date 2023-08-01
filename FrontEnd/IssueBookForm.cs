using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class IssueBookForm : Form
    {
        DataTable studentgridview;
        DataTable bookgridview;
        BookOperation bookOperation;
        public IssueBookForm()
        {
            InitializeComponent();
            student_lbl.Select();
            bookOperation = new BookOperation();
            //student table
            List<Student> students = new StudentService().GetAll();
            studentgridview = new DataTable();
            studentgridview.Columns.Add("Id");
            studentgridview.Columns.Add("First name");
            studentgridview.Columns.Add("Last name");
            studentgridview.Columns.Add("Phone number");
            foreach (Student student in students)
            {
                studentgridview.Rows.Add(student.Id, student.FirstName, student.LastName, student.PhoneNumber);
            }
            studentdataview.DataSource = studentgridview;
            studentdataview.Columns[0].Visible = false;

            //book table
            List<Book> books = new BookService().GetAll();
            bookgridview = new DataTable();
            bookgridview.Columns.Add("Id");
            bookgridview.Columns.Add("Title");
            bookgridview.Columns.Add("Description");
            bookgridview.Columns.Add("Author");
            bookgridview.Columns.Add("Quantity");
            foreach (Book book in books)
            {
                if(book.Quantity> 0)
                    bookgridview.Rows.Add(book.Id, book.Title, book.Description, book.Author, book.Quantity);
            }
            bookdataview.DataSource = bookgridview;
            bookdataview.Columns[0].Visible = false;
        }
        private void student_input_TextChanged(object sender, EventArgs e)
        {
            string searchText = student_input.Text.ToLower();

            // Create a DataView of the DataTable
            DataView dataView = new DataView(studentgridview);

            // Filter the rows of the DataView based on search text
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%' OR [{3}] LIKE '%{1}%'", "First name", searchText, "Last name", "Phone number");
            // Set the DataView as the data source of the DataGridView
            studentdataview.DataSource = dataView;
        }

        private void book_input_TextChanged(object sender, EventArgs e)
        {
            string searchText = book_input.Text.ToLower();
            // Create a DataView of the DataTable
            
            
            DataView dataView = new DataView(bookgridview);

            // Filter the rows of the DataView based on search text
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%' OR [{3}] LIKE '%{1}%'", "Title", searchText, "Description", "Author");
            // Set the DataView as the data source of the DataGridView
            bookdataview.DataSource = dataView;
        }   

        private void issue_btn_Click(object sender, EventArgs e)
        {
            var issuebook = new BookStudent()
            {
                StudentId = Guid.Parse(studentgridview.Rows[studentdataview.CurrentCell.RowIndex]["Id"].ToString()),
                BookId = Guid.Parse(bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Id"].ToString()),
                Status = BackEndService.Enums.Status.Issued,
                IssueDate = DateTime.UtcNow,
            };
            bookOperation.IssueBook(issuebook);
            student_input.Text = "";
            book_input.Text = "";
            MessageBox.Show("Book issued successfully");
            bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Id"].ToString();
            int count = int.Parse(bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Quantity"].ToString());
            count -= 1;
            bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Quantity"]=count;
            foreach (DataRow row in bookgridview.Rows)
            {
                if (int.Parse(row["Quantity"].ToString()) == 0)
                {
                    bookgridview.Rows.Remove(row);
                }
            }
        }
    }
}
