//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConceptosMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class DEPT
    {
        public int DEPT_NO { get; set; }
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]{3,16}$",ErrorMessage = "*Caracteres requeridos entre 3 y 16.")]
        [Required(ErrorMessage ="*El nombre de Departamento es obligatorio.")]
        public string DNOMBRE { get; set; }
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]{3,16}$", ErrorMessage = "*Caracteres requeridos entre 3 y 16.")]
        [Required(ErrorMessage = "*La localidad es obligatoria.")]
        public string LOC { get; set; }
    }
}
