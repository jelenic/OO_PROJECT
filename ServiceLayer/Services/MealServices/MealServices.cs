using OO_PocketGourmet_REAL.Models.Meals;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.MealServices
{
    public class MealServices : IMealServices, IMealRepository
    {
        private IMealRepository _mealRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public MealServices(IMealRepository mealRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _mealRepository = mealRepository;

        }

        public void Add(IMealModel mealModel)
        {
            //throw new NotImplementedException();
            _mealRepository.Add(mealModel);
        }

        public void Delete(IMealModel mealModel)
        {
            //throw new NotImplementedException();
            _mealRepository.Delete(mealModel);
        }

        public IEnumerable<MealModel> GetAll(int id)
        {
            //throw new NotImplementedException();
            return _mealRepository.GetAll(id);
        }

        public MealModel GetByID(int id)
        {
            //throw new NotImplementedException();
            return _mealRepository.GetByID(id);
        }

        public void Update(IMealModel mealModel)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(IMealModel mealModel)
        {
            //throw new NotImplementedException();
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(mealModel);
        }

        public void ValidateModelDataAnnotations(IMealModel mealModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(mealModel);
        }

    }
}
