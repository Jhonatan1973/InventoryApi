namespace InventoryApi.DTOs
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}