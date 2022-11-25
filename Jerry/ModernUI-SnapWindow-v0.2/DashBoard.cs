using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI_SnapWindow
{
    public partial class DashBoard : UserControl
    {
        MainForm fm = null;
        public DashBoard(MainForm _fm)
        {
            InitializeComponent();
            fm = _fm;
        }

        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            DataGridView();
            PieChart();
            LiveChartSource();
            GraphChart();
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

                    while (reader.Read())
                    {
                        this.chart3.Series["Product_Price"].Points.AddXY(reader.GetString("Product_Name"), reader.GetInt32("Product_Price"));
                    }
                }

                catch (Exception ex)
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
            value["2003"] = 0;
            value["2037"] = 37;
            value["1999"] = 99;
            geoMap.HeatMap = value;
            geoMap.Source = $"{Application.StartupPath}\\South Korea.xml";
            this.panel13.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
