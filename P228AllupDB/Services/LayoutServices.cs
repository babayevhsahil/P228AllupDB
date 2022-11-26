using Microsoft.EntityFrameworkCore;
using P228AllupDB.DAL;
using P228AllupDB.Interfaces;
using P228AllupDB.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228AllupDB.Services
{
    public class LayoutServices : ILayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Dictionary<string,string>> GetSettingAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s=>s.Key,s=>s.Value);
        }
    }
}
