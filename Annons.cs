//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThriftShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Annons
    {
        public int id { get; set; }
        public string titel { get; set; }
        public string beskrivning { get; set; }
        public double pris { get; set; }
        public int kategoriID { get; set; }
        public int anvandareID { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
    
        public virtual Anvandare Anvandare { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
