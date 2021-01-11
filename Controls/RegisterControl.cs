using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStock
{
    public partial class RegisterControl : Form
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (!String.IsNullOrEmpty(this.txbRegisterUsername.Text)
                    && !String.IsNullOrEmpty(this.txbRegisterEmail.Text)
                    && !String.IsNullOrEmpty(this.txbRegisterPassword.Text))
            {
                User user = new User()
                {
                    Username = this.txbRegisterUsername.Text,
                    Email = this.txbRegisterEmail.Text,
                    Password = this.txbRegisterPassword.Text
                };

                database.AddUser(user);
                MessageBox.Show("Successfully Registered!");
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }
            
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {

        }

        private void llblRegisterLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginControl loginControl = new LoginControl();
            loginControl.ShowDialog();
        }

        private void txbRegisterEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
