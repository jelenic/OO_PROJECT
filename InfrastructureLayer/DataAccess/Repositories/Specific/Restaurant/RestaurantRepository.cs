using CommonComponents;
using OO_PocketGourmet_REAL.Models.Restourant;
using ServiceLayer.Services.RestaurantServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.Restaurant
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private string _connectionString;

        public RestaurantRepository()
        {
            
        }

        public RestaurantRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(IRestaurantModel restaurantModel)
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

                string sql = "INSERT INTO Restaurants (RestaurantAddress, RestaurantName)" +
                            "VALUES (@RestaurantAddress, @RestaurantName)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {
                    /*try
                    {
                        UserExistsCheck(cmd, userModel, TypeOfExsistenceCheck.DoesNotExistInDB, RequestType.Add)
                    }*/
                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@RestaurantAddress", restaurantModel.RestaurantAddress);
                    cmd.Parameters.AddWithValue("@RestaurantName", restaurantModel.RestaurantName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to add Restaurant to db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public void Delete(IRestaurantModel restaurantModel)
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

                string sql = "DELETE FROM Restaurants WHERE RestaurantID=@RestaurantID";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {
                    /*try
                    {
                        UserExistsCheck(cmd, userModel, TypeOfExsistenceCheck.DoesNotExistInDB, RequestType.Add)
                    }*/
                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@RestaurantID", restaurantModel.RestaurantID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to remove Restaurant from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public IEnumerable<RestaurantModel> GetAll()
        {
            //throw new NotImplementedException();
            List<RestaurantModel> restaurantModelList = new List<RestaurantModel>();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    //SQLitePCL.Batteries.Init();
                    string sql = "SELECT * FROM Restaurants";
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RestaurantModel restaurantModel = new RestaurantModel();
                                restaurantModel.RestaurantID = Int32.Parse(reader["RestaurantID"].ToString());
                                restaurantModel.RestaurantName = reader["RestaurantName"].ToString();
                                restaurantModel.RestaurantAddress = reader["RestaurantAddress"].ToString();
                                restaurantModelList.Add(restaurantModel);

                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get Restaurant Model list from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }
                return restaurantModelList;
            }
        }

        public RestaurantModel GetByID(int id)
        {
            //throw new NotImplementedException();
            RestaurantModel restaurantModel = new RestaurantModel();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();
            bool MatchingRestaurantFound = false;
            string sql = "SELECT * FROM Restaurants WHERE RestaurantID = @RestaurantID";

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        cmd.Parameters.Add(new SQLiteParameter("@RestaurantID", id));
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            MatchingRestaurantFound = reader.HasRows;
                            while (reader.Read())
                            {
                                restaurantModel.RestaurantID = Int32.Parse(reader["RestaurantID"].ToString());
                                restaurantModel.RestaurantName = reader["RestaurantName"].ToString();
                                restaurantModel.RestaurantAddress = reader["RestaurantAddress"].ToString();


                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get Restaurant Model from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }

                if (!MatchingRestaurantFound)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: "", customMessage: "Unable to find Restaurant Model in db", helpLink: "", errorCode: 0, stackTrace: "");
                    throw new DataAccessException(dataAccesStatus);
                }
                return restaurantModel;
            }
        }

        public void Update(IRestaurantModel restaurantModel)
        {
            throw new NotImplementedException();
        }
    }
}
