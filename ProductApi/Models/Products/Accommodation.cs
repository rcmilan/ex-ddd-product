using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Accommodation : Product
{
    public Accommodation(PricingCollection Prices) : base(Prices)
    {
    }
}