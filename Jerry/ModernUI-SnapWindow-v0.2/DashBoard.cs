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
            MonthDataChart();
        }

        private void DataGridView() // 데이터 그리드 뷰 기능
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

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
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "SELECT a.*, " +
                               "CASE " +
                               "WHEN age < 20 THEN '10대' " +
                               "WHEN age < 30 THEN '20대' " +
                               "WHEN age < 40 THEN '30대' " +
                               "WHEN age < 50 THEN '40대' " +
                               "WHEN age < 60 THEN '50대' " +
                               "WHEN age < 70 THEN '60대' " +
                               "END AS age_group, " +
                               "count(*) as count " +
                               "FROM(SELECT *, FLOOR(date_format(now(), '%Y') - substring(birth, 1, 4)) age FROM black_sheep.User_Table) a " +
                               "GROUP BY age_group ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
   

                try
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.chart3.Series["연령"].Points.AddXY(reader.GetString("age_group"), reader.GetInt32("count"));
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void MonthDataChart() // 그래프차트 데이터 기능
        {
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "SELECT count(*) a , month(Order_time) FROM black_sheep.OrderList " +
                    "group by month(Order_time); ";
                               

                MySqlCommand cmd = new MySqlCommand(query, conn);
                
                MySqlDataReader reader;
                try
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        this.chart1.Series["월별건수"].Points.AddXY(reader.GetString("month(Order_time)"), reader.GetInt32("a"));
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
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

            Dictionary<string, double> value = new Dictionary<string, double>();


            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                //MySqlCommand cmd = new MySqlCommand("select * from black_sheep.OrderList", conn);
                string query = "SELECT B.idRegion_Number as Region, count(A.Order_number) as count " +
                    "FROM black_sheep.OrderList AS A " +
                    "INNER JOIN black_sheep.Region_Number AS B " +
                    "ON A.Region_Name = B.Region_Name " +
                    "GROUP BY Region ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader;
                try
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string count = reader.GetString("count");
                        string Region = reader.GetString("Region");
                        value[Region] = Convert.ToDouble(count);
                        //this.chart1.Series["Product_Price"].Points.AddXY(reader.GetString("Product_Name"), reader.GetInt32("Product_Price"));
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
           // Dictionary<string, double> value = new Dictionary<string, double>();
           // value["2003"] = 8;
           // value["2037"] = 37;
           // value["1999"] = 99;
            geoMap.HeatMap = value;
            geoMap.Source = $"{Application.StartupPath}\\South Korea.xml";
            this.panel13.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }

        
    }
}
