using AutoMapper;
using BestPracticesProject.Repositories;
using BestPracticesProject.Repositories.Categories;
using BestPracticesProject.Services.Categories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Categories
{
    public class CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
         : ICategoryService
    {
        public Task<ServiceResult> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<List<CategoryDto>>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<CategoryDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<CategoryWithProductsDto>> GetCategoryWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<List<CategoryWithProductsDto>>> GetCategoryWithProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
