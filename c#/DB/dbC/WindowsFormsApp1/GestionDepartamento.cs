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
    public partial class GestionDepartamento : Form
    {
        String strCon;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        List<int> ids;

        public GestionDepartamento()
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
            ShowDept();
        }

        private void ShowDept()
        {
           
            this.deptList.Items.Clear();
            ids.Clear();
            String sql = "SHOWDEPT";
            SqlParameter par = new SqlParameter("@DN", this.search.Text);
            this.com.Parameters.Add(par);

            this.com.Connection = this.con;
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;

            this.con.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.deptList.Items.Add(this.reader["DNOMBRE"]);
                ids.Add(int.Parse(this.reader["DEPT_NO"].ToString()));
            }

            this.com.Parameters.Clear();
            this.reader.Close();
            this.con.Close();
        }

        private void ClearData()
        {
            this.no.Text = "";
            this.name.Text = "";
            this.loc.Text = "";
        }

        private void ShowDataDept()
        {
            ClearData();
            if (this.deptList.SelectedIndex != -1)
            {
                String sql ="SHOWDATADEPT";
                SqlParameter par = new SqlParameter("@DN", this.ids[this.deptList.SelectedIndex]);
                this.com.Parameters.Add(par);

                this.com.Connection = this.con;
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;
               
                this.con.Open();
                this.reader = this.com.ExecuteReader();
                this.reader.Read();

                this.no.Text = this.reader["DEPT_NO"].ToString();
                this.name.Text = this.reader["DNOMBRE"].ToString();
                this.loc.Text = this.reader["LOC"].ToString();

                this.com.Parameters.Clear();
                this.reader.Close();
                this.con.Close();
            }
        }

        private Boolean ValidateData()
        {
            if (this.no.Text != "" && this.name.Text != ""
                && this.loc.Text != "")
            {
                return true;
            }
            return false;
        }

        private void deptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataDept();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            ShowDept();
        }

        private void InsertDept()
        {
            if (ValidateData())
            {
                String sql = "INSERTDEPT";
                SqlParameter parn = new SqlParameter("@N",int.Parse(this.no.Text));
                SqlParameter pard = new SqlParameter("@DN", this.name.Text);
                SqlParameter parl = new SqlParameter("@LOC", this.loc.Text);
                this.com.Parameters.Add(parn);
                this.com.Parameters.Add(pard);
                this.com.Parameters.Add(parl);

                this.com.Connection = this.con;
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;

                this.con.Open();
                int afectados = this.com.ExecuteNonQuery();

                this.com.Parameters.Clear();
                this.reader.Close();
                this.con.Close();
                ShowDept();
                ClearData();
            }
        }

        private void DelDept()
        {
            if (this.deptList.SelectedIndex != -1)
            {
                String sql = "DELDEPT";
                SqlParameter parn = new SqlParameter("@N", int.Parse(this.no.Text));
                this.com.Parameters.Add(parn);

                this.com.Connection = this.con;
                this.com.CommandType = CommandType.StoredProcedure;
                this.com.CommandText = sql;

                this.con.Open();
                int afectados = this.com.ExecuteNonQuery();

                this.com.Parameters.Clear();
                this.reader.Close();
                this.con.Close();
                ShowDept();
                ClearData();
            }
        }

        private void UpdateDept()
        {
            if (this.deptList.SelectedIndex != -1)
            {
                if (ValidateData())
                {
                    String sql = "UPDATEDEPT";
                    SqlParameter paro = new SqlParameter("@OLD",this.ids[this.deptList.SelectedIndex]);
                    SqlParameter parn = new SqlParameter("@N", int.Parse(this.no.Text));
                    SqlParameter pard = new SqlParameter("@DN", this.name.Text);
                    SqlParameter parl = new SqlParameter("@LOC", this.loc.Text);
                    this.com.Parameters.Add(paro);
                    this.com.Parameters.Add(parn);
                    this.com.Parameters.Add(pard);
                    this.com.Parameters.Add(parl);

                    this.com.Connection = this.con;
                    this.com.CommandType = CommandType.StoredProcedure;
                    this.com.CommandText = sql;

                    this.con.Open();
                    int afectados = this.com.ExecuteNonQuery();

                    this.com.Parameters.Clear();
                    this.reader.Close();
                    this.con.Close();
                    ShowDept();
                    ClearData();
                }
               
            }
        }

        private void bntInsert_Click(object sender, EventArgs e)
        {
            InsertDept();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DelDept();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateDept();
        }
    }
}
