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
        public string DNI_Client { get; set; }

        [Column("MOBILE_CLIENT")]
        public string Mobile_Client { get; set; }

        [Column("TELEPHONE_CLIENT")]
        public string Telephone_Client { get; set; }
    }
}