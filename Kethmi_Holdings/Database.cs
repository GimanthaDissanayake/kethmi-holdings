using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace Kethmi_Holdings
{
    public class Database
    {

        #region feilds
        private SqlConnection con;
        private DataSet ds;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private DataTable dt;
    
        //use the app config connection string for the system. so we do not need to rebuild the application when changing the server.
        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #endregion

        #region methods
        //inizialize sql connection when the instance of database call is created!
        public Database()
        {
            con = new SqlConnection(strConn);
        }

        /*this will return single value for the query
        example "SELECT name from employee where employeeID=10"*/
        public String getValue(String query)
        {
            String foundValue = "";
            con.ConnectionString = strConn;
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

        public List<String> getList(String query, int index)
        {
            con.Open();
            List<String> list = new List<String>();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetString(index));
            }
            con.Close();
            return list;
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
            con.ConnectionString = strConn;
            con.Open();
            cmd = new SqlCommand(query, con);
           cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable select(String query)
        {
            con.ConnectionString = strConn;
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        #endregion

        public DataSet selectDS(String query)
        {
            con.ConnectionString = strConn;
            con.Open();
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
