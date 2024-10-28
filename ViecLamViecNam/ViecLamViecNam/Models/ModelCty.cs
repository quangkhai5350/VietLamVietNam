using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ViecLamViecNam.Models
{
    public partial class ModelCty : DbContext
    {
        public ModelCty()
            : base("name=ModelCty")
        {
        }

        public virtual DbSet<aspnet_getVisitors> aspnet_getVisitors { get; set; }
        public virtual DbSet<aspnet_mapauto> aspnet_mapauto { get; set; }
        public virtual DbSet<aspnet_mapSub> aspnet_mapSub { get; set; }
        public virtual DbSet<DM_ChucDanh> DM_ChucDanh { get; set; }
        public virtual DbSet<DM_DanToc> DM_DanToc { get; set; }
        public virtual DbSet<DM_DoiTuong> DM_DoiTuong { get; set; }
        public virtual DbSet<DM_DonViDaoTao> DM_DonViDaoTao { get; set; }
        public virtual DbSet<DM_GioiTinh> DM_GioiTinh { get; set; }
        public virtual DbSet<DM_HocPhi> DM_HocPhi { get; set; }
        public virtual DbSet<DM_HocVan> DM_HocVan { get; set; }
        public virtual DbSet<DM_KhuCongNghiep> DM_KhuCongNghiep { get; set; }
        public virtual DbSet<DM_LoaiCongViec> DM_LoaiCongViec { get; set; }
        public virtual DbSet<DM_LoaiHinhDoanhNghiep> DM_LoaiHinhDoanhNghiep { get; set; }
        public virtual DbSet<DM_LoaiTinhTrang> DM_LoaiTinhTrang { get; set; }
        public virtual DbSet<DM_LyDoHuyC> DM_LyDoHuyC { get; set; }
        public virtual DbSet<DM_LyDoNghiViec> DM_LyDoNghiViec { get; set; }
        public virtual DbSet<DM_NganHang> DM_NganHang { get; set; }
        public virtual DbSet<DM_NganhKinhDoanh> DM_NganhKinhDoanh { get; set; }
        public virtual DbSet<DM_NganhLaoDong> DM_NganhLaoDong { get; set; }
        public virtual DbSet<DM_NgheHoc> DM_NgheHoc { get; set; }
        public virtual DbSet<DM_NgheKinhDoanh> DM_NgheKinhDoanh { get; set; }
        public virtual DbSet<DM_NgheLaoDong> DM_NgheLaoDong { get; set; }
        public virtual DbSet<DM_NghiepVu> DM_NghiepVu { get; set; }
        public virtual DbSet<DM_NoiCapGPLX> DM_NoiCapGPLX { get; set; }
        public virtual DbSet<DM_QuocGia> DM_QuocGia { get; set; }
        public virtual DbSet<DM_ThoiGianLamViec> DM_ThoiGianLamViec { get; set; }
        public virtual DbSet<DM_TinhTrangPheDuyetHoSo> DM_TinhTrangPheDuyetHoSo { get; set; }
        public virtual DbSet<DM_TinhTrangViecLam> DM_TinhTrangViecLam { get; set; }
        public virtual DbSet<DM_TonGiao> DM_TonGiao { get; set; }
        public virtual DbSet<DM_TrinhDoChuyenMon> DM_TrinhDoChuyenMon { get; set; }
        public virtual DbSet<DoanhNghiep> DoanhNghieps { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung> DoanhNghiep_TuyenDung { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_DiaDiemLamViec2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_DiaDiemLamViec2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaKinhNghiem2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaKinhNghiem2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaLuong2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_MoTaLuong2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023> DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023 { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_NghiepVu> DoanhNghiep_TuyenDung_NghiepVu { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_NgoaiNgu> DoanhNghiep_TuyenDung_NgoaiNgu { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_TinHoc> DoanhNghiep_TuyenDung_TinHoc { get; set; }
        public virtual DbSet<DoanhNghiep_UngTuyen> DoanhNghiep_UngTuyen { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachHang_KinhNghiem_LamViec_2022> KhachHang_KinhNghiem_LamViec_2022 { get; set; }
        public virtual DbSet<KhachHang_NghiepVu> KhachHang_NghiepVu { get; set; }
        public virtual DbSet<KhachHang_TimViec_NgoaiNgu_2022> KhachHang_TimViec_NgoaiNgu_2022 { get; set; }
        public virtual DbSet<KhachHang_TimViec_TinHoc> KhachHang_TimViec_TinHoc { get; set; }
        public virtual DbSet<KhachHang_TimViecLam> KhachHang_TimViecLam { get; set; }
        public virtual DbSet<KhachHang_TimViecLam_FileDinhKem> KhachHang_TimViecLam_FileDinhKem { get; set; }
        public virtual DbSet<KhachHang_TrinhDo> KhachHang_TrinhDo { get; set; }
        public virtual DbSet<m_gioithieu> m_gioithieu { get; set; }
        public virtual DbSet<m_Lienket> m_Lienket { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategories { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhanVien_LoaiTaiKhoan> NhanVien_LoaiTaiKhoan { get; set; }
        public virtual DbSet<NhanVien_TaiKhoan> NhanVien_TaiKhoan { get; set; }
        public virtual DbSet<NhatKy_Admin> NhatKy_Admin { get; set; }
        public virtual DbSet<Pay_CTXuatDiem> Pay_CTXuatDiem { get; set; }
        public virtual DbSet<Pay_GiaSP> Pay_GiaSP { get; set; }
        public virtual DbSet<Pay_NhapDiem> Pay_NhapDiem { get; set; }
        public virtual DbSet<Pay_Sys> Pay_Sys { get; set; }
        public virtual DbSet<Pay_TonCuoi> Pay_TonCuoi { get; set; }
        public virtual DbSet<PHU_HSTD_Luu> PHU_HSTD_Luu { get; set; }
        public virtual DbSet<PHU_HSTV_Luu> PHU_HSTV_Luu { get; set; }
        public virtual DbSet<SMS_admintoDN> SMS_admintoDN { get; set; }
        public virtual DbSet<UserWeb> UserWebs { get; set; }
        public virtual DbSet<UserWeb_PhanQuyen> UserWeb_PhanQuyen { get; set; }
        public virtual DbSet<VBPQ_DonVi> VBPQ_DonVi { get; set; }
        public virtual DbSet<VBPQ_LoaiTaiLieu> VBPQ_LoaiTaiLieu { get; set; }
        public virtual DbSet<VBPQ_TaiLieu> VBPQ_TaiLieu { get; set; }
        public virtual DbSet<DM_DiaChi> DM_DiaChi { get; set; }
        public virtual DbSet<DoanhNghiep_TuyenDung_CongVan_List_2023> DoanhNghiep_TuyenDung_CongVan_List_2023 { get; set; }
        public virtual DbSet<loaihoso> loaihosoes { get; set; }
        public virtual DbSet<NewsStatu> NewsStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_ChucDanh>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DonViDaoTao>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<DM_DonViDaoTao>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<DM_KhuCongNghiep>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LoaiHinhDoanhNghiep>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LoaiTinhTrang>()
                .Property(e => e.LoaiTinhTrang_ID)
                .IsUnicode(false);

            modelBuilder.Entity<DM_LyDoNghiViec>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_NgheHoc>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_QuocGia>()
                .Property(e => e.QuocGia_NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_ThoiGianLamViec>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TinhTrangPheDuyetHoSo>()
                .Property(e => e.TinhTrangHoSo_NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DM_TrinhDoChuyenMon>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Skype)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.NguoiDaiDien_DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaSoThue)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.LoaiChuTheTuyenDung)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep>()
                .Property(e => e.MaChuTheTuyenDung)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.XoaHoSo)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.YeuCauNganhNghe_34_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.MongMuonDN_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung>()
                .Property(e => e.YeuCauThem_2022)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023>()
                .Property(e => e.ThoiGianTu)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_LaoDongNuocNgoai_ThoiGianLamViec2023>()
                .Property(e => e.ThoiGianDen)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaVach)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoGiayPhepLaiXe)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.HangGPLX)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoBHXH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Sotaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Skype)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Facebook)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_KinhNghiem_LamViec_2022>()
                .Property(e => e.TuThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_KinhNghiem_LamViec_2022>()
                .Property(e => e.DenThang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.DiemHoSo)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.NganhNghe34_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.MucLuong_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.KhaNangDapUng_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam>()
                .Property(e => e.SanSangLamViec_2022)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TimViecLam_FileDinhKem>()
                .Property(e => e.NguoiUpload)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang_TrinhDo>()
                .Property(e => e.NguoiTao)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.msrepl_tran_version1)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien_TaiKhoan>()
                .Property(e => e.TenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien_TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.GuiId)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.SoCongVan)
                .IsUnicode(false);

            modelBuilder.Entity<DoanhNghiep_TuyenDung_CongVan_List_2023>()
                .Property(e => e.NgayCongVan)
                .IsUnicode(false);

            modelBuilder.Entity<loaihoso>()
                .Property(e => e.nguoitao)
                .IsUnicode(false);
        }
    }
}
