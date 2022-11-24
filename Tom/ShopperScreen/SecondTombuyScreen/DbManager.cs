using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SecondTombuyScreen
{
    internal class DbManager
    {
        public MySqlConnection conn;
        public DbManager(MySqlConnection _conn)
        {
            conn = _conn;
        }

        string connStr = null;
        public DbManager(string _connStr)
        {
            connStr = _connStr;
        }

        public List<ItemMaster> SelectItemMaster(string whereStr)
        {
            List<ItemMaster> imList = new List<ItemMaster>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM ItemMaster";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ItemMaster im = new ItemMaster();
                    im.Product_Code = (string)rdr["Product_Code"];
                    im.Product_Name = (string)rdr["Product_Name"];
                    im.Place = (string)rdr["Place"];
                    im.Stock_Qty = Convert.ToInt32(rdr["Stock_Qty"]);
                    im.Product_Price = Convert.ToInt32(rdr["Product_Price"]);

                    imList.Add(im);
                }
                rdr.Close();
            }
            return imList;
        }

        public List<OrderList> SelectOrderList(string whereStr)
        {
            List<OrderList> oList = new List<OrderList>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM OrderList";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    OrderList ol = new OrderList();
                    ol.Product_Code = (string)rdr["Product_Code"];
                    ol.Order_Qty = (int)rdr["Order_Qty"];
                    ol.User_Number = (string)rdr["User_Number"];
                    ol.User_Name = (string)rdr["User_Name"];
                    ol.Region_Name = (string)rdr["Region_Name"];
                    ol.Address = (string)rdr["Address"];
                    ol.Order_Time = (string)rdr["Order_Time"];
                    ol.Order_Number = rdr["Order_Number"].ToString();
                    oList.Add(ol);
                }
                rdr.Close();
            }
            return oList;
        }


        public List<INOUTRec> SelectInoutRec(string whereStr)
        {
            List<INOUTRec> InoutRecList = new List<INOUTRec>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM InoutRec";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    INOUTRec ir = new INOUTRec();


                    ir.Order_Number = (string)rdr["Order_Number"];
                    ir.Product_Code = (string)rdr["Product_Code"];
                    ir.Product_Name = (string)rdr["Product_Name"];
                    ir.InProduct_Number = (string)rdr["InProduct_Number"];
                    ir.OutProduct_Number = (string)rdr["OutProduct_Number"];
                    ir.Place = (string)rdr["Place"];
                    ir.In_Time = (string)rdr["In_Time"];
                    ir.Out_Time = (string)rdr["Out_Time"];

                    InoutRecList.Add(ir);
                }
                rdr.Close();
            }
            return InoutRecList;
        }


        public List<SortRec> SelectSortRec(string whereStr)
        {
            List<SortRec> SortRecList = new List<SortRec>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM SortRec";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    SortRec Sr = new SortRec();
                    Sr.Order_Number = (string)rdr["Order_Number"];
                    Sr.Product_Code = (string)rdr["Product_Code"];
                    Sr.Sort_Qty = (int)rdr["Sort_Qty"];
                    Sr.User_Number = (string)rdr["User_Number"];
                    Sr.Region_Name = (string)rdr["Region_Name"];
                    Sr.Address = (string)rdr["Address"];
                    Sr.Sort_Time = (string)rdr["Sort_Time"];

                    SortRecList.Add(Sr);
                }
                rdr.Close();
            }
            return SortRecList;
        }


        public List<Stock_Table> SelectStock_Table(string whereStr)
        {
            List<Stock_Table> Stock_TableList = new List<Stock_Table>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Stock_Table";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Stock_Table St = new Stock_Table();

                    St.Product_Code = (string)rdr["Product_Code"];
                    St.Product_Name = (string)rdr["Product_Name"];
                    St.Stock_Qty = Convert.ToInt32(rdr["Stock_Qty"]);
                    St.Place = (string)rdr["Place"];
                    St.Remark = (string)rdr["Remark"];
                    St.Indate = (string)rdr["Indate"];

                    Stock_TableList.Add(St);
                }
                rdr.Close();
            }
            return Stock_TableList;
        }

        public List<User_Table> SelectUser_Table(string whereStr)
        {
            List<User_Table> uList = new List<User_Table>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM User_Table";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else
                    sql_where = " WHERE " + whereStr;

                sql += sql_where;

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    User_Table ul = new User_Table();
                    ul.User_Number = (string)rdr["User_Number"];
                    ul.User_Name = (string)rdr["User_Name"];
                    ul.Phone = (string)rdr["Phone"];
                    ul.Birth = (string)rdr["Birth"];

                    uList.Add(ul);
                }
                rdr.Close();
            }
            return uList;
        }
        public bool InsertMysql(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //string insertQuery = "INSERT INTO Co32table(idx,header,body) VALUES(3,'header1','body2')";
                try//예외 처리
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }


        public void SelectQuery(string query, out MySqlDataReader rdr)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
            }
        }



    }
}
