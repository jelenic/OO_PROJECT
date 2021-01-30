using ServiceLayer.CommonServices;
using ServiceLayer.Services.RestaurantServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using InfrastructureLayer.DataAccess.Repositories.Specific.Restaurant;
using OO_PocketGourmet_REAL.Models.Restourant;
using CommonComponents;
using Newtonsoft.Json.Linq;

namespace ServicesLayer.Tests
{
    [Trait("Category", "DataAccessValidations")]
    public class RestaurantServicesDataAccessTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private RestaurantServices _restaurantServices;
        private string _connectionString;

        public RestaurantServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            _testOutputHelper = testOutputHelper;
            _restaurantServices = new RestaurantServices(new RestaurantRepository(_connectionString), new ModelDataAnnotationCheck());

        }

        [Fact]
        public void ShouldReturnListOfRestaurants()
        {
            List<RestaurantModel> restaurantModelList = (List<RestaurantModel>)_restaurantServices.GetAll();
            Assert.NotEmpty(restaurantModelList);

            foreach (RestaurantModel rm in restaurantModelList)
            {
                _testOutputHelper.WriteLine($"Name:{rm.RestaurantName}\nAddress:{rm.RestaurantAddress}\n");
            }
        }

        [Fact]
        public void ShouldReturnSuccessForAdd()
        {
            RestaurantModel rm = new RestaurantModel()
            {
                RestaurantName = "testName",
                RestaurantAddress = "testAddress",
            };
            bool operationSucceeded = false;
            string dataAccessStatusJsonStr = string.Empty;
            string formatedJsonString = string.Empty;

            try
            {
                _restaurantServices.Add(rm);
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
                _testOutputHelper.WriteLine("The restaurant was successfully added");

            }
            finally
            {
                _testOutputHelper.WriteLine(formatedJsonString);
            }
        }

    }
}
