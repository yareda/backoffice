﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("SecurityModel", "fk_user_opt_reference_applicat", "application_option", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ClearOffice.Security.Data.ApplicationOption), "user_option_value", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ClearOffice.Security.Data.UserOptionValue), true)]
[assembly: EdmRelationshipAttribute("SecurityModel", "fk_user_opt_reference_user", "user", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ClearOffice.Security.Data.User), "user_option_value", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ClearOffice.Security.Data.UserOptionValue), true)]

#endregion

namespace ClearOffice.Security.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ClearOfficeEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ClearOfficeEntities object using the connection string found in the 'ClearOfficeEntities' section of the application configuration file.
        /// </summary>
        public ClearOfficeEntities() : base("name=ClearOfficeEntities", "ClearOfficeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ClearOfficeEntities object.
        /// </summary>
        public ClearOfficeEntities(string connectionString) : base(connectionString, "ClearOfficeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ClearOfficeEntities object.
        /// </summary>
        public ClearOfficeEntities(EntityConnection connection) : base(connection, "ClearOfficeEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ApplicationOption> ApplicationOptions
        {
            get
            {
                if ((_ApplicationOptions == null))
                {
                    _ApplicationOptions = base.CreateObjectSet<ApplicationOption>("ApplicationOptions");
                }
                return _ApplicationOptions;
            }
        }
        private ObjectSet<ApplicationOption> _ApplicationOptions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UserOptionValue> UserOptionValues
        {
            get
            {
                if ((_UserOptionValues == null))
                {
                    _UserOptionValues = base.CreateObjectSet<UserOptionValue>("UserOptionValues");
                }
                return _UserOptionValues;
            }
        }
        private ObjectSet<UserOptionValue> _UserOptionValues;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ApplicationOptions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToApplicationOptions(ApplicationOption applicationOption)
        {
            base.AddObject("ApplicationOptions", applicationOption);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UserOptionValues EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUserOptionValues(UserOptionValue userOptionValue)
        {
            base.AddObject("UserOptionValues", userOptionValue);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityModel", Name="ApplicationOption")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ApplicationOption : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ApplicationOption object.
        /// </summary>
        /// <param name="optionId">Initial value of the OptionId property.</param>
        public static ApplicationOption CreateApplicationOption(global::System.Int32 optionId)
        {
            ApplicationOption applicationOption = new ApplicationOption();
            applicationOption.OptionId = optionId;
            return applicationOption;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OptionId
        {
            get
            {
                return _OptionId;
            }
            set
            {
                if (_OptionId != value)
                {
                    OnOptionIdChanging(value);
                    ReportPropertyChanging("OptionId");
                    _OptionId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OptionId");
                    OnOptionIdChanged();
                }
            }
        }
        private global::System.Int32 _OptionId;
        partial void OnOptionIdChanging(global::System.Int32 value);
        partial void OnOptionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ModuleId
        {
            get
            {
                return _ModuleId;
            }
            set
            {
                OnModuleIdChanging(value);
                ReportPropertyChanging("ModuleId");
                _ModuleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModuleId");
                OnModuleIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ModuleId;
        partial void OnModuleIdChanging(Nullable<global::System.Int32> value);
        partial void OnModuleIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OptionName
        {
            get
            {
                return _OptionName;
            }
            set
            {
                OnOptionNameChanging(value);
                ReportPropertyChanging("OptionName");
                _OptionName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OptionName");
                OnOptionNameChanged();
            }
        }
        private global::System.String _OptionName;
        partial void OnOptionNameChanging(global::System.String value);
        partial void OnOptionNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OptionValue
        {
            get
            {
                return _OptionValue;
            }
            set
            {
                OnOptionValueChanging(value);
                ReportPropertyChanging("OptionValue");
                _OptionValue = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OptionValue");
                OnOptionValueChanged();
            }
        }
        private global::System.String _OptionValue;
        partial void OnOptionValueChanging(global::System.String value);
        partial void OnOptionValueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OptionHelpText
        {
            get
            {
                return _OptionHelpText;
            }
            set
            {
                OnOptionHelpTextChanging(value);
                ReportPropertyChanging("OptionHelpText");
                _OptionHelpText = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OptionHelpText");
                OnOptionHelpTextChanged();
            }
        }
        private global::System.String _OptionHelpText;
        partial void OnOptionHelpTextChanging(global::System.String value);
        partial void OnOptionHelpTextChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityModel", "fk_user_opt_reference_applicat", "user_option_value")]
        public EntityCollection<UserOptionValue> UserOptionValue
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserOptionValue>("SecurityModel.fk_user_opt_reference_applicat", "user_option_value");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserOptionValue>("SecurityModel.fk_user_opt_reference_applicat", "user_option_value", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        public static User CreateUser(global::System.Int32 userId)
        {
            User user = new User();
            user.UserId = userId;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                OnFullNameChanging(value);
                ReportPropertyChanging("FullName");
                _FullName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FullName");
                OnFullNameChanged();
            }
        }
        private global::System.String _FullName;
        partial void OnFullNameChanging(global::System.String value);
        partial void OnFullNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> PasswordNeverExpires
        {
            get
            {
                return _PasswordNeverExpires;
            }
            set
            {
                OnPasswordNeverExpiresChanging(value);
                ReportPropertyChanging("PasswordNeverExpires");
                _PasswordNeverExpires = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PasswordNeverExpires");
                OnPasswordNeverExpiresChanged();
            }
        }
        private Nullable<global::System.Boolean> _PasswordNeverExpires;
        partial void OnPasswordNeverExpiresChanging(Nullable<global::System.Boolean> value);
        partial void OnPasswordNeverExpiresChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Disabled
        {
            get
            {
                return _Disabled;
            }
            set
            {
                OnDisabledChanging(value);
                ReportPropertyChanging("Disabled");
                _Disabled = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Disabled");
                OnDisabledChanged();
            }
        }
        private Nullable<global::System.Boolean> _Disabled;
        partial void OnDisabledChanging(Nullable<global::System.Boolean> value);
        partial void OnDisabledChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> CanNotChangePassword
        {
            get
            {
                return _CanNotChangePassword;
            }
            set
            {
                OnCanNotChangePasswordChanging(value);
                ReportPropertyChanging("CanNotChangePassword");
                _CanNotChangePassword = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CanNotChangePassword");
                OnCanNotChangePasswordChanged();
            }
        }
        private Nullable<global::System.Boolean> _CanNotChangePassword;
        partial void OnCanNotChangePasswordChanging(Nullable<global::System.Boolean> value);
        partial void OnCanNotChangePasswordChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityModel", "fk_user_opt_reference_user", "user_option_value")]
        public EntityCollection<UserOptionValue> UserOptionValue
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserOptionValue>("SecurityModel.fk_user_opt_reference_user", "user_option_value");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserOptionValue>("SecurityModel.fk_user_opt_reference_user", "user_option_value", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SecurityModel", Name="UserOptionValue")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UserOptionValue : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UserOptionValue object.
        /// </summary>
        /// <param name="valueId">Initial value of the ValueId property.</param>
        public static UserOptionValue CreateUserOptionValue(global::System.Int32 valueId)
        {
            UserOptionValue userOptionValue = new UserOptionValue();
            userOptionValue.ValueId = valueId;
            return userOptionValue;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ValueId
        {
            get
            {
                return _ValueId;
            }
            set
            {
                if (_ValueId != value)
                {
                    OnValueIdChanging(value);
                    ReportPropertyChanging("ValueId");
                    _ValueId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ValueId");
                    OnValueIdChanged();
                }
            }
        }
        private global::System.Int32 _ValueId;
        partial void OnValueIdChanging(global::System.Int32 value);
        partial void OnValueIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private Nullable<global::System.Int32> _UserId;
        partial void OnUserIdChanging(Nullable<global::System.Int32> value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OptionId
        {
            get
            {
                return _OptionId;
            }
            set
            {
                OnOptionIdChanging(value);
                ReportPropertyChanging("OptionId");
                _OptionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OptionId");
                OnOptionIdChanged();
            }
        }
        private Nullable<global::System.Int32> _OptionId;
        partial void OnOptionIdChanging(Nullable<global::System.Int32> value);
        partial void OnOptionIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityModel", "fk_user_opt_reference_applicat", "application_option")]
        public ApplicationOption ApplicationOption
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ApplicationOption>("SecurityModel.fk_user_opt_reference_applicat", "application_option").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ApplicationOption>("SecurityModel.fk_user_opt_reference_applicat", "application_option").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ApplicationOption> ApplicationOptionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ApplicationOption>("SecurityModel.fk_user_opt_reference_applicat", "application_option");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ApplicationOption>("SecurityModel.fk_user_opt_reference_applicat", "application_option", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SecurityModel", "fk_user_opt_reference_user", "user")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("SecurityModel.fk_user_opt_reference_user", "user").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("SecurityModel.fk_user_opt_reference_user", "user").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("SecurityModel.fk_user_opt_reference_user", "user");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("SecurityModel.fk_user_opt_reference_user", "user", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
