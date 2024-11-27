using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class QuyetDinh
{
    public int MaQuyetDinh { get; set; }

    public string? TieuDe { get; set; }

    public string? MoTa { get; set; }

    public DateTime? NgayBanHanh { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }
}
