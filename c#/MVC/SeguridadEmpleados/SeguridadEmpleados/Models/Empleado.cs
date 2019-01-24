using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SeguridadEmpleados.Models
{
    [Table("EMP")]
    public class Empleado : IPrincipal
    {
        [Key]
        [Column("EMP_NO")]
        [Display(Name ="Número Empleado")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEmpleado { get; set; }
        [Column("APELLIDO")]
        [Display(Name = "Apellido")]
        public String Apellido { get; set; }
        [Column("OFICIO")]
        [Display(Name = "Oficio")]
        public String Oficio { get; set; }
        [Column("SALARIO")]
        [Display(Name = "Salario")]
        public int Salario { get; set; }
        [Column("DIR")]
        [Display(Name = "Direcctor")]
        public int Director { get; set; }

        public Empleado(IIdentity identidad)
        {
            this.Identity = identidad;
        }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            if (this.Oficio.ToUpper() == role.ToUpper())
            {
                return true;
            }
            return false ;
        }
    }
}