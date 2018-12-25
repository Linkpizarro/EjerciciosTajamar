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
    public partial class Cifrado : Form
    {
        String ruta;
        public Cifrado()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.fileDialog.ShowDialog();
            ruta = this.fileDialog.FileName;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            this.fileDialog.ShowDialog();
            ruta = this.fileDialog.FileName;
        }

        private void Cifrar(String text,String url,String privada, String publica)
        {
            byte[] key = UTF8Encoding.UTF8.GetBytes(privada);
            byte[] iv = UTF8Encoding.UTF8.GetBytes(publica);

            int keySize = 32;
            int ivSize = 16;

            Array.Resize(ref key, keySize);
            Array.Resize(ref iv, ivSize);

            Crypting.encryptToFile(text,url,key,iv);
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            Cifrar(this.text.Text,ruta,this.privateKeyE.Text,this.publicKeyE.Text);
            Clear();
        }

        private void Descifrar(String url, String privada, String publica)
        {
            byte[] key = UTF8Encoding.UTF8.GetBytes(privada);
            byte[] iv = UTF8Encoding.UTF8.GetBytes(publica);

            int keySize = 32;
            int ivSize = 16;

            Array.Resize(ref key, keySize);
            Array.Resize(ref iv, ivSize);

            this.textEncrypt.Text=Crypting.decryptFromFile(url, key, iv);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            Descifrar(ruta, this.privateKeyD.Text, this.publicKeyD.Text); 
        }

        private void Clear()
        {
            this.text.Text = "";
            this.privateKeyE.Text = "";
            this.publicKeyE.Text = "";
            this.privateKeyE.Text= "";
            this.publicKeyE.Text = "";
            this.textEncrypt.Text = "";
        }
    }
}
