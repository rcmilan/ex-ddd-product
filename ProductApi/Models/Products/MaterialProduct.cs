﻿using ProductApi.Models.Enum;
using ProductApi.Models.Prices;
using ProductApi.Models.Recurrencies;

namespace ProductApi.Models.Products;

public record MaterialProduct(
    ProductType Category,
    int Quantity,
    Range<Pricing> Prices,
    Recurrency Recurrency) : Product(Category, Prices, Recurrency);