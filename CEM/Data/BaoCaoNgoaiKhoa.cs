using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class BaoCaoNgoaiKhoa
{
    public int Id { get; set; }

    public string LoaiBaoCao { get; set; } = null!;

    public DateOnly Ngay { get; set; }

    public string MoTaBaoCao { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
