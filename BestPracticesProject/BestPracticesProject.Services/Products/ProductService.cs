using BestPracticesProject.Repositories;
using BestPracticesProject.Repositories.Products;
using BestPracticesProject.Services.Products.Create;
using BestPracticesProject.Services.Products.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Products
{
    public class ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork) : IProductService
    {
        public Task<ServiceResult<CreateProductResponse>> CreateAsync(CreateProductRequest request)
        {
            throw new NotImplementedException();
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

        public Task<ServiceResult<List<ProductDto>>> GetPagedAllListAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
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
