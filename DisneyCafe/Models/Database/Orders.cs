using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DisneyCafe.Data;

namespace DisneyCafe.Models.Database
{
    public class Orders
    {
        /// <summary>
        /// Auto-Incrementing id
        /// </summary>
        [Key]
        [Required]
        public int OrderId { get; set; }

        /// <summary>
        /// When an order is submitted the user
        /// will be sent a confirmation code
        /// which would be a combination of numbers and letters
        /// and those would be saved here linked with the account
        /// </summary>
        [Required]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The application user the order belongs to
        /// </summary>
        [NotMapped]
        public ApplicationUser User { get; set; }
        /// <summary>
        /// All desserts ordered by the user
        /// </summary>
        [NotMapped]
        public CustomerInfomation CustomerInfomation { get; set; }
    }
}
