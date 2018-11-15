using System;
using System.Collections;
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
    public partial class Colecciones : Form
    {
        
        public Colecciones()
        {
            InitializeComponent();
            MetodoArrayList();
        }

        //Lista
        private void element_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            this.myList.Items.Add(this.element.Text);
            this.element.Text = "";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            this.myList.Items.Remove(this.element.Text);
            this.element.Text = "";
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            this.myList.Items.Clear();
        }

        private void myList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeSelect_Click(object sender, EventArgs e)
        {
            for (int i = this.myList.SelectedIndices.Count - 1; i >= 0 ; i --)
            { 
                this.myList.Items.RemoveAt(this.myList.SelectedIndices[i]);
            }
        }

        //Random
        private void numList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void evens_TextChanged(object sender, EventArgs e)
        {

        }

        private void odds_TextChanged(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            this.numList.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                this.numList.Items.Add(rnd.Next(1, 50));
            }
        }

        private void operate_Click(object sender, EventArgs e)
        {
            int total = 0;
            int odd = 0;
            int even = 0;
            for (int i = 0; i < this.numList.Items.Count; i++)
            {
                total = total + int.Parse(this.numList.Items[i].ToString());
                if (int.Parse(this.numList.Items[i].ToString())%2 == 0)
                {
                    even = even + int.Parse(this.numList.Items[i].ToString());
                }
                else
                {
                    odd = odd + int.Parse(this.numList.Items[i].ToString());
                }
            }

            this.total.Text = total.ToString();
            this.odds.Text = odd.ToString();
            this.evens.Text = even.ToString();
        }

        //tienda
        private void product_TextChanged(object sender, EventArgs e)
        {

        }

        private void shopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.shopList.SelectedIndices.Count > 1)
            {
                this.btnModify.Enabled = false;
                this.product.Text = "";
            }
            else
            {
                this.btnDelete.Enabled = true;
                this.btnModify.Enabled = true;
                this.btnMoveSelected.Enabled = true;
                if (this.shopList.SelectedIndex != -1)
                {
                    this.product.Text = this.shopList.Items[this.shopList.SelectedIndex].ToString();
                }
                else
                {
                    this.product.Text = "";
                }
            }
            
        }

        private void storageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.storageList.SelectedIndex == 0)
            {
                this.btnUp.Enabled = false;
                this.btnDown.Enabled = true;
            }
            else if (this.storageList.SelectedIndex == this.storageList.Items.Count - 1)
            {
                this.btnDown.Enabled = false;
                this.btnUp.Enabled = true;
            }
            else
            {
                this.btnUp.Enabled = true;
                this.btnDown.Enabled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (this.product.Text != "")
            {
                if (this.shopList.Items.Count > 0)
                {
                    int flag = 0;
                    for (int i = 0; i < this.shopList.Items.Count; i++)
                    {
                        if (this.shopList.Items[i].ToString() == this.product.Text)
                        {
                            if (this.shopList.SelectedIndex != -1)
                            {
                                this.shopList.SetSelected(this.shopList.SelectedIndex, false);
                            }
                            this.shopList.SetSelected(i,true);
                            flag += 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        this.shopList.Items.Add(this.product.Text);
                        this.product.Text = "";
                        this.btnDeleteAll.Enabled = true;
                    }
                }
                else
                {
                    this.shopList.Items.Add(this.product.Text);
                    this.product.Text = "";
                    this.btnDeleteAll.Enabled = true;
                    this.btnMoveAll.Enabled = true;
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.shopList.SelectedItems.Count >= 1)
            {
                for (int i = this.shopList.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    this.shopList.Items.RemoveAt(this.shopList.SelectedIndices[i]);       
                }
                this.btnMoveSelected.Enabled = false;
            }

            if(this.shopList.Items.Count == 0)
            {
                this.btnDeleteAll.Enabled = false;
                this.btnModify.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnMoveAll.Enabled = false;
                this.btnMoveSelected.Enabled = false;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.shopList.Items[this.shopList.SelectedIndex] = this.product.Text;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this.shopList.Items.Clear();
            this.btnDeleteAll.Enabled = false;
            this.btnModify.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnMoveAll.Enabled = false;
            this.btnMoveSelected.Enabled = false;
            this.product.Text = "";
        }

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {
            int limit = this.shopList.SelectedIndices.Count;
            for (int i = 0; i < limit; i++)
            {
                this.storageList.Items.Add(this.shopList.Items[this.shopList.SelectedIndex].ToString());
                this.shopList.Items.Remove(this.shopList.Items[this.shopList.SelectedIndex]);
            }
            this.btnMoveSelected.Enabled = false;
            this.product.Text = "";
            this.btnDelete.Enabled = false;
            this.btnModify.Enabled = false;
            if (this.shopList.Items.Count == 0)
            {
                this.btnDeleteAll.Enabled = false;
                this.btnMoveAll.Enabled = false;
            }

        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.shopList.Items.Count; i++)
            {
                this.storageList.Items.Add(this.shopList.Items[i].ToString());
            }
            this.shopList.Items.Clear();
            this.btnDeleteAll.Enabled = false;
            this.btnModify.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnMoveAll.Enabled = false;
            this.btnMoveSelected.Enabled = false;
            this.product.Text = "";
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string aux = this.storageList.Items[this.storageList.SelectedIndex].ToString();
            this.storageList.Items[this.storageList.SelectedIndex] = this.storageList.Items[this.storageList.SelectedIndex - 1].ToString();
            this.storageList.Items[this.storageList.SelectedIndex - 1] = aux;
            int index = this.storageList.SelectedIndex - 1;
            this.storageList.SetSelected(this.storageList.SelectedIndex, false);
            this.storageList.SetSelected(index, true);

        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            string aux = this.storageList.Items[this.storageList.SelectedIndex].ToString();
            this.storageList.Items[this.storageList.SelectedIndex] = this.storageList.Items[this.storageList.SelectedIndex + 1].ToString();
            this.storageList.Items[this.storageList.SelectedIndex + 1] = aux;
            int index = this.storageList.SelectedIndex + 1;
            this.storageList.SetSelected(this.storageList.SelectedIndex, false);
            this.storageList.SetSelected(index, true);
        }

        private void product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnInsert.PerformClick();
            }
          
        }

        private void MetodoArrayList()
        {
            ArrayList antigua = new ArrayList();
            antigua.Add(this.btn1);
            antigua.Add(this.btn2);
            antigua.Add(this.btn3);
            antigua.Add(this.txt1);
            antigua.Add("Esto es un String");
            foreach (Object btn in antigua)
            {
                if(btn is Button)
                {
                    ((Button)btn).Text = "ArrayList";
                }
                
            }

            List<TextBox> generica = new List<TextBox>();
            generica.Add(this.txt1);
            generica.Add(this.txt2);
            generica.Add(this.txt3);
            foreach (TextBox caja in generica)
            {
                caja.Text = "Genérico";
            }
        }
    }
}
