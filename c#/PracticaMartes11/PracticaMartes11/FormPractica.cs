using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMartes11
{
    public partial class FormPractica : Form
    {
        HelperClientePedido h;
        public FormPractica()
        {
            InitializeComponent();
            h = new HelperClientePedido();
            CargarClientes();
        }

        private void LimpiarDatos()
        {
            this.txtempresa.Text = "";
            this.txtcontacto.Text = "";
            this.txtciudad.Text = "";
            this.txtcargo.Text = "";
            this.txttelefono.Text = "";
            this.txtcodigopedido.Text = "";
            this.txtfechaentrega.Text = "";
            this.txtformaenvio.Text = "";
            this.txtimporte.Text = "";
        }

        private void CargarClientes()
        {
            foreach (String item in h.GetEmpresa())
            {
                this.cmbclientes.Items.Add(item);
            }
        }

        private void MostrarCliente()
        {
            LimpiarDatos();
            Cliente c = h.GetCliente(this.cmbclientes.SelectedItem.ToString());
            this.txtempresa.Text = c.Emp;
            this.txtcontacto.Text = c.Cont;
            this.txtciudad.Text = c.Ciu;
            this.txtcargo.Text = c.Car;
            this.txttelefono.Text = c.Tel.ToString();
            CargarPedidos(c.CodCli);
        }

        private void CargarPedidos(String cod)
        {
            this.lstpedidos.Items.Clear();
            foreach (String item in h.GetPedidos(cod))
            {
                this.lstpedidos.Items.Add(item);
            }
        }

        private void cmbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbclientes.SelectedIndex != -1)
            {
                MostrarCliente();
            }
        }

        private void MostrarPedido()
        {
            Pedido P = h.GetPedido(this.cmbclientes.SelectedItem.ToString(),
                        this.lstpedidos.SelectedItem.ToString());
            this.txtcodigopedido.Text = P.CodPed;
            this.txtfechaentrega.Text = P.Fec.ToString();
            this.txtformaenvio.Text = P.Env;
            this.txtimporte.Text = P.Imp.ToString();
        }

        private void lstpedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbclientes.SelectedIndex != -1 && this.lstpedidos.SelectedIndex != -1)
            {
                MostrarPedido();
            }
           
        }

        private void ModificarCliente()
        {
            h.ModificarCliente(this.cmbclientes.SelectedItem.ToString(),
                this.txtempresa.Text,this.txtcargo.Text,this.txtcontacto.Text,
                this.txtciudad.Text,this.txttelefono.Text);
            LimpiarDatos();
            this.cmbclientes.SelectedIndex = -1;
        }

        private Boolean ValidarCamposCliente()
        {
            if (this.txtempresa.Text != "" &&
            this.txtcontacto.Text != "" &&
            this.txtciudad.Text != "" &&
            this.txtcargo.Text != "" &&
            this.txttelefono.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            if (this.cmbclientes.SelectedIndex != -1 && ValidarCamposCliente())
            {
                ModificarCliente();
            }
        }

        private void EliminarPedido()
        {
            h.EliminarPedido(this.cmbclientes.SelectedItem.ToString(),
                this.lstpedidos.SelectedItem.ToString());
            MostrarCliente();
        }

        private void btneliminarpedido_Click(object sender, EventArgs e)
        {
            if(this.cmbclientes.SelectedIndex != -1 && this.lstpedidos.SelectedIndex != -1)
            {
                EliminarPedido();
            }
        }

        private void ModificarPedido()
        {
            h.ModificarPedido(this.cmbclientes.SelectedItem.ToString(),
                this.txtcodigopedido.Text,this.txtfechaentrega.Text,this.txtformaenvio.Text,
                this.txtimporte.Text);
            MostrarCliente();
        }

        private void btnnuevopedido_Click(object sender, EventArgs e)
        {
            ModificarPedido();
        }
    }
}
