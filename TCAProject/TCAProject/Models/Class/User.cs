using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAProject.Models.Class
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_USER")]
        public int Id_User { get; set; }

        [Column("ID_ROL")]
        [Required(ErrorMessage ="Es necesario que seleccione un tipo de Usuario.")]
        [RegularExpression(@"^[1-2]{1}$",ErrorMessage ="Los valores para Usuario solo pueden ser 'Cliente' o 'Jugador'.")]
        [Display(Description = "Tipo de Usuario")]
        public int Id_Rol { get; set; }

        [Column("NAME_USER")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Nombre es obligatório.")]
        [RegularExpression(@"^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$", ErrorMessage ="El Nombre debe empezar por mayúscula.")]
        [Display(Name = "Nombre")]
        public String Name_User { get; set; }

        [Column("SURNAME_USER")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Apellido es obligatório.")]
        [RegularExpression(@"^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$", ErrorMessage = "El Apellido debe empezar por mayúscula.")]
        [Display(Name = "Apellido")]
        public String Surname_User { get; set; }

        [Column("EMAIL_USER")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "El campo Email es obligatório.")]
        [RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$", ErrorMessage = "El Email no es correcto.")]
        [Display(Name = "Email")]
        public String Email_User { get; set; }

        [Column("PASSWORD_USER")]
        public String Password_User { get; set; }

        [Column("IMAGE_USER")]
        public String Image_User { get; set; }

        [Column("CREATED_USER")]
        public DateTime Created_User { get; set; }

        [Column("UPDATED_USER")]
        public DateTime Updated_User { get; set; }

        [Column("STATUS_USER")]
        public int Status_User { get; set; }
    }
}