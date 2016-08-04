using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountBook
{
    public class TypesDAL
    {
        public DataTable GetAllType()
        {
            string sql = "select * from [Types]";

            return SqlDbHelper.GetDataTable(sql);
        }
    }
}
