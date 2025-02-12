using Inventory.DataAccess;
using Inventory.Models;
using Inventory.Services.Interfaces;

namespace Inventory.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity, new()
    {
        //Usamos virtual para que, en caso de ser necesario, podamos hacer un override en las clases derivadas
        public virtual List<T> List()
        {
            using var context = new InventoryContext();
            return context.Set<T>().ToList();   //Set<T>() crea un  DbSet de tipo T
        }

        public virtual void Create(T objectInstance)
        {
            using (var context = new InventoryContext())
            {
                context.Set<T>().Add(objectInstance); //Set<T>() crea un  DbSet de tipo T
                context.SaveChanges();
            }
        }

        public virtual void Update(T objectInstance)
        {
            using (var context = new InventoryContext())
            {
                context.Set<T>().Update(objectInstance); //Set<T>() crea un  DbSet de tipo T
                context.SaveChanges();
            };
        }

        public virtual void Delete(T objectInstance)
        {
            using (var context = new InventoryContext())
            {
                context.Set<T>().Remove(objectInstance);
                context.SaveChanges();
            };
        }
    }
}