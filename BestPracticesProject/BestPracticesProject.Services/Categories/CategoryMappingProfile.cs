using AutoMapper;
using BestPracticesProject.Repositories.Categories;
using BestPracticesProject.Services.Categories.Create;
using BestPracticesProject.Services.Categories.Dto;
using BestPracticesProject.Services.Categories.Update;

namespace BestPracticesProject.Services.Categories
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<Category, CategoryWithProductsDto>().ReverseMap();

            CreateMap<CreateCategoryRequest, Category>().ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));

            CreateMap<UpdateCategoryRequest, Category>().ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));
        }
    }
}
