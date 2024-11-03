using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TDonHang
{
    public int MaDonHang { get; set; }

    public int? MaKhachHang { get; set; }

    public DateTime? NgayDatHang { get; set; }

    public string? TrangThai { get; set; }

    public virtual TKhachHang? MaKhachHangNavigation { get; set; }

    public virtual ICollection<TChiTietDonHang> TChiTietDonHangs { get; } = new List<TChiTietDonHang>();
}
