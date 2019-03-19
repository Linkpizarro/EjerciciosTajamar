using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientePracticaMonedas.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Cliente_Id { get; set; }
        public int Moneda_Id { get; set; }
        public int Unidades { get; set; }
        public DateTime Fecha { get; set; }
    }
}
