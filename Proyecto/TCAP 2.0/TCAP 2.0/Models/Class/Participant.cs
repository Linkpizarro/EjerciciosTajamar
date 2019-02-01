using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Class
{
    [Table("PARTICIPANTS")]
    public class Participant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PARTICIPANT")]
        public int Id_Participant { get; set; }
        [Column("ID_PARTY")]
        public int Id_Party { get; set; }
        [Column("ID_PLAYER")]
        public int Id_Player { get; set; }
        [Column("LEADER_PARTICIPANT")]
        public int Leader_Participant { get; set; }
        [NotMapped]
        public Player Player { get; set; }
    }
}