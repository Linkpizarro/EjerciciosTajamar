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
    public partial class ModificarDoctor : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public ModificarDoctor()
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
            ShowDoctor();
        }

        private void ShowDoctor()
        {
            this.doctorList.Items.Clear();
            this.com.CommandText = "SELECT APELLIDO FROM DOCTOR";
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.doctorList.Items.Add(this.reader["APELLIDO"]);
            }
            this.reader.Close();
            this.con.Close();
        }

        private void ClearData()
        {
            this.surname.Text = "";
            this.especial.Text = "";
            this.salari.Text = "";
        }

        private void DataDoctor()
        {
            ClearData();
            if (this.doctorList.SelectedIndex != -1)
            {
                String sql = "SELECT APELLIDO,ESPECIALIDAD,SALARIO FROM DOCTOR WHERE" +
                    " APELLIDO = @APELLIDO";

                String apellido = this.doctorList.SelectedItem.ToString();
                SqlParameter par = new SqlParameter();
                par.ParameterName = "@APELLIDO";
                par.Value = apellido;
                par.DbType = DbType.String;
                par.Direction = ParameterDirection.Input;

                this.com.Parameters.Add(par);
                this.com.Connection = this.con;
                this.com.CommandText = sql;
                this.com.CommandType = CommandType.Text;   
                
                this.con.Open();
                this.reader = this.com.ExecuteReader();
                this.reader.Read();

                this.surname.Text = this.reader["APELLIDO"].ToString();
                this.especial.Text = this.reader["ESPECIALIDAD"].ToString();
                this.salari.Text = this.reader["SALARIO"].ToString();

                this.com.Parameters.Clear();
                this.reader.Close();
                this.con.Close();
            }
        }

        private Boolean ValidateData()
        {
            if (this.surname.Text != "" && this.especial.Text != ""
                && this.salari.Text != "")
            {
                return true;
            }
            return false;
        }

        private void UpdateDoctor()
        {
            if (ValidateData())
            {
                String sql = "UPDATE DOCTOR SET APELLIDO = @NEWSURNAME" +
                    ", ESPECIALIDAD = @NEWESP, SALARIO = @NEWSAL " +
                    "WHERE APELLIDO = @OLDSURNAME";

                String oldsurname = this.doctorList.SelectedItem.ToString();
                String newsurname = this.surname.Text;
                String newesp = this.especial.Text;
                String newsal = this.salari.Text;
                SqlParameter parold = new SqlParameter("OLDSURNAME",oldsurname);
                SqlParameter parnew = new SqlParameter("NEWSURNAME", newsurname);
                SqlParameter paresp = new SqlParameter("NEWESP", newesp);
                SqlParameter parsal = new SqlParameter("NEWSAL", newsal);

                this.com.Parameters.Add(parold);
                this.com.Parameters.Add(parnew);
                this.com.Parameters.Add(paresp);
                this.com.Parameters.Add(parsal);
                this.com.Connection = this.con;
                this.com.CommandText = sql;
                this.com.CommandType = CommandType.Text;

                this.con.Open();
                int afectados = this.com.ExecuteNonQuery();

                this.com.Parameters.Clear();
                this.reader.Close();
                this.con.Close();
                ClearData();
                ShowDoctor();
            }
        }

        private void doctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataDoctor();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateDoctor();
        }
    }
}
