using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Course(Pricing Prices) : Product(Prices);