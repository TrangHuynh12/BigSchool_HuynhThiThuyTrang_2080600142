using System.ComponentModel.DataAnnotations;

namespace HuynhThiThuyTrang_2080600142.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}