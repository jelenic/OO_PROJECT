using OO_PocketGourmet_REAL.Models.Restourant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.RestaurantServices
{
    public interface IRestaurantServices
    {
        void ValidateModel(IRestaurantModel restaurantModel);

        void ValidateModelDataAnnotations(IRestaurantModel restaurantModel);
    }
}
