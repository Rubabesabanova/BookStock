using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStock.Controls
{
    public partial class ProductGridControl : Form
    {
        public ProductGridControl()
        {
            InitializeComponent();
            GetAll();
        }

        public void GetAll()
        {
            using (Database Db = new Database("stockDb"))
            {
                var productgrids = Db.GetAllGrid();
                dgvProduct.DataSource = productgrids;
            }
        }
    }
}
