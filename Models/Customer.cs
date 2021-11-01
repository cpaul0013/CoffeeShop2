using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChrisCafe.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(40)]
        public string fname { get; set; }


        [StringLength(40)]
        public string lname { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        public DateTime birthday { get; set; }

        public string FaveDrink { get; set; }

    }

}
