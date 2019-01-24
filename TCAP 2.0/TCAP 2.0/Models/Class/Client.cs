using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Class
{
    [Table("CLIENTS")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_CLIENT")]
        public int Id_Client { get; set; }

        [Column("ID_USER")]
        public int Id_User { get; set; }

        [Column("DNI_CLIENT")]
        [Required(ErrorMessage ="El campo DNI es obligatorio.")]
        [RegularExpression(@"^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$",ErrorMessage = "El DNI no es válido.")]
        [Display(Description = "DNI")]
        public string DNI_Client { get; set; }

        [Column("MOBILE_CLIENT")]
        [Required(ErrorMessage = "El número de móvil es obligatorio.")]
        [RegularExpression(@"^(\+34|0034|34)?[67]\d{8}$", ErrorMessage = "El número de móvil no es válido.")]
        [Display(Name = "Número de Móvil")]
        public string Mobile_Client { get; set; }

        [Column("TELEPHONE_CLIENT")]
        [RegularExpression(@"^(\+34|0034|34)?[89]\d{8}$",ErrorMessage = "El número de teléfono no es válido.")]
        [Display(Name = "Número de Teléfono")]
        public string Telephone_Client { get; set; }

        [NotMapped]
        public User GeneralData { get; set; }
    }
}