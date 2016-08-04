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

        public void AddRangeDetail(List<Detial> list,int aid)
        {
            string sql = "insert into detail values(@aid,@name,@number,@money)";
            List<SqlParameter> pars = new List<SqlParameter>();
            
            foreach(Detial detail in list){
                pars.Clear();
                pars.Add(new SqlParameter("@aid", aid));
                pars.Add(new SqlParameter("@name",detail.Name));
                pars.Add(new SqlParameter("@number", detail.Number));
                pars.Add(new SqlParameter("@money", detail.Money));

                SqlDbHelper.ExecuteNonQuery(sql,pars.ToArray());
            }
        }
    }
}
