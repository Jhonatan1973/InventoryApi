using System.ComponentModel.DataAnnotations;


namespace InventoryApi.Entities
{
    public class Product
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        public string? Description { get; set; }


        public string? Sku { get; set; }


        public int Quantity { get; set; }


        public decimal Price { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public DateTime? UpdatedAt { get; set; }
    }
}