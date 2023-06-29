using Microsoft.AspNetCore.Mvc;
using ProductApi.DataTransferObjects;
using ProductApi.Models.Bundles;
using ProductApi.Models.Prices;
using ProductApi.Models.Products;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var priceRanges = new PricingCollection
            {
                new PricingRange(2, 10, 500),
                new PricingRange(11, 15, 400)
            };

            Product p1 = new OnlineCourse(new FixedPrice(1000));
            Product p2 = new Course(priceRanges);
            Product p3 = new OnlineCourse(new NoPricing());

            var result = new ProductBundle { p1, p2, p3 };

            return Ok(result);
        }

        [HttpGet("DTO")]
        public IActionResult GetDto()
        {
            UniqueOfferDto result = new OnlineCourse(new FixedPrice(1000));

            return Ok(result);
        }
    }
}