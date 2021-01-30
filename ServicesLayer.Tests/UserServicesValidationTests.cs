using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ServicesLayer.Tests
{
    [Trait("Category", "Model Validations")]
    public class UserServicesValidationTests: IClassFixture<UserServicesFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private UserServicesFixture _userServicesFixture;

        public UserServicesValidationTests(UserServicesFixture userServicesFixture, ITestOutputHelper testOutputHelper)
        {
            this._userServicesFixture = userServicesFixture;
            _testOutputHelper = testOutputHelper;

            SetValidSampleValues();
        }

        [Fact]
        public void ShouldNotThrowExceptionForDefaultTestValuesOnAnnotations()
        {
            var exception = Record.Exception(() => _userServicesFixture.UserServices.ValidateModelDataAnnotations
                                (_userServicesFixture.UserModel));
            Assert.Null(exception);
            WriteExceptionTestResult(exception);
        }

        [Fact]
        public void ShouldThrowExceptionIfAnyDataAnnotationCheckFails()
        {
            _userServicesFixture.UserModel.UserEmail = "test.test4gmail.crm";
            Exception exception = Assert.Throws<ArgumentException>(testCode: () => _userServicesFixture.UserServices.ValidateModelDataAnnotations
                                (_userServicesFixture.UserModel));
            WriteExceptionTestResult(exception);
        }



        private void SetValidSampleValues()
        {
            _userServicesFixture.UserModel.UserID = 1;
            _userServicesFixture.UserModel.UserEmail = "test.test@gmail.com";
            _userServicesFixture.UserModel.UserName = "Ime";
            _userServicesFixture.UserModel.UserPassword = "abcdefg";
            _userServicesFixture.UserModel.UserRestaurant = 2;
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            if (exception != null)
            {
                _testOutputHelper.WriteLine(exception.Message);
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                JObject json = JObject.FromObject(_userServicesFixture.UserModel);
                stringBuilder.Append("*** No EXC was thrown ***");
                foreach (JProperty jProperty in json.Properties())
                {
                    stringBuilder.Append(jProperty.Name).Append("-->")
                                .Append(jProperty.Value).AppendLine();
                }

                _testOutputHelper.WriteLine(stringBuilder.ToString());

            }
        }
    }
}
