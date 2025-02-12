using Inventory.Models;

namespace Inventory.Services.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity, new()
    {
        public List<T> List(); //Se regresa una lista con elementos de tipo T

        //public T Get(int T); //Se regresa un elemento de tipo T

        public void Create(T objectInstance); //Se acepta un objeto de tipo T

        public void Update(T objectInstance); //Se acepta un objeto de tipo T

        public void Delete(T objectInstance); //Se acepta un objeto de tipo T
    }
}