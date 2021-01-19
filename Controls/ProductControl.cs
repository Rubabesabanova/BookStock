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
                    Product product = new Product();
                    product.Name = tbxProductName.Text;
                    product.Price = Convert.ToDouble(tbxProductPrice.Text);
                    Db.CreateProduct(product);
                    rtbxProductData.Text = $"Name : {product.Name}, Price : {product.Price} Created";
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
                bool isExists = false;
                foreach (Product product in products)
                {
                    if (Convert.ToInt32(tbxProductId.Text) == product.Id)
                    {
                        isExists = true;
                        product.Name = tbxProductName.Text;
                        product.Price = Convert.ToInt32(tbxProductPrice.Text);
                        Db.UpdateProduct(product);
                        rtbxProductData.Text = $"Name : {product.Name}, Price : {product.Price} Updated";
                        break;
                    }
                }
                 if(!isExists)
                    {
                        MessageBox.Show("There is no such product.");
                    }
                
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            using (Database Db = new Database("stockDb"))
            {
                int id = Convert.ToInt32(tbxProductId.Text);
                Db.DeleteProduct(id);
                rtbxProductData.Text = $"No {id}. product Deleted";
            }
        }
    }
}
