using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Security
{
    public class WorkshopPermissionHelper
    {
        #region Enums
        /// <summary>
        /// Roles Enumeration
        /// </summary>
        public enum Role
        {
            /// <summary>
            /// Role BillingManager
            /// </summary>
            BillingManager,
            /// <summary>
            /// Role CustomerManager
            /// </summary>
            CustomerManager,
            /// <summary>
            /// Role DataEntryOfficer
            /// </summary>
            DataEntryOfficer,
            /// <summary>
            /// Role EquipmentManager
            /// </summary>
            EquipmentManager,
            /// <summary>
            /// Role WorkorderManager
            /// </summary>
            WorkorderManager,
            /// <summary>
            /// Role WorkshopManager
            /// </summary>
            WorkshopManager,
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
        }
        /// <summary>
        /// Operations Enumeration
        /// </summary>
        public enum Operation
        {
            /// <summary>
            /// Operation AddContract
            /// </summary>
            AddContract,
            /// <summary>
            /// Operation AddCustomer
            /// </summary>
            AddCustomer,
            /// <summary>
            /// Operation AddEquipment
            /// </summary>
            AddEquipment,
            /// <summary>
            /// Operation AddEquipmentAttachment
            /// </summary>
            AddEquipmentAttachment,
            /// <summary>
            /// Operation AddEquipmentInsurance
            /// </summary>
            AddEquipmentInsurance,
            /// <summary>
            /// Operation AddLaborUnit
            /// </summary>
            AddLaborUnit,
            /// <summary>
            /// Operation AddLookUpItem
            /// </summary>
            AddLookUpItem,
            /// <summary>
            /// Operation AddMaintenanceTask
            /// </summary>
            AddMaintenanceTask,
            /// <summary>
            /// Operation AddNewEquipmentExpiration
            /// </summary>
            AddNewEquipmentExpiration,
            /// <summary>
            /// Operation AddNewMicelaneousItem
            /// </summary>
            AddNewMicelaneousItem,
            /// <summary>
            /// Operation AddNewPMService
            /// </summary>
            AddNewPMService,
            /// <summary>
            /// Operation AddPart
            /// </summary>
            AddPart,
            /// <summary>
            /// Operation AddVendors
            /// </summary>
            AddVendors,
            /// <summary>
            /// Operation AddWorkshopSetting
            /// </summary>
            AddWorkshopSetting,
            /// <summary>
            /// Operation ApproveWorkorder
            /// </summary>
            ApproveWorkorder,
            /// <summary>
            /// Operation CancelContract
            /// </summary>
            CancelContract,
            /// <summary>
            /// Operation CloseWorkorder
            /// </summary>
            CloseWorkorder,
            /// <summary>
            /// Operation DeleteContract
            /// </summary>
            DeleteContract,
            /// <summary>
            /// Operation DeleteCustomer
            /// </summary>
            DeleteCustomer,
            /// <summary>
            /// Operation DeleteEquipment
            /// </summary>
            DeleteEquipment,
            /// <summary>
            /// Operation DeleteEquipmentAttachment
            /// </summary>
            DeleteEquipmentAttachment,
            /// <summary>
            /// Operation DeleteEquipmentExpiration
            /// </summary>
            DeleteEquipmentExpiration,
            /// <summary>
            /// Operation DeleteEquipmentInsurance
            /// </summary>
            DeleteEquipmentInsurance,
            /// <summary>
            /// Operation DeleteInvoice
            /// </summary>
            DeleteInvoice,
            /// <summary>
            /// Operation DeleteLaborUnit
            /// </summary>
            DeleteLaborUnit,
            /// <summary>
            /// Operation DeleteLookupItem
            /// </summary>
            DeleteLookupItem,
            /// <summary>
            /// Operation DeleteMaintenanceTask
            /// </summary>
            DeleteMaintenanceTask,
            /// <summary>
            /// Operation DeleteMicelaneousItem
            /// </summary>
            DeleteMicelaneousItem,
            /// <summary>
            /// Operation DeletePart
            /// </summary>
            DeletePart,
            /// <summary>
            /// Operation DeletePaymentRecord
            /// </summary>
            DeletePaymentRecord,
            /// <summary>
            /// Operation DeletePMService
            /// </summary>
            DeletePMService,
            /// <summary>
            /// Operation DeleteVendors
            /// </summary>
            DeleteVendors,
            /// <summary>
            /// Operation DeleteWorkorder
            /// </summary>
            DeleteWorkorder,
            /// <summary>
            /// Operation DeleteWorkshopSetting
            /// </summary>
            DeleteWorkshopSetting,
            /// <summary>
            /// Operation GenerateInvoice
            /// </summary>
            GenerateInvoice,
            /// <summary>
            /// Operation IssueWorkorder
            /// </summary>
            IssueWorkorder,
            /// <summary>
            /// Operation PostInvoice
            /// </summary>
            PostInvoice,
            /// <summary>
            /// Operation PrintContract
            /// </summary>
            PrintContract,
            /// <summary>
            /// Operation PrintInvoice
            /// </summary>
            PrintInvoice,
            /// <summary>
            /// Operation PrintWorkorder
            /// </summary>
            PrintWorkorder,
            /// <summary>
            /// Operation ReadEquipmentAttachment
            /// </summary>
            ReadEquipmentAttachment,
            /// <summary>
            /// Operation RecordPayment
            /// </summary>
            RecordPayment,
            /// <summary>
            /// Operation RenewContract
            /// </summary>
            RenewContract,
            /// <summary>
            /// Operation UpdateContract
            /// </summary>
            UpdateContract,
            /// <summary>
            /// Operation UpdateCustomer
            /// </summary>
            UpdateCustomer,
            /// <summary>
            /// Operation UpdateEquipment
            /// </summary>
            UpdateEquipment,
            /// <summary>
            /// Operation UpdateEquipmentExpiration
            /// </summary>
            UpdateEquipmentExpiration,
            /// <summary>
            /// Operation UpdateEquipmentInsurance
            /// </summary>
            UpdateEquipmentInsurance,
            /// <summary>
            /// Operation UpdateInvoice
            /// </summary>
            UpdateInvoice,
            /// <summary>
            /// Operation UpdateLookupItem
            /// </summary>
            UpdateLookupItem,
            /// <summary>
            /// Operation UpdateMaintenanceTask
            /// </summary>
            UpdateMaintenanceTask,
            /// <summary>
            /// Operation UpdateMiscelaneousItem
            /// </summary>
            UpdateMiscelaneousItem,
            /// <summary>
            /// Operation UpdatePMService
            /// </summary>
            UpdatePMService,
            /// <summary>
            /// Operation UpdateRecordPayment
            /// </summary>
            UpdateRecordPayment,
            /// <summary>
            /// Operation UpdateVendor
            /// </summary>
            UpdateVendor,
            /// <summary>
            /// Operation UpdateWorkorder
            /// </summary>
            UpdateWorkorder,
            /// <summary>
            /// Operation ViewContractList
            /// </summary>
            ViewContractList,
            /// <summary>
            /// Operation ViewCustomersList
            /// </summary>
            ViewCustomersList,
            /// <summary>
            /// Operation ViewEquipmentList
            /// </summary>
            ViewEquipmentList,
            /// <summary>
            /// Operation ViewInvoiceList
            /// </summary>
            ViewInvoiceList,
            /// <summary>
            /// Operation ViewPMServiceList
            /// </summary>
            ViewPMServiceList,
            /// <summary>
            /// Operation ViewVendors
            /// </summary>
            ViewVendors,
            /// <summary>
            /// Operation ViewWorkorderList
            /// </summary>
            ViewWorkorderList,
            /// <summary>
            /// Operation ViewCustomerList
            /// </summary>
            ViewCustomerList,
      
        }
        #endregion

        /// <summary>
        /// Retrieve Item name from a Role Enum.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <returns>The Role Name.</returns>
       
        public virtual string ItemName(Role role)
        {
            if ((role == Role.BillingManager))
            {
                return "BillingManager";
            }
            if ((role == Role.CustomerManager))
            {
                return "CustomerManager";
            }
            if ((role == Role.DataEntryOfficer))
            {
                return "DataEntryOfficer";
            }
            if ((role == Role.EquipmentManager))
            {
                return "EquipmentManager";
            }
            if ((role == Role.WorkorderManager))
            {
                return "WorkorderManager";
            }
            if ((role == Role.WorkshopManager))
            {
                return "WorkshopManager";
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
            throw new System.ArgumentException("Unknown Task name", "task");
        }
        /// <summary>
        /// Retrieve Item name from a Operation Enum.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <returns>The Operation Name.</returns>
        public virtual string ItemName(Operation operation)
        {
            if ((operation == Operation.AddContract))
            {
                return "AddContract";
            }
            if ((operation == Operation.AddCustomer))
            {
                return "AddCustomer";
            }
            if ((operation == Operation.AddEquipment))
            {
                return "AddEquipment";
            }
            if ((operation == Operation.AddEquipmentAttachment))
            {
                return "AddEquipmentAttachment";
            }
            if ((operation == Operation.AddEquipmentInsurance))
            {
                return "AddEquipmentInsurance";
            }
            if ((operation == Operation.AddLaborUnit))
            {
                return "AddLaborUnit";
            }
            if ((operation == Operation.AddLookUpItem))
            {
                return "AddLookUpItem";
            }
            if ((operation == Operation.AddMaintenanceTask))
            {
                return "AddMaintenanceTask";
            }
            if ((operation == Operation.AddNewEquipmentExpiration))
            {
                return "AddNewEquipmentExpiration";
            }
            if ((operation == Operation.AddNewMicelaneousItem))
            {
                return "AddNewMicelaneousItem";
            }
            if ((operation == Operation.AddNewPMService))
            {
                return "AddNewPMService";
            }
            if ((operation == Operation.AddPart))
            {
                return "AddPart";
            }
            if ((operation == Operation.AddVendors))
            {
                return "AddVendors";
            }
            if ((operation == Operation.AddWorkshopSetting))
            {
                return "AddWorkshopSetting";
            }
            if ((operation == Operation.ApproveWorkorder))
            {
                return "ApproveWorkorder";
            }
            if ((operation == Operation.CancelContract))
            {
                return "CancelContract";
            }
            if ((operation == Operation.CloseWorkorder))
            {
                return "CloseWorkorder";
            }
            if ((operation == Operation.DeleteContract))
            {
                return "DeleteContract";
            }
            if ((operation == Operation.DeleteCustomer))
            {
                return "DeleteCustomer";
            }
            if ((operation == Operation.DeleteEquipment))
            {
                return "DeleteEquipment";
            }
            if ((operation == Operation.DeleteEquipmentAttachment))
            {
                return "DeleteEquipmentAttachment";
            }
            if ((operation == Operation.DeleteEquipmentExpiration))
            {
                return "DeleteEquipmentExpiration";
            }
            if ((operation == Operation.DeleteEquipmentInsurance))
            {
                return "DeleteEquipmentInsurance";
            }
            if ((operation == Operation.DeleteInvoice))
            {
                return "DeleteInvoice";
            }
            if ((operation == Operation.DeleteLaborUnit))
            {
                return "DeleteLaborUnit";
            }
            if ((operation == Operation.DeleteLookupItem))
            {
                return "DeleteLookupItem";
            }
            if ((operation == Operation.DeleteMaintenanceTask))
            {
                return "DeleteMaintenanceTask";
            }
            if ((operation == Operation.DeleteMicelaneousItem))
            {
                return "DeleteMicelaneousItem";
            }
            if ((operation == Operation.DeletePart))
            {
                return "DeletePart";
            }
            if ((operation == Operation.DeletePaymentRecord))
            {
                return "DeletePaymentRecord";
            }
            if ((operation == Operation.DeletePMService))
            {
                return "DeletePMService";
            }
            if ((operation == Operation.DeleteVendors))
            {
                return "DeleteVendors";
            }
            if ((operation == Operation.DeleteWorkorder))
            {
                return "DeleteWorkorder";
            }
            if ((operation == Operation.DeleteWorkshopSetting))
            {
                return "DeleteWorkshopSetting";
            }
            if ((operation == Operation.GenerateInvoice))
            {
                return "GenerateInvoice";
            }
            if ((operation == Operation.IssueWorkorder))
            {
                return "IssueWorkorder";
            }
            if ((operation == Operation.PostInvoice))
            {
                return "PostInvoice";
            }
            if ((operation == Operation.PrintContract))
            {
                return "PrintContract";
            }
            if ((operation == Operation.PrintInvoice))
            {
                return "PrintInvoice";
            }
            if ((operation == Operation.PrintWorkorder))
            {
                return "PrintWorkorder";
            }
            if ((operation == Operation.ReadEquipmentAttachment))
            {
                return "ReadEquipmentAttachment";
            }
            if ((operation == Operation.RecordPayment))
            {
                return "RecordPayment";
            }
            if ((operation == Operation.RenewContract))
            {
                return "RenewContract";
            }
            if ((operation == Operation.UpdateContract))
            {
                return "UpdateContract";
            }
            if ((operation == Operation.UpdateCustomer))
            {
                return "UpdateCustomer";
            }
            if ((operation == Operation.UpdateEquipment))
            {
                return "UpdateEquipment";
            }
            if ((operation == Operation.UpdateEquipmentExpiration))
            {
                return "UpdateEquipmentExpiration";
            }
            if ((operation == Operation.UpdateEquipmentInsurance))
            {
                return "UpdateEquipmentInsurance";
            }
            if ((operation == Operation.UpdateInvoice))
            {
                return "UpdateInvoice";
            }
            if ((operation == Operation.UpdateLookupItem))
            {
                return "UpdateLookupItem";
            }
            if ((operation == Operation.UpdateMaintenanceTask))
            {
                return "UpdateMaintenanceTask";
            }
            if ((operation == Operation.UpdateMiscelaneousItem))
            {
                return "UpdateMiscelaneousItem";
            }
            if ((operation == Operation.UpdatePMService))
            {
                return "UpdatePMService";
            }
            if ((operation == Operation.UpdateRecordPayment))
            {
                return "UpdateRecordPayment";
            }
            if ((operation == Operation.UpdateVendor))
            {
                return "UpdateVendor";
            }
            if ((operation == Operation.UpdateWorkorder))
            {
                return "UpdateWorkorder";
            }
            if ((operation == Operation.ViewContractList))
            {
                return "ViewContractList";
            }
            if ((operation == Operation.ViewCustomersList))
            {
                return "ViewCustomersList";
            }
            if ((operation == Operation.ViewEquipmentList))
            {
                return "ViewEquipmentList";
            }
            if ((operation == Operation.ViewInvoiceList))
            {
                return "ViewInvoiceList";
            }
            if ((operation == Operation.ViewPMServiceList))
            {
                return "ViewPMServiceList";
            }
            if ((operation == Operation.ViewVendors))
            {
                return "ViewVendors";
            }
            if ((operation == Operation.ViewWorkorderList))
            {
                return "ViewWorkorderList";
            }
            throw new System.ArgumentException("Unknown Operation name", "operation");
        }
    }
}
