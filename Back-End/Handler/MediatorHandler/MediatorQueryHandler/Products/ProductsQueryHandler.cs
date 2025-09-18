namespace Handler.MediatorHandler.MediatorQueryHandler.Categories
{
    public class ProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>,
        IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IUnityOfWork _unityOfWork;

        public ProductsQueryHandler(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Product>().GetAllAsync();
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unityOfWork.Repository<Product>().GetByidAsync(request.Id);
        }

	}
}
