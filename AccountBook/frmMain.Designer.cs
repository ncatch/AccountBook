namespace AccountBook
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.tool_main = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_AccountList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_main});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(597, 25);
            this.menu_main.TabIndex = 1;
            this.menu_main.Text = "menuStrip1";
            // 
            // tool_main
            // 
            this.tool_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_AccountList,
            this.toolStripSeparator1,
            this.tool_exit});
            this.tool_main.Name = "tool_main";
            this.tool_main.Size = new System.Drawing.Size(56, 21);
            this.tool_main.Text = "主菜单";
            // 
            // tool_AccountList
            // 
            this.tool_AccountList.Name = "tool_AccountList";
            this.tool_AccountList.Size = new System.Drawing.Size(152, 22);
            this.tool_AccountList.Text = "消费列表";
            this.tool_AccountList.Click += new System.EventHandler(this.tool_AccountList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tool_exit
            // 
            this.tool_exit.Name = "tool_exit";
            this.tool_exit.Size = new System.Drawing.Size(152, 22);
            this.tool_exit.Text = "退出";
            this.tool_exit.Click += new System.EventHandler(this.tool_exit_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(597, 355);
            this.Controls.Add(this.menu_main);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem tool_main;
        private System.Windows.Forms.ToolStripMenuItem tool_AccountList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tool_exit;

    }
}