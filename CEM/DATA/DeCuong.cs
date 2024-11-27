using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class DeCuong
{
    public int MaDeCuong { get; set; }

    public string? TieuDe { get; set; }

    public string? MoTa { get; set; }

    public string? DuongDanTep { get; set; }

    public int? MaBaiGiang { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual BaiGiang? MaBaiGiangNavigation { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
