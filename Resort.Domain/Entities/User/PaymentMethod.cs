using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class PaymentMethod
    {
        public long UserId { get; set; }
        public int CardNumber { get; set; }
        public long CardTypeId { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuingBank { get; set; }

        public virtual CardType CardType { get; set; }
        public virtual User User { get; set; }
    }
}
