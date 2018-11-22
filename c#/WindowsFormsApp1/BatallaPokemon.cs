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
    public partial class BatallaPokemon : Form
    {
        List<Pokemon> pks = new List<Pokemon>(); 
        public BatallaPokemon()
        {
            InitializeComponent();
        }

        private void BatallaPokemon_Load(object sender, EventArgs e)
        {
            //4 habilidades:
            Ability a1 = new Ability("Placaje",5);
            Ability a2 = new Ability("Ataque Rápido",2);
            Ability a3 = new Ability("Pistola Agua", 8);
            Ability a4 = new Ability("Mordisco", 6);
            Ability[] atacks = new Ability[] { a1, a2, a3, a4 };
            int i = 0;
            foreach (Button btn in this.abilities.Controls)
            {
                btn.Text = atacks[i].Name;
                btn.Click += Atack;
                i++;
            }
           
            //mi pokemon:
            Pokemon p1 = new Pokemon("Squirtle",30,100,12,"./Squirtle.png",atacks);
            this.varname.Text = p1.Name;
            this.nhp.Text = p1.HP.ToString() ;
            this.nlevel.Text = p1.Level.ToString();
            this.mypokeimage.Image = Image.FromFile(p1.Image);
            pks.Add(p1);
        }

        private void Atack(Object sender, EventArgs e)
        {


            
            foreach (Ability a in pks[0].Abilities)
            {
                if (((Button)sender).Text == a.Name)
                {
                    pks[0].Attack(a,pks[0]);
                    if(pks[0].HP <= 0)
                    {
                        this.nhp.Text = (0).ToString();
                        this.varhp.Width = 0;
                        MessageBox.Show("Se ha debilitado","Win",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.nhp.Text = pks[0].HP.ToString();
                        this.varhp.Width -= a.Power * 5;
                    }
                   
                }
            }
        }
    }
}
