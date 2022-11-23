using SecondTombuyScreen.Properties;
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


        public ItemProp(ItemMaster _im, int orderCount, int count)
        {
            InitializeComponent();
            im = _im;

            switch (count) {
                case 1:
                    pictureBox1.Image = Resources._01;
                    break;
                case 2:
                    pictureBox1.Image = Resources._02;
                    break;
                case 3:
                    pictureBox1.Image = Resources._03;
                    break;
                case 4:
                    pictureBox1.Image = Resources._04;
                    break;
                case 5:
                    pictureBox1.Image = Resources._05;
                    break;
                case 6:
                    pictureBox1.Image = Resources._06;
                    break;
            }


            groupBox1.Text = im.Product_Name;
            vlblKf94LeftCount.Text = im.Product_Price.ToString() + " 원";

            lblKf94LeftCount.Text = (im.Stock_Qty - orderCount).ToString();
        }
    }
}
