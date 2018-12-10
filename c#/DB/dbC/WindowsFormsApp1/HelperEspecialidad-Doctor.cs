using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HelperEspecialidad_Doctor
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public HelperEspecialidad_Doctor()
        {
            this.strCon = "Data Source = LOCALHOST;" +
           " Initial Catalog = HOSPITAL;" +
           " Persist Security Info = True;" +
           "User ID = SA;" +
           "Password = 'MCSD2018'";
            //this.strCon = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog= HOSPITAL;Integrated Security=True";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = System.Data.CommandType.Text;
        }

        public List<String> GetEspecialidad()
        {
            String sql = "SELECT DISTINCT ESPECIALIDAD FROM DOCTOR";
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.Text;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            List<String> result = new List<String>(); 
            while (this.reader.Read())
            {
                String nombre = this.reader["ESPECIALIDAD"].ToString();
                result.Add(nombre);
            }
            this.reader.Close();
            this.con.Close();
            return result;
        }

        public List<String> GetHospital(String n = "")
        {
            String sql;
            if (n == ""){
               sql = "SELECT DISTINCT NOMBRE FROM HOSPITAL";
            }
            else
            {
               sql = "SELECT DISTINCT NOMBRE FROM HOSPITAL " +
                    "WHERE NOMBRE = '"+n+"'";
            }
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.Text;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            List<String> result = new List<String>();
            while (this.reader.Read())
            {
                String nombre = this.reader["NOMBRE"].ToString();
                result.Add(nombre);
            }
            this.reader.Close();
            this.con.Close();
            return result;
        }

        public List<Doctor> GetDoctores(String esp)
        {
            String sql = "DOCTORESPECIALIDAD";
            SqlParameter par = new SqlParameter("@ESP", esp);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            List<Doctor> result = new List<Doctor>();
            while (this.reader.Read())
            {
                Doctor d = new Doctor();
                String doctor_no = this.reader["DOCTOR_NO"].ToString();
                String apellido = this.reader["APELLIDO"].ToString();
                String  especialidad = this.reader["ESPECIALIDAD"].ToString();
                String hospital = this.reader["HOSPITAL"].ToString();
                String salario = this.reader["SALARIO"].ToString();
                d.Doctor_no = doctor_no;
                d.Apellido = apellido;
                d.Especialidad = especialidad;
                d.Hospital = hospital;
                d.Salario = salario;
                result.Add(d);
            }
            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            return result;
        }

        public void ModificarDoctor(String id,String ape,String hos,String esp,String sal)
        {
            String sql = "MODIFICARDOCTOR";
            SqlParameter par = new SqlParameter("@ID", id);
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@A", ape);
            this.com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter("@H", hos);
            this.com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@E", esp);
            this.com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@S", sal);
            this.com.Parameters.Add(par5);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            int afec = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.con.Close();
        }

        public void InsertarDoctor(String ape, String hos, String esp, String sal)
        {
            String sql = "INSERTARDOCTOR";
            SqlParameter par2 = new SqlParameter("@A", ape);
            this.com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter("@H", hos);
            this.com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@E", esp);
            this.com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@S", sal);
            this.com.Parameters.Add(par5);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            int afec = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.con.Close();
        }
    }
}
