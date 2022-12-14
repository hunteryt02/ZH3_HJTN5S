﻿using System;
using System.Collections.Generic;

namespace ZH3_HJTN5S.Models;

public partial class Shippers
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Orders> Orders { get; } = new List<Orders>();
}
