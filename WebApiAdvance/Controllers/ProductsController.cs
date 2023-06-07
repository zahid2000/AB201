﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiAdvance.Core.DAL.Repositories.Abstracts;
using WebApiAdvance.DAL.Repositories.Abstracts;
using WebApiAdvance.DAL.UnitOfWork.Abstracts;
using WebApiAdvance.Entities;
using WebApiAdvance.Entities.Dtos.Products;

namespace WebApiAdvance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProductDto>>> GetProducts()
        {
            if (await _unitOfWork.ProductRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var result = await _unitOfWork.ProductRepository.GetAllAsync(includes:"Brand");
            List<GetProductDto> getProductDtos = _mapper.Map<List<GetProductDto>>(result);

            return getProductDtos;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductDto>> GetProduct(int id)
        {
            if (await _unitOfWork.ProductRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            GetProductDto result = _mapper.Map<GetProductDto>(product);
            return result;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, UpdateProductDto productdto)
        {
            if (! await ProductExists(id))
            {
                return NotFound();
            }
            Product product = _mapper.Map<Product>(productdto);
            product.ProductCode = "TEst";
             _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> PostProduct([FromBody] CreateProductDto productdto)
        {
            Product product = _mapper.Map<Product>(productdto);
            product.Created = DateTime.UtcNow;
            product.ProductCode = product.Name.Substring(0, 2);
            await _unitOfWork.ProductRepository.AddAsync(product);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if ( await _unitOfWork.ProductRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

             _unitOfWork.ProductRepository.Delete(product);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        private async Task<bool> ProductExists(int id)
        {
            return await _unitOfWork.ProductRepository.IsExistsAsync(p=>p.Id==id);
        }
    }
}
