using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTombuyScreen
{
    public partial class ItemProp : UserControl
    {
        public ItemMaster im;
        public ItemProp()
        {
            InitializeComponent();
        }


        public ItemProp(ItemMaster _im, int orderCount)
        {
            InitializeComponent();
            im = _im;

            groupBox1.Text = im.Product_Name;
            vlblKf94LeftCount.Text = im.Product_Price.ToString() + " 원";

            lblKf94LeftCount.Text = (im.Stock_Qty - orderCount).ToString();
        }
    }
}
