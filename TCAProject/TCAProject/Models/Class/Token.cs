using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAProject.Models.Class
{
    [Table("TOKENS")]
    public class Token
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_TOKEN")]
        public int Id_token { get; set; }

        [Column("ID_USER")]
        public int Id_User { get; set; }

        [Column("VALUE_TOKEN")]
        public string Value_Token { get; set; }

        [Column("START_TOKEN")]
        public DateTime Start_Token { get; set; }

        [Column("END_TOKEN")]
        public DateTime End_Token { get; set; }

    }
}