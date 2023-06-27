using Microsoft.AspNetCore.Mvc;
using ProductApi.DataTransferObjects;
using ProductApi.Models.Enum;
using ProductApi.Models.Offers;
using ProductApi.Models.Prices;
using ProductApi.Models.Products;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var fixed1 = new Range<Pricing>
            {
                new FixedPrice(1000)
            };

            var fixed2 = new Range<Pricing>
            {
                new FixedPrice(00)
            };

            var priceRanges = new Range<Pricing>
            {
                new PricingRange(2, 10, 500),
                new PricingRange(11, 15, 400)
            };

            Product p1 = new InfoProduct(ProductType.OnlineCourse, fixed1, new Unique());
            Product p2 = new MaterialProduct(ProductType.Accommodation, priceRanges, new Unique());
            Product p3 = new InfoProduct(ProductType.OnlineCourse, fixed2, new Recurrent(Frequency.Monthly));

            var result = new ProductBundle().Concat(new[] { p1, p2, p3 });

            return Ok(result);
        }

        [HttpGet("DTO")]
        public IActionResult GetDto()
        {
            Product p1 = new InfoProduct(
                ProductType.OnlineCourse,
                new Range<Pricing> { new FixedPrice(1000) },
                new Unique());

            UniqueOfferDto result = p1;

            return Ok(result);
        }
    }
}