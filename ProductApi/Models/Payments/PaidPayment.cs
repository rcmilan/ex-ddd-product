namespace ProductApi.Models.Payments;

public record PaidPayment(DateTime PaidAt, int ValueInCents) : Payment(ValueInCents);