using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nhanvien
    {
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string MaNv { get; set; } = null!;
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string TenNv { get; set; } = null!;
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string? Sdt { get; set; }
        /// <summary>
        /// Tài khoản đăng nhập
        /// </summary>
        public string TaiKhoan { get; set; } = null!;
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string MatKhau { get; set; } = null!;
        /// <summary>
        /// Quyền sử dụng
        /// </summary>
        public int QuyenSd { get; set; }
    }
}
