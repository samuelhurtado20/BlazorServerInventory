using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public class ProductEntity : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string ProductCode { get; set; }

    [Required]
    [StringLength(100)]
    public string ProductName { get; set; }

    [StringLength(600)]
    public string ProductDescription { get; set; }

    [Required]
    public decimal ProductTotalQuantity { get; set; }

    [Required]
    public int CategoryId { get; set; }

    public CategoryEntity Category { get; set; }

    public ICollection<StorageEntity> Storages { get; set; }
}