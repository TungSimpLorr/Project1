using System;
using System.Collections.Generic;

namespace KOI_Shop.Models;

public partial class TGiongCaKoi
{
    public int MaGiongCa { get; set; }

    public string TenGiongCa { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<TCaKoi> TCaKois { get; } = new List<TCaKoi>();
}
