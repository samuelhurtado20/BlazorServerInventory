using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public class WarehouseEntity : BaseEntity
{
    [Required]
    [StringLength(100)]
    public string WarehouseName { get; set; }

    [Required]
    [StringLength(100)]
    public string WarehouseAddress { get; set; }
}