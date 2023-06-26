using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public abstract record Product(
    ProductType Category,
    Pricing Pricing,
    Recurrency Recurrency);