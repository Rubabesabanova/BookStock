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
    public partial class LoginControl : Form
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void llblLoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterControl registerControl = new RegisterControl();
            registerControl.ShowDialog();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (!String.IsNullOrEmpty(this.txbLoginEmail.Text)
                    && !String.IsNullOrEmpty(this.txbLoginPassword.Text))
            {
                bool isExist = false;

                foreach (var user in database.GetAllUsers())
                {
                    if (user.Email == this.txbLoginEmail.Text && user.Password == this.txbLoginPassword.Text)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist)
                {
                    MessageBox.Show("Successfully Logined!");
                }
                else
                {
                    MessageBox.Show("Username or password is wrong! Please try again!");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }
        }
        }
    }

