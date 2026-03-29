using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace messaging_assignment.Services
{
    public class AuthService
    {
        public User? LoggedInUser;

        public void LoginUser(User user)
        {
            LoggedInUser = user;
        }

        public void LogoutUser()
        {
            LoggedInUser = null;
        }
    }
}
