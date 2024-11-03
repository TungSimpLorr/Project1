using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TChiTietDonHang
{
    public int MaDonHang { get; set; }

    public int MaCaKoi { get; set; }

    public int? SoLuong { get; set; }

    public decimal? GiaBan { get; set; }

    public virtual TCaKoi MaCaKoiNavigation { get; set; } = null!;

    public virtual TDonHang MaDonHangNavigation { get; set; } = null!;
}
