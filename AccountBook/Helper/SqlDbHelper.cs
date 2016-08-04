using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

public class SqlDbHelper
{
    /// <summary>
    /// 连接字符串
    /// </summary>
    public static readonly string connectionString = ConfigurationManager.ConnectionStrings["AccountBookDB"].ConnectionString;

    #region ExecuteNonQuery命令
    /// <summary>
    /// 对数据库执行增、删、改命令
    /// </summary>
    /// <param name="safeSql">T-Sql语句</param>
    /// <returns>受影响的记录数</returns>
    public static int ExecuteNonQuery(string safeSql)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            Connection.Open();
            SqlTransaction trans = Connection.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                cmd.Transaction = trans;

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                int result = cmd.ExecuteNonQuery();

                trans.Commit();
                Connection.Close();
                return result;
            }
            catch
            {
                trans.Rollback();
                return 0;
            }
        }
    }

    /// <summary>
    /// 对数据库执行增、删、改命令
    /// </summary>
    /// <param name="sql">T-Sql语句</param>
    /// <param name="values">参数数组</param>
    /// <returns>受影响的记录数</returns>
    public static int ExecuteNonQuery(string sql, SqlParameter[] values)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            Connection.Open();
            SqlTransaction trans = Connection.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Transaction = trans;
                cmd.Parameters.AddRange(values);
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                int result = cmd.ExecuteNonQuery();
                trans.Commit();
                return result;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new ApplicationException("执行失败",ex);
            }
        }
    }
    /// <summary>
    /// 对数据库执行增、删、改命令(没有事务)
    /// </summary>
    /// <param name="sql">T-Sql语句</param>
    /// <param name="values">参数数组</param>
    /// <returns>受影响的记录数</returns>
    public static int ExecuteQuery(string sql, SqlParameter[] values)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            Connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("执行失败", ex);
            }
        }
    }
    #endregion

    #region ExecuteScalar命令
    /// <summary>
    /// 查询结果集中第一行第一列的值
    /// </summary>
    /// <param name="safeSql">T-Sql语句</param>
    /// <returns>第一行第一列的值</returns>
    public static int ExecuteScalar(string safeSql)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
    }

    public static Object ExecuteScalarObj(string safeSql)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            return cmd.ExecuteScalar();
        }
    }
    /// <summary>
    /// 查询结果集中第一行第一列的值
    /// </summary>
    /// <param name="sql">T-Sql语句</param>
    /// <param name="values">参数数组</param>
    /// <returns>第一行第一列的值</returns>
    public static int ExecuteScalar(string sql, SqlParameter[] values)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }
    }
    #endregion

    #region ExecuteReader命令
    /// <summary>
    /// 创建数据读取器
    /// </summary>
    /// <param name="safeSql">T-Sql语句</param>
    /// <param name="Connection">数据库连接</param>
    /// <returns>数据读取器对象</returns>
    public static SqlDataReader ExecuteReader(string safeSql, SqlConnection Connection)
    {
        if (Connection.State != ConnectionState.Open)
            Connection.Open();
        SqlCommand cmd = new SqlCommand(safeSql, Connection);
        SqlDataReader reader = cmd.ExecuteReader();
        return reader;
    }

    /// <summary>
    /// 创建数据读取器
    /// </summary>
    /// <param name="sql">T-Sql语句</param>
    /// <param name="values">参数数组</param>
    /// <param name="Connection">数据库连接</param>
    /// <returns>数据读取器</returns>
    public static SqlDataReader ExecuteReader(string sql, SqlParameter[] values, SqlConnection Connection)
    {
        if (Connection.State != ConnectionState.Open)
            Connection.Open();
        SqlCommand cmd = new SqlCommand(sql, Connection);
        cmd.Parameters.AddRange(values);
        SqlDataReader reader = cmd.ExecuteReader();
        return reader;
    }
    #endregion

    #region ExecuteDataTable命令
    /// <summary>
    /// 执行指定数据库连接对象的命令,指定存储过程参数,返回DataTable
    /// </summary>
    /// <param name="type">命令类型(T-Sql语句或者存储过程)</param>
    /// <param name="safeSql">T-Sql语句或者存储过程的名称</param>
    /// <param name="values">参数数组</param>
    /// <returns>结果集DataTable</returns>
    public static DataTable ExecuteDataTable(CommandType type, string safeSql, params SqlParameter[] qq)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(qq);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }

    /// <summary>
    /// 执行指定数据库连接对象的命令,指定存储过程参数,返回DataTable
    /// </summary>
    /// <param name="safeSql">T-Sql语句</param>
    /// <returns>结果集DataTable</returns>
    public static DataTable ExecuteDataTable(string safeSql)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(ds);
            }
            catch (Exception)
            {

            }
            return ds.Tables[0];
        }
    }

    /// <summary>
    /// 执行指定数据库连接对象的命令,指定存储过程参数,返回DataTable
    /// </summary>
    /// <param name="sql">T-Sql语句</param>
    /// <param name="values">参数数组</param>
    /// <returns>结果集DataTable</returns>
    public static DataTable ExecuteDataTable(string sql, params SqlParameter[] values)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandTimeout = 0;
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
    #endregion

    #region GetDataSet命令
    /// <summary>
    /// 取出数据
    /// </summary>
    /// <param name="safeSql">sql语句</param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static DataSet GetDataSet(string safeSql, params SqlParameter[] values)
    {

        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);

            if (values != null)
                cmd.Parameters.AddRange(values);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(ds);
            }
            catch
            {
                return null;
            }
            finally
            {
                Connection.Close();
            }
            return ds;
        }
    }
    #endregion

    #region GetDataTable命令
    /// <summary>
    /// 取出数据
    /// </summary>
    /// <param name="safeSql">sql语句</param>
    /// <param name="tabName">DataTable别名</param>
    /// <param name="values"></param>
    /// <returns></returns>
    public static DataTable GetDataTable(string safeSql)
    {
        using (SqlConnection Connection = new SqlConnection(connectionString))
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            Connection.Close();
            return dt;
        }
    }
    #endregion

    #region ExecureData 命令
    /// <summary>
    /// 批量修改数据
    /// </summary>
    /// <param name="ds">修改过的DataSet</param>
    /// <param name="strTblName">表名</param>
    /// <returns></returns>
    public static int ExecureData(DataSet ds, string strTblName)
    {
        try
        {
            //创建一个数据库连接
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();

                //创建一个用于填充DataSet的对象
                SqlCommand myCommand = new SqlCommand("SELECT * FROM " + strTblName, Connection);
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                //获取SQL语句，用于在数据库中选择记录
                myAdapter.SelectCommand = myCommand;

                //自动生成单表命令，用于将对DataSet所做的更改与数据库更改相对应
                SqlCommandBuilder myCommandBuilder = new SqlCommandBuilder(myAdapter);

                return myAdapter.Update(ds, strTblName);  //更新ds数据
            }

        }
        catch (Exception err)
        {
            throw err;
        }
    }

    #endregion


    /// <summary>
    /// 分页方法
    /// </summary>
    /// <param name="procName">存储过程名称</param>
    /// <param name="parameters">参数列表</param>
    /// <param name="totalNum">查询记录总数</param>
    /// <returns>返回数据表</returns>
    public static DataSet GetDataTableByProc(string procName, SqlParameter[] parameters)
    {
        SqlConnection conn= new SqlConnection(connectionString);
        DataSet ds = new DataSet();
        conn.Open();
        SqlCommand com = new SqlCommand(procName);
        com.CommandType = CommandType.StoredProcedure;
        com.Connection = conn;
        com.CommandTimeout = 600;

        if (parameters != null)
        {
            foreach (SqlParameter parameter in parameters)
            {
                if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                {
                    parameter.Value = DBNull.Value;
                }
                com.Parameters.Add(parameter);
            }
        }

        SqlDataAdapter da = new SqlDataAdapter(com);
        da.Fill(ds);
        conn.Close();
        return ds;
    }

    public static List<Dictionary<string, object>> GetList(string sql)
    {
        List<Dictionary<string, object>> listdc = new List<Dictionary<string, object>>();
        using (SqlConnection Connection = new SqlConnection(SqlDbHelper.connectionString))
        {
            SqlDataReader sdr = SqlDbHelper.ExecuteReader(sql, Connection);
            while (sdr.Read())
            {
                Dictionary<string, object> dc = new Dictionary<string, object>();
                for (int cindex = 0; cindex < sdr.FieldCount; cindex++)
                {
                    dc.Add(sdr.GetName(cindex), sdr[cindex]);
                }
                listdc.Add(dc);
            }
            sdr.Close();
        }
        return listdc;
    }

}
