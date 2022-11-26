using P228AllupDB.Models;
using System.Collections.Generic;

namespace P228AllupDB.ViewsModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
