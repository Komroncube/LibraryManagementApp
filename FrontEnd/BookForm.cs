using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class BookForm : Form
    {
        BookService BookService = new BookService();
        bool isediting;
        private DataTable bookgridview;
        public BookForm()
        {
            InitializeComponent();
            List<Book> booklist = BookService.GetAll();

            //gridview table
            bookgridview = new DataTable();
            bookgridview.Columns.Add("Id");
            bookgridview.Columns.Add("Title");
            bookgridview.Columns.Add("Description");
            bookgridview.Columns.Add("Author");
            bookgridview.Columns.Add("Price");
            bookgridview.Columns.Add("Quantity");
            foreach (var item in booklist)
            {
                bookgridview.Rows.Add(item.Id.ToString(), item.Title, item.Description, item.Author, item.Price, item.Quantity);
            }
            dataview.DataSource = bookgridview;
            dataview.Columns[0].Visible = false;
            dataview.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataview.Columns["Author"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private bool isValid(out double value)
        {
            bool isvalid = true;
            if (title_input.Text.Trim() == "")
            {
                title_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (author_input.Text.Trim() == "")
            {
                author_lbl.ForeColor = Color.Red; ;
                isvalid = false;
            }
            if (!double.TryParse(price_input.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                MessageBox.Show("Kitobning narxini to'g'ri kiriting");
                price_lbl.ForeColor = Color.Red;
                isvalid = false;
            }
            if (quantity_updown.Value < 0)
            {
                quantity_lbl.ForeColor = Color.Red;
                quantity_updown.Value = 0;
                isvalid = false;
            }
            return isvalid;
        }
        private void ClearFields()
        {
            title_lbl.ForeColor = Color.Cyan;
            author_lbl.ForeColor = Color.Cyan;
            price_lbl.ForeColor = Color.Cyan;
            quantity_lbl.ForeColor = Color.Cyan;
            title_input.Clear();
            description_input.Clear();
            author_input.Clear();
            price_input.Clear();
            quantity_updown.Value = 0;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
            isediting = true;
            var items = bookgridview.Rows[dataview.CurrentCell.RowIndex].ItemArray;
            title_input.Text = items[1].ToString();
            description_input.Text = items[2].ToString();
            author_input.Text = items[3].ToString();
            price_input.Text = items[4].ToString();
            quantity_updown.Value = int.Parse(items[5].ToString());
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isediting == false)
                {
                    Guid delitem = Guid.Parse(bookgridview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString());

                    bookgridview.Rows[dataview.CurrentCell.RowIndex].Delete();
                    BookService.Delete(delitem);

                }
            }
            catch
            {

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            double value;
            if (isValid(out value))
            {
                var book = new Book()
                {
                    Title = title_input.Text.Trim(),
                    Description = description_input.Text.Trim(),
                    Author = author_input.Text.Trim(),
                    Price = value,
                    Quantity = (int)quantity_updown.Value,
                };
                if (isediting)
                {
                    bookgridview.Rows[dataview.CurrentCell.RowIndex]["Title"] = title_input.Text.Trim();
                    bookgridview.Rows[dataview.CurrentCell.RowIndex]["Description"] = description_input.Text.Trim();
                    bookgridview.Rows[dataview.CurrentCell.RowIndex]["Author"] = author_input.Text.Trim();
                    bookgridview.Rows[dataview.CurrentCell.RowIndex]["Price"] = value;
                    bookgridview.Rows[dataview.CurrentCell.RowIndex]["Quantity"] = quantity_updown.Value;
                    book.Id = Guid.Parse(bookgridview.Rows[dataview.CurrentCell.RowIndex]["Id"].ToString());
                    BookService.Update(book);
                    isediting = false;
                }
                else
                {
                    BookService.Create(book);
                    bookgridview.Rows.Add(book.Id, book.Title, book.Description, book.Author, book.Price, book.Quantity);
                }
                ClearFields();
            }
        }


        //editing cell size
        #region editing_cell_size
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataview.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell != null && cell.Value != null)
                {
                    // Calculate the required height for the cell
                    int preferredHeight = CalculatePreferredRowHeight(dataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Set the row height
                    if (dataview.Rows[e.RowIndex].Height < preferredHeight)
                    {
                        dataview.Rows[e.RowIndex].Height = preferredHeight;
                    }
                }
            }
        }

        private int CalculatePreferredRowHeight(string cellText)
        {
            using (Graphics graphics = dataview.CreateGraphics())
            {
                SizeF size = graphics.MeasureString(cellText, dataview.Font, dataview.Columns["Description"].Width);
                return (int)size.Height + 5; // Add some extra padding
            }
        }
        #endregion editing_cell_size
    }
}
