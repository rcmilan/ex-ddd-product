﻿using ProductApi.Models.Prices;

namespace ProductApi.Models.Products;

public abstract record Product(Pricing Prices);