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
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Ficheros : Form
    {
        String path = "./Productos.txt";
        List<Product> productsList = new List<Product>();
        String personPath = "./Personas.txt";
        List<Person> personsList = new List<Person>();
        String actorPath = "./Actores.txt";
        List<Person> actorsList = new List<Person>();
        XmlSerializer serializer;

        public Ficheros()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Person>));
        }

        private void Ficheros_Load(object sender, EventArgs e)
        {
            ShowData();      
            ShowDataP();
            ShowDataA();
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

        //Actores
        private void WriteA()
        {
            StreamWriter writer = new StreamWriter(actorPath);
            Person p = new Person(this.txtName.Text, this.txtSurname.Text, int.Parse(this.txtAge.Text));
            actorsList.Add(p);        
            this.serializer.Serialize(writer, actorsList);
            writer.Flush();
            writer.Close();
        }
        private void ReadA()
        {
            StreamReader reader = new StreamReader(actorPath);
            actorsList.Clear();

            actorsList = (List<Person>)serializer.Deserialize(reader);
            reader.Close();
           
        }
        private void ClearDataA()
        {
            this.actors.Items.Clear();
            this.txtName.Text = "";
            this.txtSurname.Text = "";
            this.txtAge.Text = "";
        }
        private void ShowDataA()
        {
            ReadA();
            foreach (Person p in actorsList)
            {
                this.actors.Items.Add(p.Name + " " + p.Surname + " -> " + p.Age + " Años.");
            }
        }
        private void DelActorsList()
        {
            actorsList.RemoveAt(this.actors.SelectedIndex);
            WriteA();
        }
        private void btnAddAct_Click(object sender, EventArgs e)
        {
            if (!(this.txtName is null) && !(this.txtSurname is null) && !(this.txtAge is null))
            {
                WriteA();
                ClearDataA();
                ShowDataA();
            }
        }

        private void btnDelAct_Click(object sender, EventArgs e)
        {
            DelActorsList();
            ClearDataA();
            ShowDataA();
        }
    }
}
