using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TKiemTraKhangGui
{
    public int MaKiemTra { get; set; }

    public int? MaKhachHangGui { get; set; }

    public int? MaKhachHangNhan { get; set; }

    public int? MaCaKoi { get; set; }

    public DateTime? NgayKiemTra { get; set; }

    public string? TrangThai { get; set; }

    public virtual TCaKoi? MaCaKoiNavigation { get; set; }

    public virtual TKhachHang? MaKhachHangGuiNavigation { get; set; }

    public virtual TKhachHang? MaKhachHangNhanNavigation { get; set; }
}
