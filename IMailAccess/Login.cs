using System;
using System.Windows.Forms;

namespace IMailAccess
{
    public partial class Login : Form
    {
        string username = "نامه";
        string password = "123";
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (name.Text == username)
            {
                if (pass.Text == password)
                {
                    Indicator IDK = new Indicator();
                    IDK.Show();
                    this.Hide();
                }
                else
                {
                    Error();
                }
            }
            else
            {
                Error();
            }
        }

        private void Error()
        {
            name.Text = "";
            pass.Text = "";
            MessageBox.Show("نام / رمز اشتباه است");
            name.Focus();
        }
    }
}
