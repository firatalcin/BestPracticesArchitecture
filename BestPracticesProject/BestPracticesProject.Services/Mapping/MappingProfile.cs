using AutoMapper;
using BestPracticesProject.Repositories.Products;
using BestPracticesProject.Services.Products;
using BestPracticesProject.Services.Products.Create;
using BestPracticesProject.Services.Products.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<CreateProductRequest, Product>().ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));

            CreateMap<UpdateProductRequest, Product>().ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name.ToLowerInvariant()));
        }
    }
}
