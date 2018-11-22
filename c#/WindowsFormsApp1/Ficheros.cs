using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Ficheros : Form
    {
        String path = "./Productos.txt";
        List<Product> productsList = new List<Product>();
        String personPath = "./Personas.txt";
        List<Person> personsList = new List<Person>();

        public Ficheros()
        {
            InitializeComponent();
        }
        private void Ficheros_Load(object sender, EventArgs e)
        {
            CreateProductsList();
            ShowData();
        }

        //Productos
        private async void Write()
        {
            FileInfo file;
            TextWriter writer;
            if (Read() != "")
            {
                file = new FileInfo(path);
                writer = file.AppendText();
                await writer.WriteAsync("&" + this.name.Text + "@" + this.price.Text);
            }
            else
            {
                file = new FileInfo(path);
                writer = file.AppendText();
                await writer.WriteAsync(this.name.Text + "@" + this.price.Text);
            }

            writer.Flush();
            writer.Close();
        }
        private String Read()
        {
            FileInfo file = new FileInfo(path);
            TextReader reader = file.OpenText();
            String content;
            using (reader)
            {
                content = reader.ReadToEnd();
            }
            reader.Close();
            return content;
        }
        private void CreateProductsList()
        {
            productsList.Clear();
            String content = Read();
            if (content != "")
            {
                List<String[]> dataProduct = new List<String[]>();
                if (content.Contains('&'))
                {
                    String[] product = content.Split('&');
                    foreach (String item in product)
                    {
                        dataProduct.Add(item.Split('@'));
                    }
                }
                else{
                    dataProduct.Add(content.Split('@'));
                }
                foreach (String[] item in dataProduct)
                {
                    productsList.Add(new Product(item[0], double.Parse(item[1])));
                }
            }
           
            
            
        }
        private void ClearData()
        {
            this.products.Items.Clear();
            this.name.Text = "";
            this.price.Text = "";
        }
        private void ShowData() {
            CreateProductsList();
            foreach (Product p in productsList)
            {
                this.products.Items.Add(p.Name + " -> " + p.Price + "€");
            }
        }
        private void DelProductsList()
        {
              productsList.Remove(productsList[this.products.SelectedIndex]);
              ReWrite();
        }
        private async void ReWrite()
        {
            String content = "";
            int i = 0;
            foreach (Product P in productsList)
            {
                if (i == 0)
                {
                    content += P.Name + "@" + P.Price;
                }
                else
                {
                    content += "&" + P.Name + "@" + P.Price;
                }
                i++;
            }
            FileInfo file = new FileInfo(path);
            TextWriter writer = file.CreateText();
            await writer.WriteAsync(content);
            writer.Flush();
            writer.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(this.name is null) && !(this.price is null))
            {
                Write();
                ClearData();
                ShowData();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DelProductsList();
            CreateProductsList();
            ClearData();
            ShowData();
        }

        //Personas
        private async void WriteP()
        {
            FileInfo file;
            TextWriter writer;
            if (ReadP() != "")
            {
                file = new FileInfo(personPath);
                writer = file.AppendText();
                await writer.WriteAsync("&" + this.pname.Text + "@" + this.psurname.Text + "@" + this.page.Text);
            }
            else
            {
                file = new FileInfo(personPath);
                writer = file.AppendText();
                await writer.WriteAsync(this.pname.Text + "@" + this.psurname.Text + "@" + this.page.Text);
            }

            writer.Flush();
            writer.Close();
        }
        private String ReadP()
        {
            FileInfo file = new FileInfo(personPath);
            TextReader reader = file.OpenText();
            String content;
            using (reader)
            {
                content = reader.ReadToEnd();
            }
            reader.Close();
            return content;
        }
        private void CreatePersonsList()
        {
            personsList.Clear();
            String content = ReadP();
            if (content != "")
            {
                List<String[]> dataPerson = new List<String[]>();
                if (content.Contains('&'))
                {
                    String[] person = content.Split('&');
                    foreach (String item in person)
                    {     
                        dataPerson.Add(item.Split('@'));
                    }
                }
                else
                {
                    dataPerson.Add(content.Split('@'));
                }
                foreach (String[] item in dataPerson)
                {
                    personsList.Add(new Person(item[0],item[1],int.Parse(item[2])));
                }
            }



        }
        private void ClearDataP()
        {
            this.persons.Items.Clear();
            this.pname.Text = "";
            this.psurname.Text = "";
            this.page.Text = "";
        }
        private void ShowDataP()
        {
            CreatePersonsList();
            foreach (Person p in personsList)
            {
                this.persons.Items.Add(p.Name + " " + p.Surname + " -> " + p.Age + " Años.");
            }
        }
        private void DelPersonsList()
        { 
            personsList.RemoveAt(this.persons.SelectedIndex);
            ReWriteP();
        }
        private async void ReWriteP()
        {
            String content = "";
            int i = 0;
            foreach (Person P in personsList)
            {
                if (i == 0)
                {
                    content += P.Name + "@" + P.Surname + "@" + P.Age;
                }
                else
                {
                    content += "&" + P.Name + "@" + P.Surname + "@" + P.Age;
                }
                i++;
            }
            FileInfo file = new FileInfo(personPath);
            TextWriter writer = file.CreateText();
            await writer.WriteAsync(content);
            writer.Flush();
            writer.Close();
        }
        private void btnAddP_Click(object sender, EventArgs e)
        {
            if (!(this.pname is null) && !(this.psurname is null) && !(this.page is null))
            {
                WriteP();
                ClearDataP();
                ShowDataP();
            }
        }
        private void btnDelP_Click(object sender, EventArgs e)
        {
            DelPersonsList();
            CreatePersonsList();
            ClearDataP();
            ShowDataP();
        }
    }
}
