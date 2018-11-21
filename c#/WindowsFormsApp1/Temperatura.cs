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
    public partial class Temperatura : Form
    {

        String[] nombreMeses = new String[] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
        List<Object> meses = new List<Object>();

        public Temperatura()
        {
            InitializeComponent();
        }

        private void Temperatura_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int fecha = 1;
            foreach (String n in nombreMeses)
            {
                double max = 0;
                double min = 0;
                if (fecha >= 3 && fecha <= 6)
                {
                    max = rnd.Next(12, 28);
                    min = rnd.Next(12, 28);
                    while (min >= max)
                    {
                        min = rnd.Next(12, 28);
                    }
                    
                }
                else if(fecha>6 && fecha<=9)
                {
                    max = rnd.Next(20,42);
                    min = rnd.Next(20,42);
                    while (min >= max)
                    {
                        min = rnd.Next(20, 42);
                    }
                }
                else
                {
                    max = rnd.Next(-5, 16);
                    min = rnd.Next(-5, 16);
                    while (min >= max)
                    {
                        min = rnd.Next(-5, 16);
                    }
                }

                meses.Add(new Mes(n,max,min));
                this.mesesList.Items.Add(n);
                fecha++;
            }
        }

        private void mesesList_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            foreach (Mes mes in meses)
            {
                if (this.mesesList.Items[this.mesesList.SelectedIndex].ToString() == mes.Name)
                {
                    Console.WriteLine(sender.ToString());
                    this.maxima.Text = mes.Max.ToString();
                    this.minima.Text = mes.Min.ToString();
                    this.media.Text = mes.Media().ToString();
                    break;
                }
            }
        }
    }
}
