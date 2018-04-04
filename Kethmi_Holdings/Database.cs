using System;
using System.Data.SqlClient;
using System.Data;

namespace Kethmi_Holdings
{
    public class Database
    {

        #region feilds
        private SqlConnection con;
        DataSet ds;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        //private ReportDataSource rds;
        private string conString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=KethmiHoldings;Integrated Security=True";
        #endregion

        #region methods
        //inizialize sql connection when the instance of database call is created!
        public Database()
        {
            con = new SqlConnection(conString);
        }

        /*this will return single value for the query
        example "SELECT name from employee where employeeID=10"*/
        public String getValue(String query)
        {
            String foundValue = "";
            con.ConnectionString = conString;
            using (con)
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foundValue = reader[0].ToString();
                        }
                    }
                }
            }
            con.Close();
            return foundValue;
        }
        /*
        public ReportDataSource getReportDataSource(String query)
        {
            //con = new SqlConnection(@"Data Source=MADUSHANKA-PC\SERVERME;Initial Catalog=SuperMarket;Integrated Security=True");
            ds = new DataSet();
            da = new SqlDataAdapter(query, con);
            da.Fill(ds, ds.Tables[0].TableName);
            rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            return rds;
        }*/

        public void insertUpdateDelete(String query)
        {
            con.ConnectionString = conString;
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable select(String query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        #endregion


    }
}
