using Exceptions;
using System;

namespace Domain
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ExpiryYear { get; set; }

        public override void Validate()
        {
            if (Price <= 0)
                throw new InvalidPriceException("Price must be greater than 0");

            if (ExpiryYear < DateTime.Now.Year)
                throw new InvalidExpiryYearException("Expiry year cannot be in past");
        }
    }
}
