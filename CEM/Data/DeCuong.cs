using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class DeCuong
{
    public int Id { get; set; }

    public string? NoiDungDaoTao { get; set; }

    public string? Ten { get; set; }

    public virtual ChuongTrinhDaoTao? TenNavigation { get; set; }
}
