using Microsoft.EntityFrameworkCore;
using WebApiAdvance.DAL.EfCore;
using WebApiAdvance.DAL.Repositories.Abstracts;
using WebApiAdvance.DAL.Repositories.Concretes.EFCore;
using WebApiAdvance.DAL.UnitOfWork.Abstracts;

namespace WebApiAdvance.DAL.UnitOfWork.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext? _appDbContext;
        private IProductRepository _productRepository;
        private IBrandRepository _brandRepository;
        public UnitOfWork(AppDbContext? appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IProductRepository ProductRepository => _productRepository = _productRepository ?? new EFProductRepository(_appDbContext);

        public IBrandRepository BrandRepository => _brandRepository=_brandRepository?? new EFBrandRepository(_appDbContext);

        public async Task SaveAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
