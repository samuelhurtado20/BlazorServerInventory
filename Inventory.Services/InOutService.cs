using Inventory.DataAccess;
using Inventory.Models;

namespace Inventory.Services;

public class InOutService : ServiceBase<InOutEntity>
{
    public InOutEntity Get(int id)
    {
        using var context = new InventoryContext();
        return context.InOuts.Find(id) ?? new InOutEntity();
    }
}