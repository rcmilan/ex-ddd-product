namespace ProductApi.Models.Prices;

public record PricingRange(int From, int To, int ValueInCents) : Pricing(ValueInCents);