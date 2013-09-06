using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ClearOffice.Security.Data;
using System.Security;
using ClearOffice.Security.Views;

namespace ClearOffice.Security
{
    public class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            Byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
            SHA256Managed hashProvider = new SHA256Managed();
            hashProvider.Initialize();
            passwordBytes = hashProvider.ComputeHash(passwordBytes);
            hashProvider.Clear();
            return Convert.ToBase64String(passwordBytes);
        }

        public static string[] GetUserPermissions(string userName)
        {
            var permissions = new List<string>();

            // Get all list of user permissions

            return permissions.ToArray();
        }

        public static User GetUserDetail(int userId)
        {
            User user;
            var context = new ClearOfficeEntities();
            user = context.Users.First(u => u.UserId == userId);
            return user;
        }

        public static User GetUserDetail(string userName)
        {
            User user;
            var context = new ClearOfficeEntities();
            user = context.Users.First(u => u.UserName == userName);
            return user;
        }

        public static bool Authenticate(string userName, string password)
        {
            var context = new ClearOfficeEntities();
            User user = null;

            // Check if the provided user is found in the database. If not tell the user that the user account provided
            // does not exist in the database.
            try
            {
                user = context.Users.First(u => u.UserName == userName);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("The requested user could not be found.", ex);
            }

            // If the user account is disabled then we dont need to allow login instead we need to throw an exception
            // stating that the account is disabled.
            if (null != user.Disabled)
            {
                if (user.Disabled.Value == true)
                    throw new ApplicationException(
                        "The user account is currently disabled. Please contact your administrator.");
            }

            // Fianlly check if the passwords match
            if (null != user)
            {
                if (user.Password == HashPassword(password))
                {
                    //Add the current Identity and Principal to the current thread.
                    var identity = new UserIdentity(userName);
                    var principal = new UserPrincipal(identity);
                    Thread.CurrentPrincipal = principal;
                    return true;
                }
                else
                {
                    throw new ApplicationException("The supplied user name and password do not match.");
                }
            }
            return false;
        }

        public static bool ChangePassword(int userId, string password)
        {
            var context = new ClearOfficeEntities();
            try
            {
                var user = context.Users.First(u => u.UserId == userId);
                user.Password = HashPassword(password);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool DisableUserAccount(int userId)
        {
            var context = new ClearOfficeEntities();
            try
            {
                var user = context.Users.First(u => u.UserId == userId);
                user.Disabled = user.Disabled.HasValue ? !user.Disabled : true;
                context.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw new ApplicationException("Error disabling/enabling user account", exception);
            }
        }

        public static UsersListView ShowUsersList()
        {
            return new UsersListView();
        }
    }
}
