namespace Handler.MediatorHandler.MediatorCommand.Products
{
    public class AddProductCommand : IRequest<Product>
    {
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public IFormFile Image { get; set; }
		public int ProductCode { get; set; }
		public int MinimumQuantity { get; set; }
		public int DiscountRate { get; set; }
		public double Price { get; set; }
		public string Category { get; set; }

		public AddProductCommand( ProductDto productDto)
        {
			Id = productDto.Id;
			Name = productDto.Name;
			Image = productDto.Image;
			ProductCode = productDto.ProductCode;
			MinimumQuantity = productDto.MinimumQuantity;
			DiscountRate = productDto.DiscountRate;
			Price = productDto.Price;
			Category = productDto.Category;
        }
    }
}
