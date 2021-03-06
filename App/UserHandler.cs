﻿using Logging;

namespace App
{
    public class UserHandler : IHandle<CreateUser>
    {
        static readonly ILog Log = LogProvider.GetLogger();
        readonly IUserCreator userCreator;
        readonly UserReferenceGenerator userReferenceGenerator;
        readonly IUserRepository userRepository;

        public UserHandler(IUserRepository userRepository, IUserCreator userCreator, UserReferenceGenerator userReferenceGenerator)
        {
            this.userRepository = userRepository;
            this.userCreator = userCreator;
            this.userReferenceGenerator = userReferenceGenerator;
        }

        public void Handle(CreateUser createUser)
        {
            var user = userRepository.GetUserByEmailAddress(createUser.Email);
            if (user != null)
            {
                Log.Info("User {0} already exists", createUser.Email);
                throw new UserExistsException(createUser.Email);
            }
            var userReference = userReferenceGenerator.Generate(createUser);
            userCreator.Create(
                createUser.Title,
                createUser.Firstname,
                createUser.Surname,
                createUser.DateOfBirth,
                createUser.Email,
                createUser.TelephoneNumber,
                createUser.Address,
                userReference);
        }
    }
}