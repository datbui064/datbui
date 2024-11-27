using System;
using System.Collections.Generic;

namespace CEM.DATA;

public partial class NguoiDung
{
    public int MaNguoiDung { get; set; }

    public string? TenDangNhap { get; set; }

    public string? MatKhau { get; set; }

    public string? HoTen { get; set; }

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public string? VaiTro { get; set; }

    public virtual ICollection<BaiGiang> BaiGiangs { get; set; } = new List<BaiGiang>();

    public virtual ICollection<BaoCao> BaoCaos { get; set; } = new List<BaoCao>();

    public virtual ICollection<CauHoi> CauHois { get; set; } = new List<CauHoi>();

    public virtual ICollection<DeCuong> DeCuongs { get; set; } = new List<DeCuong>();

    public virtual ICollection<KeHoachGiangDay> KeHoachGiangDays { get; set; } = new List<KeHoachGiangDay>();

    public virtual ICollection<PhuongTienCongCu> PhuongTienCongCus { get; set; } = new List<PhuongTienCongCu>();

    public virtual ICollection<QuyetDinh> QuyetDinhs { get; set; } = new List<QuyetDinh>();
}
