namespace InventoryApi.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}