//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simpeda
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sepeda
    {
        public Sepeda()
        {
            this.Transaksi = new HashSet<Transaksi>();
        }
    
        public int idSepeda { get; set; }
        public int idShelter { get; set; }
        public string merkSepeda { get; set; }
        public string warnaSepeda { get; set; }
        public string keterangan { get; set; }
    
        public virtual Shelter Shelter { get; set; }
        public virtual ICollection<Transaksi> Transaksi { get; set; }
    }
}