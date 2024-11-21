using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class GiaoTrinh
{
    public int Id { get; set; }

    public int SoGiaoTrinh { get; set; }

    public string TenGiaoTrinh { get; set; } = null!;

    public string TacGiaGiaoTrinh { get; set; } = null!;

    public int NamXbgt { get; set; }

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
