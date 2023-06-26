namespace ProductApi.Models.Prices;

public record PriceRange<T>(T From, T To, int ValueInCents) : Pricing(ValueInCents);