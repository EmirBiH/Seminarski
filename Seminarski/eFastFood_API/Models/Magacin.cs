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
    
    public partial class Magacin
    {
        public int MagacinID { get; set; }
        public Nullable<decimal> Kolicina { get; set; }
        public Nullable<decimal> DonjaGranica { get; set; }
        public Nullable<int> ProizvodID { get; set; }
    
        public virtual Proizvod Proizvod { get; set; }
    }
}
