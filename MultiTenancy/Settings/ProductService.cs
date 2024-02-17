﻿
using Microsoft.EntityFrameworkCore;

namespace MultiTenancy.Settings
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreatedAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            return _context.Products.FindAsync(id);
        }
    }
}