using Handler.MediatorHandler.MediatorCommand.Products;

 namespace Handler.MediatorHandler.MediatorCommandHndler.Products
{

	public class ProductCommandHandler : IRequestHandler<AddProductCommand, Product>,
		IRequestHandler<UpdateProductCommand, Product>, IRequestHandler<DeleteProductCommand, Product>
{
	private readonly IUnityOfWork _unityOfWork;
	private readonly IMapper _mapper;
	public ProductCommandHandler(IUnityOfWork unityOfWork, IMapper mapper)
	{
		_unityOfWork = unityOfWork;
		_mapper = mapper;
	}
	public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
	{
		var product = _mapper.Map<Product>(request);
		product.Image = await ImageHandler.ImageConverterAsync(request.Image);
		await _unityOfWork.Repository<Product>().AddAsync(product);
		await _unityOfWork.Complete();
		return product;
	}

	public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
	{
		var find = await _unityOfWork.Repository<Product>().GetByidAsync(request.Id);
		var product = _mapper.Map(request, find);
		product.Image = await ImageHandler.ImageConverterAsync(request.Image);
		await _unityOfWork.Repository<Product>().UpdateAsync(find);
		await _unityOfWork.Complete();
		return find;
	}
	public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
	{
		var find = await _unityOfWork.Repository<Product>().GetByidAsync(request.Id);
		await _unityOfWork.Repository<Product>().DeleteAsync(request.Id);
		await _unityOfWork.Complete();
		return find;
	}
}
}