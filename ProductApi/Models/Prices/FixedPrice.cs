namespace ProductApi.Models.Prices;

public record FixedPrice(int ValueInCents) : Pricing(ValueInCents);