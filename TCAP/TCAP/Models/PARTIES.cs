//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARTIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PARTIES()
        {
            this.PARTICPANTS = new HashSet<PARTICPANTS>();
        }
    
        public int ID_PARTY { get; set; }
        public int ID_PUB { get; set; }
        public string BOARDGAME_PARTY { get; set; }
        public System.DateTime START_PARTY { get; set; }
        public int CURRENT_PARTICIPANT_PARTY { get; set; }
        public int MAX_PARTICIPANT_PARTY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICPANTS> PARTICPANTS { get; set; }
        public virtual PUBS PUBS { get; set; }
    }
}
