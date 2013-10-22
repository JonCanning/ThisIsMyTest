using System;

namespace App
{
    public class User
    {
        public User(
            string title,
            string firstname,
            string surname,
            DateTime dateOfBirth,
            string email,
            string telephoneNumber,
            Address address,
            string reference)
        {
            Address = address;
            Title = title;
            Firstname = firstname;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Email = email;
            Reference = reference;
            TelephoneNumber = telephoneNumber;
        }

        public Address Address { get; private set; }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Firstname { get; private set; }
        public string Surname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Email { get; private set; }
        public string Reference { get; private set; }
        public string TelephoneNumber { get; private set; }
    }
}