using AutoMapper;
using InventoryApi.DTOs;
using InventoryApi.Entities;
using InventoryApi.Repositories;


namespace InventoryApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;


        public ProductService(IProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        public async Task<ProductDto> CreateAsync(ProductCreateDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _repo.AddAsync(product);
            await _repo.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }


        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return false;
            _repo.Remove(existing);
            return await _repo.SaveChangesAsync();
        }


        public async Task<List<ProductDto>> GetAllAsync()
        {
            var list = await _repo.GetAllAsync();
            return _mapper.Map<List<ProductDto>>(list);
        }


        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null) return null;
            return _mapper.Map<ProductDto>(entity);
        }


        public async Task<bool> UpdateAsync(int id, ProductUpdateDto dto)
        {
            var existing = await _repo.GetByIdAsync(id);
            if (existing == null) return false;
            _mapper.Map(dto, existing);
            existing.UpdatedAt = DateTime.UtcNow;
            _repo.Update(existing);
            return await _repo.SaveChangesAsync();
        }
    }
}