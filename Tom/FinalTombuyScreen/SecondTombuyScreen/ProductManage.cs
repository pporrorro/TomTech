using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTombuyScreen
{
    public partial class ProductManage : Form
    {
        private DbManager dm;
        private string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

        private List<ItemMaster> imList;
        private List<OrderList> oList;
        private List<ItemProp> iPList;


        private List<INOUTRec> irList;
        private List<SortRec> SrList;
        private List<Stock_Table> StList;


        public ProductManage()
        {
            InitializeComponent();
            dm = new DbManager(strConn);
            imList = new List<ItemMaster>();
            oList = new List<OrderList>();
            iPList = new List<ItemProp>();
        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            tableLayoutPanel_pList.Visible = false;

            //1. DB에서 물건 조회
            imList = dm.SelectItemMaster(null);
            oList = dm.SelectOrderList(null);
            //2. 메뉴 표시
            //2-1. tablelayoutpanel_pList 를 imList의 갯수만큼 행으로 쪼갠다.
            // tableLayoutPanel_pList
            for (int row = tableLayoutPanel_pList.RowCount; row <= imList.Count; row++)
            {
                //사용자 지정 폼
                int orderCnt = 0;
                string pc = imList[row - 1].Product_Code;

                foreach (OrderList foo in oList)
                {
                    if (foo.Product_Code.Equals(pc))
                        orderCnt += foo.Order_Qty;
                }
                ItemProp ip = new ItemProp(imList[row - 1], orderCnt);
                iPList.Add(ip);

                tableLayoutPanel_pList.Controls.Add(ip, 0, row);
                ip.Anchor = AnchorStyles.Top;


            }
            //tableLayoutPanel2.TabIndex++;
            tableLayoutPanel_pList.Visible = true;
        }

        string orderStr = "";
        private void btnShowOrderbasket_Click(object sender, EventArgs e)
        {
            /*
            ------------------------------------------------------------------------
                 장바구니에 담은 마스크 개수: 5 , 담은 마스크의 총개수: 5
                 장바구니에 담은 물티슈 개수 : 2 , 담은 물티슈의 총개수: 2
                ------------------------------------------------------------------------
                 장바구니에 담은 마스크 개수 : 1 , 담은 마스크의 총개수: 6
                 장바구니에 담은 물티슈 개수 : 5 , 담은 물티슈의 총개수: 7
                 장바구니에 담은 이어폰 개수 : 3 , 담은 이어폰의 총개수: 3
            */

            string sep = "------------------------------------------------------------------------";
            string contents = "";

            //주문번호 생성 알고리즘으로 아래를 대체해야 함
            OrderList ol = oList[oList.Count - 1];
            //0. 주문 갯수를 구해온다 --> iPList
            int idx = int.Parse( ol.Order_Number) + 1;
            // --------------------------------------

            foreach(ItemProp ip in iPList)
            {
                string productCode = ip.im.Product_Code;
                string productName = ip.im.Product_Name;
                int Qty = (int)ip.numCount1.Value;
                if(Qty > 0)
                {
                    string io = "INSERT INTO `black_sheep`.`OrderList` (`Order_number`, `Product_Code`, `Order_Qty`, `User_Number`, `User_Name`, `Region_Name`, `Address`, `Order_time`) VALUES ('" + (idx++).ToString() +"', '"
                                                                    + productCode
                                                                    + "', '" + Qty.ToString()
                                                                    + "', '4444', 'adf', 'adf', 'dfsa', '" +
                                                                    DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "');";
                    bool foo = dm.InsertMysql(io);
                    int orderCnt = 0;
                    if (foo == true)
                    {
                        //주문한 총개수
                        foreach (OrderList o in oList)
                        {
                            if (o.Product_Code.Equals(productCode))
                                orderCnt += o.Order_Qty;
                        }

                        contents += "장바구니에 담은 " + productName + " 개수 :" + Qty.ToString() + ", 담은 " 
                                     + productName + "의 총 개수 : " + orderCnt.ToString() + "\r\n";
                       
                    }
                    else
                    {
                        txtOrderList.AppendText("주문 입력 오류가 발생했습니다.\r\n");
                    }
                }
                
            }
            txtOrderList.AppendText(sep + "\r\n" + contents  + sep + "\r\n");
            

        }
    }
}
