namespace ProductApi.Models.Prices;

public record PriceRange(int From, int To, int ValueInCents) : Pricing(ValueInCents);