using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class CauHoi
{
    public int MaCauHoi { get; set; }

    public string? NoiDung { get; set; }

    public string? DapAn { get; set; }

    public int? MaBaiGiang { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual BaiGiang? MaBaiGiangNavigation { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
