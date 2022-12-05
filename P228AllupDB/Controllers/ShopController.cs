using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228AllupDB.DAL;
using P228AllupDB.Models;
using P228AllupDB.ViewsModels.Shop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228AllupDB.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context) 
        {
            _context = context;
        }

       public async Task<IActionResult> Search(int? id, string search)
        {
            IEnumerable<ProductListVM> products = await _context.Products
                .Where(
                p => id != null ? p.CategoryId == id : true &&
                p.Title.ToLower().Contains(search.ToLower()) ||
                p.Brand.Name.ToLower().Contains(search.ToLower()))
                .OrderByDescending(p=>p.Id).Take(5)
                .Select(x=> new ProductListVM
                {
                    Id= x.Id,
                    Title= x.Title,
                    Image = x.MainImage
                })
                .ToListAsync();

           

            return PartialView("_SearchPartial", products);
        }
    }
}
