using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BookStock.DAL;
using BookStock.Models;

namespace BookStock.Controls
{
    public partial class BookControl : Form
    {
        public BookControl()
        {
            InitializeComponent();
            Book book1 = new Book()
            {
                Id = 1,
                Name = "C#",
                Image = @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\4136Vv9FsvL._SX334_BO1,204,203,200_.jpg"
            };
            Book book2 = new Book()
            {
                Id = 1,
                Name = "Python",
                Image = @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\51tjBN6kkEL._SX374_BO1,204,203,200_.jpg"
            };
            Book book3 = new Book()
            {
                Id = 1,
                Name = "Java",
                Image = @"D:\C#course\ShopManagementApp\ShopManagementApp\Images\images.jpg"
            };
            DatabaseSecond.Books.Add(book1);
            DatabaseSecond.Books.Add(book2);
            DatabaseSecond.Books.Add(book3);
            var bookList = DatabaseSecond.Books.GetAll();
            int x = 30;
            int picX = 280;
            foreach (var book in bookList)
            {
                GroupBox gbxBook = new GroupBox();
                gbxBook.Text = book.Name;
                gbxBook.Size = new Size(140, 160);
                gbxBook.Location = new Point(x, 23);
                x += 120;
                this.Controls.Add(gbxBook);
            }
            string[] images = Directory.GetFiles(@"D:\C#course\ShopManagementApp\ShopManagementApp\Images", "*.jpg");
            foreach (var image in images)
            {

                PictureBox pictureBox = new PictureBox();

                pictureBox.Name = "pictureBox";
                pictureBox.Size = new Size(100, 100);
                pictureBox.Location = new Point(picX, 23);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile(image);

                picX += 310;
                this.Controls.Add(pictureBox);


            }
        }
        private Form _loginControl;
        

        public BookControl(Form form) : this()
        {
            _loginControl = form;
        }

        
    }
}
