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
using BookStock.Controls;
using BookStock.DAL;
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
            RegisterControl registerControl = new RegisterControl(this);
            registerControl.ShowDialog();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txbLoginEmail.Text)
                    && !String.IsNullOrEmpty(this.txbLoginPassword.Text))
            {
                bool IsExists = false;

                foreach (var user in DatabaseSecond.Users.GetAll())
                {
                    if (user.Email == this.txbLoginEmail.Text && user.Password == this.txbLoginPassword.Text)
                    {
                        MessageBox.Show("Successfully Logined!");
                        BookControl bookControl = new BookControl(this);
                        bookControl.ShowDialog();
                        IsExists = true;
                        break;
                    }
                }
                if (!IsExists)
                {
                    MessageBox.Show("Email or password is wrong! Please try again!");
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }
        }
        }
    }

