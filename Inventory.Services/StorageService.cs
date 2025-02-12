using Inventory.DataAccess;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Services;

public class StorageService : ServiceBase<StorageEntity>
{
    public StorageEntity Get(int id)
    {
        using var context = new InventoryContext();
        return context.Storages.Find(id) ?? new StorageEntity();
    }

    public bool GetByCode(string code)
    {
        using var context = new InventoryContext();
        var result = context.Storages.Where(x => x.StorageCode == code);
        return result.Any();
    }

    public List<StorageEntity> GetProductsByWarehouse(int warehouseId)
    {
        using var context = new InventoryContext();
        var result = context.Storages
            .Include(x => x.Product)
            .Where(x => x.WarehouseId == warehouseId);
        return result.ToList();
    }
}