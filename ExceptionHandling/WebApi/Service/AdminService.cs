using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Exceptions;
using WebApi.Fake_DataBase;
using WebApi.Models;

namespace WebApi.Service
{
    public static class AdminService
    {
        public static List<Admin> GetAllAdmins()
        {
            return DB.Admins;
        }

        public static Admin GetAdminById(int id)
        {
            try
            {
                var admin = DB.Admins.Single(admin => admin.Id.Equals(id));
                return admin;
            }
            catch(InvalidOperationException ex)
            {
                throw new AdminServiceException($"There is no admin with Id: {id}");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public static List<User> GetAllAdminsFriends(Admin findAdmin)
        {
            try
            {
                if (findAdmin == null)
                    throw new AdminServiceException("You send me a null");

                var adminFriends = DB.Admins.SingleOrDefault(admin => admin.Equals(findAdmin));
                return adminFriends.Friends;
            }
            catch (AdminServiceException ex)
            {
                throw new AdminServiceException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
