using System.Linq.Expressions;
using WebApiAdvance.Core.DAL.Repositories.Abstracts;
using WebApiAdvance.Entities;
using WebApiAdvance.Entities.Dtos.Products;

namespace WebApiAdvance.DAL.Repositories.Abstracts;

public interface IProductRepository:IRepository<Product>{
    Task<Product> GetByName(string name);

}
