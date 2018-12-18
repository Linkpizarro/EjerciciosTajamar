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
        public Cifrado()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.folderDialog.ShowDialog();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}
