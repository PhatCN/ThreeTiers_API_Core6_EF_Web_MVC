using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.DataContext;
using DAL.Reponsitories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DAL.Reponsitories
{
    public class Reponsitory<TModel> : IGenericReponsitory<TModel> where TModel : class
    {
        private readonly test_3_tier_core_6Context _context;
        public Reponsitory(test_3_tier_core_6Context context) 
        { 
            _context= context;
        }

        public void CreateNhanVien(TModel model)
        {
            try
            {
                _context.Set<TModel>().Add(model);
                _context.SaveChanges();
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
                var nv = _context.Set<TModel>().Find(id);
                _context.Set<TModel>().Remove(nv);
                _context.SaveChanges();
            }
            catch 
            { 
                throw; 
            }

        }

        public async Task<TModel> DetailsNhanVien(string? id)
        {
            try
            {
                    return await _context.Set<TModel>().FindAsync(id);
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<List<TModel>> GetNhanVien()
        {
            try
            {
               return await _context.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw new NotImplementedException();
            }
            
        }

        public void UpdateNhanVien(TModel model)
        {
            try
            {
                _context.Set<TModel>().Update(model);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
