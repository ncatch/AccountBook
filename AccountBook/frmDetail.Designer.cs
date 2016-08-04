namespace AccountBook
{
    partial class frmDetail
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
            this.grid_detail = new System.Windows.Forms.DataGridView();
            this.detialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_IsOut = new System.Windows.Forms.ComboBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detialName,
            this.Number,
            this.Money});
            this.grid_detail.Location = new System.Drawing.Point(87, 167);
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowTemplate.Height = 23;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(343, 160);
            this.grid_detail.TabIndex = 10;
            // 
            // detialName
            // 
            this.detialName.DataPropertyName = "detailname";
            this.detialName.HeaderText = "名称";
            this.detialName.Name = "detialName";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "数量";
            this.Number.Name = "Number";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "金额";
            this.Money.Name = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "支出/收入";
            // 
            // cbo_IsOut
            // 
            this.cbo_IsOut.FormattingEnabled = true;
            this.cbo_IsOut.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.cbo_IsOut.Location = new System.Drawing.Point(87, 50);
            this.cbo_IsOut.Name = "cbo_IsOut";
            this.cbo_IsOut.Size = new System.Drawing.Size(121, 20);
            this.cbo_IsOut.TabIndex = 7;
            this.cbo_IsOut.Text = "支出";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(87, 83);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(343, 78);
            this.txt_Remark.TabIndex = 5;
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(87, 17);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(121, 21);
            this.txt_Money.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "金额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "项目";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "备注";
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 348);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_IsOut);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "frmDetail";
            this.Text = "明细";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn detialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_IsOut;
    }
}