namespace OO_PocketGourmet_REAL.Models.User
{
    public interface IUserModel
    {
        string UserEmail { get; set; }
        int UserID { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
        int UserRestaurant { get; set; }
    }
}