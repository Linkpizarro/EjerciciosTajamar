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
    public partial class SorteoIniciar : Form
    {
        public String nLabels;
        public String nWins;
        public SorteoIniciar()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ApplyInformation();
        }

        private void ApplyInformation()
        {
            if (this.nwin.Text != "" && this.nlab.Text != "")
            {
                if (int.Parse(this.nwin.Text) <= int.Parse(this.nlab.Text))
                {
                    nLabels = this.nlab.Text;
                    nWins = this.nwin.Text;
                    this.Close();
                }
                else{
                    MessageBox.Show("EL NÚMERO DE APUESTAS DEBE SER MENOR A LA CANTIDAD DE NÚMEROS DEL BOLETO","Número Incorrecto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void nlab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nwin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            { 
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
