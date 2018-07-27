using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace webBookReservation2.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int BookISBN { get; set; }
        public int StudentId { get; set; }
        public string Doyoureserve { get; set; }
        public string Date { get; set; }

        public virtual Book Book { get; set; }
    }
}