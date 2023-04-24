using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "name" && txt_password.Text == "password")
            {
                new MainForm().Show();
                this.Hide();
            }
            else if (txt_username.Text == "cus name" && txt_password.Text == "cus password")
            {
                new MainForm2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or password");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
