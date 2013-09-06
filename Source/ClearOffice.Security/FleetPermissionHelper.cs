using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Security
{
    public class FleetPermissionHelper
    {
        #region Enums
        /// <summary>
        /// Roles Enumeration
        /// </summary>
        public enum Role
        {
            /// <summary>
            /// Role DataEntryOfficer
            /// </summary>
            DataEntryOfficer,
            /// <summary>
            /// Role GeneralServiceCoordinator
            /// </summary>
            GeneralServiceCoordinator,
            /// <summary>
            /// Role VehicleManager
            /// </summary>
            VehicleManager,
        }
        /// <summary>
        /// Tasks Enumeration
        /// </summary>
        public enum Task
        {
            /// <summary>
            /// Task Delete
            /// </summary>
            Delete,
            /// <summary>
            /// Task Insert
            /// </summary>
            Insert,
            /// <summary>
            /// Task LoadModule
            /// </summary>
            LoadModule,
            /// <summary>
            /// Task ManageSettings
            /// </summary>
            ManageSettings,
            /// <summary>
            /// Task Update
            /// </summary>
            Update,
            /// <summary>
            /// Task ViewReport
            /// </summary>
            ViewReport,
            /// <summary>
            /// Task ViewReport
            /// </summary>
            ManageTire,
        }
        /// <summary>
        /// Operations Enumeration
        /// </summary>
        public enum Operation
        {
            /// <summary>
            /// Operation AddLookupItem
            /// </summary>
            AddLookupItem,
            /// <summary>
            /// Operation AddNewCoupon
            /// </summary>
            AddNewCoupon,
            /// <summary>
            /// Operation AddNewFuelLog
            /// </summary>
            AddNewFuelLog,
            /// <summary>
            /// Operation AddNewMaintenanceActivities
            /// </summary>
            AddNewMaintenanceActivities,
            /// <summary>
            /// Operation AddNewMaintenanceExpenses
            /// </summary>
            AddNewMaintenanceExpenses,
            /// <summary>
            /// Operation AddNewMaintenanceParts
            /// </summary>
            AddNewMaintenanceParts,
            /// <summary>
            /// Operation AddMaintenanceRecord
            /// </summary>
            AddMaintenanceRecord,
            /// <summary>
            /// Operation AddNewVehicle
            /// </summary>
            AddNewVehicle,
            /// <summary>
            /// Operation AddNewVehicleExpense
            /// </summary>
            AddNewVehicleExpense,
            /// <summary>
            /// Operation AddVehicleInsurance
            /// </summary>
            AddVehicleInsurance,
            /// <summary>
            /// Operation CanConsumeCoupon
            /// </summary>
            CanConsumeCoupon,
            /// <summary>
            /// Operation DeleteCoupon
            /// </summary>
            DeleteCoupon,
            /// <summary>
            /// Operation DeleteLookupItem
            /// </summary>
            DeleteLookupItem,
            /// <summary>
            /// Operation DeleteLookupItem
            /// </summary>
            DeleteMaintenance,
            /// <summary>
            /// Operation DeleteVehicle
            /// </summary>
            DeleteVehicle,
            /// <summary>
            /// Operation UpdateFuelLog
            /// </summary>
            UpdateFuelLog,
            /// <summary>
            /// Operation UpdateLookupItem
            /// </summary>
            UpdateLookupItem,
            /// <summary>
            /// Operation UpdateMaintenanceRecord
            /// </summary>
            UpdateMaintenanceRecord,
            /// <summary>
            /// Operation UpdateMaintenancExpense
            /// </summary>
            UpdateMaintenancExpense,
            /// <summary>
            /// Operation UpdateVehicle
            /// </summary>
            UpdateVehicle,
            /// <summary>
            /// Operation UpdateVehicleExpense
            /// </summary>
            UpdateVehicleExpense,
            /// <summary>
            /// Operation UpdateVehicleInsurance
            /// </summary>
            UpdateVehicleInsurance,
            /// <summary>
            /// Operation ViewCouponList
            /// </summary>
            ViewCouponList,
            /// <summary>
            /// Operation ViewMaintenanceHistoryList
            /// </summary>
            ViewMaintenanceHistoryList,
            /// <summary>
            /// Operation ViewVehiclesList
            /// </summary>
            ViewVehiclesList,
        }
        #endregion
        /// <summary>
        /// Retrieve Item name from a Role Enum.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <returns>The Role Name.</returns>
        public virtual string ItemName(Role role)
        {
            if ((role == Role.DataEntryOfficer))
            {
                return "DataEntryOfficer";
            }
            if ((role == Role.GeneralServiceCoordinator))
            {
                return "GeneralServiceCoordinator";
            }
            if ((role == Role.VehicleManager))
            {
                return "VehicleManager";
            }
            throw new System.ArgumentException("Unknown Role name", "role");
        }
        /// <summary>
        /// Retrieve Item name from a Task Enum.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns>The Task Name.</returns>
        public virtual string ItemName(Task task)
        {
            if ((task == Task.Delete))
            {
                return "Delete";
            }
            if ((task == Task.Insert))
            {
                return "Insert";
            }
            if ((task == Task.LoadModule))
            {
                return "LoadModule";
            }
            if ((task == Task.ManageSettings))
            {
                return "ManageSettings";
            }
            if ((task == Task.Update))
            {
                return "Update";
            }
            if ((task == Task.ViewReport))
            {
                return "ViewReport";
            }
            if ((task == Task.ManageTire))
            {
                return "ManageTire";
            }
            throw new System.ArgumentException("Unknown Task name", "task");
        }
        /// <summary>
        /// Retrieve Item name from a Operation Enum.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <returns>The Operation Name.</returns>
        public virtual string ItemName(Operation operation)
        {
            if ((operation == Operation.AddLookupItem))
            {
                return "AddLookupItem";
            }
            if ((operation == Operation.AddNewCoupon))
            {
                return "AddNewCoupon";
            }
            if ((operation == Operation.AddNewFuelLog))
            {
                return "AddNewFuelLog";
            }
            if ((operation == Operation.AddNewMaintenanceActivities))
            {
                return "AddNewMaintenanceActivities";
            }
            if ((operation == Operation.AddNewMaintenanceExpenses))
            {
                return "AddNewMaintenanceExpenses";
            }
            if ((operation == Operation.AddNewMaintenanceParts))
            {
                return "AddNewMaintenanceParts";
            }
            if ((operation == Operation.AddMaintenanceRecord))
            {
                return "AddMaintenanceRecord";
            }
            if ((operation == Operation.AddNewVehicle))
            {
                return "AddNewVehicle";
            }
            if ((operation == Operation.AddNewVehicleExpense))
            {
                return "AddNewVehicleExpense";
            }
            if ((operation == Operation.AddVehicleInsurance))
            {
                return "AddVehicleInsurance";
            }
            if ((operation == Operation.CanConsumeCoupon))
            {
                return "CanConsumeCoupon";
            }
            if ((operation == Operation.DeleteCoupon))
            {
                return "DeleteCoupon";
            }
            if ((operation == Operation.DeleteLookupItem))
            {
                return "DeleteLookupItem";
            }
            if ((operation == Operation.DeleteMaintenance))
            {
                return "DeleteMaintenance";
            }
            if ((operation == Operation.DeleteVehicle))
            {
                return "DeleteVehicle";
            }
            if ((operation == Operation.UpdateFuelLog))
            {
                return "UpdateFuelLog";
            }
            if ((operation == Operation.UpdateLookupItem))
            {
                return "UpdateLookupItem";
            }
            if ((operation == Operation.UpdateMaintenanceRecord))
            {
                return "UpdateMaintenanceRecord";
            }
            if ((operation == Operation.UpdateMaintenancExpense))
            {
                return "UpdateMaintenancExpense";
            }
            if ((operation == Operation.UpdateVehicle))
            {
                return "UpdateVehicle";
            }
            if ((operation == Operation.UpdateVehicleExpense))
            {
                return "UpdateVehicleExpense";
            }
            if ((operation == Operation.UpdateVehicleInsurance))
            {
                return "UpdateVehicleInsurance";
            }
            if ((operation == Operation.ViewCouponList))
            {
                return "ViewCouponList";
            }
            if ((operation == Operation.ViewMaintenanceHistoryList))
            {
                return "ViewMaintenanceHistoryList";
            }
            if ((operation == Operation.ViewVehiclesList))
            {
                return "ViewVehiclesList";
            }
            throw new System.ArgumentException("Unknown Operation name", "operation");
        }
    }
}
