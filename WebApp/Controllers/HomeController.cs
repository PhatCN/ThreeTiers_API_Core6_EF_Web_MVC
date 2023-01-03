using BLL.Services.Contracts;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INhanVienServices _nhanVienServices;

        public HomeController(ILogger<HomeController> logger, INhanVienServices nhanVienServices)
        {
            _logger = logger;
            _nhanVienServices= nhanVienServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> ListNhanVien()
        {
            List<Nhanvien> listNhanVien = await _nhanVienServices.GetNhanviens();
            return View(listNhanVien);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}