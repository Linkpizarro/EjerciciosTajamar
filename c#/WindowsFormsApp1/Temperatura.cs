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
        List<Año> años = new List<Año>();
        Random rnd = new Random();
        String[] nombreMeses = new String[] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
        int indexYear;

        public Temperatura()
        {
            InitializeComponent();
        }
        private void Temperatura_Load(object sender, EventArgs e)
        {
          
        }
        private List<Mes> GenerateMonth()
        {
            int fecha = 1;
            List<Mes> meses = new List<Mes>();
            foreach (String n in nombreMeses)
            {
                double max = 0;
                double min = 0;
                if (fecha >= 3 && fecha <= 6)
                {
                    max = rnd.Next(12, 28);
                    min = rnd.Next(12, 28);
                }
                else if (fecha > 6 && fecha <= 9)
                {
                    max = rnd.Next(20, 42);
                    min = rnd.Next(20, 42);
                }
                else
                {
                    max = rnd.Next(-5, 16);
                    min = rnd.Next(-5, 16);
                }

                if (min > max)
                {
                    double aux = min;
                    min = max;
                    max = aux;
                }

                meses.Add(new Mes(n, max, min));
                fecha++;
            }
            return meses;
        }
        private void GenerateYear()
        {
            this.comboAnios.Items.Clear();
            for (int i = 0; i < int.Parse(this.nAnios.Text); i++)
            {
                años.Add(new Año((2000 + i),GenerateMonth()));
                this.comboAnios.Items.Add(2000+i);
            }
        }      
        private void ClearDataMonth()
        {
            this.maxima.Text = "";
            this.minima.Text = "";
            this.media.Text = "";
            this.mesesList.Items.Clear();
        }
        private void ShowDataYear()
        {
            this.anioMaxima.Text = años[this.comboAnios.SelectedIndex].MaxYear().ToString();
            this.anioMinima.Text = años[this.comboAnios.SelectedIndex].MinYear().ToString();
            this.anioMedia.Text = años[this.comboAnios.SelectedIndex].MediaYear().ToString();
        }
        private void ClearDataYear()
        {
            this.anioMaxima.Text ="";
            this.anioMinima.Text ="";
            this.anioMedia.Text ="";
        }
        private void ShowDataMonth()
        {
            foreach (Mes mes in años[indexYear].Month)
            {
                if (this.mesesList.Items[this.mesesList.SelectedIndex].ToString() == mes.Name)
                {
                    this.maxima.Text = mes.Max.ToString();
                    this.minima.Text = mes.Min.ToString();
                    this.media.Text = mes.Media().ToString();
                    break;
                }
            }
        }
        private void ShowListMonth()
        {
            foreach (String mes in nombreMeses)
            {
                this.mesesList.Items.Add(mes);
            }
        }
        private void comboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDataYear();
            ClearDataMonth();
            ShowDataYear();
            ShowListMonth();    
            indexYear = this.comboAnios.SelectedIndex;
        }
        private void mesesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDataMonth();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.comboAnios.Items.Clear();
            ClearDataMonth();
            ClearDataYear();
            GenerateYear();
            this.comboAnios.SelectedItem = 2000;
        }
    }
}
