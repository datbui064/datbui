using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class TaiLieuHocTap
{
    public int MaTaiLieu { get; set; }

    public string? TenTaiLieu { get; set; }

    public string? TacGia { get; set; }

    public int? NamXuatBan { get; set; }

    public string? NhaXuatBan { get; set; }

    public string? LoaiTaiLieu { get; set; }

    public string? DuongDan { get; set; }

    public int? MaBaiGiang { get; set; }

    public virtual BaiGiang? MaBaiGiangNavigation { get; set; }
}
