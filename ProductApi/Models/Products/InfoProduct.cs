using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record InfoProduct(
    ProductType Category,
    Pricing Pricing,
    Recurrency Recurrency) : Product(Category, Pricing, Recurrency);