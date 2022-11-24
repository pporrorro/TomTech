using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTombuyScreen//디자인 테스트

{

    internal class ProductInfo
    {
        public int SelectPrice(string productname)
        {
            Dictionary<string, int> dPrice = new Dictionary<string, int>();
            dPrice.Add("KF-94 Mask", 3000);
            dPrice.Add("물티슈", 1500);
            dPrice.Add("이어폰", 3000);
            dPrice.Add("방향제", 7000);
            dPrice.Add("건전지", 1000);
            dPrice.Add("면도기", 2500);

            return dPrice[productname];
        }



    }
}
