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
            this.lblKf94LeftCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vlblKf94LeftCount = new System.Windows.Forms.Label();
            this.numCount1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKf94LeftCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vlblKf94LeftCount);
            this.groupBox1.Controls.Add(this.numCount1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 69);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product_Name";
            // 
            // lblKf94LeftCount
            // 
            this.lblKf94LeftCount.AutoSize = true;
            this.lblKf94LeftCount.Location = new System.Drawing.Point(208, 46);
            this.lblKf94LeftCount.Name = "lblKf94LeftCount";
            this.lblKf94LeftCount.Size = new System.Drawing.Size(31, 16);
            this.lblKf94LeftCount.TabIndex = 76;
            this.lblKf94LeftCount.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "남은수량";
            // 
            // vlblKf94LeftCount
            // 
            this.vlblKf94LeftCount.AutoSize = true;
            this.vlblKf94LeftCount.Location = new System.Drawing.Point(6, 29);
            this.vlblKf94LeftCount.Name = "vlblKf94LeftCount";
            this.vlblKf94LeftCount.Size = new System.Drawing.Size(55, 16);
            this.vlblKf94LeftCount.TabIndex = 0;
            this.vlblKf94LeftCount.Text = "2000원";
            // 
            // numCount1
            // 
            this.numCount1.Location = new System.Drawing.Point(75, 27);
            this.numCount1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCount1.Name = "numCount1";
            this.numCount1.Size = new System.Drawing.Size(60, 26);
            this.numCount1.TabIndex = 75;
            // 
            // ItemProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemProp";
            this.Size = new System.Drawing.Size(324, 72);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKf94LeftCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vlblKf94LeftCount;
        public System.Windows.Forms.NumericUpDown numCount1;
    }
}
