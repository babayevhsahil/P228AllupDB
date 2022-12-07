using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228AllupDB.DAL;
using P228AllupDB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228AllupDB.ViewsModels.Home;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

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
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsManin == true).ToListAsync(),
                NewArrival = await _context.Products.Where(p => p.IsDeleted == false && p.IsNewArrival).ToListAsync(),
                BestSeller = await _context.Products.Where(p => p.IsDeleted == false && p.IsBestSeller).ToListAsync(),
                Featured = await _context.Products.Where(p => p.IsDeleted == false && p.IsFeatured).ToListAsync(),
            };

            return View(homeVM);
        }

        //public async Task<IActionResult> SahilSetCoockie()
        //{
        //    Product product = await _context.Products.FirstAsync();

        //    string pro = JsonConvert.SerializeObject(product);

        //    HttpContext.Response.Cookies.Append("basket", pro);

        //    return Ok();
        //}

        //public async Task<IActionResult> SahilGetCoockie()
        //{
        //   string pro = HttpContext.Request.Cookies["basket"];

        //    return Json(pro);
        //}

        //public async Task<IActionResult> SetSession()
        //{

        //    HttpContext.Session.SetString("P228", "My First Session");

        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> GetSession()
        //{

        //    //HttpContext.Session.GetString("P228");

        //    return Content(HttpContext.Session.GetString("P228")); 
        //}
    }
}
