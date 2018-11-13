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
    public partial class ClaseDateTime : Form
    {
        public ClaseDateTime()
        {
            InitializeComponent();
            this.currentDate.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void currentDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void value_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeFormat_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.currentDate.Text);
            if (changeFormat.Checked)
            {
                this.currentDate.Text = fecha.ToLongDateString();
            }
            else{
                this.currentDate.Text = fecha.ToShortDateString();
            }
        }

        private void rDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rMonth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rYear_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void increment_Click(object sender, EventArgs e)
        {
            if ((this.rDay.Checked || this.rMonth.Checked || this.rYear.Checked) && (this.value.Text!="")){
                DateTime fechaInicial = DateTime.Parse(this.currentDate.Text);
                DateTime fechaFinal;
                if (this.rDay.Checked)
                {
                    fechaFinal = fechaInicial.AddDays(int.Parse(this.value.Text));
                }else if(this.rMonth.Checked)
                {
                    fechaFinal = fechaInicial.AddMonths(int.Parse(this.value.Text));
                }
                else
                {
                    fechaFinal = fechaInicial.AddYears(int.Parse(this.value.Text));
                }

                if (this.changeFormat.Checked)
                {
                    this.dateResult.Text = fechaFinal.ToLongDateString().ToString();
                }
                else
                {
                    this.dateResult.Text = fechaFinal.ToShortDateString().ToString();
                }

                TimeSpan intervalo = fechaFinal.Subtract(fechaInicial);
                this.diferent.Text = intervalo.Days + " Días o " + (intervalo.Days * 24)  + " horas.";

                //int dias = int.Parse(fechaFinal.Subtract(fechaInicial).ToString().Split('.')[0]);
                //this.diferent.Text = dias + " Días o " + (dias * 24) + " horas."; 


                

            }

        }
    }
}
