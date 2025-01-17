using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataBase;

public class DBSqlSrv<T> where T : DataBaseObject, new(){
    
        private SqlConnection conn; 
        public DBSqlSrv(string dataSoruce, string database){
            SqlConnectionStringBuilder s = new();
            s.DataSource = dataSoruce;
            s.InitialCatalog = database;
            s.IntegratedSecurity = true;
            string connection = s.ConnectionString;
            conn =  new SqlConnection(connection);
        }

        public List<T> All
        
        {
            get
            {
                List<T> values = [];
                conn.Open();
                SqlCommand cmd = new($"Select * FROM {typeof(T).Name}");
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                
                DataTable dt = new();
                dt.Load(reader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    T obj = new();
                    obj.LoadFromSqlRow(dt.Rows[i]);
                    values.Add(obj);    
                }

                conn.Close();

                return values;
            }
        }

        public void Save(T obj)
        {
            string values = obj.SaveToSql();
            conn.Open();
            SqlCommand cmd = new(values);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            // StringBuilder strBuilder = new();
            // strBuilder.Append($"INSERT INTO {typeof(T).Name} values(");
            // for (int i = 0; i < values.Length; i++)
            //     strBuilder.Append($"{values[i]} ,");
            // strBuilder.Append(")");
                
            
        }


}