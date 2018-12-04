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
    public partial class GestionHospital : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        List<int> ids;
        List<int> cods;

        public GestionHospital()
        {
            InitializeComponent();
            this.strCon = "Data Source = LOCALHOST;" +
            " Initial Catalog = HOSPITAL;" +
            " Persist Security Info = True;" +
            "User ID = SA;" +
            "Password = 'MCSD2018'";
            this.con = new SqlConnection(this.strCon);
            this.com = new SqlCommand();
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.Text;
            ids = new List<int>();
            cods = new List<int>();
            ShowHospitales();
        }
        private void ShowHospitales()
        {
            String sql = "SELECT * FROM HOSPITAL";
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.hospitales.Items.Add(this.reader["NOMBRE"]);
                cods.Add(int.Parse(this.reader["HOSPITAL_COD"].ToString()));
            }

            this.reader.Close();
            this.con.Close();
        }
        private void ShowTrabajadores()
        {
            ClearData();
            this.empleados.Items.Clear();
            ids.Clear();
            String sql = "TRABAJADOR_HOSPITAL";
            SqlParameter par = new SqlParameter("@COD",this.cods[this.hospitales.SelectedIndex]);

            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.empleados.Items.Add(this.reader["APELLIDO"]);
                ids.Add(int.Parse(this.reader["ID"].ToString()));
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();

            ShowDataHospital();
        }
        private void hospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTrabajadores();
        }
        private void ClearData()
        {
            this.sal.Text = "";
            this.job.Text = "";
        }
        private void ClearDataHospital()
        {
            this.persons.Text = "";
            this.sum.Text = "";
            this.med.Text = "";
        }
        private void ShowDataTrabajador()
        {
            ClearData();
            String sql = "MOSTRAR_DATOS_TRABAJADOR";
            SqlParameter par = new SqlParameter("@ID", this.ids[this.empleados.SelectedIndex]);

            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            this.sal.Text = this.reader["SALARIO"].ToString();
            this.job.Text = this.reader["TRABAJO"].ToString();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }
        private void ShowDataHospital()
        {
            ClearDataHospital();
            String sql = "MOSTRAR_DATOS_HOSPITAL";
            SqlParameter par = new SqlParameter("@COD", this.cods[this.hospitales.SelectedIndex]);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            this.persons.Text = this.reader["PERSONAS"].ToString();
            this.sum.Text = this.reader["SUMA"].ToString();
            this.med.Text = this.reader["MEDIA"].ToString();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
            
        }
        private void empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataTrabajador();
        }
        private void UpdateEmpleados()
        {           
            if (this.empleados.SelectedIndex != -1)
            {               
                String sql = "ACTUALIZAR_EMPLEADO";
                SqlParameter par = new SqlParameter("@ID", this.ids[this.empleados.SelectedIndex]);
                SqlParameter parsal = new SqlParameter("@SAL",this.sal.Text);
                SqlParameter parjob = new SqlParameter("@JOB",this.job.Text);
                this.com.Parameters.Add(par);
                this.com.Parameters.Add(parsal);
                this.com.Parameters.Add(parjob);
                this.com.Connection = this.con;
                this.com.CommandText = sql;
                this.com.CommandType = CommandType.StoredProcedure;

                this.con.Open();
                int afectados = this.com.ExecuteNonQuery();

                this.com.Parameters.Clear();
                this.con.Close();

                ClearData();
                ShowTrabajadores();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateEmpleados();
        }
    }
}
