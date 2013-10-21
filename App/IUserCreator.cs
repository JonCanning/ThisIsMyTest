using System;

namespace App
{
    public interface IUserCreator
    {
        void Create(string title, string firstname, string surname, DateTime dateOfBirth, string email,
            string telephoneNumber, Address address, string reference);
    }
}