using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class BaoCao
{
    public int MaBaoCao { get; set; }

    public string? TieuDe { get; set; }

    public string? NoiDung { get; set; }

    public string? DuongDanTep { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
