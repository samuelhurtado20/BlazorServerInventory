using Inventory.DataAccess;
using Inventory.Models;

namespace Inventory.Services;

public class WarehouseService : ServiceBase<WarehouseEntity>
{
    public WarehouseEntity Get(int id)
    {
        using var context = new InventoryContext();
        return context.Warehouses.Find(id) ?? new WarehouseEntity();
    }
}