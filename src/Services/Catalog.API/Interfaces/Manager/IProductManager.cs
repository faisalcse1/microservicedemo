using Catalog.API.Models;
using MongoRepo.Interfaces.Manager;

namespace Catalog.API.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {
        public List<Product> GetByCategory(string category);
    }
}
