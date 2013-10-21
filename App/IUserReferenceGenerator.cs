namespace App
{
    public interface IUserReferenceGenerator
    {
        string Generate(CreateUser createUser);
    }
}