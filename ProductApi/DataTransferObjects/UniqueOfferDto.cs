using ProductApi.Models.Products;

namespace ProductApi.DataTransferObjects
{
    public class UniqueOfferDto
    {
        public int ValueInCents { get; set; }

        public static implicit operator UniqueOfferDto(Product p) => new()
        {
            ValueInCents = p.Prices.First().ValueInCents,
        };
    }
}