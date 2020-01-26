using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        public string ConfirmationCode { get; set; }

        /// <summary>
        /// Reference Key to Customer / AspNetUsers 
        /// to be able to attach an order to a customer
        /// * will have to done in another issue
        /// </summary>
        [ForeignKey("Customer Id")]
        public int CustomerReferenceId { get; set; }

        /*
           Will create a new issue to create a food/order 
           table that will save all the food that was ordered
           in a list:
           public list<?> OrderItems { get; set;}
         */
    }
}
