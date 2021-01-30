using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OO_PocketGourmet_REAL.Models.Meals
{
    public class MealModel : IMealModel
    {
        public int MealID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "name is required")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "name length should be between 1 and 40 characters")]
        public string MealName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int MealPrice { get; set; }

        [Range(0, 5, ErrorMessage = "Taste must be between 0 and 5")]
        public int MealSaltTaste { get; set; }

        [Range(0, 5, ErrorMessage = "Taste must be between 0 and 5")]
        public int MealSweetTaste { get; set; }

        [Range(0, 5, ErrorMessage = "Taste must be between 0 and 5")]
        public int MealSourTaste { get; set; }

        [Range(0, 5, ErrorMessage = "Taste must be between 0 and 5")]
        public int MealBitterTaste { get; set; }

        [Range(0, 5, ErrorMessage = "Taste must be between 0 and 5")]
        public int MealSpicyTaste { get; set; }

        public int MealRestaurant { get; set; }

    }
}
