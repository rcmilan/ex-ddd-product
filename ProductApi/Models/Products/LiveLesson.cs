using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record LiveLesson(Pricing Prices) : Product(Prices);