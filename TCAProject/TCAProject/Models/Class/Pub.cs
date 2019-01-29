using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAProject.Models.Class
{
    [Table("PUBS")]
    public class Pub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PUB")]
        public int Id_Pub { get; set; }
        [Column("ID_CLIENT")]
        public int Id_Client { get; set; }
        [Column("NAME_PUB")]
        public String Name_Pub { get; set; }
        [Column("ADDRESS_PUB")]
        public String Address_Pub { get; set; }
        [Column("CP_PUB")]
        public int CP_Pub { get; set; }
        [Column("PHONE_PUB")]
        public String Phone_Pub { get; set; }
        [Column("STATUS_PUB")]
        public int Status_Pub { get; set; }
    }
}