using System;
using System.Collections.Generic;
using System.Text;

namespace StockDatabase
{
    public class Authentication
    {
        public string HotelId { get; set; }
        public string Mobile { get; set; }
        public string ReservationNo { get; set; }
        public string VerificationCode { get; set; }
        public DateTime Expiration { get; set; }
    }
}
