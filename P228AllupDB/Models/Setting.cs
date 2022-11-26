using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P228AllupDB.Models

{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string Key { get; set; }
        [StringLength(2500)]
        public string Value { get; set; }
    }
}
