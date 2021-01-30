using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO_PocketGourmet_REAL.Models.Meals;

namespace ServiceLayer.Services.MealServices
{
    public interface IMealServices
    {
        void ValidateModel(IMealModel mealModel);

        void ValidateModelDataAnnotations(IMealModel mealModel);
    }
}
