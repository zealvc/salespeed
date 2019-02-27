using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public long Id { get; set; }
        public string Role1 { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
