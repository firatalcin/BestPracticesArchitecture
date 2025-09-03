using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Products.UpdateStock
{
    public record UpdateProductStockRequest(int ProductId, int Quantity);
}
