using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        private SqlConnection connection;
        private static DBConnection instance;

        public static DBConnection Instance
        {
            get 
            { 
                if(instance==null)
                {
                    instance = new DBConnection();
                }
                return instance; 
            }
        }

        private DBConnection()
        {
            connection = new SqlConnection("Data Source=kite\\sqlexpress;Initial Catalog=LichCongTacVaNhacViec;Integrated Security=True");
        }

        private SqlConnection OpenConnectionIfNeed()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable ExecuteSelectQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                OpenConnectionIfNeed();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dt;
        }

        public bool ExecuteInsertQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnectionIfNeed();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return true;
        }

        public bool ExecuteUpdateQuery(String query, SqlParameter[] parameters, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnectionIfNeed();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.CommandType = cmdType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException e)
            {
                throw e;
            }
        }
    }
}
