using WebApiAdvance.Core.DAL.Repositories.Concretes.EFCore;
using WebApiAdvance.DAL.EfCore;
using WebApiAdvance.DAL.Repositories.Abstracts;
using WebApiAdvance.Entities;

namespace WebApiAdvance.DAL.Repositories.Concretes.EFCore
{
    public class EFBrandRepository : EFBaseRepository<Brand, AppDbContext>, IBrandRepository
    {
        public EFBrandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
