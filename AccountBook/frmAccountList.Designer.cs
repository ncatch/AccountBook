namespace AccountBook
{
    partial class frmAccountList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountList));
            this.grid_account = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tool_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_close = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.time_ChangeImage = new System.Windows.Forms.Timer(this.components);
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tim_hide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_account)).BeginInit();
            this.con_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_account
            // 
            this.grid_account.AllowUserToAddRows = false;
            this.grid_account.AllowUserToDeleteRows = false;
            this.grid_account.AllowUserToResizeColumns = false;
            this.grid_account.AllowUserToResizeRows = false;
            this.grid_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TypeName,
            this.DateTime,
            this.Money,
            this.IsOut});
            this.grid_account.Location = new System.Drawing.Point(252, 1);
            this.grid_account.MultiSelect = false;
            this.grid_account.Name = "grid_account";
            this.grid_account.RowHeadersVisible = false;
            this.grid_account.RowTemplate.Height = 23;
            this.grid_account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_account.Size = new System.Drawing.Size(403, 261);
            this.grid_account.TabIndex = 0;
            this.grid_account.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_account_CellDoubleClick);
            this.grid_account.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_account_CellMouseDown);
            this.grid_account.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_account_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "类型";
            this.TypeName.Name = "TypeName";
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.DateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateTime.HeaderText = "时间";
            this.DateTime.Name = "DateTime";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "金额";
            this.Money.Name = "Money";
            // 
            // IsOut
            // 
            this.IsOut.DataPropertyName = "IsOut";
            this.IsOut.HeaderText = "是否支出";
            this.IsOut.Name = "IsOut";
            // 
            // con_Main
            // 
            this.con_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Add,
            this.tool_del,
            this.toolStripSeparator1,
            this.tool_close});
            this.con_Main.Name = "con_Main";
            this.con_Main.Size = new System.Drawing.Size(101, 76);
            this.con_Main.Opening += new System.ComponentModel.CancelEventHandler(this.con_Main_Opening);
            // 
            // tool_Add
            // 
            this.tool_Add.Name = "tool_Add";
            this.tool_Add.Size = new System.Drawing.Size(100, 22);
            this.tool_Add.Text = "新增";
            this.tool_Add.Click += new System.EventHandler(this.tool_Add_Click);
            // 
            // tool_del
            // 
            this.tool_del.Name = "tool_del";
            this.tool_del.Size = new System.Drawing.Size(100, 22);
            this.tool_del.Text = "删除";
            this.tool_del.Click += new System.EventHandler(this.tool_del_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // tool_close
            // 
            this.tool_close.Name = "tool_close";
            this.tool_close.Size = new System.Drawing.Size(100, 22);
            this.tool_close.Text = "关闭";
            this.tool_close.Click += new System.EventHandler(this.tool_close_Click);
            // 
            // pic_img
            // 
            this.pic_img.BackColor = System.Drawing.Color.Transparent;
            this.pic_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_img.BackgroundImage")));
            this.pic_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_img.Location = new System.Drawing.Point(0, 144);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(126, 119);
            this.pic_img.TabIndex = 1;
            this.pic_img.TabStop = false;
            // 
            // time_ChangeImage
            // 
            this.time_ChangeImage.Interval = 10000;
            this.time_ChangeImage.Tag = "1";
            this.time_ChangeImage.Tick += new System.EventHandler(this.time_ChangeImage_Tick);
            // 
            // cbo_Type
            // 
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Location = new System.Drawing.Point(84, 20);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(121, 20);
            this.cbo_Type.TabIndex = 2;
            this.cbo_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "类型";
            // 
            // tim_hide
            // 
            this.tim_hide.Tick += new System.EventHandler(this.tim_hide_Tick);
            // 
            // frmAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 263);
            this.ContextMenuStrip = this.con_Main;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Type);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.grid_account);
            this.Name = "frmAccountList";
            this.Text = "frmAccountList";
            this.Load += new System.EventHandler(this.frmAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_account)).EndInit();
            this.con_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_account;
        private System.Windows.Forms.ContextMenuStrip con_Main;
        private System.Windows.Forms.ToolStripMenuItem tool_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tool_close;
        private System.Windows.Forms.ToolStripMenuItem tool_del;
        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.Timer time_ChangeImage;
        private System.Windows.Forms.ComboBox cbo_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOut;
        private System.Windows.Forms.Timer tim_hide;
    }
}