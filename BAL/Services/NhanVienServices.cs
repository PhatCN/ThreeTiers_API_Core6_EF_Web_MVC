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

        public void CreateNhanVien(Nhanvien nhanvien)
        {
            try
            {
                _reponsitory.CreateNhanVien(nhanvien);
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }

        public void DeleteNhanVien(string id)
        {
            try
            {
                _reponsitory.DeleteNhanVien(id);
            }
            catch
            {
                throw;
            }
        }

        public Task<Nhanvien> Details(string id)
        {
            try
            {
               return _reponsitory.DetailsNhanVien(id);
            }
            catch(Exception ex)
            {
                throw;
            }

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

        public void UpdateNhanVien(Nhanvien nhanvien)
        {
            try
            {
                _reponsitory.UpdateNhanVien(nhanvien);
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
