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
    public partial class BuscaMinasSize : Form
    {
        public int hw = 0;
        public BuscaMinasSize()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            hw = int.Parse(this.height.Text);
            this.Close();
        }
    }
}
