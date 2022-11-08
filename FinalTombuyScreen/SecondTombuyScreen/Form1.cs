using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTombuyScreen //구매자 화면
{   
    public partial class Form1 : Form
    {
        private int iOrderPrice = 0;                  // 총 결제금액 

        private ProductInfo pi = new ProductInfo();


        //각 구매 금액
        private int iKSalePrice = 0;
        private int iWSalePrice = 0;
        private int iESalePrice = 0;
        private int iASalePrice = 0;
        private int iBSalePrice = 0;
        private int iRSalePrice = 0;


        //장바구니에 담은 내역
        string sOrderList;


        public Form1()
        {
            InitializeComponent();
            pi.updateInfo("database connect 필요");

            lblKf94LeftCount.Text = Convert.ToString(pi.iKLeftC);
            lblWetwipesLeftCount.Text = Convert.ToString(pi.iWLeftC);
            lblEarphoneLeftCount.Text = Convert.ToString(pi.iELeftC);
            lblAirfreshenerLeftCount.Text = Convert.ToString(pi.iALeftC);
            lblBatteryLeftCount.Text = Convert.ToString(pi.iBLeftC);
            lblRazorLeftCount.Text = Convert.ToString(pi.iRLeftC);

            vlblKf94LeftCount.Text = Convert.ToString(pi.viKLeftC);
            vlblWetwipesLeftCount.Text = Convert.ToString(pi.viWLeftC);
            vlblEarphoneLeftCount.Text = Convert.ToString(pi.viELeftC);
            vlblAirfreshenerLeftCount.Text = Convert.ToString(pi.viALeftC);
            vlblBatteryLeftCount.Text = Convert.ToString(pi.viBLeftC);
            vlblRazorLeftCount.Text = Convert.ToString(pi.viRLeftC);


        }

        private void btnShowOrderbasket_Click(object sender, EventArgs e)
        {
            //장바구니에 담은 가능량 체크하기
            int cVal1 = (int)numCount1.Value;
            if (cVal1 > pi.iKLeftC - pi.oiKLeftC)//pi.iKLeftC - pi.oiKLeftC = lblKf94LeftCount.Text
            {
                MessageBox.Show("마스크 재고물품이 부족합니다.");
                numCount1.Value = 0;
                return;
            }

            int cVal2 = (int)numCount2.Value;
            if (cVal2 > pi.iWLeftC - pi.oiWLeftC)//pi.iWLeftC - pi.oiWLeftC =lblWetwipesLeftCount.Text
            {
                MessageBox.Show("물티슈 재고물품이 부족합니다.");
                numCount1.Value = 0;
                return;
            }

            int cVal3 = (int)numCount3.Value;
            if (cVal3 > pi.iELeftC - pi.oiELeftC)
            {
                MessageBox.Show("이어폰 재고물품이 부족합니다.");
                numCount1.Value = 0;
                return;
            }

            int cVal4 = (int)numCount4.Value;
            if (cVal4 > pi.iALeftC - pi.oiALeftC)
            {
                MessageBox.Show("방향제 재고물품이 부족합니다.");
                numCount1.Value = 0;
                return;
            }

            int cVal5 = (int)numCount5.Value;
            if (cVal5 > pi.iBLeftC - pi.oiBLeftC)
            {
                MessageBox.Show("건전지 재고물품이 부족합니다.");
                numCount5.Value = 0;
                return;
            }

            int cVal6 = (int)numCount6.Value;
            if (cVal6 > pi.iRLeftC - pi.oiRLeftC)
            {
                MessageBox.Show("면도기 재고물품이 부족합니다.");
                numCount6.Value = 0;
                return;
            }
            // 주문 수량, 금액 TextBox 에 표현.

            // 바구니-> 장바구니에 담은정보에 올린 마스크 개수 (주문현황)
            pi.oiKLeftC += (int)numCount1.Value;

            // 바구니에->장바구니에 담은정보에 올린 물티슈 개수(주문현황)
            pi.oiWLeftC += (int)numCount2.Value;

            // 장바구니에 담은정보에 올린 이어폰 개수(주문현황)
            pi.oiELeftC += (int)numCount3.Value;

            // 장바구니에 담은정보에 올린 방향제의 개수(주문현황)
            pi.oiALeftC += (int)numCount4.Value;

            // 장바구니에 담은정보에 올린 건전지의 개수(주문현황)
            pi.oiBLeftC += (int)numCount5.Value;

            // 장바구니에 담은정보에 올린 면도기의 개수(주문현황)
            pi.oiRLeftC += (int)numCount6.Value;

            // 각 물품의 구매 금액
            iKSalePrice = (int)numCount1.Value * pi.viKLeftC;
            iWSalePrice = (int)numCount2.Value * pi.viWLeftC;
            iESalePrice = (int)numCount3.Value * pi.viELeftC;
            iASalePrice = (int)numCount4.Value * pi.viALeftC;
            iBSalePrice = (int)numCount5.Value * pi.viBLeftC;
            iRSalePrice = (int)numCount6.Value * pi.viRLeftC;

            // 거래 내역 있는 내역만 TextBox 에 표현.

            lblKf94LeftCount.Text = (pi.iKLeftC - pi.oiKLeftC).ToString();
            lblWetwipesLeftCount.Text = (pi.iWLeftC - pi.oiWLeftC).ToString();
            lblEarphoneLeftCount.Text = (pi.iELeftC - pi.oiELeftC).ToString();
            lblAirfreshenerLeftCount.Text = (pi.iALeftC - pi.oiALeftC).ToString();
            lblBatteryLeftCount.Text = (pi.iBLeftC - pi.oiBLeftC).ToString();
            lblRazorLeftCount.Text = (pi.iRLeftC - pi.oiRLeftC).ToString();


            bool isOrder = false;

            sOrderList = "----------------------------- 장바구니에 담은 내역 ----------------------------- \r\n";


            if (iKSalePrice > 0)
            {
                sOrderList += $"마스크 장바구니에 담은개수 : {numCount1.Value} , 구매 금액 : {iKSalePrice} :  \r\n";
                sOrderList += $"마스크 누적 장바구니에 담은개수 : {pi.oiKLeftC}, 마스크의 누적 구매금액 :{iKSalePrice * pi.oiKLeftC}  \r\n";


                isOrder = true;


            }
            if (iWSalePrice > 0)
            {
                sOrderList += $"물티슈 장바구니에 담은개수 : {numCount2.Value} , 구매 금액 : {iWSalePrice} :  \r\n";
                sOrderList += $"물티슈 누적 장바구니에 담은개수 : {pi.oiWLeftC}, 물티슈의 누적 구매금액 :{iWSalePrice * pi.oiWLeftC}  \r\n";

                isOrder = true;
            }
            if (iESalePrice > 0)
            {
                sOrderList += $"이어폰 장바구니에 담은개수 : {numCount3.Value} , 구매 금액 : {iESalePrice} :  \r\n";
                sOrderList += $"이어폰 누적 장바구니에 담은개수 : {pi.oiELeftC}, 이어폰의 누적 구매금액 :{iESalePrice * pi.oiELeftC}  \r\n";

                isOrder = true;
            }
            if (iASalePrice > 0)
            {
                sOrderList += $"방향제 장바구니에 담은개수 : {numCount4.Value} , 구매 금액 : {iASalePrice} :  \r\n";
                sOrderList += $"방향제 누적 장바구니에 담은개수 : {pi.oiALeftC}, 방향제의 누적 구매금액 :{iASalePrice * pi.oiALeftC}  \r\n";

                isOrder = true;
            }
            if (iBSalePrice > 0)
            {
                sOrderList += $"건전지 장바구니에 담은개수 : {numCount5.Value} , 구매 금액 : {iBSalePrice} :  \r\n";
                sOrderList += $"건전지 누적 장바구니에 담은개수 : {pi.oiBLeftC}, 건전지의 누적 구매금액 :{iBSalePrice * pi.oiBLeftC}  \r\n";

                isOrder = true;
            }
            if (iRSalePrice > 0)
            {
                sOrderList += $"면도기 장바구니에 담은개수 : {numCount6.Value} , 구매 금액 : {iRSalePrice} :  \r\n";
                sOrderList += $"면도기 누적 장바구니에 담은개수 : {pi.oiRLeftC}, 면도기의 누적 구매금액 :{iRSalePrice * pi.oiRLeftC}  \r\n";

                isOrder = true;
            }

            if (isOrder == true)
                txtOrderList.Text += sOrderList;





            else
                txtOrderList.Text = "장바구니에 담은 내역이 없습니다.\r\n";

        }

        private void btnOrderbasketCancel_Click(object sender, EventArgs e)
        {
            txtOrderList.Clear();
            numCount1.Value = 0;
            numCount2.Value = 0;
            numCount3.Value = 0;
            numCount4.Value = 0;
            numCount5.Value = 0;
            numCount6.Value = 0;

            pi.updateInfo("나중에 데이타베이스에서 업데이트 할것");


            lblKf94LeftCount.Text = Convert.ToString(pi.iKLeftC);
            lblWetwipesLeftCount.Text = Convert.ToString(pi.iWLeftC);
            lblEarphoneLeftCount.Text = Convert.ToString(pi.iELeftC);
            lblAirfreshenerLeftCount.Text = Convert.ToString(pi.iALeftC);
            lblBatteryLeftCount.Text = Convert.ToString(pi.iBLeftC);
            lblRazorLeftCount.Text = Convert.ToString(pi.iRLeftC);

        }
    }
}
