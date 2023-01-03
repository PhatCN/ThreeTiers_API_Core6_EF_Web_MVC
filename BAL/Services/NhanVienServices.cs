using BLL.Services.Contracts;
using DAL.Models;
using DAL.Reponsitories.Contracts;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private readonly IGenericReponsitory<Nhanvien> _reponsitory;
        public NhanVienServices(IGenericReponsitory<Nhanvien> reponsitory)
        {
            _reponsitory= reponsitory;
        }

        public async Task<List<Nhanvien>> GetNhanviens()
        {
            try
            {
                return await _reponsitory.GetNhanVien();
            }
            catch 
            { 
                throw new NotImplementedException(); 
            }
            
        }
    }
}
