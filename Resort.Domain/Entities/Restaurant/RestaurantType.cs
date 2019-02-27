using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class RestaurantType
    {
        public RestaurantType()
        {
            Restaurant = new HashSet<Restaurant>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
