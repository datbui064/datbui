using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class Qd
{
    public int Id { get; set; }

    public DateOnly Ngay { get; set; }

    public string AiKy { get; set; } = null!;

    public byte[]? File { get; set; }

    public virtual ICollection<BaiGiang> BaiGiangs { get; set; } = new List<BaiGiang>();

    public virtual ICollection<GiaoBai> GiaoBais { get; set; } = new List<GiaoBai>();
}
