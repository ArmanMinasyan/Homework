using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DbFilter
{
    public static class Filter
    {    ///summary
         ///function for filter DB ,,
         ///Create Store Procedure with parameters
         ///
       
        private static DataTable table = new DataTable();

        public static DataTable Filterer(TextBox id,TextBox severity,TextBox date)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Log"].ConnectionString))
            {
                con.Open();
              /*  SqlCommand cmd = new SqlCommand("dbo.filter", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = param1;
                    cmd.Parameters.Add("@Severity", SqlDbType.NVarChar).Value = param2;
                    cmd.Parameters.Add("@Time", SqlDbType.DateTime).Value = param3;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
              */
                int param1 = Int32.Parse(id.Text);
                string param2 = severity.Text;
                DateTime param3=DateTime.Parse(date.Text);
                SqlCommand cmd = new SqlCommand("dbo.filter", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = param1;
                cmd.Parameters.Add(new SqlParameter("@Severity", SqlDbType.NVarChar)).Value = param2;
                cmd.Parameters.Add(new SqlParameter("@Time", SqlDbType.DateTime)).Value = null;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                    return table;
                   
            }
           
        }

        
    }

}
