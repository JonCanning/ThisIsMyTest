namespace App
{
    public class UserReferenceGenerator : IUserReferenceGenerator
    {
        public string Generate(CreateUser createUser)
        {
            return (createUser.Email + createUser.DateOfBirth).GetHashCode().ToString();
        }
    }
}