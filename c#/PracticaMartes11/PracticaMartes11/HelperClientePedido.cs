using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMartes11
{
    class HelperClientePedido
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public HelperClientePedido()
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

        public List<String> GetEmpresa()
        {
            String sql = "GETEMPRESAS";
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            List<String> result = new List<String>();
            while (this.reader.Read())
            {
                String e = this.reader["Empresa"].ToString();
                result.Add(e);
            }

            this.reader.Close();
            this.con.Close();
            return result;
        }

        public List<String> GetPedidos(String cod)
        {
            String sql = "GETPEDIDOS";
            SqlParameter par = new SqlParameter("@COD", cod);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            List<String> result = new List<String>();
            while (this.reader.Read())
            {
                String cp = this.reader["CodigoPedido"].ToString();
                result.Add(cp);
            }
            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            return result;
        }

        public Pedido GetPedido(String nombre,String codp)
        {
            String sql = "GETPEDIDO";
            SqlParameter par = new SqlParameter("@N", nombre);
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@COD", codp);
            this.com.Parameters.Add(par2);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            Pedido result = new Pedido();
            this.reader.Read();
            
            String cp = this.reader["CodigoPedido"].ToString();
            String cc = this.reader["CodigoCliente"].ToString();
            DateTime f = DateTime.Parse(this.reader["FechaEntrega"].ToString());
            String fe = this.reader["FormaEnvio"].ToString();
            int i = int.Parse(this.reader["IMPORTE"].ToString());
            result.CodPed = cp;
            result.CodCli = cc;
            result.Fec = f;
            result.Env = fe;
            result.Imp = i;

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            return result;
        }



        public Cliente GetCliente(String nombre)
        {
            String sql = "GETCLIENTE";
            SqlParameter par = new SqlParameter("@N",nombre);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            Cliente result = new Cliente();
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

        public void ModificarCliente(String nombre, String empresa, String cargo, String contacto, String ciudad, String telefono)
        {
            String sql = "MODIFICARCLIENTE";
            SqlParameter par = new SqlParameter("@N", nombre);
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@EM", empresa);
            this.com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter("@CA", cargo);
            this.com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@CO", contacto);
            this.com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@CI", ciudad);
            this.com.Parameters.Add(par5);
            SqlParameter par6 = new SqlParameter("@TE", telefono);
            this.com.Parameters.Add(par6);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            int afec = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }

        public void EliminarPedido(String empresa, String pedido)
        {
            String sql = "ELIMINARPEDIDO";
            SqlParameter par = new SqlParameter("@EM", empresa);
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@P", pedido);
            this.com.Parameters.Add(par2);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            int afec = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }

        public void ModificarPedido(String empresa, String cod, String fecha, String forma, String importe)
        {
            String sql = "MODIFICARPEDIDO";
            SqlParameter par2 = new SqlParameter("@EM", empresa);
            this.com.Parameters.Add(par2);
            SqlParameter par = new SqlParameter("@P", cod);
            this.com.Parameters.Add(par);
            SqlParameter par3 = new SqlParameter("@FEC", fecha);
            this.com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@FO", forma);
            this.com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@IM", importe);
            this.com.Parameters.Add(par5);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = System.Data.CommandType.StoredProcedure;

            this.con.Open();
            int afec = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }
    }
}
