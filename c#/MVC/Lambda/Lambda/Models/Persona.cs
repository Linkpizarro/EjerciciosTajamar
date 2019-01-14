using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lambda.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-z]+$",ErrorMessage = "Solo letras minus.")]

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        [EmailAddress(ErrorMessage = ("Dirrecion de email incorrecta"))]
        [Required]
        [Display(Description = "Correo eletronico")]
        public String Email { get; set; }

        [DataType(DataType.Date)]
        public String FechaNac { get; set; }

        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords deben ser iguales")]
        [DataType(DataType.Password)]
        public String RepPassword { get; set; }
    }
}