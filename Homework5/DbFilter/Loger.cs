using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFilter
{
    static class Loger
    {
        static object locker = new object();
        static int id = 1;
        private static SqlDataAdapter adapter = null;
        private static DataSet dataSet = new DataSet();
        /// <summary>
        /// create table if it not exists 
        /// or delete it if it exists
        /// </summary>
        public static void Reset()
        {
            bool exists = false;
            id = 1;
            const string sqlStatement = @"SELECT * From LogTable";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Log"].ConnectionString))// from config file
            {
                string strSQl = "CREATE TABLE LogTable(ID int ,Severity nvarchar(10), Time DateTime,PRIMARY KEY(ID));";
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand(sqlStatement, con);
                    command.ExecuteNonQuery();
                    SqlCommand delete = new SqlCommand("Delete Logtable", con);
                    delete.ExecuteNonQuery();
                    exists = true;
                }
                catch
                {
                    exists = false;
                }
                if (exists == false)
                {
                    SqlCommand cmd = new SqlCommand(strSQl, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                }
            }

        }
        /// <summary>
        /// Function for add data int Sql table(Multythread)
        /// 
        /// </summary>

        public static void AddLog()
        {
            lock (locker)
            {
                List<Log> logs = new List<Log>();
                for (int i = 1; i < 10; i++)
                {
                    Log log = new Log();
                    log.Id = id++;
                    log.Time = DateTime.Now;
                    log.Severity = "Error";
                    logs.Add(log);
                }


                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Log"].ConnectionString))
                {
                    conn.Open();

                    foreach (Log item in logs)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Logtable (ID, Severity,Time) " +
                           "VALUES (@id, @severity,@time)", conn);

                        cmd.Parameters.AddWithValue("@id", item.Id);
                        cmd.Parameters.AddWithValue("@severity", item.Severity);
                        cmd.Parameters.AddWithValue("@time", item.Time);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// function for show table in winform
        /// </summary>
        /// <returns>table for datagridview </returns>
        public static DataTable Getlog()
        {
            
                   using( SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Log"].ConnectionString))
                    {
                        string sql = "select Id, Time, severity from Logtable";
                        con.Open();
                        adapter = new SqlDataAdapter(sql, con);
                        adapter.SelectCommand = new SqlCommand(sql, con);
                        adapter.Fill(dataSet, "Logtable");
                        DataTable table = dataSet.Tables["logtable"];
                        adapter.Update(dataSet, "Logtable");
                        return table;
          
                  }
                }
          
        }

    }

