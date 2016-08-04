using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountBook
{
    public class DetailDAL
    {
        public DataTable GetDetialList(int aid)
        {
            string sql = @"select Name as detailname,Number,Money from Detail where AccountId = " + aid;
            return SqlDbHelper.GetDataTable(sql);
        }
    }
}
