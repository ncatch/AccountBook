using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public class frmBase : Form
    {
        Point mouseOff;
        private ContextMenuStrip con_Main;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem tool_close;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        public frmBase()
        {
            InitializeComponent();
            //this.TransparencyKey = this.BackColor; 

            //this.BackgroundImage = Image.FromFile("./Images/main_bg.png");
            //this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Opacity = 0.92;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//防止窗口跳动
            SetStyle(ControlStyles.DoubleBuffer, true); //防止控件跳动
        }

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.con_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tool_close = new System.Windows.Forms.ToolStripMenuItem();
            this.con_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // con_Main
            // 
            this.con_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_close});
            this.con_Main.Name = "con_Main";
            this.con_Main.Size = new System.Drawing.Size(101, 26);
            // 
            // tool_close
            // 
            this.tool_close.Name = "tool_close";
            this.tool_close.Size = new System.Drawing.Size(100, 22);
            this.tool_close.Text = "关闭";
            this.tool_close.Click += new System.EventHandler(this.tool_close_Click);
            // 
            // frmBase
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ContextMenuStrip = this.con_Main;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBase";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseUp);
            this.con_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void SetEven()
        {
            foreach (Control con in this.Controls)
            {
                con.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseDown);
                con.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseMove);
                con.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseUp);

                if(con is Label){
                    con.BackColor = Color.Transparent;
                }
            }
        }

        private void frmBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = e.Location;
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void frmBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Location = new Point(Location.X + (e.X - mouseOff.X), Location.Y + (e.Y - mouseOff.Y));
            }
        }

        private void frmBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void tool_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
