using BestPracticesProject.Services.Products;
using BestPracticesProject.Services.Products.Create;
using BestPracticesProject.Services.Products.Update;
using Microsoft.AspNetCore.Mvc;

namespace BestPracticesProject.WebAPI.Controllers
{
    public class ProductsController(IProductService productService) : CustomBaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await productService.GetAllListAsync(););
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await productService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateProductRequest request)
        {
            return CreateActionResult(await productService.CreateAsync(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {
            return CreateActionResult(await productService.UpdateAsync(id, request));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await productService.DeleteAsync(id));
        }
    }
}
