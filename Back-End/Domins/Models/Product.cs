namespace Domin.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Category { get; set; } =string.Empty;
        public string? Image { get; set; }
		public int ProductCode { get; set; }
		public int MinimumQuantity { get; set; }
		public int DiscountRate { get; set; }
		public double Price { get; set; }

    }
}
