using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Services.UserServices;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.CommonServices;
using Xunit;
using Xunit.Abstractions;
using InfrastructureLayer.DataAccess.Repositories.Specific.User;
using CommonComponents;
using Newtonsoft.Json.Linq;

namespace ServicesLayer.Tests
{
    [Trait("Category", "DataAccessValidations")]
    public class UserServicesDataAccessTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private UserServices _userServices;
        private string _connectionString;

        public UserServicesDataAccessTests(ITestOutputHelper testOutputHelper)
        {
            _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";
            _testOutputHelper = testOutputHelper;
            _userServices = new UserServices(new UserRepository(_connectionString), new ModelDataAnnotationCheck());

        }

        [Fact]
        public void ShouldReturnListOfUsers()
        {
            List<UserModel> userModelList = (List<UserModel>)_userServices.GetAll();
            Assert.NotEmpty(userModelList);

            foreach(UserModel um in userModelList)
            {
                _testOutputHelper.WriteLine($"Name:{um.UserName}\nEmail:{um.UserEmail}\n");
            }
        }

        [Fact]
        public void ShouldReturnSuccessForAdd()
        {
            UserModel um = new UserModel()
            {
                UserEmail = "test.test@gmail.com",
                UserName = "test",
                UserPassword = "test",
                UserRestaurant = 1
            };
            bool operationSucceeded = false;
            string dataAccessStatusJsonStr = string.Empty;
            string formatedJsonString = string.Empty;

            try
            {
                _userServices.Add(um);
                operationSucceeded = true;
            }
            catch(DataAccessException dataAccessException)
            {
                operationSucceeded = dataAccessException.DataAccessStatusInfo.OperationSucceded;
                dataAccessStatusJsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(dataAccessException.DataAccessStatusInfo);
                formatedJsonString = JToken.Parse(dataAccessStatusJsonStr).ToString();

            }
            try
            {
                Assert.True(operationSucceeded);
                _testOutputHelper.WriteLine("The user was successfully added");

            }
            finally
            {
                _testOutputHelper.WriteLine(formatedJsonString);
            }
        }

        [Fact]
        public void ShouldReturnSuccessForDelete()
        {
            UserModel um = new UserModel()
            {
                UserEmail = "test.test@gmail.com",
                UserName = "test",
                UserPassword = "test",
                UserRestaurant = 1
            };

            bool operationSucceeded = false;
            string dataAccessStatusJsonStr = string.Empty;
            string formatedJsonString = string.Empty;

            try
            {
                _userServices.Delete(um);
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
                _testOutputHelper.WriteLine("The user was successfully deleted");

            }
            finally
            {
                _testOutputHelper.WriteLine(formatedJsonString);
            }
        }
    }
}
