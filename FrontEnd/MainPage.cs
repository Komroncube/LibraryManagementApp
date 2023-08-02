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
    public partial class MainPage : Form
    {
        Guid id = Guid.Empty;
        public MainPage(Guid id)
        {
            InitializeComponent();
            this.id = id;

            std_count.Text = new StudentService().GetCount().ToString();
            book_count.Text = new BookService().GetCount().ToString();  
            librarian_count.Text = new LibrarianService().GetCount().ToString();
            issued_count.Text = new BookOperation().GetIssuedCount().ToString();
            returned_count.Text = new BookOperation().GetReturnedCount().ToString();
            sold_count.Text = new BookOperation().GetSoldBooks().ToString();
        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            studentForm = null;
            this.Show();
        }

        private void books_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            bookForm = null;
            this.Show();
        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.ShowDialog();
            issueBookForm = null;
            this.Show();
        }

        private void returnbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
            returnBookForm = null;
            this.Show();
        }

        private void buybook_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
            purchaseForm = null;
            this.Show();
        }

        private void librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.ShowDialog();
            librarianForm = null;
            this.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {

            LoginPage loginPage = new LoginPage();
            loginPage.FormClosing += LoginPage_FormClosing;
            loginPage.Show();
            this.Hide();
        }
        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }

        private void student_MouseHover(object sender, EventArgs e)
        {
            student.ForeColor = Color.LightGreen;
        }

        private void student_MouseLeave(object sender, EventArgs e)
        {
            student.ForeColor = Color.White;
        }
    }
}
