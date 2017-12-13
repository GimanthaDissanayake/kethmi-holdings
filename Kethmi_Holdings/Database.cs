using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethmi_Holdings
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader dr;

        public Database()
        {
            con = new SqlConnection("Data Source=DESKTOP-H8M7COJ\\SQLEXPRESS;Initial Catalog=Inventory_System;Integrated Security=True");
        }

        public int insertUpdateDelete(String query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }

        public String getData(String query)
        {
            String Value = "";
            con.Open();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Value = dr[0].ToString();
            }
            con.Close();
            return Value;
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

        public List<Int32> getNumbers(String query, int index)
        {
            con.Open();
            List<Int32> list = new List<Int32>();
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    list.Add(dr.GetInt32(index));
                }
                catch (Exception)
                {
                    return list;
                }

            }
            con.Close();
            return list;
        }

        public DataTable selectData(String query)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return dt;
        }
    }
}

