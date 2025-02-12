using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class CategoryEntity : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string CategoryCode { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}