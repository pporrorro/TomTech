namespace SecondTombuyScreen
{
    partial class ProductManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderbasketCancel = new System.Windows.Forms.Button();
            this.btnPutOrderbasket = new System.Windows.Forms.Button();
            this.tableLayoutPanel_pList = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
<<<<<<<< HEAD:Tom/FinalTombuyScreen/SecondTombuyScreen/ProductManage.Designer.cs
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
========
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
>>>>>>>> b1ae92d838cb0f00c4b59f48a7c86719cc7a6866:Tom/ShopperScreen/SecondTombuyScreen/ProductManage.Designer.cs
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66771F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1528, 821);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_pList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.55118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.448819F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 813);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrderbasketCancel);
            this.panel2.Controls.Add(this.btnPutOrderbasket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 740);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 69);
            this.panel2.TabIndex = 0;
            // 
            // btnOrderbasketCancel
            // 
            this.btnOrderbasketCancel.Location = new System.Drawing.Point(357, 6);
            this.btnOrderbasketCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderbasketCancel.Name = "btnOrderbasketCancel";
            this.btnOrderbasketCancel.Size = new System.Drawing.Size(222, 54);
            this.btnOrderbasketCancel.TabIndex = 83;
            this.btnOrderbasketCancel.Text = "장바구니 취소";
            this.btnOrderbasketCancel.UseVisualStyleBackColor = true;
            this.btnOrderbasketCancel.Click += new System.EventHandler(this.btnOrderbasketCancel_Click);
            // 
            // btnPutOrderbasket
            // 
            this.btnPutOrderbasket.Location = new System.Drawing.Point(85, 9);
            this.btnPutOrderbasket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPutOrderbasket.Name = "btnPutOrderbasket";
            this.btnPutOrderbasket.Size = new System.Drawing.Size(253, 52);
            this.btnPutOrderbasket.TabIndex = 82;
            this.btnPutOrderbasket.Text = "장바구니 담기";
            this.btnPutOrderbasket.UseVisualStyleBackColor = true;
            this.btnPutOrderbasket.Click += new System.EventHandler(this.btnPutOrderbasket_Click);
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
            this.tableLayoutPanel_pList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.tableLayoutPanel_pList.Name = "tableLayoutPanel_pList";
            this.tableLayoutPanel_pList.RowCount = 1;
            this.tableLayoutPanel_pList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_pList.Size = new System.Drawing.Size(727, 732);
            this.tableLayoutPanel_pList.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(742, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.12598F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.87402F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(783, 813);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
<<<<<<<< HEAD:Tom/FinalTombuyScreen/SecondTombuyScreen/ProductManage.Designer.cs
========
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrderList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 544);
            this.panel1.TabIndex = 85;
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(26, 34);
            this.txtOrderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrderList.Size = new System.Drawing.Size(655, 489);
            this.txtOrderList.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "장바구니 정보";
            // 
>>>>>>>> b1ae92d838cb0f00c4b59f48a7c86719cc7a6866:Tom/ShopperScreen/SecondTombuyScreen/ProductManage.Designer.cs
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.btnInsertOrder);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(3, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(682, 230);
            this.groupBox7.TabIndex = 84;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "구매자 정보";
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(255, 162);
            this.btnInsertOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(174, 60);
            this.btnInsertOrder.TabIndex = 4;
            this.btnInsertOrder.Text = "주문하기";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(452, 25);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "주소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "회원이름";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 25);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "회원번호";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtOrderList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 436);
            this.panel1.TabIndex = 85;
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
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 821);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderbasketCancel;
        private System.Windows.Forms.Button btnPutOrderbasket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_pList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}