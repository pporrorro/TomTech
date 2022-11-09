using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TomBuyTest
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

        public  List<ItemMaster> SelectItemMaster(string whereStr)
        {
            List<ItemMaster>imList = new List<ItemMaster>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM ItemMaster";
                string sql_where = "";
                if (string.IsNullOrEmpty(whereStr))
                    sql_where = "";
                else 
                    sql_where = " WHERE "+ whereStr;

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

                    OrderList im = new OrderList();
                    im.Product_Code = (string)rdr["Product_Code"];
                    im.Order_Qty = (int)rdr["Order_Qty"];
                    im.User_Number = (string)rdr["User_Number"];
                    im.User_Name = (string) rdr["User_Name"];
                    im.Region_Name = (string) rdr["Region_Name"];
                    im.Address = (string) rdr["Address"];
                    im.Order_Time = (string) rdr["Order_Time"];

                    oList.Add(im);
                }
                rdr.Close();
            }
            return oList;
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
