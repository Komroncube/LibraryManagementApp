namespace FrontEnd
{
    public partial class IssueBookForm : Form
    {
        DataTable studentgridview;
        DataTable bookgridview;
        BookOperation bookOperation;
        StudentService stdservice;
        BookService bookService;
        IEnumerable<Student> students;
        IEnumerable<Book> books;
        public IssueBookForm()
        {
            InitializeComponent();
            stdservice = new StudentService();
            student_lbl.Select();
            bookOperation = new BookOperation();
            bookService = new BookService();
            //student table
            studentgridview = new DataTable();
            studentgridview.Columns.Add("Id");
            studentgridview.Columns.Add("First name");
            studentgridview.Columns.Add("Last name");
            studentgridview.Columns.Add("Phone number");
            students = stdservice.GetAll();
            AddStudentData();
            studentdataview.DataSource = studentgridview;
            studentdataview.Columns[0].Visible = false;
            studentdataview.Columns["First name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            studentdataview.Columns["Last name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            studentdataview.Columns["Phone number"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //book table
            books = bookService.GetAll();
            bookgridview = new DataTable();
            bookgridview.Columns.Add("Id");
            bookgridview.Columns.Add("Title");
            bookgridview.Columns.Add("Description");
            bookgridview.Columns.Add("Author");
            bookgridview.Columns.Add("Quantity");
            AddBookData();
            bookdataview.DataSource = bookgridview;
            bookdataview.Columns[0].Visible = false;
            bookdataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            bookdataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            bookdataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private void AddBookData()
        {
            bookgridview.Rows.Clear();
            foreach(Book book in books)
            {
                if (Array.Exists(new string[] { book.Author.ToLower(), book.Description.ToLower() }, s => s.Contains(book_input.Text.Trim().ToLower())) && book.Quantity>0)
                    bookgridview.Rows.Add(book.Id, book.Title, book.Description, book.Author, book.Quantity);
            }
        }
        private void AddStudentData()
        {
            studentgridview.Rows.Clear();
            foreach(Student std in students)
            {
                if (Array.Exists(new string[] { std.FirstName.ToLower(), std.LastName.ToLower(), std.PhoneNumber.ToLower() }, s => s.Contains(student_input.Text.Trim().ToLower())))
                    studentgridview.Rows.Add(std.Id, std.FirstName, std.LastName, std.PhoneNumber);
            }   
        }
        private void student_input_TextChanged(object sender, EventArgs e)
        {
            AddStudentData();
        }

        private void book_input_TextChanged(object sender, EventArgs e)
        {
            AddBookData();
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var issuebook = new BookStudent()
                {
                    StudentId = Guid.Parse(studentgridview.Rows[studentdataview.CurrentCell.RowIndex]["Id"].ToString()),
                    BookId = Guid.Parse(bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Id"].ToString()),
                    Status =Status.Issued,
                    IssueDate = DateTime.UtcNow,
                };
                bookOperation.IssueBook(issuebook);
                MessageBox.Show("Book issued successfully");
                Guid id = Guid.Parse(bookgridview.Rows[bookdataview.CurrentCell.RowIndex]["Id"].ToString());
                var book = books.First(book=>book.Id == id);
                book.Quantity -= 1;
                student_input.Text = string.Empty;
                book_input.Text= string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xato ma'lumot kiritildi");
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
