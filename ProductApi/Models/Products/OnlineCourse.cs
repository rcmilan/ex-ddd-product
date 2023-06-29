using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public record OnlineCourse(Pricing Prices) : Product(Prices);