using BestPracticesProject.Repositories;
using BestPracticesProject.Repositories.Products;
using BestPracticesProject.Services.Products.Create;
using BestPracticesProject.Services.Products.Update;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Products
{
    public class ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork) : IProductService
    {
        public async Task<ServiceResult<CreateProductResponse>> CreateAsync(CreateProductRequest request)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Stock = request.Stock
            };

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();
            return ServiceResult<CreateProductResponse>.SuccessAsCreated(new CreateProductResponse(product.Id),$"api/products/{product.Id}");
        }

        public Task<ServiceResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<List<ProductDto>>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<ProductDto?>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<List<ProductDto>>> GetPagedAllListAsync(int pageNumber, int pageSize)
        {
            var product = await productRepository.GetAll()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(p => new ProductDto(p.Id, p.Name, p.Price, p.Stock))
                .ToListAsync();

            return ServiceResult<List<ProductDto>>.Success(product);k
        }

        public Task<ServiceResult<List<ProductDto>>> GetTopPriceProductsAsync(int count)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> UpdateAsync(int id, UpdateProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
