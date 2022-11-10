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
        public ProductManage()
        {
            InitializeComponent();
            dm = new DbManager(strConn);
            imList = new List<ItemMaster>();
            oList = new List<OrderList>();
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

                tableLayoutPanel_pList.Controls.Add(ip, 0, row);
                ip.Anchor = AnchorStyles.Top;


            }
            //tableLayoutPanel2.TabIndex++;
            tableLayoutPanel_pList.Visible = true;
        }
    }
}
