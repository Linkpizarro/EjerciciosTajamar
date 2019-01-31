using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Videoclub.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPedido")]
        public int Id { get; set; }
        [Column("IdCliente")]
        public int IdCliente { get; set; }
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
        [Column("Fecha")]
        public DateTime Fecha { get; set; }
        [Column("Cantidad")]
        public int Cantidad { get; set; }
        [Column("Precio")]
        public int Precio { get; set; }
    }
}