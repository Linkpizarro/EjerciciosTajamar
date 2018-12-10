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
    public partial class EjercicioEspecialidad_Doctor : Form
    {
        HelperEspecialidad_Doctor h;
        List<Doctor> listaDoctores;
        public EjercicioEspecialidad_Doctor()
        {
            InitializeComponent();
            h = new HelperEspecialidad_Doctor();
            listaDoctores = new List<Doctor>();
            MostrarEspecialidades();
            MostrarHospitales();
        }
        private void MostrarEspecialidades()
        {
            foreach (String item in h.GetEspecialidad())
            {
                this.cbxEspecialidad.Items.Add(item);
                this.especialidades.Items.Add(item);
            }
        }
        private void MostrarHospitales()
        {
            foreach (String item in h.GetHospital())
            {
                this.hospitales.Items.Add(item);
            }
        }
        private void LimpiarDatos()
        {
            this.apellido.Text = "";
            this.hospitales.SelectedIndex = -1;
            this.especialidades.SelectedIndex = -1;
            this.salario.Text = "";
        }
        private void MostrarDoctores()
        {
            this.doctores.Items.Clear();
            this.listaDoctores.Clear();
            LimpiarDatos();
            foreach (String index in this.cbxEspecialidad.SelectedItems)
            {
                foreach (Doctor item in h.GetDoctores(index.ToString()))
                {
                    this.doctores.Items.Add(item.Apellido);
                    this.listaDoctores.Add(item);
                }
            }
        }
        private void cbxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxEspecialidad.SelectedIndex != -1)
            {
                MostrarDoctores();
            }
            else
            {
                this.doctores.Items.Clear();
            }
        }
        private void MostrarDatosDoctor()
        {
            Doctor d = this.listaDoctores[this.doctores.SelectedIndex];
            this.apellido.Text = d.Apellido;
            this.salario.Text = d.Salario;
            this.hospitales.SelectedIndex = this.hospitales.Items.IndexOf(d.Hospital);
            this.especialidades.SelectedIndex = this.cbxEspecialidad.Items.IndexOf(d.Especialidad);
        }
        private void doctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.doctores.SelectedIndex != -1)
            {
                MostrarDatosDoctor();
            }
            
        }
        private Boolean ValidarDatos()
        {
            if (this.apellido.Text == "" || this.salario.Text == "" || this.hospitales.SelectedIndex == -1 || this.especialidades.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.doctores.SelectedIndex != -1 && ValidarDatos())
            {
                h.ModificarDoctor(this.listaDoctores[this.doctores.SelectedIndex].Doctor_no,this.apellido.Text,
                this.hospitales.SelectedItem.ToString(),this.especialidades.SelectedItem.ToString(),this.salario.Text);
                MostrarDoctores();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                h.InsertarDoctor(this.apellido.Text,this.hospitales.SelectedItem.ToString(), this.especialidades.SelectedItem.ToString(),
                this.salario.Text);
                MostrarDoctores();
            }
        }
        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&& !char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
