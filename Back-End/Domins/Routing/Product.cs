namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class Product
        {
            private const string Prefix = Rule + "Product";
            public const string Get = Prefix;
            public const string GetProductById = Prefix + "/get-product-by-id";
            public const string GetAllProducts = Prefix + "/get-all-products";
            public const string AddProduct = Prefix + "/add-product";
            public const string UpdateProduct = Prefix + "/update-product";
            public const string DeleteProduct = Prefix + "/delete-product";
        }
    }
}
