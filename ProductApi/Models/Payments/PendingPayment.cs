namespace ProductApi.Models.Payments;

public record PendingPayment(DateTime CreatedAt, int ValueInCents) : Payment(ValueInCents);