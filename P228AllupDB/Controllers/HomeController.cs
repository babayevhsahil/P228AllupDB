using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228AllupDB.DAL;
using P228AllupDB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228AllupDB.ViewsModels.Home;

namespace P228AllupDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            //List<Setting> settings = _context.Settings.ToList();
            //ViewBag.Settings = settings;

            //List<Slider> sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c=>c.IsDeleted == false && c.IsManin == true).ToListAsync()
            };

            return View(homeVM);
        }
    }
}
