using System;
using System.Collections.Generic;

namespace Resort.Domain.Entities
{
    public partial class AccommodationReservation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AccommodationId { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        public int Infant { get; set; }
        public int NumberOfNight { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? RefundPaid { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string Status { get; set; }
        public long? LanguageId { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual Language Language { get; set; }
        public virtual User User { get; set; }
    }
}
