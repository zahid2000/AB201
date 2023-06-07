using WebApiAdvance.Core.DAL.Repositories.Concretes.EFCore;
using WebApiAdvance.DAL.EfCore;
using WebApiAdvance.DAL.Repositories.Abstracts;
using WebApiAdvance.Entities;

namespace WebApiAdvance.DAL.Repositories.Concretes.EFCore;

public class EFProductRepository :EFBaseRepository<Product,AppDbContext>, IProductRepository
{
    public EFProductRepository(AppDbContext context):base(context)
    {        
    }

    public async Task<Product> GetByName(string name)
    {
        return new Product();
    }
}
