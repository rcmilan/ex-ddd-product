using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Accommodation(Pricing Prices) : Product(Prices);