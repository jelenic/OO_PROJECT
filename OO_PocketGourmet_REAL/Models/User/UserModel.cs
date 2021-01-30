using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OO_PocketGourmet_REAL.Models.User
{
    public class UserModel : IUserModel
    {
        public int UserID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "name is required")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "name length should be between 1 and 40 characters")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "mail is required")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "mail length should be between 1 and 40 characters")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
            , ErrorMessage = "email format is not correct")]
        public string UserEmail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "password is required")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "password length should be between 4 and 40 characters")]
        public string UserPassword { get; set; }

        public int UserRestaurant { get; set; }
    }
}
