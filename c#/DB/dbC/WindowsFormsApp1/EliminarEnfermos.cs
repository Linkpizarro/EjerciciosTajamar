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
    public partial class EliminarEnfermos : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        List<String> inscriciones;
        public EliminarEnfermos()
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
            this.inscriciones = new List<String>();
            ShowEnfermos();
        }

        private void ShowEnfermos()
        {
            this.inscriciones.Clear();
            this.enferList.Items.Clear();
            String sql = "MOSTRARENFERMOS";
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.inscriciones.Add(this.reader["INSCRIPCION"].ToString());
                this.enferList.Items.Add(this.reader["APELLIDO"]);
            }
            this.reader.Close();
            this.con.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            String inscripcion = this.inscriciones[this.enferList.SelectedIndex];
            String sql = "BORRARENFERMO";
            SqlParameter par = new SqlParameter("@INSCRIPCION", inscripcion);
            this.com.Parameters.Add(par);
            this.com.Connection = this.con;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.con.Open();
            int afectador = this.com.ExecuteNonQuery();
            this.com.Parameters.Clear();
            this.con.Close();
            this.surname.Text = "";
            ShowEnfermos();
        }

        private void enferList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.surname.Text = this.enferList.SelectedItem.ToString();
        }
    }
}
