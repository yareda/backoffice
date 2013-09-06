﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ------------------------------------------------------------------------------
//  <auto-generated>
//     This code was generated by NetSqlAzMan CodeDom.
//     NetSqlAzMan - Andrea Ferendeles - http://netsqlazman.codeplex.com
//     NetSqlAzMan Version: 3.6.0.15
//     CLR Version: v4.0.30319
//     <NetSqlAzMan-info>
//        Store: ClearOffice
//        Application: FixedAsset
//        Last update: 6/4/2012 11:20:16 ጡዋት
//     </NetSqlAzMan-info>
//  </auto-generated>
// ------------------------------------------------------------------------------
// 
// 
// TODO: Add NetSqlAzMan.dll Assembly reference.
// 
// 
namespace ClearOffice.Security
{
    using System;
    using System.Security.Principal;
    using System.Collections.Generic;
    using System.Text;
    using NetSqlAzMan;
    using NetSqlAzMan.Interfaces;

    /// <summary>
    /// NetSqlAzMan Check Access Helper Class for NetSqlAzMan 'FixedAsset' Application 
    /// </summary>
    public partial class FixedAssetPermissionHelper
    {                                       
        #region Enums
        /// <summary>
        /// Roles Enumeration
        /// </summary>
        public enum Role
        {
            /// <summary>
            /// Role AssetManger
            /// </summary>
            AssetManger,
            /// <summary>
            /// Role CustodianManager
            /// </summary>
            CustodianManager,
            /// <summary>
            /// Role DataEntryOfficer
            /// </summary>
            DataEntryOfficer,
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
            /// Task ManageSetting
            /// </summary>
            ManageSetting,
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
            /// Operation AddAsset
            /// </summary>
            AddAsset,
            /// <summary>
            /// Operation AddAssetCategory
            /// </summary>
            AddAssetCategory,
            /// <summary>
            /// Operation AddCustodian
            /// </summary>
            AddCustodian,
            /// <summary>
            /// Operation AddLookupItem
            /// </summary>
            AddLookupItem,
            /// <summary>
            /// Operation AdjustAsset
            /// </summary>
            AdjustAsset,
            /// <summary>
            /// Operation AssignNewAsset
            /// </summary>
            AssignNewAsset,
            /// <summary>
            /// Operation CalculateDepreciation
            /// </summary>
            CalculateDepreciation,
            /// <summary>
            /// Operation DeleteAsset
            /// </summary>
            DeleteAsset,
            /// <summary>
            /// Operation DeleteAssetCategory
            /// </summary>
            DeleteAssetCategory,
            /// <summary>
            /// Operation DeleteCustodian
            /// </summary>
            DeleteCustodian,
            /// <summary>
            /// Operation DeleteLookupItem
            /// </summary>
            DeleteLookupItem,
            /// <summary>
            /// Operation DisposeAsset
            /// </summary>
            DisposeAsset,
            /// <summary>
            /// Operation EditApplicationSetting
            /// </summary>
            EditApplicationSetting,
            /// <summary>
            /// Operation ReturnAsset
            /// </summary>
            ReturnAsset,
            /// <summary>
            /// Operation TransferAsset
            /// </summary>
            TransferAsset,
            /// <summary>
            /// Operation UpdateAsset
            /// </summary>
            UpdateAsset,
            /// <summary>
            /// Operation UpdateCustodian
            /// </summary>
            UpdateCustodian,
            /// <summary>
            /// Operation UpdateLookupItem
            /// </summary>
            UpdateLookupItem,
            /// <summary>
            /// Operation ViewApplicationSetting
            /// </summary>
            ViewApplicationSetting,
            /// <summary>
            /// Operation ViewAssetList
            /// </summary>
            ViewAssetList,
            /// <summary>
            /// Operation ViewAssetCategory
            /// </summary>
            ViewAssetCategory,
            /// <summary>
            /// Operation ViewCautodianList
            /// </summary>
            ViewCautodianList,
        }
        #endregion

        /// <summary>
        /// Retrieve Item name from a Role Enum.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <returns>The Role Name.</returns>
        public virtual string ItemName(Role role)
        {
            if ((role == Role.AssetManger))
            {
                return "AssetManger";
            }
            if ((role == Role.CustodianManager))
            {
                return "CustodianManager";
            }
            if ((role == Role.DataEntryOfficer))
            {
                return "DataEntryOfficer";
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
            if ((task == Task.ManageSetting))
            {
                return "ManageSetting";
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
            if ((operation == Operation.AddAsset))
            {
                return "AddAsset";
            }
            if ((operation == Operation.AddAssetCategory))
            {
                return "AddAssetCategory";
            }
            if ((operation == Operation.AddCustodian))
            {
                return "AddCustodian";
            }
            if ((operation == Operation.AddLookupItem))
            {
                return "AddLookupItem";
            }
            if ((operation == Operation.AdjustAsset))
            {
                return "AdjustAsset";
            }
            if ((operation == Operation.AssignNewAsset))
            {
                return "AssignNewAsset";
            }
            if ((operation == Operation.CalculateDepreciation))
            {
                return "CalculateDepreciation";
            }
            if ((operation == Operation.DeleteAsset))
            {
                return "DeleteAsset";
            }
            if ((operation == Operation.DeleteAssetCategory))
            {
                return "DeleteAssetCategory";
            }
            if ((operation == Operation.DeleteCustodian))
            {
                return "DeleteCustodian";
            }
            if ((operation == Operation.DeleteLookupItem))
            {
                return "DeleteLookupItem";
            }
            if ((operation == Operation.DisposeAsset))
            {
                return "DisposeAsset";
            }
            if ((operation == Operation.EditApplicationSetting))
            {
                return "EditApplicationSetting";
            }
            if ((operation == Operation.ReturnAsset))
            {
                return "ReturnAsset";
            }
            if ((operation == Operation.TransferAsset))
            {
                return "TransferAsset";
            }
            if ((operation == Operation.UpdateAsset))
            {
                return "UpdateAsset";
            }
            if ((operation == Operation.UpdateCustodian))
            {
                return "UpdateCustodian";
            }
            if ((operation == Operation.UpdateLookupItem))
            {
                return "UpdateLookupItem";
            }
            if ((operation == Operation.ViewAssetCategory))
            {
                return "ViewAssetCategory";
            }
            if ((operation == Operation.ViewApplicationSetting))
            {
                return "ViewApplicationSetting";
            }
            if ((operation == Operation.ViewAssetList))
            {
                return "ViewAssetList";
            }
            if ((operation == Operation.ViewCautodianList))
            {
                return "ViewCautodianList";
            }
            throw new System.ArgumentException("Unknown Operation name", "operation");
        }
    }
}
