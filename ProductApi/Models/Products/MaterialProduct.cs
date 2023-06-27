using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record MaterialProduct(PricingCollection<Pricing> Prices, Recurrency Recurrency) : Product(Prices, Recurrency);