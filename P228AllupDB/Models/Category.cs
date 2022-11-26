using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P228AllupDB.Models
{
    public class Category : BaseEntity
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public Nullable<int> ParentId { get; set; }
        public bool IsManin { get; set; }
        public Category Parent { get; set; }
        public IEnumerable<Category> Children { get; set; }
    }
}
