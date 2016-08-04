using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

public class SqlDbHelper
{
    /// <summary>
    /// �����ַ���
    /// </summary>
    public static readonly string connectionString = ConfigurationManager.ConnectionStrings["AccountBookDB"].ConnectionString;

    #region ExecuteNonQuery����
    /// <summary>
    /// �����ݿ�ִ������ɾ��������
    /// </summary>
    /// <param name="safeSql">T-Sql���</param>
    /// <returns>��Ӱ��ļ�¼��</returns>
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
    /// �����ݿ�ִ������ɾ��������
    /// </summary>
    /// <param name="sql">T-Sql���</param>
    /// <param name="values">��������</param>
    /// <returns>��Ӱ��ļ�¼��</returns>
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
                throw new ApplicationException("ִ��ʧ��",ex);
            }
        }
    }
    /// <summary>
    /// �����ݿ�ִ������ɾ��������(û������)
    /// </summary>
    /// <param name="sql">T-Sql���</param>
    /// <param name="values">��������</param>
    /// <returns>��Ӱ��ļ�¼��</returns>
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
                throw new ApplicationException("ִ��ʧ��", ex);
            }
        }
    }
    #endregion

    #region ExecuteScalar����
    /// <summary>
    /// ��ѯ������е�һ�е�һ�е�ֵ
    /// </summary>
    /// <param name="safeSql">T-Sql���</param>
    /// <returns>��һ�е�һ�е�ֵ</returns>
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
    /// ��ѯ������е�һ�е�һ�е�ֵ
    /// </summary>
    /// <param name="sql">T-Sql���</param>
    /// <param name="values">��������</param>
    /// <returns>��һ�е�һ�е�ֵ</returns>
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

    #region ExecuteReader����
    /// <summary>
    /// �������ݶ�ȡ��
    /// </summary>
    /// <param name="safeSql">T-Sql���</param>
    /// <param name="Connection">���ݿ�����</param>
    /// <returns>���ݶ�ȡ������</returns>
    public static SqlDataReader ExecuteReader(string safeSql, SqlConnection Connection)
    {
        if (Connection.State != ConnectionState.Open)
            Connection.Open();
        SqlCommand cmd = new SqlCommand(safeSql, Connection);
        SqlDataReader reader = cmd.ExecuteReader();
        return reader;
    }

    /// <summary>
    /// �������ݶ�ȡ��
    /// </summary>
    /// <param name="sql">T-Sql���</param>
    /// <param name="values">��������</param>
    /// <param name="Connection">���ݿ�����</param>
    /// <returns>���ݶ�ȡ��</returns>
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

    #region ExecuteDataTable����
    /// <summary>
    /// ִ��ָ�����ݿ����Ӷ��������,ָ���洢���̲���,����DataTable
    /// </summary>
    /// <param name="type">��������(T-Sql�����ߴ洢����)</param>
    /// <param name="safeSql">T-Sql�����ߴ洢���̵�����</param>
    /// <param name="values">��������</param>
    /// <returns>�����DataTable</returns>
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
    /// ִ��ָ�����ݿ����Ӷ��������,ָ���洢���̲���,����DataTable
    /// </summary>
    /// <param name="safeSql">T-Sql���</param>
    /// <returns>�����DataTable</returns>
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
    /// ִ��ָ�����ݿ����Ӷ��������,ָ���洢���̲���,����DataTable
    /// </summary>
    /// <param name="sql">T-Sql���</param>
    /// <param name="values">��������</param>
    /// <returns>�����DataTable</returns>
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

    #region GetDataSet����
    /// <summary>
    /// ȡ������
    /// </summary>
    /// <param name="safeSql">sql���</param>
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

    #region GetDataTable����
    /// <summary>
    /// ȡ������
    /// </summary>
    /// <param name="safeSql">sql���</param>
    /// <param name="tabName">DataTable����</param>
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

    #region ExecureData ����
    /// <summary>
    /// �����޸�����
    /// </summary>
    /// <param name="ds">�޸Ĺ���DataSet</param>
    /// <param name="strTblName">����</param>
    /// <returns></returns>
    public static int ExecureData(DataSet ds, string strTblName)
    {
        try
        {
            //����һ�����ݿ�����
            using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();

                //����һ���������DataSet�Ķ���
                SqlCommand myCommand = new SqlCommand("SELECT * FROM " + strTblName, Connection);
                SqlDataAdapter myAdapter = new SqlDataAdapter();
                //��ȡSQL��䣬���������ݿ���ѡ���¼
                myAdapter.SelectCommand = myCommand;

                //�Զ����ɵ���������ڽ���DataSet�����ĸ��������ݿ�������Ӧ
                SqlCommandBuilder myCommandBuilder = new SqlCommandBuilder(myAdapter);

                return myAdapter.Update(ds, strTblName);  //����ds����
            }

        }
        catch (Exception err)
        {
            throw err;
        }
    }

    #endregion


    /// <summary>
    /// ��ҳ����
    /// </summary>
    /// <param name="procName">�洢��������</param>
    /// <param name="parameters">�����б�</param>
    /// <param name="totalNum">��ѯ��¼����</param>
    /// <returns>�������ݱ�</returns>
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
