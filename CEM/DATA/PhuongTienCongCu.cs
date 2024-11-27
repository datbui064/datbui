using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class PhuongTienCongCu
{
    public int MaCongCu { get; set; }

    public string? TenCongCu { get; set; }

    public string? MoTa { get; set; }

    public string? DuongDanTep { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
