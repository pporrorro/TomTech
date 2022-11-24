using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTombuyScreen//디자인 테스트

{

    internal class ProductInfo
    {
        //갯수//총 재고 개수
        public int iKLeftC = 0;// kf94마스크의 총 재고 개수
        public int iWLeftC = 0;// 물티슈의 총 재고 개수
        public int iELeftC = 0;// 이어폰의 총 재고 개수
        public int iALeftC = 0;// 방향제의 총 재고 개수
        public int iBLeftC = 0;// 건전지의 총 재고 개수
        public int iRLeftC = 0;// 면도기의 총 재고 개수

        //가격
        public int viKLeftC = 0;
        public int viWLeftC = 0;
        public int viELeftC = 0;
        public int viALeftC = 0;
        public int viBLeftC = 0;
        public int viRLeftC = 0;

        //주문 현황
        public int oiKLeftC = 0;
        public int oiWLeftC = 0;
        public int oiELeftC = 0;
        public int oiALeftC = 0;
        public int oiBLeftC = 0;
        public int oiRLeftC = 0;

        public void updateInfo(string databaseInfo)
        {
            iKLeftC = 500;
            iWLeftC = 100;
            iELeftC = 50;
            iALeftC = 30;
            iBLeftC = 40;
            iRLeftC = 200;

            viKLeftC = 2000;
            viWLeftC = 1500;
            viELeftC = 8000;
            viALeftC = 7000;
            viBLeftC = 1000;
            viRLeftC = 2500;

            oiKLeftC = 0;
            oiWLeftC = 0;
            oiELeftC = 0;
            oiALeftC = 0;
            oiBLeftC = 0;
            oiRLeftC = 0;
        }

        public ItemMaster im;

        //public int SelectPrice(string productname)
        //{
        //    foreach(in im.Product_Name)
        //    return SelectPrice();
        //}
        // 수정중 단가 불러오는 함수만들 예정


    }
}
