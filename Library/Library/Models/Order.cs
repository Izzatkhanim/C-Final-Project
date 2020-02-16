using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [Required]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public bool IsDone { get; set; }
                
        public DateTime? ReturnDate { get; set; }

        public decimal? ReturnPrice { get; set; }

        public Client Client { get; set; }
        public Book Book { get; set; }
    }
}
