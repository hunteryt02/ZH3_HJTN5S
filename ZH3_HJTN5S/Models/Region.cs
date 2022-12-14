using System;
using System.Collections.Generic;

namespace ZH3_HJTN5S.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territories> Territories { get; } = new List<Territories>();
}
