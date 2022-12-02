using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P228AllupDB.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
