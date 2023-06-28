using ProductApi.Models.Prices;
using ProductApi.Models.Products;

namespace ProductApi.DataTransferObjects
{
    public record UniqueOfferDto(int ValueInCents = 0)
    {
        public int ValueInCents { get; private set; } = ValueInCents;

        public static implicit operator UniqueOfferDto(Product p) => p.Prices switch
        {
            FixedPrice fp => new(fp.ValueInCents),
            _ => new(),
        };
    }
}