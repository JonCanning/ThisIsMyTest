namespace App
{
    public interface IUserRepository
    {
        User GetUserByEmailAddress(string email);
    }
}