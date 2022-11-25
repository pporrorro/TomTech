using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Runtime.InteropServices;
using RJCodeAdvance.RJControls;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace ModernUI_SnapWindow
{
    public partial class Form1 : Form
    {
        private string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

        // Fields
        private int borderSize = 2;

        // Constructor
        public Form1()
        {

            MySqlConnection conn = new MySqlConnection(strConn);
            InitializeComponent();
            this.Padding = new Padding(borderSize); // Border Size
            this.BackColor = Color.FromArgb(98, 102, 244); // Border Color
            DataGridView();
            PieChart();
            LiveChartSource();
            GraphChart();

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelTitleBar_MouseDown_1(object sender, MouseEventArgs e) // 마우스 화면 드래그 기능
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//

        //Overridden methods
        protected override void WndProc(ref Message m) // 폼 상단바 제거 기능
        {


            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            // Remove border and keep snap window

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        // Event Methods
        private void Form1_Resize(object sender, EventArgs e) // 폼 화면 크기 조정 기능 1
        {
            AdjustForm();
        }

        // Private Methods
        private void AdjustForm() // 폼 화면 크기 조정 기능 2
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;

                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }


        }

        private void btnMinimize_Click(object sender, EventArgs e) // 폼 화면 최소화 기능
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) // 폼 화면 최대화 기능
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void btnClose_Click(object sender, EventArgs e) // 폼 화면 닫기 기능
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e) // X
        {
            CollapseMenu();
        }

        private void CollapseMenu() 
        {
            
        }

        private static void InsertUpdate() // 삽입 기능 X
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Tab1 VALUES (2, 'Tom')", conn);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Tab1 SET Name='Tim' WHERE Id=2";
                cmd.ExecuteNonQuery();
            }
        }

        private void DataGridView() // 데이터 그리드 뷰 기능
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from black_sheep.ItemMaster", conn);
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    BindingSource bindingSource = new BindingSource();

                    bindingSource.DataSource = dataTable;
                    //dataGridView1.DataSource = bindingSource;
                    adapter.Update(dataTable);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();


            }
        }

        private void PieChart() // 파이 차트 데이터 기능
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from black_sheep.ItemMaster", conn);
                MySqlDataReader reader;
                try
                {
                    reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        this.chart3.Series["Product_Price"].Points.AddXY(reader.GetString("Product_Name"), reader.GetInt32("Product_Price"));
                    }
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void GraphChart() // 그래프차트 데이터 기능
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from black_sheep.ItemMaster", conn);
                MySqlDataReader reader;
                try
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.chart1.Series["Product_Price"].Points.AddXY(reader.GetString("Product_Name"), reader.GetInt32("Product_Price"));
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void LiveChartSource() // 지도 함수 데이터 기능
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
            Dictionary<string, double> value = new Dictionary<string, double>();
            value["2003"] = random.Next(0, 100);
            value["2037"] = random.Next(0, 100);
            value["1999"] = random.Next(0, 100);
            geoMap.HeatMap = value;
            geoMap.Source = $"{Application.StartupPath}\\South Korea.xml";
            this.panel13.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
