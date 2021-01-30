using OO_PocketGourmet_REAL.Models.Restourant;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.RestaurantServices
{
    public class RestaurantServices : IRestaurantRepository, IRestaurantServices
    {
        private IRestaurantRepository _restaurantRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public RestaurantServices(IRestaurantRepository restaurantRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _restaurantRepository = restaurantRepository;

        }

        public void Add(IRestaurantModel restaurantModel)
        {
            //throw new NotImplementedException();
            _restaurantRepository.Add(restaurantModel);
        }

        public void Delete(IRestaurantModel restaurantModel)
        {
            //throw new NotImplementedException();
            _restaurantRepository.Delete(restaurantModel);
        }

        public IEnumerable<RestaurantModel> GetAll()
        {
            //throw new NotImplementedException();
            return _restaurantRepository.GetAll();
        }

        public RestaurantModel GetByID(int id)
        {
            //throw new NotImplementedException();
            return _restaurantRepository.GetByID(id);
        }

        public void Update(IRestaurantModel restaurantModel)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(IRestaurantModel restaurantModel)
        {
            //throw new NotImplementedException();
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(restaurantModel);
        }

        public void ValidateModelDataAnnotations(IRestaurantModel restaurantModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(restaurantModel);
        }
    }
}
