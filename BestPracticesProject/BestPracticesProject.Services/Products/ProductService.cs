﻿using BestPracticesProject.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Services.Products
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
    }
}
