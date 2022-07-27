namespace TestTaskOnSea.Models.Interfaces
{
    public interface IUser
    {
        string Login { get; set; }
        string Password { set; }
        string Email { get; set; }
    }
}
