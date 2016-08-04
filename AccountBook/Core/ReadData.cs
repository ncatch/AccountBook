using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace AccountBook
{
    public class ReadData
    {
        //把dataread中的数转换成集合
        public static List<T> ToList<T>(SqlDataReader dr) where T : new()
        {
            List<T> list = new List<T>();

            while (dr.Read())
            {
                T t = new T();
                PropertyInfo[] pr = typeof(T).GetProperties();

                foreach (var v in pr)
                {
                    if(v.PropertyType.FullName.StartsWith("System.")){
                        v.SetValue(t, dr[v.Name] is DBNull ? "" : dr[v.Name]);
                    }
                }

                list.Add(t);
            }
            return list;
        }

        public static List<T> ToList<T>(DataTable dt) where T : new()
        {
            List<T> list = new List<T>();

            foreach(DataRow dr in dt.Rows){
                T t = new T();
                PropertyInfo[] pr = typeof(T).GetProperties();

                foreach (var v in pr)
                {
                    if (v.PropertyType.FullName.StartsWith("System."))
                    {
                        v.SetValue(t, dr[v.Name] is DBNull ? "" : dr[v.Name]);
                    }
                }

                list.Add(t);
            }
                
            
            return list;
        }

        //把一行dataread数据转换成对象返回
        public static T ToObject<T>(SqlDataReader dr) where T:new()
        {
            T t = new T();

            dr.Read();

            PropertyInfo[] pro = typeof(T).GetProperties();

            foreach(var v in pro){
                if(v.PropertyType.FullName.StartsWith("System.")){
                    v.SetValue(t,dr[v.Name] is DBNull ? "" : dr[v.Name]);
                }
            }

            return t;
        }

        public static T ToObject<T>(DataRow row) where T : new()
        {
            T t = new T();

            PropertyInfo[] pro = typeof(T).GetProperties();

            foreach (var v in pro)
            {
                if (v.PropertyType.FullName.StartsWith("System."))
                {
                    v.SetValue(t, row[v.Name] is DBNull ? "" : row[v.Name]);
                }
            }

            return t;
        }
    }
}
