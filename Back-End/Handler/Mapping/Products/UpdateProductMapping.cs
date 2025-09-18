using Handler.MediatorHandler.MediatorCommand.Products;

namespace Handler.Mapping.Products
{
    public class UpdateProductMapping : Profile
    {
        public UpdateProductMapping()
        {
            CreateMap<UpdateProductCommand, Product>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
				.ForMember(dest => dest.MinimumQuantity, opt => opt.MapFrom(src => src.MinimumQuantity))
				.ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
				.ForMember(dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode))
				.ForMember(dest => dest.DiscountRate, opt => opt.MapFrom(src => src.DiscountRate));
		}
    }
}
