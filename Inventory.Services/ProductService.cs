using Inventory.DataAccess;
using Inventory.Models;

namespace Inventory.Services;

public class ProductService : ServiceBase<ProductEntity>
{
    public ProductEntity Get(int id)
    {
        using var context = new InventoryContext();
        return context.Products.Find(id) ?? new ProductEntity();
    }
}