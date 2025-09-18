using Handler.MediatorHandler.MediatorCommand.Products;

namespace Handler.Extensions
{
    public static class AddValidators
    {
        public static void Validators(this IServiceCollection services)
        {


            //Product
            services.AddValidatorsFromAssembly(typeof(AddProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteProductCommand).Assembly);


        }

    }
}
