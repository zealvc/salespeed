using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class RestaurantMenu
    {
        public long RestaurantId { get; set; }
        public long MenuId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
