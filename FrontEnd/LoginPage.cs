using BackEndService.Data;

namespace FrontEnd
{
    public partial class LoginPage : Form
    {
        Guid id;
        public LoginPage()
        {
            InitializeComponent();
            label1.Select();
        }

        private void showcb_CheckedChanged(object sender, EventArgs e)
        {
            if (showcb.Checked == true)
            {
                pass_input.UseSystemPasswordChar = false;
            }
            else
            {
                pass_input.UseSystemPasswordChar = true;
            }
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            if (username_input.Text == "")
            {
                isvalid = false;
            }
            if (pass_input.Text == "")
            {
                isvalid = false;
            }
            LibraryManagementDb db = new LibraryManagementDb();
            if (isvalid == false)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {

                if (new LibrarianService().CheckUser(username_input.Text, pass_input.Text, out id))
                {
                    MainPage mainPage = new MainPage(id);
                    mainPage.FormClosing += MainPage_FormClosing;
                    mainPage.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }

        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Application.Exit();
            }
        }
    }
}