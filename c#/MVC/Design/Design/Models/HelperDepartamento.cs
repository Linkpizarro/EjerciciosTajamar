using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Design.Models
{
    public class HelperDepartamento
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        public HelperDepartamento()
        {
            String cadena = ConfigurationManager.ConnectionStrings["cadenaHospital"].ConnectionString;
            this.con = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
        }

        public Departamento GetDepartamento(String dept_no){
            String sql = "SELECT * FROM DEPT WHERE DEPT_NO = @D";
            SqlParameter p = new SqlParameter("@D",dept_no);
            this.com.Parameters.Add(p);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            Departamento d = new Departamento();
            if (this.reader.HasRows)
            {
                d.Numero = this.reader["DEPT_NO"].ToString();
                d.Nombre = this.reader["DNOMBRE"].ToString();
                d.Localidad = this.reader["LOC"].ToString();
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            return d;
        }

    }
}