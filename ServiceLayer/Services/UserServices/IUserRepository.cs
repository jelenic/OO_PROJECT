using OO_PocketGourmet_REAL.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer.Services.UserServices
{
    public interface IUserRepository
    {
        void Add(IUserModel userModel);
        void Update(IUserModel userModel);
        void Delete(IUserModel userModel);

        IEnumerable<UserModel> GetAll();

        UserModel GetByEmail(string email);

    }
}
