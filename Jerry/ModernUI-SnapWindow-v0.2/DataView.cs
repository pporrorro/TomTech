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
    public partial class DataView : UserControl
    {
        MainForm fm = null;
        public DataView(MainForm _fm)
        {
            InitializeComponent();
            fm = _fm;
        }

        public DataView()
        {
            InitializeComponent();
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            DataGridView1();
            DataGridView2();
            DataGridView3();
            DataGridView4();
        }

        private void DataGridView1() // 데이터 그리드 뷰 기능 1
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
                    dataGridView5.DataSource = bindingSource;
                    adapter.Update(dataTable);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();


            }
        }

        private void DataGridView2() // 데이터 그리드 뷰 기능 2
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
                    dataGridView2.DataSource = bindingSource;
                    adapter.Update(dataTable);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();


            }
        }

        private void DataGridView3() // 데이터 그리드 뷰 기능 3
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
                    dataGridView3.DataSource = bindingSource;
                    adapter.Update(dataTable);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();


            }
        }

        private void DataGridView4() // 데이터 그리드 뷰 기능 4
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
                    dataGridView4.DataSource = bindingSource;
                    adapter.Update(dataTable);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.ExecuteNonQuery();


            }
        }

    }
}
