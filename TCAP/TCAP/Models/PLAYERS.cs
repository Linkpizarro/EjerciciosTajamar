//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLAYERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAYERS()
        {
            this.PARTICPANTS = new HashSet<PARTICPANTS>();
            this.TICKETS = new HashSet<TICKETS>();
        }
    
        public int ID_PLAYER { get; set; }
        public int ID_USER { get; set; }
        public string NICK_PLAYER { get; set; }
        public Nullable<int> AGE_PLAYER { get; set; }
        public string SEX_PLAYER { get; set; }
        public string DESCRIPTION_PLAYER { get; set; }
        public int PP_PLAYER { get; set; }
        public int NP_PLAYER { get; set; }
        public int SEALS_PLAYER { get; set; }
        public int LEVEL_PLAYER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICPANTS> PARTICPANTS { get; set; }
        public virtual USERS USERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKETS> TICKETS { get; set; }
    }
}
