using Inventory.DataAccess;
using Inventory.Models;

namespace Inventory.Services;

public class CategoryService : ServiceBase<CategoryEntity>
{
    public CategoryEntity Get(int id)
    {
        using var context = new InventoryContext();
        return context.Categories.Find(id) ?? new CategoryEntity();
    }
}