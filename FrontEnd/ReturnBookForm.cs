using BackEndService.Service;
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
    public partial class ReturnBookForm : Form
    {
        DataTable issuedgridview;
        DataTable returnedbookgridview;
        BookOperation bookOperation;

        public ReturnBookForm()
        {
            InitializeComponent();
            student_lbl.Select();
            bookOperation = new BookOperation();
            
            AddDataToTable(out issuedgridview,out returnedbookgridview);
            issueddataview.DataSource = issuedgridview;
            issueddataview.Columns[0].Visible = false;
            issueddataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            issueddataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            issueddataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            returneddataview.DataSource = returnedbookgridview;
            returneddataview.Columns[0].Visible = false;
            returneddataview.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            returneddataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            returneddataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;



        }
        private void AddDataToTable(out DataTable issue, out DataTable returned)
        {
            var bookstudent = BookOperation.GetStudentBooks();
            issue = new DataTable();
            issue.Columns.Add("Id");
            issue.Columns.Add("Student firstname");
            issue.Columns.Add("Student lastname");
            issue.Columns.Add("Phone number");
            issue.Columns.Add("Title");
            issue.Columns.Add("Description");
            issue.Columns.Add("Author");


            returned = new DataTable();
            returned.Columns.Add("Id");
            returned.Columns.Add("Student firstname");
            returned.Columns.Add("Student lastname");
            returned.Columns.Add("Phone number");
            returned.Columns.Add("Title");
            returned.Columns.Add("Description");
            returned.Columns.Add("Author");
            foreach (var book in bookstudent)
            {
                
                if (book.Status == BackEndService.Enums.Status.Issued)
                {
                    issue.Rows.Add(book.Id, book.FirstName, book.LastName, book.PhoneNumber, book.Title, book.Description, book.Author);
                }
                else
                {
                    returned.Rows.Add(book.Id, book.FirstName, book.LastName, book.PhoneNumber, book.Title, book.Description, book.Author);

                }
            }

        }
        private void return_btn_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(issuedgridview.Rows[issueddataview.CurrentCell.RowIndex]["Id"].ToString());
            bookOperation.ReturnBook(id);
            student_input.Text = "";
            book_input.Text = "";
            MessageBox.Show("Book returned successfully");
            AddDataToTable(out issuedgridview, out returnedbookgridview);
            issueddataview.DataSource = issuedgridview;
            returneddataview.DataSource = returnedbookgridview;
        }

        private void student_input_TextChanged(object sender, EventArgs e)
        {
            string searchText = student_input.Text.ToLower();

            // Create a DataView of the DataTable
            DataView dataView = new DataView(issuedgridview);

            // Filter the rows of the DataView based on search text
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%' OR [{3}] LIKE '%{1}%'", "Student firstname", searchText, "Student lastname", "Phone number");
            // Set the DataView as the data source of the DataGridView
            issueddataview.DataSource = dataView;
        }

        private void book_input_TextChanged(object sender, EventArgs e)
        {
            string searchText = book_input.Text.ToLower();
            // Create a DataView of the DataTable


            DataView dataView = new DataView(issuedgridview);

            // Filter the rows of the DataView based on search text
            dataView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%' OR [{3}] LIKE '%{1}%'", "Title", searchText, "Description", "Author");
            // Set the DataView as the data source of the DataGridView
            issueddataview.DataSource = dataView;
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
