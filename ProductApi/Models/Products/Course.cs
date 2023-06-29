using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Course : Product
{
    public Course(PricingCollection Prices) : base(Prices)
    {
    }
}