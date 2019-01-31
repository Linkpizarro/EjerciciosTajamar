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
        [Required(ErrorMessage ="El nombre del juego es obligatiorio.")]
        [RegularExpression(@"^\d\w+$",ErrorMessage ="No se admiten caracteres especiales.")]
        [Display(Name = "Juego de Mesa")]
        public String Boargame_Party { get; set; }
        [Column("START_PARTY")]
        [Required(ErrorMessage = "El día de inicio es obligatiorio.")]
        [Display(Name = "Día de Inicio")]
        public DateTime Start_Party { get; set; }
        [Column("CURRENT_PARTICIPANT_PARTY")]
        public int Current_Participant_Party { get; set; }
        [Column("MAX_PARTICIPANT_PARTY")]
        [Required(ErrorMessage = "El número máximo de participantes es obligatiorio.")]
        [Display(Name = "Número Máximo de Participantes")]
        public int Max_Participant_Party { get; set; }
        [Column("STATUS_PARTY")]
        public int Status_Party { get; set; }
        [NotMapped]
        public List<Participant> Participants { get; set; }
        [NotMapped]
        public Pub Pub { get; set; }
    }
}