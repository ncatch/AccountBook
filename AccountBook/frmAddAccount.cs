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
    public partial class frmAddAccount : frmBase
    {
        public frmAddAccount()
            : base()
        {
            InitializeComponent();
            base.SetEven();
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            TypesDAL tdal = new TypesDAL();
            cbo_Type.ValueMember = "Id";
            cbo_Type.DisplayMember = "Name";
            cbo_Type.DataSource = tdal.GetAllType();

            if(this.Tag != null){
                AccountDAL adal = new AccountDAL();
                Account acc = adal.GetAccountById(Convert.ToInt32(this.Tag));

                cbo_Type.SelectedValue = acc.Type;
                txt_Money.Text = acc.Money.ToString();
                com_Isout.Text = acc.IsOut == "是" ? "支出" : "收入";
                date_datetime.Value = acc.DateTime;

                DetailDAL ddal = new DetailDAL();
                grid_detail.DataSource = ddal.GetDetialList(acc.Id);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int money = 0;
                List<Detial> dlist = new List<Detial>();

                for (int i = 0; i < grid_detail.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = grid_detail.Rows[i];

                    if (row.Cells["Money"].Value is DBNull)
                    {
                        row.Cells["Money"].Value = 0;
                    }

                    money += Convert.ToInt32(row.Cells["Money"].Value);

                    dlist.Add(new Detial
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value is DBNull ? 0 : row.Cells["Id"].Value),
                        Number = Convert.ToInt32(row.Cells["Number"].Value),
                        Name = row.Cells["detialName"].Value.ToString(),
                        Money = Convert.ToDecimal(row.Cells["Money"].Value)
                    });
                }

                Account acc = new Account
                {
                    Remark = txt_Remark.Text,
                    Type = Convert.ToInt32(cbo_Type.SelectedValue),
                    DateTime = date_datetime.Value,
                    IsOut = com_Isout.Text == "支出" ? "是" : "否",
                    Money = Convert.ToInt32(txt_Money.Text),
                    Id = this.Tag == null ? 0 : Convert.ToInt32(this.Tag)
                };

                AccountDAL adal = new AccountDAL();
                DetailDAL ddal = new DetailDAL();

                if(acc.Id > 0){
                    adal.UpdateAccount(acc);
                }
                else
                {
                    int aid = adal.AddAccount(acc);
                    acc.Id = aid;
                }

                ddal.AddRangeDetail(dlist, acc.Id);
                
                Tool.promptMessage("保存成功!");
                this.Close();
            }
            catch(Exception ex){
                Tool.errorMessage(ex.Message);
            }
        }

        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int money = 0;

            foreach (DataGridViewRow row in grid_detail.Rows)
            {
                if (row.Cells["Money"].Value != DBNull.Value)
                {
                    money += Convert.ToInt32(row.Cells["Money"].Value);
                }
            }

            txt_Money.Text = money.ToString();
        }

        private void tool_del_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = grid_detail.SelectedRows[0].Cells["Id"];

            if(cell.Value != DBNull.Value){
                DetailDAL ddal = new DetailDAL();
                ddal.DeleteDetail(cell.Value.ToString());
            }

            grid_detail.Rows.Remove(grid_detail.SelectedRows[0]);

            Tool.promptMessage("删除成功!");
        }
    }
}
