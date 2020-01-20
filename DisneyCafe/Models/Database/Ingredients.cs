using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Models.Database
{
    public class Ingredients
    {
        /// <summary>
        /// Auto-Incrementing Id for ingredients in the database
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Ingredient Name
        /// </summary>
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Ingredient Measurement |Lbs/Cups/Ounces/Single|
        /// Will be chosen by a dropdown pre-populated
        /// </summary>
        [StringLength(25)]
        [Required]
        public string Mesurement { get; set; }

        /// <summary>
        /// Amount of the item left in stock
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// The ingredients expiration date
        /// </summary>
        [Required]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// When the Ingredient is last ordered
        /// </summary>
        public DateTime LastOrdered { get; set; }
    }
}
