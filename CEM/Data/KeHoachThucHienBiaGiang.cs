using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class KeHoachThucHienBiaGiang
{
    public int Id { get; set; }

    public string LoaiKeHoach { get; set; } = null!;

    public string NdkeHoach { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public virtual ChuongTrinhDaoTao TenNavigation { get; set; } = null!;
}
