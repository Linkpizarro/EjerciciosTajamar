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
    public partial class Buscador : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;

        public Buscador()
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
            ShowEMP();
        }

        private void ShowEMP()
        {
            this.listEMP.Items.Clear();
            this.com.CommandText = "SELECT APELLIDO,OFICIO FROM EMP " +
                "WHERE APELLIDO LIKE '%" +
                this.txtApellido.Text +
                "%'";
            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.listEMP.Items.Add(this.reader["APELLIDO"] + "----" + this.reader["OFICIO"]);
            }
            this.reader.Close();
            this.con.Close();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ShowEMP();
        }
    }
}
