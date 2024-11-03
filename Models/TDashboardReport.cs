using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TDashboardReport
{
    public int MaReport { get; set; }

    public string? LoaiReport { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NoiDungReport { get; set; }
}
