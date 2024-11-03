using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TCaKoi
{
    public int MaCaKoi { get; set; }

    public int? MaGiongCa { get; set; }

    public string? NguonGoc { get; set; }

    public string? GioiTinh { get; set; }

    public int? Tuoi { get; set; }

    public decimal? KichThuoc { get; set; }

    public string? TinhCach { get; set; }

    public string? TrangThai { get; set; }

    public virtual TGiongCaKoi? MaGiongCaNavigation { get; set; }

    public virtual ICollection<TAnhCaKoi> TAnhCaKois { get; } = new List<TAnhCaKoi>();

    public virtual ICollection<TChiTietDonHang> TChiTietDonHangs { get; } = new List<TChiTietDonHang>();

    public virtual ICollection<TKiemTraKhangGui> TKiemTraKhangGuis { get; } = new List<TKiemTraKhangGui>();

    public virtual ICollection<TRating> TRatings { get; } = new List<TRating>();
}
