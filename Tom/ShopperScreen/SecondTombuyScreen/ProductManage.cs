using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Google.Protobuf.WellKnownTypes;

#region < HEADER >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : 전체상품 주문화면
//   Form Name    : 작업지시 별 생산 실적 현황 및 달성율
//   Name Space   : Shopper Screen 으로 바꿔줘야함...
//   Created Date : 2022-11-24 오후 12시
//   Made By      : STELLA
//   Description  : 장바구니 내역에 총 합계, 단가 추가 중 (단가 가져오는 함수 ItemInfo에 추가 중)
// *---------------------------------------------------------------------------------------------*
#endregion

namespace SecondTombuyScreen
{

    public partial class ProductManage : Form
    {
        private DbManager dm;
        private ItemProp ip;
        private ProductInfo pi;
        private string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;";

        private List<ItemMaster> imList;
        private List<OrderList> oList;
        private List<ItemProp> iPList;
        private List<INOUTRec> irList;
        private List<SortRec> SrList;
        private List<Stock_Table> StList;
        private List<User_Table> uList;

        Dictionary<string, int> Basket = new Dictionary<string, int>();
        int count = 0;


        public ProductManage()
        {
            InitializeComponent();
            dm = new DbManager(strConn);
            ip = new ItemProp();


            imList = new List<ItemMaster>();
            oList = new List<OrderList>();
            iPList = new List<ItemProp>();
            irList = new List<INOUTRec>();
            SrList = new List<SortRec>();
            StList = new List<Stock_Table>();
            uList = new List<User_Table>();
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
                    if (foo.Product_Code.Equals(pc)) orderCnt += foo.Order_Qty;
                }
                count++;
                ItemProp ip = new ItemProp(imList[row - 1], orderCnt, count);
                iPList.Add(ip);

                tableLayoutPanel_pList.Controls.Add(ip, 0, row);
                ip.Anchor = AnchorStyles.Top;
            }
            //tableLayoutPanel2.TabIndex++;
            tableLayoutPanel_pList.Visible = true;
        }

        private void btnOrderbasketCancel_Click(object sender, EventArgs e)
        {
            foreach (ItemProp ip in iPList)
            {
                ip.numCount1.Value = 0;
            }
        }

        string orderStr = "";

        private void btnPutOrderbasket_Click(object sender, EventArgs e)
        {
            orderStr += "--------------- 장바구니 담긴 내역 ---------------\r\n";

            // ItemProp 확인해서 딕셔너리 Basket 에 주문수량 담기
            foreach (ItemProp ip in iPList)
            {
                string sProductName = ip.groupBox1.Text;
                string sProductPrice = ip.lblProductPrice.Text;
                int iLeftCount = Convert.ToInt32(ip.lblLeftCount.Text);
                int iOrderCount = (int)ip.numCount1.Value;

                sProductPrice = sProductPrice.Substring(0, sProductPrice.Length-1);
                int iProductPrice = Convert.ToInt32(sProductPrice);

                if (iLeftCount - iOrderCount < 0)
                {
                    MessageBox.Show($"{sProductName} 의 재고물품이 부족합니다.");
                    orderStr = "";
                    return;
                }

                if (iOrderCount > 0)
                {
                    if (Basket.ContainsKey(sProductName)) Basket[sProductName] += iOrderCount;
                    else
                    { 
                        Basket.Add(sProductName, iOrderCount);
                    }
                    
                }

                ip.numCount1.Value = 0;
            }
            
            foreach (string key in Basket.Keys)
            {
                List<ItemMaster> lst = new List<ItemMaster>();
                lst = dm.SelectItemMaster(key);
                // orderStr += $"  {key}  |  {lst}  |  {Basket[key]}  개  \r\n"; //
                // 장바구니 내역 띄울때 더 가독성 좋게 하기위해 수정 중 (단가, 총 합계 넣을 예정)//
            }

            if (orderStr == "---------------- 장바구니 담긴 내역 ----------------\r\n")
            {
                orderStr = "장바구니에 담은 내역이 없습니다.\r\n";
            }
            else orderStr += "";

            txtOrderList.Text = orderStr; // 내역 출력
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if (Basket.Count == 0)
            {
                MessageBox.Show("장바구니에 주문할 내역이 없습니다.");
                return;
            }
            else if (MessageBox.Show("장바구니 내역을 주문하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sUserName = textBox1.Text;
            string sAddress = textBox2.Text;
            string sUserNumber = textBox3.Text;
            List<User_Table> ul = new List<User_Table>();
            ul = dm.SelectUser_Table(sUserNumber);

            if (sUserName != ul[0].User_Name)
            {
                MessageBox.Show("회원정보가 일치하지 않습니다.");
                return;
            }

            imList = dm.SelectItemMaster(null);
            oList = dm.SelectOrderList(null);
            string sep = "------------------------------------------------------------------------";
            string contents = "";

            // 주문번호 생성 알고리즘
            OrderList ol = oList[oList.Count - 1];
            int idx = int.Parse(ol.Order_Number) + 1;
            int zc = 8 - Convert.ToString(idx).Length;
            string sdx = new String('0', zc);
            sdx += Convert.ToString(idx++);
            // --------------------------------------

            foreach (ItemProp ip in iPList)
            {
                string productCode = ip.im.Product_Code;
                string productName = ip.im.Product_Name;

                int Qty = (int)ip.numCount1.Value;
                if (Qty > 0)
                {
                    string io = "INSERT INTO `black_sheep`.`OrderList` (`Order_number`, `Product_Code`, `Order_Qty`, `User_Number`, `User_Name`, `Region_Name`, `Address`, `Order_time`) VALUES ('" + sdx + "', '"
                                                                    + productCode
                                                                    + ", " + Qty.ToString()
                                                                    + "," + sUserNumber + "," + sUserName + "," + "" + "," + sAddress +
                                                                    DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "');";
                    bool foo = dm.InsertMysql(io);
                    int orderCnt = 0;

                    if (foo == true)
                    {
                        // 주문한 총개수
                        foreach (OrderList o in oList)
                        {
                            if (o.Product_Code.Equals(productCode)) orderCnt += o.Order_Qty;
                        }
                        contents += productName + orderCnt.ToString() + "개" + "\r\n";
                    }
                    else
                    {
                        txtOrderList.AppendText("주문 입력 오류가 발생했습니다.\r\n");
                    }
                }
            }
            txtOrderList.AppendText(sep + " 주문내역" + "\r\n" + contents + sep + "\r\n");
        }
       
    }
}
