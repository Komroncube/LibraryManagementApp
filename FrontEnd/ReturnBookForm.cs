namespace FrontEnd
{
    public partial class ReturnBookForm : Form
    {
        DataTable issuedgridview;
        DataTable returnedgridview;
        BookOperation bookOperation;
        IEnumerable<BookStudentView> bookStudents;
        public ReturnBookForm()
        {
            InitializeComponent();
            student_lbl.Select();
            bookOperation = new BookOperation();
            bookStudents = bookOperation.GetStudentBooks();


            issuedgridview = new DataTable();
            issuedgridview.Columns.Add("Id");
            issuedgridview.Columns.Add("Student firstname");
            issuedgridview.Columns.Add("Student lastname");
            issuedgridview.Columns.Add("Phone number");
            issuedgridview.Columns.Add("Title");
            issuedgridview.Columns.Add("Description");
            issuedgridview.Columns.Add("Author");
            issueddataview.DataSource = issuedgridview;

            issueddataview.Columns[0].Visible = false;
            issueddataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            issueddataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            issueddataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            returnedgridview = new DataTable();
            returnedgridview.Columns.Add("Id");
            returnedgridview.Columns.Add("Student firstname");
            returnedgridview.Columns.Add("Student lastname");
            returnedgridview.Columns.Add("Phone number");
            returnedgridview.Columns.Add("Title");
            returnedgridview.Columns.Add("Description");
            returnedgridview.Columns.Add("Author");
            returnedgridview.Columns.Add("Returned date");



            returneddataview.DataSource = returnedgridview;
            returneddataview.Columns[0].Visible = false;
            returneddataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            returneddataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            returneddataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            AddIssuedData();
            AddReturnedData();


        }
        
        private void return_btn_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(issuedgridview.Rows[issueddataview.CurrentCell.RowIndex]["Id"].ToString());
            var item = bookStudents.First(x => x.Id == id);
            item.Status = Status.Returned;
            item.ReturnedDate = DateTime.UtcNow;
            bookOperation.ReturnBook(id);
            student_input.Text = "";
            book_input.Text = "";
            MessageBox.Show("Book returned successfully");
            AddReturnedData();
            AddIssuedData();

        }

        private void student_input_TextChanged(object sender, EventArgs e)
        {
            AddIssuedData();
        }

        private void book_input_TextChanged(object sender, EventArgs e)
        {
            AddIssuedData();
        }

        private void AddIssuedData()
        {
            issuedgridview.Rows.Clear();
            foreach (BookStudentView book in bookStudents)
            {
                if (book.Status==Status.Issued && Array.Exists(new string[] { book.Author.ToLower(), book.Description.ToLower() }, s => s.Contains(book_input.Text.Trim().ToLower())) && Array.Exists(new string[] { book.FirstName.ToLower(), book.LastName.ToLower(), book.PhoneNumber.ToLower() }, s => s.Contains(student_input.Text.Trim().ToLower())))
                    issuedgridview.Rows.Add(book.Id, book.FirstName, book.LastName, book.PhoneNumber, book.Title, book.Description, book.Author);
            }
        }
        private void AddReturnedData()
        {
            returnedgridview.Rows.Clear();
            foreach(BookStudentView book in bookStudents)
            {
                returnedgridview.Rows.Add(book.Id, book.FirstName, book.LastName, book.PhoneNumber, book.Title, book.Description, book.Author, book.ReturnedDate);

            }
        }
        #region issue_editing_cell_size
        private void issuedataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = issueddataview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value != null)
                {
                    // Calculate the required height for the cell
                    int preferredHeight = IssueCalculatePreferredRowHeight(issueddataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Set the row height
                    if (issueddataview.Rows[e.RowIndex].Height < preferredHeight)
                    {
                        issueddataview.Rows[e.RowIndex].Height = preferredHeight;
                    }
                }


            }
        }

        private int IssueCalculatePreferredRowHeight(string cellText)
        {
            using (Graphics graphics = issueddataview.CreateGraphics())
            {
                SizeF size = graphics.MeasureString(cellText, issueddataview.Font, issueddataview.Columns["Description"].Width);
                return (int)size.Height + 5; // Add some extra padding
            }
        }
        #endregion editing_cell_size
        #region return_editing_cell_size
        private void return_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = issueddataview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value != null)
                {
                    // Calculate the required height for the cell
                    int preferredHeight = ReturnCalculatePreferredRowHeight(issueddataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Set the row height
                    if (issueddataview.Rows[e.RowIndex].Height < preferredHeight)
                    {
                        issueddataview.Rows[e.RowIndex].Height = preferredHeight;
                    }
                }


            }
        }

        private int ReturnCalculatePreferredRowHeight(string cellText)
        {
            using (Graphics graphics = issueddataview.CreateGraphics())
            {
                SizeF size = graphics.MeasureString(cellText, issueddataview.Font, issueddataview.Columns["Description"].Width);
                return (int)size.Height + 5; // Add some extra padding
            }
        }
        #endregion editing_cell_size


    }
}
