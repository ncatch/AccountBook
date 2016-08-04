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
    public partial class frmAccountList : frmBase
    {
        public frmAccountList():base()
        {
            InitializeComponent();
            //base.InitializeComponent();
            base.SetEven();
        }

        /// <summary>
        /// 返回grid当前选中行的Id 如果没有选中行 则返回-1
        /// </summary>
        public int GridSelectId
        {
            get
            {
                if (grid_account.SelectedRows.Count == 0)
                {
                    return -1;
                }
                return Convert.ToInt32(grid_account.Rows[grid_account.SelectedRows[0].Index].Cells["Id"].Value);
            }
        }


        private void frmAccountList_Load(object sender, EventArgs e)
        {
            time_ChangeImage.Enabled = true;
            //this.TransparencyKey = this.BackColor;
            BindData();
        }

        public void BindData()
        {
            AccountDAL dal = new AccountDAL();
            grid_account.DataSource = dal.GetAllAccount();

        }

        private void tool_Add_Click(object sender, EventArgs e)
        {
            frmAddAccount frm = new frmAddAccount();
            frm.ShowDialog();
            BindData();
        }

        private void tool_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grid_account_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetail frm = new frmDetail();
            frm.Tag = grid_account.Rows[e.RowIndex].Cells["Id"].Value;
            frm.MdiParent = this.MdiParent;
            frm.ShowDialog();
        }

        private void con_Main_Opening(object sender, CancelEventArgs e)
        {
            if (grid_account.SelectedRows.Count == 0)
            {
                tool_del.Enabled = false;
            }
        }

        private void tool_del_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                AccountDAL dal = new AccountDAL();
                if (dal.DeleteAccount(GridSelectId))
                {
                    MessageBox.Show("删除成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    grid_account.Rows.Remove(grid_account.SelectedRows[0]);
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void grid_account_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                grid_account.Rows[e.RowIndex].Selected = true;
            }
        }

        private void grid_account_MouseDown(object sender, MouseEventArgs e)
        {
            grid_account.ClearSelection();
        }

        private void time_ChangeImage_Tick(object sender, EventArgs e)
        {
            string index = (Convert.ToInt32(time_ChangeImage.Tag) + 1).ToString();
            time_ChangeImage.Tag = index;
            string name = "img_img" + index + ".png";
            pic_img.Image = Image.FromFile("./Images/" + name);
        }
    }
}
