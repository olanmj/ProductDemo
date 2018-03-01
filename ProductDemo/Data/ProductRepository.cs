using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductDemo.Models;

namespace ProductDemo.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.Include(p => p.Company)
                .SingleOrDefaultAsync(m => m.ProductID == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Include(p => p.Company).ToListAsync();
        }
    }
}
