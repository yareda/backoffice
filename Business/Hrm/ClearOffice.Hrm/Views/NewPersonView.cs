using System;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Hrm.Business;

namespace ClearOffice.Hrm.Views
{
    public partial class NewPersonView : XtraForm, IDetailForm
    {
        private readonly ProfileProxy proxy;
        private Person person;
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public NewPersonView()
        {
            InitializeComponent();
            proxy = new ProfileProxy();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            person = new Person();
            personBindingSource.DataSource = person;
            nationalityBindingSource.DataSource = proxy.Context.Nationalities.ToList();
            maritalStatusBindingSource.DataSource = proxy.Context.MaritalStatuses;
            sexBindingSource.DataSource = Sex.GetSexLookup();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            personBindingSource.EndEdit();
            person = (Person)personBindingSource.Current;
            
            try
            {
                // Add the current person object to the collection
                proxy.Context.Persons.AddObject(person);

                // Create an employee object and associate the current person with it
                var employee = new Employee();
                employee.PersonalDetail = person;
                employee.EmployeeNo = "######";
                employee.StatusId = Employee.StatusActive;
                proxy.Context.Employees.AddObject(employee);

                // Persist local changes to the database.
                proxy.Save();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while adding new employee.",exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void CancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void personBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.SaveCommand.Enabled = person.IsValid();
        }



        public void AuthorizeForm()
        {
            SaveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                 hph.ItemName(HRMPermissionHelper.Operation.AddEmployee));

        }

        private void addNationalityHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.NationalityView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.nationalityBindingSource.DataSource = store.Context.Nationalities.ToList();
            }
        }
    }
}