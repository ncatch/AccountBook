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
    public partial class frmDetail : frmBase
    {
        public frmDetail() : base()
        {
            InitializeComponent();
            SetEven();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            AccountDAL adal = new AccountDAL();
            DetailDAL ddal = new DetailDAL();

            Account acc = adal.GetAccountById(Convert.ToInt32(this.Tag));

            txt_Money.Text = acc.Money.ToString();
            txt_Remark.Text = acc.Remark;

            if(acc.IsOut == "否"){
                cbo_IsOut.Text = "收入";
            }

            grid_detail.DataSource = ddal.GetDetialList(acc.Id);
        }
    }
}
