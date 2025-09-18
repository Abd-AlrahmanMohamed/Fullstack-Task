namespace Handler.MediatorHandler.MediatorCommand.Products
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
