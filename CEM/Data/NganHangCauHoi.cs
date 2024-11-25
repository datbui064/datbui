using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class NganHangCauHoi
{
    public int Id { get; set; }

    public string NdCauHoi { get; set; } = null!;

    public string DapAn { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
