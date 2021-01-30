using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.CommonServices;

namespace ServiceLayer.Services.UserServices
{
    public class UserServices: IUserServices, IUserRepository
    {
        private IUserRepository _userRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public UserServices(IUserRepository userRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _userRepository = userRepository;

        }

        public void Add(IUserModel userModel)
        {
            //throw new NotImplementedException();
            _userRepository.Add(userModel);
        }

        public void Delete(IUserModel userModel)
        {
            //throw new NotImplementedException();
            _userRepository.Delete(userModel);
        }

        public IEnumerable<UserModel> GetAll()
        {
            //throw new NotImplementedException();
            return _userRepository.GetAll();
        }

        public UserModel GetByEmail(string email)
        {
            //throw new NotImplementedException();
            return _userRepository.GetByEmail(email);
        }

        public void Update(IUserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(IUserModel userModel)
        {
            //throw new NotImplementedException();
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(userModel);
            ValidateUserEmail(userModel);
        }

        public void ValidateModelDataAnnotations(IUserModel userModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(userModel);
        }

        public void ValidateUserEmail(IUserModel userModel)
        {
            StringBuilder errorsStringBuilder = new StringBuilder();
            string mail = userModel.UserEmail;
            if (!".com .hr".Contains(mail))
            {
                errorsStringBuilder.Append("mail must end with .com or .hr");
            }
            if (!mail.Contains("@"))
            {
                errorsStringBuilder.Append("mail must contain @");
            }
        }
    }
}
