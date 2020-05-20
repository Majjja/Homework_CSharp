using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_DataBase;
using WebApi.Models;

namespace WebApi.Service
{
    public static class UserService
    {
        public static List<User> GetAllUsers()
        {
            return DB.Users;
        }

        public static User GetUserById(int id)
        {

            try
            {
                var user = DB.Users.Single(user => user.Id.Equals(id));
                return user;
            }
            catch (InvalidOperationException ex)
            {
                throw new UserServiceException($"There is no user with Id:{id}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public static List<User> GetAllUsersFriends(User findUser)
        {
            try
            {
                var user = DB.Users.Single(user => user.Equals(findUser));
                return user.Friends;
            }
            catch (InvalidOperationException ex)
            {
                throw new UserServiceException("You send me a null", ex);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
