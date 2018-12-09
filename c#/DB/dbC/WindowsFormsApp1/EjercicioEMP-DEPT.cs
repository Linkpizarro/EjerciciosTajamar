using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EjercicioEMP_DEPT : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public EjercicioEMP_DEPT()
        {
            InitializeComponent();
            //this.strCon = "Data Source = LOCALHOST;" +
            //" Initial Catalog = HOSPITAL;" +
            //" Persist Security Info = True;" +
            //"User ID = SA;" +
            //"Password = 'MCSD2018'";
            this.strCon = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog= HOSPITAL;Integrated Security=True";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.Text;
            CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            String sql = "SELECT DNOMBRE FROM DEPT";
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cbxDept.Items.Add(this.reader["DNOMBRE"].ToString());
                this.dept.Items.Add(this.reader["DNOMBRE"].ToString());
            }

            this.reader.Close();
            this.con.Close();
        }

        private void LimpiarDatosEmpleados()
        {
            this.sal.Text = "";
            this.job.Text = "";
            this.dept.SelectedIndex = -1;
        }

        private void MostrarEmpleados()
        {
            this.empleados.Items.Clear();
            LimpiarDatosEmpleados();
            String sql = "MOSTRAR_EMPLEADOS";
            SqlParameter par = new SqlParameter("@P",cbxDept.SelectedItem.ToString());
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                empleados.Items.Add(this.reader["APELLIDO"].ToString());
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }

        private void MostrarDatosGenerales() {
            this.nPersonas.Text = "";
            this.sumSalario.Text = "";

            String sql = "DATOS_DEPARTAMENTOS";
            this.com.Connection = this.con;
            SqlParameter par = new SqlParameter("@P", cbxDept.SelectedItem.ToString());
            this.com.Parameters.Add(par);
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();

            try {
                nPersonas.Text = this.reader["PERSONAS"].ToString();
                sumSalario.Text = this.reader["TOTAL"].ToString();
            }
            catch (System.InvalidOperationException)
            {
                nPersonas.Text = "0";
                sumSalario.Text = "0";
            }
              
            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }

        private void cbxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDept.SelectedIndex != -1)
            {
                MostrarEmpleados();
                MostrarDatosGenerales();
            }
        }

        private void MostrarDatosEmpleados()
        {
            LimpiarDatosEmpleados();
            String sql = "MOSTRAR_DATOS_EMPLEADOS";
            SqlParameter par = new SqlParameter("@P",cbxDept.SelectedItem.ToString());
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@X",empleados.SelectedItem.ToString());
            this.com.Parameters.Add(par2);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();

            this.sal.Text = this.reader["SALARIO"].ToString();
            this.job.Text = this.reader["OFICIO"].ToString();
            this.dept.SelectedIndex = this.cbxDept.SelectedIndex;

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

        }

        private void empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatosEmpleados();
        }

        private void ModificarEmpleado()
        {
            String sql = "ACTUALIZAR_DATOS_EMPLEADOS";
            SqlParameter par = new SqlParameter("@P", cbxDept.SelectedItem.ToString());
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@X", this.empleados.SelectedItem.ToString());
            this.com.Parameters.Add(par2);
            SqlParameter par3 = new SqlParameter("@S",this.sal.Text);
            this.com.Parameters.Add(par3);
            SqlParameter par4 = new SqlParameter("@O",this.job.Text);
            this.com.Parameters.Add(par4);
            SqlParameter par5 = new SqlParameter("@D",this.dept.SelectedItem.ToString());
            this.com.Parameters.Add(par5);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            int afectados = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

            MostrarEmpleados();
            MostrarDatosGenerales();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.empleados.SelectedIndex != -1)
            {
                if (int.Parse(this.sal.Text) >= 0 && this.job.Text != "")
                {
                    ModificarEmpleado();
                }
            }
        }

        private void EliminarEmpleado()
        {
            String sql = "ELIMINAR_EMPLEADO";
            SqlParameter par = new SqlParameter("@P", cbxDept.SelectedItem.ToString());
            this.com.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter("@X", this.empleados.SelectedItem.ToString());
            this.com.Parameters.Add(par2);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            int afectados = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

            MostrarEmpleados();
            MostrarDatosGenerales();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }
    }
}
