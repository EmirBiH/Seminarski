//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eFastFood_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GPProizvod
    {
        [Key]
        public int GPProizvodID { get; set; }
        public int GotoviProizvodID { get; set; }
        public int ProizvodID { get; set; }
        public Nullable<decimal> KolicinaUtroska { get; set; }
        public int MjernaJedinicaID { get; set; }

        public virtual GotoviProizvod GotoviProizvod { get; set; }
        public virtual MjernaJedinica MjernaJedinica { get; set; }
        public virtual Proizvod Proizvod { get; set; }
    }
}
