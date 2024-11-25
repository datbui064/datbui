using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class TaiLieuCtngoaiKhoa
{
    public int Id { get; set; }

    public string TenTaiLieu { get; set; } = null!;

    public string TacGia { get; set; } = null!;

    public DateOnly Ngay { get; set; }

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
