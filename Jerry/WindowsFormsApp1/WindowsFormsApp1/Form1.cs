using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        
        private string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";
        
        


        public Form1()
        {
            
            MySqlConnection conn = new MySqlConnection(strConn);

            InitializeComponent();
            LiveChartSource();
            DataGridView();

        }

        private void DataGridView()
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

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();

               
            }
        }

        private void LiveChartSource()
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
            Dictionary<string, double> value = new Dictionary<string, double>();
            value["2003"] = random.Next(0, 100);
            value["2037"] = random.Next(0, 100);
            value["1999"] = random.Next(0, 100);
            geoMap.HeatMap = value;
            geoMap.Source = $"{Application.StartupPath}\\South Korea.xml";
            this.panel1.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }

    }
}
