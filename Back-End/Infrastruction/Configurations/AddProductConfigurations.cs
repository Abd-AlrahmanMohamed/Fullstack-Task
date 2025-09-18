
namespace Infrastructure.Configurations
{
    public class AddProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Image)
                .IsRequired();
            builder
                .Property(p => p.Price)
                .IsRequired();
        

        }
    }
}
