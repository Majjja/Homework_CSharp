using FakeFacebook.Exceptions;
using FakeFacebook.Logger;
using System;
using WebApi.Exceptions;
using WebApi.Service;

namespace FakeFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All users:");
            Console.ResetColor();
            var allUsers = UserService.GetAllUsers();
            allUsers.ForEach(user => Console.WriteLine($"{user.FirstName} {user.LastName}"));

            try
            {
                var userById = UserService.GetUserById(7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"User with an Id:{userById.Id} is {userById.FirstName} {userById.LastName}");
                Console.ResetColor();

                var usersfriends = UserService.GetAllUsersFriends(userById);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{userById.FirstName}'s Friends:");
                usersfriends.ForEach(friends => Console.WriteLine($"- {friends.FirstName}"));
                Console.ResetColor();

            }
            catch (UserServiceException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (Exception ex)
            {
                var loggingUsersEx = new ExceptionLogger();
                loggingUsersEx.LogUserExceptions(ex);
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("All admins:");
            Console.ResetColor();
            var allAdmins = AdminService.GetAllAdmins();
            allAdmins.ForEach(admin => Console.WriteLine($"{admin.FirstName} {admin.LastName}"));

            try
            {
                var adminById = AdminService.GetAdminById(4);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Admin with an Id:{adminById.Id} is {adminById.FirstName} {adminById.LastName}");
                Console.ResetColor();

                var adminsFriends = AdminService.GetAllAdminsFriends(null);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{adminById.FirstName}'s Friends:");
                adminsFriends.ForEach(friends => Console.WriteLine($"- {friends.FirstName}"));
                Console.ResetColor();
            }
            catch (AdminServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                var loggingAdmsinEx = new ExceptionLogger();
                loggingAdmsinEx.LogAdminExceptions(ex);
                throw new ServiceExceptions("Something went wrong", ex);
            }

            Console.WriteLine("Program proceed");
        }
    }
}
