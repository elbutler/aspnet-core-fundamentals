﻿using System.ComponentModel.DataAnnotations;

namespace SimpleCrm
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required()]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required()]
        public string LastName { get; set; }
        [MinLength(7), MaxLength(12)]
        public string PhoneNumber { get; set; }
        public bool OptInNewsletter { get; set; }
        public CustomerType Type { get; set; }
    }
}
