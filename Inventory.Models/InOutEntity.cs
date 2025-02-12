using System.ComponentModel.DataAnnotations;

namespace Inventory.Models;

public class InOutEntity : BaseEntity
{
    [Required]
    public DateTime InOutDate { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public bool IsInput { get; set; }

    public int StorageId { get; set; }

    public StorageEntity Storage { get; set; }
}