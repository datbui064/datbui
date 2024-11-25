using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class HeThongGiaoAn
{
    public int Id { get; set; }

    public string LoaiGiaoAn { get; set; } = null!;

    public string NdGiaoAn { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
