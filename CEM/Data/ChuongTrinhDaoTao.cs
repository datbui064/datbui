using System;
using System.Collections.Generic;

namespace CEM.Data;

public partial class ChuongTrinhDaoTao
{
    public string Ten { get; set; } = null!;

    public string MaNganhDaoTao { get; set; } = null!;

    public DateOnly BatDau { get; set; }

    public DateOnly KetThuc { get; set; }

    public int SoMonHoc { get; set; }

    public int SoTinChi { get; set; }

    public string? YeuCauDauRa { get; set; }

    public virtual ICollection<BaoCaoNgoaiKhoa> BaoCaoNgoaiKhoas { get; set; } = new List<BaoCaoNgoaiKhoa>();

    public virtual ICollection<DeCuong> DeCuongs { get; set; } = new List<DeCuong>();

    public virtual ICollection<GiaoTrinh> GiaoTrinhs { get; set; } = new List<GiaoTrinh>();

    public virtual ICollection<HeThongCauhoivaBt> HeThongCauhoivaBts { get; set; } = new List<HeThongCauhoivaBt>();

    public virtual ICollection<HeThongGiaoAn> HeThongGiaoAns { get; set; } = new List<HeThongGiaoAn>();

    public virtual ICollection<KeHoachThucHienBiaGiang> KeHoachThucHienBiaGiangs { get; set; } = new List<KeHoachThucHienBiaGiang>();

    public virtual ICollection<NganHangCauHoi> NganHangCauHois { get; set; } = new List<NganHangCauHoi>();

    public virtual ICollection<TaiLieuCtngoaiKhoa> TaiLieuCtngoaiKhoas { get; set; } = new List<TaiLieuCtngoaiKhoa>();
}
