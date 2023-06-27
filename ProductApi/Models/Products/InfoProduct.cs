using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record InfoProduct(Pricing Prices, Recurrency Recurrency) : Product(Prices, Recurrency);