using BLL.Services.Contracts;
using DAL.DataContext;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INhanVienServices _nhanVienServices;
        private readonly test_3_tier_core_6Context _context;

        public HomeController(ILogger<HomeController> logger, INhanVienServices nhanVienServices,test_3_tier_core_6Context context)
        {
            _logger = logger;
            _nhanVienServices= nhanVienServices;
            _context= context;
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

            //List<Nhanvien> listNhanVien = await _context.Nhanviens.ToListAsync();
            return View(listNhanVien);
        }
        [HttpGet]
        public IActionResult ShowCreate()
        {
            return View(new Nhanvien());
        }
        [HttpPost]
        public  IActionResult Create(Nhanvien nhanvien)
        {
            _nhanVienServices.CreateNhanVien(nhanvien);
            return RedirectToAction("Listnhanvien","Home");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}