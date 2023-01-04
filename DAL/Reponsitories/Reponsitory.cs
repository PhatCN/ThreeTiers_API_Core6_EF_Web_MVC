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

        public Task<TModel> CreateNhanVien()
        {
            throw new NotImplementedException();
        }

        public async Task<List<TModel>> GetNhanVien()
        {
            try
            {
                return await _context.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }           
        }
    }
}
