using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockDatabase
{
    [Table("Reservation")]
    public class Reservation
    {
        [Required]
        public string HotelId { get; set; }
        [Required]
        public string ReservationNo { get; set; }
        [Required]
        public string ReservationBy { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string CheckInDate { get; set; }
        [Required]
        public string CreateDate { get; set; }
    }
}
