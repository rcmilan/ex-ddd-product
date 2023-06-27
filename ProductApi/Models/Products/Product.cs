using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public abstract record Product(
    PricingCollection<Pricing> Prices,
    Recurrency Recurrency);