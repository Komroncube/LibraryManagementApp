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
        BookOperation operation;
        StudentService stdservice;
        BookService bookser;
        LibrarianService lib;
        Guid id = Guid.Empty;
        public MainPage(Guid id)
        {
            InitializeComponent();
            stdservice = new StudentService();
            this.id = id;
            operation = new BookOperation();
            bookser = new BookService();
            lib = new LibrarianService();
            LoadData();
        }

        private void student_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            studentForm = null;
            LoadData();

            this.Show();
        }

        private void books_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
            bookForm = null;
            LoadData();

            this.Show();
        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            this.Hide();
            IssueBookForm issueBookForm = new IssueBookForm();
            issueBookForm.ShowDialog();
            issueBookForm = null;
            LoadData();

            this.Show();
        }

        private void returnbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.ShowDialog();
            returnBookForm = null;
            LoadData();

            this.Show();
        }

        private void buybook_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
            purchaseForm = null;
            LoadData();

            this.Show();
        }

        private void librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrarianForm librarianForm = new LibrarianForm();
            librarianForm.ShowDialog();
            librarianForm = null;
            LoadData();

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
        private void LoadData()
        {
            std_count.Text = stdservice.GetCount().ToString();
            book_count.Text = bookser.GetCount().ToString();
            librarian_count.Text = lib.GetCount().ToString();
            issued_count.Text = operation.GetIssuedCount().ToString();
            returned_count.Text = operation.GetReturnedCount().ToString();
            sold_count.Text = operation.GetSoldBooks().ToString();
        }

        
    }
}
