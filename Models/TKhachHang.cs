using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TKhachHang
{
    public int MaKhachHang { get; set; }

    public string HoTen { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public string? LoaiKhachHang { get; set; }

    public virtual ICollection<TDonHang> TDonHangs { get; } = new List<TDonHang>();

    public virtual ICollection<TKiemTraKhangGui> TKiemTraKhangGuiMaKhachHangGuiNavigations { get; } = new List<TKiemTraKhangGui>();

    public virtual ICollection<TKiemTraKhangGui> TKiemTraKhangGuiMaKhachHangNhanNavigations { get; } = new List<TKiemTraKhangGui>();

    public virtual ICollection<TRating> TRatings { get; } = new List<TRating>();
}
