using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record Lesson(Pricing Prices) : Product(Prices);