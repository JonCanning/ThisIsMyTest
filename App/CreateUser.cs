using System;

namespace App
{
    public class CreateUser
    {
        public CreateUser(string title, string firstname, string surname, DateTime dateOfBirth, string email,
            string telephoneNumber, Address address)
        {
            Title = title;
            Firstname = firstname;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Email = email;
            TelephoneNumber = telephoneNumber;
            Address = address;
        }

        public string Title { get; private set; }
        public string Firstname { get; private set; }
        public string Surname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Email { get; private set; }
        public string TelephoneNumber { get; private set; }
        public Address Address { get; private set; }
    }
}