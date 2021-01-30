using CommonComponents;
using InfrastructureLayer.DataAccess.Repositories.Specific.Meal;
using Newtonsoft.Json.Linq;
using OO_PocketGourmet_REAL.Models.Meals;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.MealServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ServicesLayer.Tests
{

    [Trait("Category", "DataAccessValidations")]
    public class MealServicesDataAccessTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private MealServices _mealServices;
        private string _connectionString;

        public MealServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            _testOutputHelper = testOutputHelper;
            _mealServices = new MealServices(new MealRepository(_connectionString), new ModelDataAnnotationCheck());

        }

        [Fact]
        public void ShouldReturnListOfMealsInARestaurant()
        {
            List<MealModel> mealModelList = (List<MealModel>)_mealServices.GetAll(1);
            Assert.NotEmpty(mealModelList);

            foreach (MealModel mm in mealModelList)
            {
                _testOutputHelper.WriteLine($"Name:{mm.MealName}\nPrice:{mm.MealPrice}\nRestaurantID:{mm.MealRestaurant}");
            }
        }
        [Fact]
        public void ShouldReturnSuccessForAdd()
        {
            MealModel mm = new MealModel()
            {
                MealName = "testName",
                MealPrice = 10,
                MealRestaurant = 1,
                MealSaltTaste = 0,
                MealBitterTaste = 1,
                MealSourTaste = 1,
                MealSpicyTaste = 0,
                MealSweetTaste = 0
            };
            bool operationSucceeded = false;
            string dataAccessStatusJsonStr = string.Empty;
            string formatedJsonString = string.Empty;

            try
            {
                _mealServices.Add(mm);
                operationSucceeded = true;
            }
            catch (DataAccessException dataAccessException)
            {
                operationSucceeded = dataAccessException.DataAccessStatusInfo.OperationSucceded;
                dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dataAccessException.DataAccessStatusInfo);
                formatedJsonString = JToken.Parse(dataAccessStatusJsonStr).ToString();

            }
            try
            {
                Assert.True(operationSucceeded);
                _testOutputHelper.WriteLine("The meal was successfully added");

            }
            finally
            {
                _testOutputHelper.WriteLine(formatedJsonString);
            }
        }
    }
}
