using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class BaiGiang
{
    public int Id { get; set; }

    public string TenBaiGiang { get; set; } = null!;

    public byte[]? DuongDanBaiGiang { get; set; }

    public int SoTietHoc { get; set; }

    public int SoQuyetDinh { get; set; }

    public virtual Qd SoQuyetDinhNavigation { get; set; } = null!;
}
