namespace AccountBook
{
    partial class frmAddAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.con_gridHandle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tool_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_del = new System.Windows.Forms.ToolStripMenuItem();
            this.grid_detail = new System.Windows.Forms.DataGridView();
            this.detialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_Isout = new System.Windows.Forms.ComboBox();
            this.date_datetime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.con_gridHandle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // con_gridHandle
            // 
            this.con_gridHandle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Add,
            this.tool_del});
            this.con_gridHandle.Name = "con_gridHandle";
            this.con_gridHandle.Size = new System.Drawing.Size(101, 48);
            // 
            // tool_Add
            // 
            this.tool_Add.Name = "tool_Add";
            this.tool_Add.Size = new System.Drawing.Size(100, 22);
            this.tool_Add.Text = "新增";
            // 
            // tool_del
            // 
            this.tool_del.Name = "tool_del";
            this.tool_del.Size = new System.Drawing.Size(100, 22);
            this.tool_del.Text = "删除";
            // 
            // grid_detail
            // 
            this.grid_detail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detialName,
            this.Number,
            this.Money});
            this.grid_detail.ContextMenuStrip = this.con_gridHandle;
            this.grid_detail.Location = new System.Drawing.Point(75, 281);
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowTemplate.Height = 23;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(343, 117);
            this.grid_detail.TabIndex = 11;
            this.grid_detail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellEndEdit);
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
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(343, 418);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(75, 177);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(343, 89);
            this.txt_Remark.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "备注";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(245, 418);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Money
            // 
            this.txt_Money.Enabled = false;
            this.txt_Money.Location = new System.Drawing.Point(75, 55);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(121, 21);
            this.txt_Money.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "金额";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型";
            // 
            // cbo_Type
            // 
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(75, 19);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(121, 20);
            this.cbo_Type.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "支出/收入";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "明细";
            // 
            // com_Isout
            // 
            this.com_Isout.FormattingEnabled = true;
            this.com_Isout.Items.AddRange(new object[] {
            "支出",
            "收入"});
            this.com_Isout.Location = new System.Drawing.Point(75, 94);
            this.com_Isout.Name = "com_Isout";
            this.com_Isout.Size = new System.Drawing.Size(121, 20);
            this.com_Isout.TabIndex = 15;
            this.com_Isout.Text = "支出";
            // 
            // date_datetime
            // 
            this.date_datetime.CustomFormat = "年-月-日 时:分:秒";
            this.date_datetime.Location = new System.Drawing.Point(75, 131);
            this.date_datetime.Name = "date_datetime";
            this.date_datetime.Size = new System.Drawing.Size(121, 21);
            this.date_datetime.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 159);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.date_datetime);
            this.Controls.Add(this.com_Isout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Type);
            this.Name = "frmAddAccount";
            this.Text = "frmAddAccount";
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            this.con_gridHandle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView grid_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn detialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.ContextMenuStrip con_gridHandle;
        private System.Windows.Forms.ToolStripMenuItem tool_Add;
        private System.Windows.Forms.ToolStripMenuItem tool_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox com_Isout;
        private System.Windows.Forms.DateTimePicker date_datetime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}