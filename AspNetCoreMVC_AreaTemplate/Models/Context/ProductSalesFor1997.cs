﻿using System;
using System.Collections.Generic;

namespace AspNetCoreMVC_AreaTemplate.Models.Context;

public partial class ProductSalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? ProductSales { get; set; }
}
