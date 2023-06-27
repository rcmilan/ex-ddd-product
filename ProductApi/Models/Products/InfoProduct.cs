using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record InfoProduct(
    ProductType Category,
    Range<Pricing> Prices,
    Recurrency Recurrency) : Product(Category, Prices, Recurrency);