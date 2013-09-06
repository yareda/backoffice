using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NetSqlAzMan.Cache;
using NetSqlAzMan;
using System.Configuration;
using NetSqlAzMan.Interfaces;

namespace ClearOffice.Security
{
    public class PermissionManager
    {
        private static PermissionManager permission;

        private StorageCache cache;
        private static readonly string Connection = ConfigurationManager.ConnectionStrings["Security"].ConnectionString;
        private static readonly string StoreName = ConfigurationManager.AppSettings["store"];
        private static readonly string Application = ConfigurationManager.AppSettings["application"];

        public const string WORKSHOP_APPLICATION = "Workshop";
        public const string HRM_APPLICATION = "Hrm";
        public const string FLEET_APPLICATION = "Fleet";
        public const string FIXED_ASSET_APPLICATION = "FixedAsset";
        public const string INVENTORY_APPLICATION = "Inventory";
        public const string ADMINISTRATION_APPLICATION = "Administration";

        #region Static Singleton Factory Methods

        /// <summary>
        /// Creats and returns a permission manager for managing user permissions.
        /// </summary>
        /// <returns>Instance of PermissionManager class </returns>
        public static PermissionManager GetPermissionManager()
        {
            return permission ?? (permission = new PermissionManager());
        }

        public static PermissionManager GetPermissionManager(string store)
        {
            return permission ?? (permission = new PermissionManager(store));
        }

        public static PermissionManager GetPermissionManager(string store, string connection)
        {
            return permission ?? (permission = new PermissionManager(store, connection));
        }

        #endregion

        #region Private Constructors

        /// <summary>
        /// Private constructor for Singleton pattern implementation.
        /// </summary>
        private PermissionManager(): this(ConfigurationManager.AppSettings["store"]) { }

        private PermissionManager(string store): this(store, ConfigurationManager.ConnectionStrings["Security"].ConnectionString) { }

        private PermissionManager(string store, string connection)
        {
           cache =new StorageCache(connection);

           try
            {
                cache.BuildStorageCache();
                //cache.BuildStorageCache(store);
            }
            catch (Exception exception)
            {
                throw new ApplicationException("Unable to initialize NetSqlAzMan security store", exception);
            }
        }
        #endregion
        #region Authorization Methods

        /// <summary>
        /// Checks for the authorization of a given item (Task/Operation) for a user.
        /// The default values for store, application and connection come from .config settings. User information will default
        /// to Thread.CurrentPrincipal.Identity
        /// </summary>
        /// <param name="item">Name of the Task/Operation</param>
        /// <returns>Boolean result for the user's authorization.</returns>
        public bool IsAuthorized(string item)
        {
            var user = (UserIdentity)Thread.CurrentPrincipal.Identity;
            var dbUser = cache.Storage.GetDBUser(user.Name);
            var authorization = cache.CheckAccess(StoreName, Application, item, dbUser.CustomSid.ToString(), DateTime.Now, false);
           return (authorization == AuthorizationType.Allow) ||
                   (authorization == AuthorizationType.AllowWithDelegation);
        }

        public bool IsAuthorized(string appName, string item)
        {
            var user = (UserIdentity)Thread.CurrentPrincipal.Identity;
            var dbUser = cache.Storage.GetDBUser(user.Name);

            var authorization = cache.CheckAccess(StoreName, appName, item, dbUser.CustomSid.ToString(), DateTime.Now, false);
        return (authorization == AuthorizationType.Allow) ||
                   (authorization == AuthorizationType.AllowWithDelegation);
        }
        /// <summary>
        /// Checks for the authorization of a given user against a permission. This method is suited for DBUsers ONLY.
        /// The user information for this method is retrived from Thread.CurrentPrincipal.Identity (which is of type
        /// UserIdentity)
        /// </summary>
        /// <param name="application">Name of the application to check permissions against. If not specified it will default to the one provided in the .config file with 'application' key</param>       
        /// <param name="item">The name of the Task or Operation to check</param>
        /// <param name="operationOnly">
        /// Boolean flag to tell wether to use Operations only. If set to true the authorization will only check Tasks.
        /// In order to check both Tasks and Operations set this parameter to false. The default is true.
        /// </param>
        /// <returns>Boolean result for user authorization</returns>
        public bool IsAuthorized(string application, string item, bool operationOnly = true)
        {
            var user = (UserIdentity)Thread.CurrentPrincipal.Identity;
            var dbUser = cache.Storage.GetDBUser(user.Name);

            var authorization = cache.CheckAccess(StoreName, application, item, dbUser.CustomSid.ToString(), DateTime.Now, operationOnly);
            //
            return (authorization == AuthorizationType.Allow)||(authorization == AuthorizationType.AllowWithDelegation);
        }

        #endregion

    }
}
