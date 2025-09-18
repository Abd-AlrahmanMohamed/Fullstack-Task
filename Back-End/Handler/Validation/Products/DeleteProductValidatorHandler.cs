using Handler.MediatorHandler.MediatorCommand.Products;

namespace Handler.Validation.Products
{
    public class DeleteProductValidatorHandler : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductValidatorHandler()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty();
        }
    }
}
