using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCAP_2._0.Models.Class
{
    [Table("PLAYERS")]
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PLAYER")]
        public int Id_Player { get; set; }

        [Column("ID_USER")]
        public int Id_User { get; set; }

        [Column("NICK_PLAYER")]
        [Required(ErrorMessage = "El nick es obligatorio.")]
        //[RegularExpression(@"^(?=.{8, 20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "El nick tiene que estar comprendido entre 8 y 20 caracteres.")]
        [Display(Name = "Nick")]
        public string Nick_Player { get; set; }

        [Column("AGE_PLAYER")]
        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Display(Name = "Edad")]
        public int Age_Player { get; set; }

        [Column("SEX_PLAYER")]
        [Display(Name = "Género")]
        public string Sex_Player { get; set; }

        [Column("DESCRIPTION_PLAYER")]
        [Display(Name = "Descripción Personal")]
        public string Description_Player { get; set; }

        [Column("PP_PLAYER")]
        public int Pp_Player { get; set; }

        [Column("NP_PLAYER")]
        public int Np_Player { get; set; }

        [Column("SEALS_PLAYER")]
        public int Seals_Player { get; set; }

        [Column("LEVEL_PLAYER")]
        public int Level_Player { get; set; }
    }
}