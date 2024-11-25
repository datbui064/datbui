using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class GiaoBai
{
    public int Id { get; set; }

    public DateOnly NgayGiaoBai { get; set; }

    public int SoQuyetDinh { get; set; }

    public virtual Qd SoQuyetDinhNavigation { get; set; } = null!;
}
