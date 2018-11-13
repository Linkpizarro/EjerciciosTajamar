using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClaseString : Form
    {
        public ClaseString()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {
            if(this.email.Text != null && Regex.IsMatch(this.email.Text, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
            {
                this.res.Text = "Válido.";
            }
            else{
                this.res.Text = "No Válido.";
            }
            //    if (this.email.Text != "")
            //    {
            //        if (this.email.Text.Contains('@'))
            //        {
            //            if (this.email.Text.Split('@').Length == 2)
            //            {
            //                if (this.email.Text.Split('@')[0].Length > 0 && this.email.Text.Split('@')[1].Length > 0)
            //                {
            //                    if (this.email.Text.Split('@')[1].Contains('.'))
            //                    {
            //                        if (this.email.Text.Split('@')[1].Split('.')[this.email.Text.Split('@')[1].Split('.').Length - 1].Length >= 2 
            //                            && this.email.Text.Split('@')[1].Split('.')[this.email.Text.Split('@')[1].Split('.').Length - 1].Length <= 4)
            //                        {
            //                            this.res.Text = "Válido.";
            //                        }
            //                        else
            //                        {
            //                            this.res.Text = "El email debe contener un dominio de entre 2 y 4 carateres.";
            //                        }
            //                    }
            //                    else
            //                    {
            //                        this.res.Text = "El email debe contener un caracter '.'.";
            //                    }             
            //                }
            //                else
            //                {
            //                    this.res.Text = "El caracter '@' debe ir acompañado de otros caracteres.";
            //                }
            //            }
            //            else{
            //                this.res.Text = "El email sólo puede contener una '@'.";
            //            }
            //        }
            //        else
            //        {
            //            this.res.Text = "El email debe contener un caracter '@'.";
            //        }
            //    }
            //    else
            //    {
            //        this.res.Text = "El email no puede estar vacío.";
            //    }
        }

        private void res_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIsbn_Click(object sender, EventArgs e)
        {
            char[] numeros = this.isbn.Text.ToCharArray(0,this.isbn.Text.Length);
            int suma=0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += int.Parse(numeros[i].ToString()) * (i+1);
            }
            if (suma % 11 == 0)
            {
                this.resIsbn.Text = "correcto";
            }
            else
            {
                this.resIsbn.Text = "No correcto";
            }
        }

        private void resIsbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void resNarcisista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNarcisista_Click(object sender, EventArgs e)
        {


                char[] numeros = this.numero.Text.ToCharArray(0, this.numero.Text.Length);
                double suma = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (char.IsNumber(numeros[i]))
                    {
                        suma += Math.Pow(double.Parse(numeros[i].ToString()), numeros.Length);
                    }
                   
                }
                if (suma == double.Parse(this.numero.Text))
                {
                    this.resNarcisista.Text = "Es Narcisista";
                }
                else
                {
                    this.resNarcisista.Text = "No es Narcisista";
                }
            
        }

        private void resCadena_TextChanged(object sender, EventArgs e)
        {

        }

        private void invertir_Click(object sender, EventArgs e)
        {
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            char[] letras = this.cadena.Text.ToCharArray();
            string reverse = String.Empty;
            for (int i = letras.Length - 1; i > -1; i--)
            {
                reverse += letras[i];
            }
            tiempo.Stop();
            this.resCadena.Text = reverse;
        }

        private void invertirBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            StringBuilder letras = new StringBuilder();
            letras.Append(this.cadena.Text);
            for (int i = 0; i < letras.Length; i++)
            {
                char reverse = letras[letras.Length - 1];
                letras = letras.Remove(letras.Length - 1,1);
                letras.Insert(i,reverse);
            }
            this.resCadena.Text = "Tiempo: " + tiempo.Elapsed.Milliseconds.ToString();
        }

        private void ClaseString_Load(object sender, EventArgs e)
        {

        }

        private void cadena_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
