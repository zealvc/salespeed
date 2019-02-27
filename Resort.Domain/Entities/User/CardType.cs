using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class CardType
    {
        public CardType()
        {
            PaymentMethod = new HashSet<PaymentMethod>();
        }

        public long Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethod { get; set; }
    }
}
