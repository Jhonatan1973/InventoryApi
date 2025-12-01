using InventoryApi.Entities;


namespace InventoryApi.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task AddAsync(Product product);
        void Update(Product product);
        void Remove(Product product);
        Task<bool> SaveChangesAsync();
    }
}