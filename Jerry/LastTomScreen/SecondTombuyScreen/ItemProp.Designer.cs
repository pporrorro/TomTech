namespace SecondTombuyScreen
{
    partial class ItemProp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLeftCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.numCount1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLeftCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblProductPrice);
            this.groupBox1.Controls.Add(this.numCount1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox1.Location = new System.Drawing.Point(147, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(342, 133);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product_Name";
            // 
            // lblLeftCount
            // 
            this.lblLeftCount.AutoSize = true;
            this.lblLeftCount.Location = new System.Drawing.Point(246, 76);
            this.lblLeftCount.Name = "lblLeftCount";
            this.lblLeftCount.Size = new System.Drawing.Size(42, 20);
            this.lblLeftCount.TabIndex = 76;
            this.lblLeftCount.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "재고량 (개)";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(31, 59);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(73, 20);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "2000원";
            // 
            // numCount1
            // 
            this.numCount1.Location = new System.Drawing.Point(122, 57);
            this.numCount1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCount1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCount1.Name = "numCount1";
            this.numCount1.Size = new System.Drawing.Size(69, 30);
            this.numCount1.TabIndex = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // ItemProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemProp";
            this.Size = new System.Drawing.Size(496, 141);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numCount1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblLeftCount;
        public System.Windows.Forms.Label lblProductPrice;
    }
}
