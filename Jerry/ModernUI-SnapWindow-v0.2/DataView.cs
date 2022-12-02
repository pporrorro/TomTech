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

            Progressbar1();
            Progressbar2();
            Progressbar3();
            Progressbar4();


        }

        private void DataGridView1() // 데이터 그리드 뷰 기능 1
        {
            
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Product_Name AS 제품명, " +
                                                    "Order_Qty AS 주문개수, " +
                                                    "Order_Com AS 완료 FROM black_sheep.Sort1; ", conn);

                this.dataGridView5.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
                this.dataGridView5.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

                dataGridView5.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

                for (int i = 1; i < dataGridView5.Rows.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    }
                    else
                    {
                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

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
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Product_Name AS 제품명, " +
                                                    "Order_Qty AS 주문개수, " +
                                                    "Order_Com AS 완료 FROM black_sheep.Sort2; ", conn);

                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                this.dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
                this.dataGridView2.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

                for (int i = 1; i < dataGridView2.Rows.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    }
                    else
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

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
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Product_Name AS 제품명, " +
                                                    "Order_Qty AS 주문개수, " +
                                                    "Order_Com AS 완료 FROM black_sheep.Sort3; ", conn);

                dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                this.dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
                this.dataGridView3.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

                for (int i = 1; i < dataGridView3.Rows.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    }
                    else
                    {
                        dataGridView3.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

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
            string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Product_Name AS 제품명, " +
                                                    "Order_Qty AS 주문개수, " +
                                                    "Order_Com AS 완료 FROM black_sheep.Sort1; ", conn);

                dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                this.dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
                this.dataGridView4.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);

                for (int i = 1; i < dataGridView4.Rows.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    }
                    else
                    {
                        dataGridView4.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }

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

        private void dataGridView5_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }

        private void dataGridView4_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat drawFormat = new StringFormat();
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            using (Brush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 35, e.RowBounds.Location.Y + 4, drawFormat);
            }
        }

        private void Progressbar1()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Step = 10;
            progressBar1.Value = 100;
        }

        private void Progressbar2()
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 200;
            progressBar2.Step = 10;
            progressBar2.Value = 100;
        }
        private void Progressbar3()
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 200;
            progressBar3.Step = 10;
            progressBar3.Value = 100;
        }

        private void Progressbar4()
        {
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 200;
            progressBar4.Step = 10;
            progressBar4.Value = 100;
        }

    }
}
