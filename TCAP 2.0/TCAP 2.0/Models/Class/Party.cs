using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Class
{
    [Table("PARTIES")]
    public class Party
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PARTY")]
        public int Id_Party { get; set; }
        [Column("ID_PUB")]
        public int Id_Pub { get; set; }
        [Column("BOARDGAME_PARTY")]
        public String Boargame_Party { get; set; }
        [Column("START_PARTY")]
        public DateTime Start_Party { get; set; }
        [Column("CURRENT_PARTICIPANT_PARTY")]
        public int Current_Participant_Party { get; set; }
        [Column("MAX_PARTICIPANT_PARTY")]
        public int Max_Participant_Party { get; set; }
        [Column("STATUS_PARTY")]
        public int Status_Party { get; set; }
        [NotMapped]
        public List<Participant> Participants { get; set; }
        [NotMapped]
        public Pub Pub { get; set; }
    }
}