namespace App
{
    public class UserReferenceGenerator
   {
        public virtual string Generate(CreateUser createUser)
        {
            return (createUser.Email + createUser.DateOfBirth).GetHashCode().ToString();
        }
    }
}