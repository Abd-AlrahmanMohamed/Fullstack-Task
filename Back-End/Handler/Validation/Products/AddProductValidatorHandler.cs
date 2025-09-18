using Handler.MediatorHandler.MediatorCommand.Products;

namespace Handler.Validation.Products
{
    public class AddProductValidatorHandler : AbstractValidator<AddProductCommand>
    {
        public AddProductValidatorHandler()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ProductCode).NotEmpty();
            RuleFor(p => p.Image).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.MinimumQuantity).NotNull().NotEmpty();
            RuleFor(p => p.DiscountRate).NotNull().NotEmpty();
            RuleFor(p => p.Category).NotNull().NotEmpty();
        }
    }
}
