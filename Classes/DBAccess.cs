using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Supply_business.Classes;
using System.Windows.Forms;

namespace DatabaseProject
{
    public class DBAccess
    {
        public SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlTransaction DbTran;

        private static string strConnString = "Data Source=(local);Initial Catalog=PAW_project_Goods&Suppliers;Integrated Security=True";

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeConn()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                createConn();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConn();
            }
        }

        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                createConn();
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                closeConn();
            }
        }
    }

}