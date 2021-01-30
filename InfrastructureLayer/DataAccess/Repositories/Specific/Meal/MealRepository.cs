using CommonComponents;
using OO_PocketGourmet_REAL.Models.Meals;
using ServiceLayer.Services.MealServices;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.Meal
{
    public class MealRepository : IMealRepository
    {

        private string _connectionString;

        public MealRepository()
        {

        }

        public MealRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void Add(IMealModel mealModel)
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

                string sql = "INSERT INTO Meals (MealName, MealPrice, MealRestaurant, MealSaltTaste, MealSourTaste, MealSpicyTaste, MealSweetTaste, MealBitterTaste)" +
                            "VALUES (@MealName, @MealPrice, @MealRestaurant, @MealSaltTaste, @MealSourTaste, @MealSpicyTaste, @MealSweetTaste, @MealBitterTaste)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {

                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@MealName", mealModel.MealName);
                    cmd.Parameters.AddWithValue("@MealPrice", mealModel.MealPrice);
                    cmd.Parameters.AddWithValue("@MealRestaurant", mealModel.MealRestaurant);
                    cmd.Parameters.AddWithValue("@MealSaltTaste", mealModel.MealSaltTaste);
                    cmd.Parameters.AddWithValue("@MealSourTaste", mealModel.MealSourTaste);
                    cmd.Parameters.AddWithValue("@MealSpicyTaste", mealModel.MealSpicyTaste);
                    cmd.Parameters.AddWithValue("@MealSweetTaste", mealModel.MealSweetTaste);
                    cmd.Parameters.AddWithValue("@MealBitterTaste", mealModel.MealBitterTaste);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to add Meal to db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public void Delete(IMealModel mealModel)
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

                string sql = "DELETE FROM Meals WHERE MealID=@MealID";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                {
                    /*try
                    {
                        UserExistsCheck(cmd, userModel, TypeOfExsistenceCheck.DoesNotExistInDB, RequestType.Add)
                    }*/
                    cmd.CommandText = sql;
                    cmd.Prepare();

                    cmd.Parameters.AddWithValue("@MealID", mealModel.MealID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to remove Meal from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                        throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                    }
                    sqLiteConnection.Close();
                }
            }
        }

        public IEnumerable<MealModel> GetAll(int id)
        {
            //throw new NotImplementedException();
            List<MealModel> mealModelList = new List<MealModel>();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    //SQLitePCL.Batteries.Init();
                    string sql = "SELECT * FROM Meals";
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MealModel mealModel = new MealModel();
                                mealModel.MealID = Int32.Parse(reader["MealID"].ToString());
                                mealModel.MealName = reader["MealName"].ToString();
                                mealModel.MealPrice = Int32.Parse(reader["MealPrice"].ToString());
                                mealModel.MealRestaurant = Int32.Parse(reader["MealRestaurant"].ToString());

                                mealModel.MealSaltTaste = Int32.Parse(reader["MealSaltTaste"].ToString());
                                mealModel.MealSourTaste = Int32.Parse(reader["MealSourTaste"].ToString());
                                mealModel.MealSpicyTaste = Int32.Parse(reader["MealSpicyTaste"].ToString());
                                mealModel.MealSweetTaste = Int32.Parse(reader["MealSweetTaste"].ToString());
                                mealModel.MealBitterTaste = Int32.Parse(reader["MealBitterTaste"].ToString());

                                if (mealModel.MealRestaurant == id)
                                {
                                    mealModelList.Add(mealModel);
                                }

                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get Meal Model list from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }
                return mealModelList;
            }
        }

        public MealModel GetByID(int id)
        {
            //throw new NotImplementedException();
            MealModel mealModel = new MealModel();
            DataAccessStatus dataAccesStatus = new DataAccessStatus();
            bool MatchingMealFound = false;
            string sql = "SELECT * FROM Meals WHERE MealID = @MealID";

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    sqLiteConnection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, sqLiteConnection))
                    {
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        cmd.Parameters.Add(new SQLiteParameter("@MealID", id));
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            MatchingMealFound = reader.HasRows;
                            while (reader.Read())
                            {
                                mealModel.MealID = Int32.Parse(reader["MealID"].ToString());
                                mealModel.MealName = reader["MealName"].ToString();
                                mealModel.MealPrice = Int32.Parse(reader["MealPrice"].ToString());
                                mealModel.MealRestaurant = Int32.Parse(reader["MealRestaurant"].ToString());

                                mealModel.MealSaltTaste = Int32.Parse(reader["MealSaltTaste"].ToString());
                                mealModel.MealSourTaste = Int32.Parse(reader["MealSourTaste"].ToString());
                                mealModel.MealSpicyTaste = Int32.Parse(reader["MealSpicyTaste"].ToString());
                                mealModel.MealSweetTaste = Int32.Parse(reader["MealSweetTaste"].ToString());
                                mealModel.MealBitterTaste = Int32.Parse(reader["MealBitterTaste"].ToString());


                            }
                        }
                        sqLiteConnection.Close();
                    }
                }
                catch (SQLiteException e)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: e.Message, customMessage: "Unable to get Meal Model from db", helpLink: e.HelpLink, errorCode: e.ErrorCode, stackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccesStatus);
                }

                if (!MatchingMealFound)
                {
                    dataAccesStatus.setValues(status: "Error", operationSucceded: false, exceptionMessage: "", customMessage: "Unable to find Meal Model in db", helpLink: "", errorCode: 0, stackTrace: "");
                    throw new DataAccessException(dataAccesStatus);
                }
                return mealModel;
            }
        }

        public void Update(IMealModel mealModel)
        {
            throw new NotImplementedException();
        }
    }
}
