using DisneyCafe.Models.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Models
{
    /// <summary>
    /// Customer shipment model
    /// </summary>
    public class CustomerInfomation
    {
        /// <summary>
        /// Auto-Incrementing Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Customer legal first name
        /// </summary>
        [Required]
        [Display(Name = "Legal First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer legal last name
        /// </summary>
        [Required]
        [Display(Name = "Legal Last Name")]
        public string LastName { get; set }

        /// <summary>
        /// Customer shipping/mailing address
        /// </summary>
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Customers city of residence
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Customers state of residence
        /// </summary>
        [Required]
        public string State { get; set; }

        /// <summary>
        /// Customers Phone Number
        /// </summary>
        [Required(ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Phone Number ex.(555)555-5555")]
        [RegularExpression(@"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Application User
        /// </summary>
        [Required]
        public ApplicationUser User { get; set; }
    }
}
