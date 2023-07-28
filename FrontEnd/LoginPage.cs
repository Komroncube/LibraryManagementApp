using BackEndService.Data;

namespace FrontEnd
{
    public partial class LoginPage : Form
    {
        bool devmode = false;

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
            if (devmode)
            {

            }
            else
            {
                if (username_input.Text == "")
                {
                    isvalid = false;
                }
                if (pass_input.Text == "")
                {
                    isvalid = false;
                }
                LibraryManagementDb db = new LibraryManagementDb();
                if (isvalid==false)
                {
                        MessageBox.Show("Invalid username or password");
                }
                else
                {
                    var res = db.Librarian.FirstOrDefault(x => x.UserName == username_input.Text && x.Password == pass_input.Text);
                    if (res != null)
                    {
                        //yangi window opens
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        }
    }
}