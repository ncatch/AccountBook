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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_IsOut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_detail = new System.Windows.Forms.DataGridView();
            this.detialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "支出/收入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "备注";
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(76, 26);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(121, 21);
            this.txt_Money.TabIndex = 4;
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(76, 92);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(343, 78);
            this.txt_Remark.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "金额";
            // 
            // cbo_IsOut
            // 
            this.cbo_IsOut.FormattingEnabled = true;
            this.cbo_IsOut.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.cbo_IsOut.Location = new System.Drawing.Point(76, 59);
            this.cbo_IsOut.Name = "cbo_IsOut";
            this.cbo_IsOut.Size = new System.Drawing.Size(121, 20);
            this.cbo_IsOut.TabIndex = 7;
            this.cbo_IsOut.Text = "支出";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "项目";
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
            this.grid_detail.Location = new System.Drawing.Point(76, 176);
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
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 348);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_IsOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetail";
            this.Text = "明细";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_IsOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn detialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
    }
}