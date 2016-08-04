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
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int money = 0;
            List<Detial> dlist = new List<Detial>();

            for (int i = 0; i < grid_detail.Rows.Count - 1; i++)
            {
                DataGridViewRow row = grid_detail.Rows[i];
                money += Convert.ToInt32(row.Cells["Money"].Value);

                dlist.Add(new Detial
                {
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
                Money = Convert.ToInt32(txt_Money.Text)
            };

            AccountDAL adal = new AccountDAL();
            DetailDAL ddal = new DetailDAL();

            int aid = adal.AddAccount(acc);
            ddal.AddRangeDetail(dlist, aid);
        }

        private void grid_detail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int money = 0;

            foreach (DataGridViewRow row in grid_detail.Rows)
            {
                money += Convert.ToInt32(row.Cells["Money"].Value);
            }

            txt_Money.Text = money.ToString();
        }
    }
}
