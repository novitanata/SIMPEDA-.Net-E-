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
    
    public partial class Mahasiswa
    {
        public Mahasiswa()
        {
            this.Transaksi = new HashSet<Transaksi>();
        }
    
        public string NRP { get; set; }
        public int idJurusan { get; set; }
        public string namaMhs { get; set; }
        public string teleponMhs { get; set; }
        public string alamatMhs { get; set; }
        public string emailMhs { get; set; }
        public Nullable<int> poinPunishmentMhs { get; set; }
    
        public virtual JurusanInstansi JurusanInstansi { get; set; }
        public virtual ICollection<Transaksi> Transaksi { get; set; }
    }
}
