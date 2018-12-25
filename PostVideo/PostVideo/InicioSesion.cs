using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostVideo
{
    public partial class InicioSesion : Form
    {
        String passwordDB;
        String emailDB;
        public InicioSesion()
        {
            InitializeComponent();
            IntanciarEmailYClave();
        }
        private void IntanciarEmailYClave()
        {
            this.emailDB = "unemail@email.es";
            this.passwordDB = Hashing.HashPassword("MiContraseña");
        }

        private void Login()
        {
            if (this.email.Text == this.emailDB)
            {
                if (Hashing.ValidatePassword(this.password.Text, this.passwordDB);
                {
                    this.info.ForeColor = Color.Green;
                    this.info.Text = "Correcto!";
                }
                else{
                    this.info.ForeColor = Color.Red;
                    this.info.Text = "La contraseña es incorrecta.";
                }
            }
            else
            {
                this.info.ForeColor = Color.Red;
                this.info.Text = "El email no es válido.";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
