using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public class StorageEntity : BaseEntity
{
    [Required]
    public string StorageCode { get; set; }

    [Required]
    public DateTime LastUpdate { get; set; }

    [Required]
    public int PartialQuantity { get; set; }

    public int ProductId { get; set; }

    public ProductEntity Product { get; set; }

    public int WarehouseId { get; set; }

    public WarehouseEntity Warehouse { get; set; }

    public ICollection<InOutEntity> InOuts { get; set; }
}