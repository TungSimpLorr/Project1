using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TRating
{
    public int MaKhachHang { get; set; }

    public int MaCaKoi { get; set; }

    public int? DiemRating { get; set; }

    public string? Feedback { get; set; }

    public virtual TCaKoi MaCaKoiNavigation { get; set; } = null!;

    public virtual TKhachHang MaKhachHangNavigation { get; set; } = null!;
}
