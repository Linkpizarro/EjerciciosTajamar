using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GestionBDHospitales : Form
    {
        Connect c = new Connect("HOSPITAL");
        public GestionBDHospitales()
        {
            InitializeComponent();
            Cargar();
        }
        private void Cargar()
        {
            foreach (String item in c.GetNameTables())
            {
                this.tablas.Items.Add(item);
            }
        }

        private void GenerarCheckBox()
        {
            this.columnsZone.Controls.Clear();
            foreach (String item in c.GetNameColumn(this.tablas.SelectedItem.ToString()))
            {
                CheckBox bx = new CheckBox();
                bx.Text = item;
                bx.Checked = true;
                bx.Click += Consultar;
                this.columnsZone.Controls.Add(bx);
            }
        }
        private void Consultar(Object sender,EventArgs e)
        {
            Mostrar();
        }
        private List<String> ColumnasMarcadas()
        {
            List<String> result = new List<String>();
            foreach (CheckBox item in this.columnsZone.Controls)
            {
                if (item.Checked)
                {
                    result.Add(item.Text);
                }
            }
            return result;
        }
        private void Mostrar()
        {
            this.list.Items.Clear();
            String nt;

            if (this.tablas.SelectedIndex!=-1)
            {
                nt = this.tablas.SelectedItem.ToString();
                String p;

                if (this.col.SelectedIndex == -1)
                {
                    p = "";
                }
                else
                {
                    p = this.col.SelectedItem.ToString();
                }


                if (ColumnasMarcadas().Count != 0)
                {
                    foreach (List<String> index in c.ShowTable(nt, ColumnasMarcadas(), p, this.value.Text, cbStrict.Checked))
                    {
                        String cadena = "";
                        for (int i = 0; i < index.Count; i++)
                        {
                            if (i != index.Count - 1 && index.Count > 1)
                            {
                                cadena += index[i] + "<---->";
                            }
                            else
                            {
                                cadena += index[i];
                            }

                        }

                        this.list.Items.Add(cadena);
                    }
                }
               
            }
          
        }
        private void CargarColumnas()
        {
            this.col.Items.Clear();
            foreach (String item in c.GetNameColumn(this.tablas.SelectedItem.ToString()))
            {
                this.col.Items.Add(item);
            }
        }
        private void tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarColumnas();
            GenerarCheckBox();
            Mostrar();
        }
        private void value_TextChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void cbStrict_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void col_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
