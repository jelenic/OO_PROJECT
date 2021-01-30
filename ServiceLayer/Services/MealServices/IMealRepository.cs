using OO_PocketGourmet_REAL.Models.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.MealServices
{
    public interface IMealRepository
    {
        void Add(IMealModel mealModel);
        void Update(IMealModel mealModel);
        void Delete(IMealModel mealModel);

        IEnumerable<MealModel> GetAll(int id);

        MealModel GetByID(int id);
    }
}
