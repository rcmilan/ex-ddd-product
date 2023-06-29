using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record AdditionalService(Pricing Prices) : Product(Prices);