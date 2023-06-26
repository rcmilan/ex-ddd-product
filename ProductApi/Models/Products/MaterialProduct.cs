using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record MaterialProduct(
    ProductType Category,
    Pricing Pricing,
    Recurrency Recurrency) : Product(Category, Pricing, Recurrency);