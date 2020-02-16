using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
     public class Client
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public string Lastname { get; set; }


        [Required]
        public string Email { get; set; }


        [Required]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool Status { get; set; }
       
        public Book Book{ get; set; }
    }
}
