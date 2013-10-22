using System;

namespace App
{
    public class UserExistsException : Exception
    {
        public UserExistsException(string email) : base(email) {}
    }
}