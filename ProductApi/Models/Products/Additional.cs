using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Additional(Pricing Prices) : Product(Prices);