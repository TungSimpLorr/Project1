using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TAnhCaKoi
{
    public int MaCaKoi { get; set; }

    public string TenFileAnh { get; set; } = null!;

    public short? ViTri { get; set; }

    public virtual TCaKoi MaCaKoiNavigation { get; set; } = null!;
}
