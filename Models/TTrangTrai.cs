using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TTrangTrai
{
    public int MaTrangTrai { get; set; }

    public string TenTrangTrai { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }
}
