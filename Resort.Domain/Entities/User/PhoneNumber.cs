using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class PhoneNumber
    {
        public long UserId { get; set; }
        public string Phone { get; set; }

        public virtual User User { get; set; }
    }
}
