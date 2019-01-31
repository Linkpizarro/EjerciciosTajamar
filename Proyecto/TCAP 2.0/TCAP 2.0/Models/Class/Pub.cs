using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Class
{
    [Table("PUBS")]
    public class Pub
    {
        //****FALTAN VALIDACIONES****
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PUB")]
        public int Id_Pub { get; set; }
        [Column("ID_CLIENT")]
        public int Id_Client { get; set; }
        [Column("NAME_PUB")]
        [Display(Name = "Nombre")]
        public String Name_Pub { get; set; }
        [Column("ADDRESS_PUB")]
        [Display(Name = "Dirección")]
        public String Address_Pub { get; set; }
        [Column("CP_PUB")]
        [Display(Name = "Código Postal")]
        public String CP_Pub { get; set; }
        [Column("PHONE_PUB")]
        [Display(Name = "Número de Teléfono")]
        public String Phone_Pub { get; set; }
        [Column("STATUS_PUB")]
        public int Status_Pub { get; set; }
    }
}