using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record MaterialProduct(Pricing Prices, Recurrency Recurrency) : Product(Prices, Recurrency);