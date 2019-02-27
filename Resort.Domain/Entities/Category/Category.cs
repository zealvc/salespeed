using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Category
    {
        public Category()
        {
            Accommodation = new HashSet<Accommodation>();
            Activity = new HashSet<Activity>();
            Restaurant = new HashSet<Restaurant>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modify { get; set; }
        public string Status { get; set; }
        public long LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual ICollection<Accommodation> Accommodation { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
