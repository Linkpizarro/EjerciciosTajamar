using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCEjemplo1.Models
{
    public class Connect
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public Connect()
        {
            this.strCon = "Data Source = LOCALHOST;" +
           " Initial Catalog = PRACTICAADO;" +
           " Persist Security Info = True;" +
           "User ID = SA;" +
           "Password = 'MCSD2018'";
            //this.strCon = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog= PRACTICAADO;Integrated Security=True";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.Text;
        }
       
        public List<String> GetData(String sql,String col)
        {
            com.Connection = con;
            com.CommandText = sql;
            com.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();
            reader = com.ExecuteReader();
            List<String> result = new List<String>();
            while (reader.Read())
            {
                String x = reader[col].ToString();
                result.Add(x);
            }

            reader.Close();
            con.Close();

            return result;
        }
        public Client GetCliente(String sql,String name)
        {
            SqlParameter par = new SqlParameter("@N", name);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            Client result = new Client();
            this.reader.Read();

            String cc = this.reader["CodigoCliente"].ToString();
            String n = this.reader["Empresa"].ToString();
            String con = this.reader["Contacto"].ToString();
            String car = this.reader["Cargo"].ToString();
            String ciu = this.reader["Ciudad"].ToString();
            long tel = long.Parse(this.reader["Telefono"].ToString());
            result.CodCli = cc;
            result.Emp = n;
            result.Cont = con;
            result.Car = car;
            result.Ciu = ciu;
            result.Tel = tel;

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            return result;
        }

    }
}