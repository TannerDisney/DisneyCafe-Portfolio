using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Models
{
    public class ContactForm
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "That doesn't look like an Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(2500)]
        public string Body { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Maximum Character Limit is 50")]
        public string Subject { get; set; }
    }
}
