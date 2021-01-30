using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Services.UserServices;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.CommonServices;

namespace ServicesLayer.Tests
{
    public class UserServicesFixture
    {
        private IUserServices _userServices;
        private IUserModel _userModel;

        public UserServicesFixture()
        {
            _userModel = new UserModel();
            _userServices = new UserServices(null, new ModelDataAnnotationCheck());
        }

        public UserModel UserModel
        {
            get { return (UserModel)_userModel; }
            set { _userModel = value; }
        }

        public UserServices UserServices
        {
            get { return (UserServices)_userServices; }
            set { _userServices = value; }
        }
    }
}
