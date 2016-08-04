using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tool_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tool_AccountList_Click(object sender, EventArgs e)
        {
            frmAccountList frm = new frmAccountList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer
                       | ControlStyles.ResizeRedraw
                       | ControlStyles.Selectable
                       | ControlStyles.AllPaintingInWmPaint
                       | ControlStyles.UserPaint
                       | ControlStyles.SupportsTransparentBackColor,
                     true);

            //this.BackgroundImage = Image.FromFile("./Images/main_bg.png");
            //this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
