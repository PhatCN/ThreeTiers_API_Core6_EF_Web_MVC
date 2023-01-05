using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reponsitories.Contracts
{
    public interface IGenericReponsitory<TModel> where TModel : class
    {
        Task<List<TModel>> GetNhanVien();
        void CreateNhanVien(TModel model);
        void UpdateNhanVien(TModel model);
        void DeleteNhanVien(string id);
        Task<TModel> DetailsNhanVien(string? id);
    }
}
