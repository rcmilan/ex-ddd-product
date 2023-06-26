using ProductApi.Models.Enum;
using ProductApi.Models.Products;

namespace ProductApi.DataTransferObjects
{
    public class UniqueOfferDto
    {
        public ProductType Category { get; set; }

        public int ValueInCents { get; set; }

        public static implicit operator UniqueOfferDto(Product p) => new()
        {
            Category = p.Category,
            ValueInCents = p.Prices.First().ValueInCents,
        };
    }
}