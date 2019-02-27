using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Type
    {
        public Type()
        {
            User = new HashSet<User>();
        }

        public long Id { get; set; }
        public string Type1 { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
