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
    
    public partial class Transaksi
    {
        public int idTransaksi { get; set; }
        public string NRP { get; set; }
        public string NIP { get; set; }
        public string idPegawai { get; set; }
        public int idSepeda { get; set; }
        public Nullable<System.DateTime> waktuPinjam { get; set; }
        public Nullable<System.DateTime> waktuKembali { get; set; }
        public short status { get; set; }
        public Nullable<int> shelterKembali { get; set; }
    
        public virtual Dosen Dosen { get; set; }
        public virtual Mahasiswa Mahasiswa { get; set; }
        public virtual Pegawai Pegawai { get; set; }
        public virtual Sepeda Sepeda { get; set; }
    }
}