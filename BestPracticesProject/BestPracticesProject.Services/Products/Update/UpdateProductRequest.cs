using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Products.Update
{
    public record UpdateProductRequest(string Name, decimal Price, int Stock, int CategoryId);
}
