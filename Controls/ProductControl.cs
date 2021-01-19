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

namespace BookStock.Controls
{
    public partial class ProductControl : Form
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {
            using (Database Db = new Database("stockDb"))
            {
                var products = Db.GetAllProducts();
                foreach (Product product in products)
                {
                    rtbxProductData.Text += $"Id : {product.Id}, Name : {product.Name}, Price : {product.Price}";
                }
            }
            
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tbxProductName.Text)
                    && !String.IsNullOrEmpty(this.tbxProductPrice.Text))
            {
                using (Database Db = new Database("stockDb"))
                {
                    bool IsExists = false;
                    foreach (Product product in Db.GetAllProducts())
                    {
                        if (this.tbxProductName.Text == product.Name)
                        {
                            MessageBox.Show("The product is already added!");
                            IsExists = true;
                            break;
                        }
                    }
                    if (!IsExists)
                    {
                        Product product = new Product();
                        product.Name = tbxProductName.Text;
                        product.Price = Convert.ToDouble(tbxProductPrice.Text);
                        Db.CreateProduct(product);
                        rtbxProductData.Text = $"Name : {product.Name}, Price : {product.Price} Created";
                    }
                }
            }
                
            else
            {
                MessageBox.Show("All fields must be filled!");
            }

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            using (Database Db = new Database("stockDb"))
            {
                var products = Db.GetAllProducts();
                foreach (Product product in products)
                {
                    if (Convert.ToInt32(this.tbxProductId.Text) == product.Id)
                    {
                        product.Name = tbxProductName.Text;
                        product.Price = Convert.ToInt32(tbxProductPrice.Text);
                    }
                    else
                    {
                        MessageBox.Show("There is no such product.");
                    }
                }
            }
        }
    }
}
