using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OO_PocketGourmet_REAL.Models.Restourant
{
    public class RestaurantModel : IRestaurantModel
    {
        public int RestaurantID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "address length should be between 1 and 40 characters")]
        public string RestaurantAddress { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "name is required")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "name length should be between 1 and 40 characters")]
        public string RestaurantName { get; set; }
    }
}
