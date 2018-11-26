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
    
    public partial class SerializeImage : Form
    {
        List<Coche> cars = new List<Coche>();
        XmlSerializer serializer;
        String path = "./Coches.txt";
        public SerializeImage()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Coche>));
        }
        private void Write(int i)
        {
            if (this.marca.Text != "" && this.modelo.Text != "" && !(this.cuadroImagen.Tag is null))
            {
                Coche car;
                if (i == 0)
                {
                    if (this.marca.Text != "" && this.modelo.Text != "" && !(this.cuadroImagen.Tag is null))
                    {
                        car = new Coche();
                        car.Marca = this.marca.Text;
                        car.Modelo = this.modelo.Text;
                        car.Imagen = File.ReadAllBytes(this.cuadroImagen.Tag.ToString());
                        cars.Add(car);
                    }
                }
                else
                {
                    if (this.marca.Text != "" && this.modelo.Text != "" && !(this.cuadroImagen.Tag is null)  && this.coches.SelectedIndex != -1)
                    {
                        cars[this.coches.SelectedIndex].Marca = this.marca.Text;
                        cars[this.coches.SelectedIndex].Modelo = this.modelo.Text;
                        cars[this.coches.SelectedIndex].Imagen = File.ReadAllBytes(this.cuadroImagen.Tag.ToString());
                    }
                }
                StreamWriter writer = new StreamWriter(path);
                this.serializer.Serialize(writer, cars);
                writer.Flush();
                writer.Close();
                ClearData();
                ShowList();
            }
            
        }
        private void Read()
        {
            StreamReader reader = new StreamReader(path);
            cars = (List<Coche>)serializer.Deserialize(reader);
            reader.Close();
        }
        private void ShowList()
        {
            Read();
            foreach (Coche item in this.cars)
            {
                this.coches.Items.Add(item.Marca + " -> " + item.Modelo);
            }
        }
        private void ClearData()
        {
            this.coches.Items.Clear();
            cars.Clear();
            this.marca.Text = "";
            this.modelo.Text = "";
            this.cuadroImagen.Tag = null;
            this.cuadroImagen.Image = null;
        }
        private void DelData()
        {
            if(this.coches.SelectedIndex != -1)
            {
                cars.RemoveAt(this.coches.SelectedIndex);
                StreamWriter writer = new StreamWriter(path);
                this.serializer.Serialize(writer, cars);
                writer.Flush();
                writer.Close();
                ClearData();
                ShowList();
            }
        }
        private void ModifyData()
        {
            Write(1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Write(0);
        }
        private void cuadroImagen_Click(object sender, EventArgs e)
        {
            DialogResult result = this.open.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.cuadroImagen.Tag= this.open.FileName;
                this.cuadroImagen.Image = Image.FromFile(this.cuadroImagen.Tag.ToString());
            }
        }
        private void SerializeImage_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void coches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coche car = cars[this.coches.SelectedIndex];
            this.marca.Text = car.Marca;
            this.modelo.Text = car.Modelo;
            var ms = new MemoryStream(car.Imagen);
            this.cuadroImagen.Image = Image.FromStream(ms);
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            ModifyData();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DelData();
        }

    }
}
