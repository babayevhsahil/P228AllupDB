using P228AllupDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace P228AllupDB.Interfaces
{
    public interface ILayoutServices 
    {
        Task<Dictionary<string, string>> GetSettingAsync();
    }
}
