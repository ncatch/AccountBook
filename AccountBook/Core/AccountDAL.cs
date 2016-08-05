using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccountBook
{
    public class AccountDAL
    {
        public DataTable GetAllAccount()
        {
            string sql = @"select a.Id,a.[DateTime],a.[Money],t.Name as TypeName,a.IsOut from Account as a
                           inner join [Types] as t on t.Id = a.[Type]";
            return SqlDbHelper.GetDataTable(sql);
        }

        public Account GetAccountById(int Id)
        {
            string sql = @"select * from Account where Id = " + Id;
            return ReadData.ToObject<Account>(SqlDbHelper.GetDataTable(sql).Rows[0]);
        }

        public void UpdateAccount(Account acc)
        {
            string sql = @"update account set [datetime] = @datetime,[money] =@money,[Type]=@type,Remark=@remark,IsOut=@isout
                           where Id = @id";

            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@id",acc.Id),
                new SqlParameter("@datetime",acc.DateTime),
                new SqlParameter("@money",acc.Money),
                new SqlParameter("@type",acc.Type),
                new SqlParameter("@remark",acc.Remark),
                new SqlParameter("@isout",acc.IsOut)
            };

            SqlDbHelper.ExecuteQuery(sql,pars);
        }

        public DataTable GetAccountByTypeId(string tId)
        {
            string sql = @"select a.Id,a.[DateTime],a.[Money],t.Name as TypeName,a.IsOut from Account as a
                           inner join [Types] as t on t.Id = a.[Type]
                           where a.Type = @tid";
            return SqlDbHelper.GetDataSet(sql, new SqlParameter("@tid", tId)).Tables[0];
        }

        public bool DeleteAccount(int Id)
        {
            string sql = @"delete Detail where AccountId = " + Id + ";delete Account where Id = " + Id;

            return SqlDbHelper.ExecuteNonQuery(sql) > 0;
        }

        public int AddAccount(Account entity)
        {
            string sql = string.Format(@"insert into Account Values('{0}',{1},{2},'{3}','{4}');select scope_identity()", entity.DateTime, entity.Money, entity.Type, entity.Remark, entity.IsOut);

            return SqlDbHelper.ExecuteScalar(sql);
        }
    }
}
