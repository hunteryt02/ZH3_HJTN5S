using System;
using System.Collections.Generic;

namespace ZH3_HJTN5S.Models;

public partial class Categories
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Products> Products { get; } = new List<Products>();
}
