namespace SecondTombuyScreen
{
    partial class ProductManageControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_pList = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrderbasketCancel = new System.Windows.Forms.Button();
            this.btnPutOrderbasket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 21);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "회원번호";
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(223, 130);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(152, 48);
            this.btnInsertOrder.TabIndex = 4;
            this.btnInsertOrder.Text = "주문하기";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "회원이름";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.btnInsertOrder);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(597, 184);
            this.groupBox7.TabIndex = 84;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "구매자 정보";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "주소";
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(23, 27);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrderList.Size = new System.Drawing.Size(574, 392);
            this.txtOrderList.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 86;
            this.label3.Text = "장바구니 정보";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrderList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 468);
            this.panel1.TabIndex = 85;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(658, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.12598F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.87402F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(695, 697);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel_pList
            // 
            this.tableLayoutPanel_pList.AutoScroll = true;
            this.tableLayoutPanel_pList.AutoSize = true;
            this.tableLayoutPanel_pList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel_pList.ColumnCount = 1;
            this.tableLayoutPanel_pList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_pList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_pList.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel_pList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel_pList.Name = "tableLayoutPanel_pList";
            this.tableLayoutPanel_pList.RowCount = 1;
            this.tableLayoutPanel_pList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_pList.Size = new System.Drawing.Size(643, 628);
            this.tableLayoutPanel_pList.TabIndex = 1;
            // 
            // btnOrderbasketCancel
            // 
            this.btnOrderbasketCancel.Location = new System.Drawing.Point(312, 5);
            this.btnOrderbasketCancel.Name = "btnOrderbasketCancel";
            this.btnOrderbasketCancel.Size = new System.Drawing.Size(194, 43);
            this.btnOrderbasketCancel.TabIndex = 83;
            this.btnOrderbasketCancel.Text = "장바구니 취소";
            this.btnOrderbasketCancel.UseVisualStyleBackColor = true;
            this.btnOrderbasketCancel.Click += new System.EventHandler(this.btnOrderbasketCancel_Click);
            // 
            // btnPutOrderbasket
            // 
            this.btnPutOrderbasket.Location = new System.Drawing.Point(74, 7);
            this.btnPutOrderbasket.Name = "btnPutOrderbasket";
            this.btnPutOrderbasket.Size = new System.Drawing.Size(221, 42);
            this.btnPutOrderbasket.TabIndex = 82;
            this.btnPutOrderbasket.Text = "장바구니 담기";
            this.btnPutOrderbasket.UseVisualStyleBackColor = true;
            this.btnPutOrderbasket.Click += new System.EventHandler(this.btnPutOrderbasket_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrderbasketCancel);
            this.panel2.Controls.Add(this.btnPutOrderbasket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 60);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_pList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.55118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.448819F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(649, 697);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63399F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66771F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 703);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ProductManageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductManageControl";
            this.Size = new System.Drawing.Size(1356, 703);
            this.Load += new System.EventHandler(this.ProductManageControl_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_pList;
        private System.Windows.Forms.Button btnOrderbasketCancel;
        private System.Windows.Forms.Button btnPutOrderbasket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
