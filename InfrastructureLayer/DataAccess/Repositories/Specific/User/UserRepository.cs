using CommonComponents;
using OO_PocketGourmet_REAL.Models.User;
using ServiceLayer.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.User
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString;

        public UserRepository()
        {

        }

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(IUserModel userModel)
        {
            //throw new NotImplementedException();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    sqLiteConnection.Open();
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to open db connection", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }

                string sql = "INSERT INTO Users (UserName, UserEmail, UserPassword, UserRestaurant)" +
                            "VALUES (@UserName, @UserEmail, @UserPassword, @UserRestaurant)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {
                    /*try
                    {
                        UserExistsCheck(cmd, userModel, TypeOfExsistenceCheck.DoesNotExistInDB, RequestType.Add)
                    }*/
                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@UserName", userModel.UserName);
                    cmd.Parameters.AddWithValue("@UserEmail", userModel.UserEmail);
                    cmd.Parameters.AddWithValue("@UserPassword", userModel.UserPassword);
                    cmd.Parameters.AddWithValue("@UserRestaurant", userModel.UserRestaurant);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to add User to db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public void Delete(IUserModel userModel)
        {
            //throw new NotImplementedException();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    sqLiteConnection.Open();
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to open db connection", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }

                string sql = "DELETE FROM Users WHERE UserID=@UserID";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {
                    /*try
                    {
                        UserExistsCheck(cmd, userModel, TypeOfExsistenceCheck.DoesNotExistInDB, RequestType.Add)
                    }*/
                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@UserID", userModel.UserID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to remove User from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public IEnumerable<UserModel> GetAll()
        {
            //throw new NotImplementedException();
            List<UserModel> userModelList = new List<UserModel>();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    //SQLitePCL.Batteries.Init();
                    string sql = "SELECT * FROM Users";
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserModel userModel = new UserModel();
                                userModel.UserID = Int32.Parse(reader["UserID"].ToString());
                                userModel.UserEmail = reader["UserEmail"].ToString();
                                userModel.UserName = reader["UserName"].ToString();
                                userModel.UserPassword = reader["UserPassword"].ToString();
                                userModel.UserRestaurant = Int32.Parse(reader["UserRestaurant"].ToString());
                                userModelList.Add(userModel);

                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch(SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get User Model list from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }
                return userModelList;
            }
        }

        public UserModel GetByEmail(string email)
        {
            //throw new NotImplementedException();
            UserModel userModel = new UserModel();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();
            bool MatchingUserFound = false;
            string sql = "SELECT * FROM Users WHERE UserEmail = @UserEmail";

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        cmd.Parameters.Add(new SQLiteParameter("@UserEmail", email));
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            MatchingUserFound = reader.HasRows;
                            while (reader.Read())
                            {
                                userModel.UserID = Int32.Parse(reader["UserID"].ToString());
                                userModel.UserEmail = reader["UserEmail"].ToString();
                                userModel.UserName = reader["UserName"].ToString();
                                userModel.UserPassword = reader["UserPassword"].ToString();
                                userModel.UserRestaurant = Int32.Parse(reader["UserRestaurant"].ToString());

                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get User Model from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }

                if (!MatchingUserFound)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: "", customMessage: "Unable to find User Model in db", helpLink:"", errorCode: 0, stackTrace: "");
                    throw new DataAccessException(dataAccesStatus);
                }
                return userModel;
            }
        }

        public void Update(IUserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
