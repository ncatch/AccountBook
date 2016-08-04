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
