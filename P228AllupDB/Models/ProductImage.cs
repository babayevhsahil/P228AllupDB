using System.ComponentModel.DataAnnotations;

namespace P228AllupDB.Models
{
    public class ProductImage : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
