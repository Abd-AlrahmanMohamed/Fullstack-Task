namespace CQRSWebApi.Controllers.ManfacturingControllers
{
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(Router.Product.GetProductById)]
        public async ValueTask<Product> GetByIdAsync(int id)
        {
            var order = new GetProductByIdQuery(id);
            return await _mediator.Send(order);
        }

        [HttpGet(Router.Product.GetAllProducts)]
        public async ValueTask<IEnumerable<Product>> GetAllAsync()
        {
            var order = new GetAllProductsQuery();
            return await _mediator.Send(order);
        }
       
        [HttpPost(Router.Product.AddProduct)]
        public async ValueTask<Product> AddAsync([FromForm] ProductDto productDto)
        {
            var order = new AddProductCommand(productDto);
            return await _mediator.Send(order);
        }
        [HttpPut(Router.Product.UpdateProduct)]

        public async ValueTask<Product> UpdateAsync([FromForm] ProductDto productDto)
        {
            var order = new UpdateProductCommand(productDto);
            return await _mediator.Send(order);
        }
        [HttpDelete(Router.Product.DeleteProduct)]

        public async ValueTask<Product> DeleteAsync(int id, ProductDto orderDto)
        {
            var order = new DeleteProductCommand(id);
            return await _mediator.Send(order);
        }
    }
}
