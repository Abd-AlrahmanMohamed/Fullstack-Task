namespace Handler
{
    public static class HandlerDependencies
    {
        public static IServiceCollection AddHandlerDependencie(this IServiceCollection services) {

            //services.RegisterHandlers();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(MediatorRequest<,>));

            services.Validators();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
