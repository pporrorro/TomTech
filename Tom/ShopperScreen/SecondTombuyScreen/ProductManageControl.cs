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
    public partial class ProductManageControl : UserControl
    {
        private DbManager dm;
        private ItemProp ip;
        private ProductInfo pi;
        private string strConn = "Server=222.98.255.30;Database=black_sheep;Uid=root;Pwd=qmffortlq;CharSet=utf8;";

        private List<ItemMaster> imList;
        private List<OrderList> oList;
        private List<ItemProp> iPList;
        private List<INOUTRec> irList;
        private List<SortRec> SrList;
        private List<Stock_Table> StList;
        private List<User_Table> uList;

        Dictionary<string, int> Basket = new Dictionary<string, int>();
        int count = 0;
        int iTotalPrice = 0;
        public ProductManageControl()
        {
            InitializeComponent();
            dm = new DbManager(strConn);
            ip = new ItemProp();
            pi = new ProductInfo();

            imList = new List<ItemMaster>();
            oList = new List<OrderList>();
            iPList = new List<ItemProp>();
            irList = new List<INOUTRec>();
            SrList = new List<SortRec>();
            StList = new List<Stock_Table>();
            uList = new List<User_Table>();

        }

        private void ProductManageControl_Load(object sender, EventArgs e)
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

            // 콤보박스 세팅
            DataTable dt = dm.SelectRegion_Number();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Region_Name";   // 콤보박스에 보여줄 컬럼명.
            comboBox1.ValueMember = "Region_Name";     // 실제 사용할 Value값.

            comboBox1.SelectedIndex = 0;


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox1.Text = "지역";

        }

        private void btnOrderbasketCancel_Click(object sender, EventArgs e)
        {
            Basket.Clear();
            txtOrderList.Text = "";
            txtOrderList.Text = "  장바구니에 아무것도 없습니다. \r\n";
            iTotalPrice = 0;
            
        }
        string orderStr = "";

        private void btnPutOrderbasket_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrderList.Text = " ";
                

                orderStr += "\r\n--------------- 장바구니 담긴 내역 ---------------\r\n\r\n";

                // ItemProp 확인해서 딕셔너리 Basket 에 주문수량 담기
                foreach (ItemProp ip in iPList)
                {
                    string sProductName = ip.groupBox1.Text;                // 상품이름
                    string sProductPrice = ip.lblProductPrice.Text;         // 상품가격
                    int iLeftCount = Convert.ToInt32(ip.lblLeftCount.Text); // 재고량
                    int iOrderCount = (int)ip.numCount1.Value;              // 주문량

                    sProductPrice = sProductPrice.Substring(0, sProductPrice.Length - 1);
                    int iProductPrice = Convert.ToInt32(sProductPrice);     //

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
                        // orderStr += $"  {sProductName}    {iProductPrice}    {iOrderCount}  개\r\n";

                    }

                    iTotalPrice += iOrderCount * iProductPrice;
                    ip.numCount1.Value = 0;
                }

                if (iTotalPrice <= 0)
                {
                    MessageBox.Show("장바구니에 담은 내역이 없습니다.\r\n");
                    return;
                }
                else
                {
                    // 여태까지 장바구니에 담긴 내역 출력
                    foreach (string key in Basket.Keys)
                    {
                        int iPrice = pi.SelectPrice(key);
                        orderStr += $"  {key}    {iPrice}  원  {Basket[key]}  개  \r\n";
                    }

                    // 합계
                    orderStr += "\r\n  장바구니 총 합계 금액 : " + iTotalPrice + " 원 \r\n";
                }

                txtOrderList.TextAlign = HorizontalAlignment.Center;
                txtOrderList.Text = orderStr; // 내역 출력
                orderStr = string.Empty;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }





        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string sUserName = textBox1.Text;
                string sUserNumber = textBox3.Text;
                string sRegionName = Convert.ToString(comboBox1.SelectedValue);
                string sAddress = textBox2.Text;
                string sproductCode = string.Empty;
                string sproductName = string.Empty;

                int orderCnt = 0;
                int iTotalorderCnt = 0;
                int iTotalPrice = 0;

                imList = dm.SelectItemMaster(null);
                oList = dm.SelectOrderList(null);

                DataTable uList = dm.SelectUser_Table(sUserName, "User_Name = ");

                // 회원정보 확인
                if (sUserName == "" || sUserNumber == "")
                {
                    MessageBox.Show("회원정보가 입력되지 않았습니다.\r\n회원만 구매할 수 있습니다.");
                    return;
                }

                string sep = "-------------------------------";
                string contents = "";


                // 장바구니 확인
                if (Basket.Count == 0)
                {
                    MessageBox.Show("장바구니에 주문할 내역이 없습니다.");
                    return;
                }
                else if (MessageBox.Show("장바구니 내역을 주문하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                // 주소입력 확인
                else if (sRegionName == "지역" || sAddress == "")
                {
                    MessageBox.Show("주소가 입력되지 않았습니다.");
                    return;
                }


                // 주문번호 생성 알고리즘
                OrderList ol = oList[oList.Count - 1];
                int idx = int.Parse(ol.Order_Number) + 1;
                int zc = 8 - Convert.ToString(idx).Length;
                string sdx = new String('0', zc);
                sdx += Convert.ToString(idx++);
                // --------------------------------------



                foreach (string key in Basket.Keys)
                {
                    orderCnt = Basket[key];
                    sproductName = key;

                    // 상품코드 불러오기
                    foreach (ItemMaster item in dm.SelectItemMaster($"Product_Name = '{key}'"))
                    {
                        sproductCode = item.Product_Code;
                    }

                    if (orderCnt > 0)
                    {
                        string io = "INSERT INTO `black_sheep`.`OrderList` (`Order_number`, `Product_Code`, `Order_Qty`, `User_Number`, `User_Name`, `Region_Name`, `Address`, `Order_time`) VALUES" + $"('{sdx}', '{sproductCode}', '{orderCnt}', '{sUserNumber}', '{sUserName}', '{sRegionName}', '{sAddress}', '{DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")}');";
                        bool foo = dm.InsertMysql(io);

                        if (foo == true)
                        {
                            // 주문한 총 개수
                            foreach (OrderList o in oList)
                            {
                                if (o.Product_Code == sproductCode)
                                {
                                    int iPrice = pi.SelectPrice(o.Product_Code);
                                    contents += "\r\n  " + sproductName + "  " + iPrice + "원  " + orderCnt.ToString() + "개";
                                    iTotalPrice += iPrice * orderCnt;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("주문 입력 오류가 발생했습니다.\r\n");
                            return;
                        }
                    }
                }
                MessageBox.Show("주문이 완료되었습니다.");
                txtOrderList.Text = sep + "주문내역" + sep + contents + $"\r\n                                                                   총 주문 금액  {iTotalPrice}  원                                                                   \r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnPutOrderbasket_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtOrderList.Text = " ";


                orderStr += "\r\n--------------- 장바구니 담긴 내역 ---------------\r\n\r\n";

                // ItemProp 확인해서 딕셔너리 Basket 에 주문수량 담기
                foreach (ItemProp ip in iPList)
                {
                    string sProductName = ip.groupBox1.Text;                // 상품이름
                    string sProductPrice = ip.lblProductPrice.Text;         // 상품가격
                    int iLeftCount = Convert.ToInt32(ip.lblLeftCount.Text); // 재고량
                    int iOrderCount = (int)ip.numCount1.Value;              // 주문량

                    sProductPrice = sProductPrice.Substring(0, sProductPrice.Length - 1);
                    int iProductPrice = Convert.ToInt32(sProductPrice);     //

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
                        // orderStr += $"  {sProductName}    {iProductPrice}    {iOrderCount}  개\r\n";

                    }

                    iTotalPrice += iOrderCount * iProductPrice;
                    ip.numCount1.Value = 0;
                }

                if (iTotalPrice <= 0)
                {
                    MessageBox.Show("장바구니에 담은 내역이 없습니다.\r\n");
                    return;
                }
                else
                {
                    // 여태까지 장바구니에 담긴 내역 출력
                    foreach (string key in Basket.Keys)
                    {
                        int iPrice = pi.SelectPrice(key);
                        orderStr += $"  {key}    {iPrice}  원  {Basket[key]}  개  \r\n";
                    }

                    // 합계
                    orderStr += "\r\n  장바구니 총 합계 금액 : " + iTotalPrice + " 원 \r\n";
                }

                txtOrderList.Text = orderStr; // 내역 출력
                orderStr = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
