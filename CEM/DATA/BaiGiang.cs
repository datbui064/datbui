using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class BaiGiang
{
    public int MaBaiGiang { get; set; }

    public string? TieuDe { get; set; }

    public string? NoiDung { get; set; }

    public string? DuongDanTep { get; set; }

    public int? MaNguoiDung { get; set; }

    public virtual ICollection<CauHoi> CauHois { get; set; } = new List<CauHoi>();

    public virtual ICollection<DeCuong> DeCuongs { get; set; } = new List<DeCuong>();

    public virtual ICollection<KeHoachGiangDay> KeHoachGiangDays { get; set; } = new List<KeHoachGiangDay>();

    public virtual NguoiDung? MaNguoiDungNavigation { get; set; }

    public virtual ICollection<TaiLieuHocTap> TaiLieuHocTaps { get; set; } = new List<TaiLieuHocTap>();
}
