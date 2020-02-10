using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Models.Database
{
    /// <summary>
    /// The database table for desserts
    /// </summary>
    public class Desserts
    {
        /// <summary>
        /// Auto-Incrementing Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The title of the dessert
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        /// <summary>
        /// The desserts description
        /// </summary>
        [Required]
        [StringLength(3000)]
        public string Description { get; set; }

        /// <summary>
        /// The price of the dessert
        /// </summary>
        [Required]
        [Range(0.01, 999.99)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        /// <summary>
        /// The stock remaining of the dessert.
        /// when the stock is at zero we can disable the button 
        /// to sell the item.
        /// </summary>
        [Required]
        [Display(Name = "Remaining Stock")]
        public int Stock { get; set; }
    }
}
