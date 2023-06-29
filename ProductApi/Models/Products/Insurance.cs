using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Insurance(Pricing Prices) : Product(Prices);