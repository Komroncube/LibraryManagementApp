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
            studentdataview.Columns["First name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            studentdataview.Columns["Last name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            studentdataview.Columns["Phone number"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
                if (book.Quantity > 0)
                    bookgridview.Rows.Add(book.Id, book.Title, book.Description, book.Author, book.Quantity);
            }
            bookdataview.DataSource = bookgridview;
            bookdataview.Columns[0].Visible = false;
            bookdataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            bookdataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            bookdataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
            bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Quantity"] = count;
            foreach (DataRow row in bookgridview.Rows)
            {
                if (int.Parse(row["Quantity"].ToString()) == 0)
                {
                    bookgridview.Rows.Remove(row);
                }
            }
        }
        //editing cell size
        #region student_editing_cell_size
        private void studentdataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = studentdataview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value != null)
                {
                    // Calculate the required height for the cell
                    int preferredHeight = StudentCalculatePreferredRowHeight(studentdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Set the row height
                    if (studentdataview.Rows[e.RowIndex].Height < preferredHeight)
                    {
                        studentdataview.Rows[e.RowIndex].Height = preferredHeight;
                    }
                }
            }
        }

        private int StudentCalculatePreferredRowHeight(string cellText)
        {
            using (Graphics graphics = studentdataview.CreateGraphics())
            {
                SizeF size = graphics.MeasureString(cellText, studentdataview.Font, studentdataview.Columns["First name"].Width);
                return (int)size.Height + 5; // Add some extra padding
            }
        }
        #endregion editing_cell_size


        #region book_editing_cell_size
        private void bookdataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = bookdataview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value != null)
                {
                    // Calculate the required height for the cell
                    int preferredHeight = BookCalculatePreferredRowHeight(bookdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Set the row height
                    if (bookdataview.Rows[e.RowIndex].Height < preferredHeight)
                    {
                        bookdataview.Rows[e.RowIndex].Height = preferredHeight;
                    }
                }


            }
        }

        private int BookCalculatePreferredRowHeight(string cellText)
        {
            using (Graphics graphics = bookdataview.CreateGraphics())
            {
                SizeF size = graphics.MeasureString(cellText, bookdataview.Font, bookdataview.Columns["Description"].Width);
                return (int)size.Height + 5; // Add some extra padding
            }
        }
        #endregion editing_cell_size
    }
}
