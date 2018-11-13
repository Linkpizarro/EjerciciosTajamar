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
    public partial class DiaSemana : Form
    {
        public DiaSemana()
        {
            InitializeComponent();
        }

        private void consoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            consoleBox.Text = "El día de su nacimiento fue : " + DayOfBirth();
        }
        public Boolean BoxEmpty()
        {
            if (this.day.Text == "" || this.month.Text == "" || this.year.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean BoxValid()
        {
            if ((int.Parse(this.day.Text) <= 0 && int.Parse(this.day.Text)>31) || (int.Parse(this.month.Text) <= 0 && int.Parse(this.month.Text) > 12) || (int.Parse(this.year.Text) <= 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public String DayOfBirth()
        {
            if (BoxEmpty() && BoxValid())
            {
                string[] dias = new string[] { "Sábado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };
                int dia = int.Parse(this.day.Text);
                int mes = int.Parse(this.month.Text);
                int anio = int.Parse(this.year.Text);
                if (mes == 1 || mes == 2)
                {
                    mes += 12;
                }
                int op1 = dia + (mes * 2) + anio + (((mes + 1) * 3) / 5) + (anio / 4) - (anio / 100) + (anio / 400) + 2;
                int op2 = op1 / 7;
                int op3 = op1 - (op2 * 7);
                return dias[op3];
            }
            else
            {
                return "";
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
