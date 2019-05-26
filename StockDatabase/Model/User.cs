using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockDatabase
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Psd { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return "User";
        }
    }
}
