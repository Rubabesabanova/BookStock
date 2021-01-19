using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStock.Models;
using BookStock.DAL;

namespace BookStock
{
    public partial class RegisterControl : Form
    {
        public RegisterControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;

        public RegisterControl(Form form) : this()
        {
            _loginControl = form;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txbRegisterUsername.Text)
                    && !String.IsNullOrEmpty(this.txbRegisterEmail.Text)
                    && !String.IsNullOrEmpty(this.txbRegisterPassword.Text))
            {
                bool IsExists=false;
                foreach(User item in DatabaseSecond.Users.GetAll())
                {
                    if (this.txbRegisterEmail.Text == item.Email)
                    {
                        MessageBox.Show("The email is already used!");
                        IsExists = true;
                        break;
                    }
                }
                if (!IsExists)
                {
                    User user = new User()
                    {
                        Name = this.txbRegisterUsername.Text,
                        Email = this.txbRegisterEmail.Text,
                        Password = this.txbRegisterPassword.Text
                    };
                    DatabaseSecond.Users.Add(user);
                    MessageBox.Show("Successfully Registered!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }
            
        }

        private void llblRegisterLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginControl loginControl = new LoginControl();
            loginControl.ShowDialog();
            this.Close();
        }

    }
}
