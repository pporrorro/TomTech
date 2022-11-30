using MySql.Data.MySqlClient;
using SecondTombuyScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecondTombuyScreen;

namespace ModernUI_SnapWindow
{
    public partial class MainForm : Form
    {
        DashBoard db = null;
        DataView dv = null;
        ProductManageControl pm = null;     
        Home4 h4 = null;
        Home5 h5 = null;

        // Fields
        private int borderSize = 1;
        int menu_width = 0;

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public MainForm()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize); // Border Size
            this.BackColor = Color.FromArgb(98, 102, 244); // Border Color
        }


        private void CollapseMenu()
        {
            if (this.panel1.Width > 200)
            {
                panel1.Width = 100;

                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in this.panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }

            else
            {
                panel1.Width = 230;

                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in this.panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "     " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DashBoard();
            dv = new DataView();
            pm = new SecondTombuyScreen.ProductManageControl();
            h4 = new Home4();
            h5 = new Home5();
            
            tableLayoutPanel_main.Controls.Add(db);
            db.Dock = DockStyle.Fill;

            menu_width = (int)tableLayoutPanel_bg.ColumnStyles[0].Width;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            label_title.Text = iconButton1.Text;
            tableLayoutPanel_main.Controls.Remove(tableLayoutPanel_main.GetControlFromPosition(0, 1));
            tableLayoutPanel_main.Controls.Add(db, 0, 1);
            db.Dock = DockStyle.Fill;
        }

        
        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            

            if (tableLayoutPanel_bg.ColumnStyles[0].Width == menu_width)
            {
                tableLayoutPanel_bg.ColumnStyles[0].Width = panel1.Width = 100;

                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in this.panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }

            else
            {
                tableLayoutPanel_bg.ColumnStyles[0].Width = panel1.Width = menu_width;

                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in this.panel1.Controls.OfType<Button>())
                {
                    menuButton.Text = "     " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            label_title.Text = iconButton2.Text;
            tableLayoutPanel_main.Controls.Remove(tableLayoutPanel_main.GetControlFromPosition(0, 1));
            tableLayoutPanel_main.Controls.Add(dv, 0, 1);
            dv.Dock = DockStyle.Fill;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            label_title.Text = iconButton3.Text;
            tableLayoutPanel_main.Controls.Remove(tableLayoutPanel_main.GetControlFromPosition(0, 1));
            tableLayoutPanel_main.Controls.Add(pm, 0, 1);
            pm.Dock = DockStyle.Fill;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            label_title.Text = iconButton4.Text;
            tableLayoutPanel_main.Controls.Remove(tableLayoutPanel_main.GetControlFromPosition(0, 1));
            tableLayoutPanel_main.Controls.Add(h4, 0, 1);
            h4.Dock = DockStyle.Fill;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            label_title.Text = iconButton5.Text;
            tableLayoutPanel_main.Controls.Remove(tableLayoutPanel_main.GetControlFromPosition(0, 1));
            tableLayoutPanel_main.Controls.Add(h5, 0, 1);
            h5.Dock = DockStyle.Fill;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
