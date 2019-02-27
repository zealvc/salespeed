using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class ActivityReservation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long ActivityId { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        public int Infant { get; set; }
        public DateTime? Date { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? RefundPaid { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string Status { get; set; }
        public long? LanguageId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Language Language { get; set; }
        public virtual User User { get; set; }
    }
}
