using InventoryApi.Data;
using InventoryApi.Entities;
using Microsoft.EntityFrameworkCore;


namespace InventoryApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;


        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }


        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }


        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }


        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }


        public void Update(Product product)
        {
            _context.Products.Update(product);
        }


        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}