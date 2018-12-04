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
    public partial class pruebaConexion : Form
    {
        Connect c = new Connect("HOSPITAL");
        List<String> data = new List<string>();
        public pruebaConexion()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            data = c.ShowTable("DEPT","DNOMBRE",this.col.Text,this.value.Text);
            foreach (String item in data)
            {
                this.list.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.list.Items.Clear();
            Mostrar();
        }
    }
}
