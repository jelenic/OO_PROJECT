using OO_PocketGourmet_REAL.Models.Restourant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.RestaurantServices
{
    public interface IRestaurantRepository
    {
        void Add(IRestaurantModel restaurantModel);
        void Update(IRestaurantModel restaurantModel);
        void Delete(IRestaurantModel restaurantModel);

        IEnumerable<RestaurantModel> GetAll();

        RestaurantModel GetByID(int id);
    }
}
