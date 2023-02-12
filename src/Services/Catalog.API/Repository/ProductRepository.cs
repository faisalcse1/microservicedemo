using Catalog.API.Context;
using Catalog.API.Interfaces.Repository;
using Catalog.API.Models;
using MongoRepo.Repository;

namespace Catalog.API.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository() : base(new CatalogDbContext())
        {
        }
    }
}
