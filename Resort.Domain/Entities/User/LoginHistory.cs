using System;
using System.Collections.Generic;
using System.Net;

namespace Resort.Domain.Entities
{
    public partial class LoginHistory
    {
        public long UserId { get; set; }
        public string Browser { get; set; }
        public string Device { get; set; }
        public ValueTuple<IPAddress, int>? Ip { get; set; }
        public DateTime? Date { get; set; }
        public string RecentActivity { get; set; }
        public int? NumberOfLoginPerDay { get; set; }

        public virtual User User { get; set; }
    }
}
