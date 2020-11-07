using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_064.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public int? Kendaraaan { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public int? Customer { get; set; }
        [Required(ErrorMessage = "Jaminan tidak boleh kosong")]
        public int? Jaminan { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
