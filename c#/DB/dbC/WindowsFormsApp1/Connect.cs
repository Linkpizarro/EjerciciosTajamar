using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Connect
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public Connect(String db)
        {
            this.strCon = "Data Source = LOCALHOST;" +
            " Initial Catalog = "+ db +";" +
            " Persist Security Info = True;" +
            "User ID = SA;" +
            "Password = 'MCSD2018'";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.Text;
        }
        public List<String> ShowTable(String name, String outCol, String id = "",String paramValue = "")
        {
            String sql;
            List<String> result = new List<String>();
            if (id != "" && paramValue != "")
            {
                sql = "SELECT * FROM " + name + " WHERE " + id + " LIKE @P";
                SqlParameter par = new SqlParameter("@P",paramValue);
                this.com.Parameters.Add(par);
            }
            else
            {

                sql = "SELECT * FROM " + name;
            }

            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                result.Add(this.reader[outCol].ToString());
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

            return result;
        }
        public void Insert(String name,List<Object> values)
        {
            String sql = "INSERT INTO " + name + " VALUES (";
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
        }
    }
}
