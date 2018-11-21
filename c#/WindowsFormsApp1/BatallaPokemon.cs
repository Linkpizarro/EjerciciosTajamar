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
            this.btnAtack1.Text = a1.Name;
            this.btnAtack2.Text = a2.Name;
            this.btnAtack3.Text = a3.Name;
            this.btnAtack4.Text = a4.Name;
            Object[] atacks = new object[] {a1,a2,a3,a4};
            
            //mi pokemon:
            Pokemon p1 = new Pokemon("Squirtle",30,100,12,"./Squirtle.png",atacks);
            this.varname.Text = p1.Name;
            this.nhp.Text = p1.HP.ToString() ;
            this.nlevel.Text = p1.Level.ToString();
            this.mypokeimage.Image = Image.FromFile(p1.Image);
        }
    }
}
