using BestPracticesProject.Services.Products;

namespace BestPracticesProject.Services.Categories.Dto
{
    public record CategoryWithProductsDto(int Id, string Name, List<ProductDto> Products);
}
