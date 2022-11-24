using SecondTombuyScreen.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            string sProductName = groupBox1.Text;
            string sLeftCount = lblProductPrice.Text;
            string sProductPrice = lblProductPrice.Text;
            int iOrderCount = (int)numCount1.Value;
        }



        public ItemProp(ItemMaster _im, int orderCount, int count)
        {
            InitializeComponent();
            string sProductName = groupBox1.Text;
            string sProductPrice = lblProductPrice.Text;
            string sLeftCount = lblLeftCount.Text;
            int iOrderCount = (int)numCount1.Value;

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

            sProductName = im.Product_Name;
            sProductPrice = im.Product_Price.ToString() + " 원";
            sLeftCount = (im.Stock_Qty - orderCount).ToString();

            groupBox1.Text = sProductName;
            lblProductPrice.Text = sProductPrice;
            lblLeftCount.Text = sLeftCount;

        }
    }
}
