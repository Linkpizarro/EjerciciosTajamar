using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inyeccion.Models
{
    public class RepositoryProductos : IRepositoryProductos
    {
        List<Producto> productos;
        public RepositoryProductos()
        {
            this.CargarProductos();
        }
        private void CargarProductos()
        {
            productos = new List<Producto>();

            productos.AddRange(new Producto[] {
                new Producto() {
                    Nombre = "Iphone",
                    Image = "imgIphone.jpg",
                    Precio = 866.32 
                },
                new Producto() {
                    Nombre = "Nintendo Switch",
                    Image = "imgSwitch.jpg",
                    Precio = 399.99
                },
                new Producto() {
                    Nombre = "PS4 Slim",
                    Image = "imgPS4.jpg",
                    Precio = 299.99
                },
                        new Producto() {
                    Nombre = "Iphone",
                    Image = "imgIphone.jpg",
                    Precio = 866.32
                },
                new Producto() {
                    Nombre = "Nintendo Switch",
                    Image = "imgSwitch.jpg",
                    Precio = 399.99
                },
                new Producto() {
                    Nombre = "PS4 Slim",
                    Image = "imgPS4.jpg",
                    Precio = 299.99
                },
                        new Producto() {
                    Nombre = "Iphone",
                    Image = "imgIphone.jpg",
                    Precio = 866.32
                },
                new Producto() {
                    Nombre = "Nintendo Switch",
                    Image = "imgSwitch.jpg",
                    Precio = 399.99
                },
                new Producto() {
                    Nombre = "PS4 Slim",
                    Image = "imgPS4.jpg",
                    Precio = 299.99
                }
            });

      
        }
        public List<Producto> GetProductos()
        {
            return productos;
        }
    }
}