namespace OO_PocketGourmet_REAL.Models.Meals
{
    public interface IMealModel
    {
        int MealBitterTaste { get; set; }
        int MealID { get; set; }
        string MealName { get; set; }
        int MealPrice { get; set; }
        int MealSaltTaste { get; set; }
        int MealSourTaste { get; set; }
        int MealSpicyTaste { get; set; }
        int MealSweetTaste { get; set; }

        int MealRestaurant { get; set; }
    }
}