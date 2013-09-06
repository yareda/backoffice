using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using System.Linq;
using ClearOffice.Security;

namespace ClearOffice.Hrm.Views
{
    public partial class EmployeeDetailView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private ProfileProxy _proxy;
        private Employee employee;
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;

        public EmployeeDetailView()
        {
           InitializeComponent();
           _proxy = new ProfileProxy();
           hph = new HRMPermissionHelper();
           permissionManager = PermissionManager.GetPermissionManager();
           AuthorizeForm();
           
        }

        private void LoadEmployee(int employeeId)
        {
            // Initialize required objects.
            //_proxy = new ProfileProxy();

            LoadLookups();

            employee = _proxy.Context.Employees.First(e => e.EmployeeId == employeeId);
            // Set DataSource properties for appropriate BindingSource controls.
            employeeBindingSource.DataSource = employee;
            contactAddressesBindingSource.DataSource = employee.PersonalDetail.ContactAddress;
            // educational history bindings
            educationBindingSource.DataSource = employee.EducationalHistory;
            //Work Experiance Bindings
            workexperienceBindingSource.DataSource = employee.WorkExperiances;
            //Dependant Bindings
            dependentsBindingSource.DataSource = employee.Dependants;
            //Medical Record Bindings
            medicalBindingSource.DataSource = employee.MedicalRecords;
            //Skill Bindings
            skillsBindingSource.DataSource = employee.Skills;
            //Benefit Bindings
            benefitsBindingSource.DataSource = employee.Benefits;
            //Accident Bindings
            accidentsBindingSource.DataSource = employee.Accidents;
            //leave binding
            leavesBindingSource.DataSource = employee.EmployeeLeave;

            this.Text = string.Format("{0} {1}", employee.PersonalDetail.FirstName, employee.PersonalDetail.LastName);
        }

        private void LoadLookups()
        {
            departementsBindingSource.DataSource = _proxy.Context.Departments.ToList();
            educationLevelBindingSource.DataSource = _proxy.Context.EducationLevels.ToList();
            educationTypeBindingSource.DataSource = _proxy.Context.EducationTypes.ToList();
            dependancyTypeBindingSource.DataSource = _proxy.Context.DependantTypes.ToList();
            var sex = new List<Gender>();
            sex.Add(new Gender("Male", 1));
            sex.Add(new Gender("Female", 2));
            genderBindingSource.DataSource = sex;
            skillTypeBindingSource.DataSource = _proxy.Context.EmployeeSkillTypes.ToList();
            benefitTypeBindingSource.DataSource = _proxy.Context.BenefitTypes;
            jobBindingSource.DataSource = _proxy.Context.Jobs.ToList();
            employeeTypeBindingSource.DataSource = _proxy.Context.EmployeeTypes.ToList();
            employeeStatusBindingSource.DataSource = _proxy.Context.EmployeeStatus.ToList();
            organizationBindingSource.DataSource = _proxy.Context.Organizations.ToList();
            leaveTypeBindingSource.DataSource = _proxy.Context.LeaveTypes.ToList();
            nationalityBindingSource.DataSource = _proxy.Context.Nationalities.ToList();
            maritalStatusBindingSource.DataSource = _proxy.Context.MaritalStatuses.ToList();
            sexBindingSource.DataSource = Sex.GetSexLookup();
        }

        #region IDetailForm members

        public void ShowObject(object keyValue)
        {
            LoadEmployee(Convert.ToInt32(keyValue));
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        #endregion


        private void newContactToolStripButton_Click(object sender, EventArgs e)
        {
            AddContactAddress();

            //saveContactToolStripButton.Enabled = true;
        }

        /// <summary>
        /// Adds a new ContactAddress record to the employee object. Here we are delaying the addition of the
        /// object to the collection by creating a newly detached object to be added at a latter time.
        /// </summary>
        private void AddContactAddress()
        {
            var address = new ContactAddress { IsNew = true };
            this.contactAddressDetailBindingSource.DataSource = address;
        }

        private void saveContactToolStripButton_Click(object sender, EventArgs e)
        {
            SaveContactAddress();
            saveContactToolStripButton.Enabled = false;
            cancelContactEditToolStripButton.Enabled = true;
            newContactToolStripButton.Enabled = true;
        }

        /// <summary>
        /// Save contact address information. The saving process depends on the state of the current address object.
        /// If we are in new mode then we need to manually add the new object to the ContactAddress collection of the 
        /// PersonDetail property. If not we don't need to do anything.
        /// </summary>
        private void SaveContactAddress()
        {
            contactAddressDetailBindingSource.EndEdit();

            var address = (ContactAddress)contactAddressDetailBindingSource.Current;
            if (address.IsNew)
            {
                employee.PersonalDetail.ContactAddress.Add(address);
            }
        }

        private void contactAddressGridControl_DoubleClick(object sender, EventArgs e)
        {
            EditContactAddress();

            saveContactToolStripButton.Enabled = true;
            deleteContactAddress.Enabled = true;
        }

        /// <summary>
        /// Edit the currently selected ContactAddress record on the detail controls. First we need to get a handle
        /// of the current object from the grid and set it on the contactAddressDetailBindingSource
        /// </summary>
        private void EditContactAddress()
        {
            var address = (ContactAddress)contactAddressesBindingSource.Current;
            contactAddressDetailBindingSource.DataSource = address;
        }

        private void DeleteContactAddress_Click(object sender, EventArgs e)
        {
            var address = (ContactAddress)contactAddressDetailBindingSource.Current;
            if (address != null)
            {
                try
                {
                    employee.PersonalDetail.ContactAddress.Remove(address);
                }
                catch (Exception)
                {
                    ViewHelper.ShowErrorMessage("Unable to delete the selected contact");
                }

            }
        }

        private void newWorkexperienceToolStripButton_Click(object sender, EventArgs e)
        {
            workexperienceDetailBindingSource.DataSource = new EmployeeWorkExperiance() { IsNew = true };

            //btnSaveExperiance.Enabled = true;
        }

        private void SaveEducationalHistory()
        {
            educationDetailBindingSource.EndEdit();
            var obj = (EmployeeEducationalHistory)educationDetailBindingSource.Current;
            if (obj.IsNew)
            {
                employee.EducationalHistory.Add(obj);
            }
        }

        private void btnDeleteEduca_Click(object sender, EventArgs e)
        {

        }

        private void btnNewEducation_Click_1(object sender, EventArgs e)
        {
            AddEducation();
        }

        private void AddEducation()
        {
            educationDetailBindingSource.DataSource = new EmployeeEducationalHistory() { IsNew = true };
            //btnSaveEducation.Enabled = true;
        }

        private void btnSaveEducation_Click_1(object sender, EventArgs e)
        {
            SaveEducationalHistory();
            btnSaveEducation.Enabled = false;
            cancelEducationtoolStripButton.Enabled = true;
            btnNewEducation.Enabled = true;
        }

        private void btnDeleteEducation_Click(object sender, EventArgs e)
        {
            RemoveEducation();
        }

        private void RemoveEducation()
        {
            var ed = (EmployeeEducationalHistory)educationDetailBindingSource.Current;
            if (ed != null)
            {
                try
                {
                    employee.EducationalHistory.Remove(ed);

                    //btnSaveEducation.Enabled = false;
                    //btnDeleteEducation.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected education.");
                }
            }
        }

        private void btnSaveExperiance_Click(object sender, EventArgs e)
        {
            AddExperinance();
            btnSaveExperiance.Enabled = false;
            cancelExperiencetoolStripButton.Enabled = true;
            btnNewExperiance.Enabled = true;
        }

        private void AddExperinance()
        {
            workexperienceDetailBindingSource.EndEdit();
            var obj = (EmployeeWorkExperiance)workexperienceDetailBindingSource.Current;
            if (obj != null)
            {
                if (obj.IsNew)
                {
                    employee.WorkExperiances.Add(obj);

                    //btnDeleteExperiance.Enabled = true;
                }
            }
        }

        private void btnDeleteExperiance_Click(object sender, EventArgs e)
        {
            RemoveExperiance();
        }

        private void RemoveExperiance()
        {
            var exp = (EmployeeWorkExperiance)workexperienceDetailBindingSource.Current;
            if (exp != null)
            {
                try
                {
                    employee.WorkExperiances.Remove(exp);

                    //btnSaveExperiance.Enabled = false;
                    //btnDeleteExperiance.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected work experiance.");
                }
            }
        }

        private void btnNewDependant_Click(object sender, EventArgs e)
        {
            dependentDetailBindingSource.DataSource = new EmployeeDependant() { IsNew = true };

            //btnSaveDependant.Enabled = true;
        }

        private void AddDependant()
        {
            var obj = (EmployeeDependant)dependentDetailBindingSource.Current;
            if (obj != null)
            {
                if (obj.IsNew)
                {
                    employee.Dependants.Add(obj);

                    //btnDeleteDependant.Enabled = true;
                }
            }
        }

        private void btnSaveDependant_Click(object sender, EventArgs e)
        {
            AddDependant();
            btnSaveDependant.Enabled = false;
            cancelDependenttoolstripButton.Enabled = true;
            btnNewDependant.Enabled = true;
        }

        private void btnNewMedical_Click(object sender, EventArgs e)
        {
            medicalDetailBindingSource.DataSource = new EmployeeMedicalRecord() { IsNew = true };

            //btnSaveMedical.Enabled = true;
        }

        private void btnDeleteMedical_Click(object sender, EventArgs e)
        {
            RemoveMedical();
        }

        private void RemoveMedical()
        {
            var obj = (EmployeeMedicalRecord)medicalDetailBindingSource.Current;
            if (obj != null)
            {
                try
                {
                    employee.MedicalRecords.Remove(obj);

                    //btnDeleteMedical.Enabled = false;
                    //btnDeleteMedical.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected medical record.");
                }

            }
        }

        private void RemoveDependant()
        {
            var obj = (EmployeeDependant)dependentDetailBindingSource.Current;
            if (obj != null)
            {
                try
                {
                    dependentsBindingSource.Remove(obj);

                    //btnDeleteDependant.Enabled = false;
                    //btnSaveDependant.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected dependant.");
                }

            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeEducationalHistory)educationBindingSource.Current;
            if (obj != null)
            {
                educationDetailBindingSource.DataSource = obj;
                btnSaveEducation.Enabled = true;
                btnDeleteEducation.Enabled = true;
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeWorkExperiance)workexperienceBindingSource.Current;
            if (obj != null)
            {
                workexperienceDetailBindingSource.DataSource = obj;

                btnSaveExperiance.Enabled = true;
                btnDeleteExperiance.Enabled = true;
            }
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeDependant)dependentsBindingSource.Current;
            if (obj != null)
            {
                dependentDetailBindingSource.DataSource = obj;

                btnSaveDependant.Enabled = true;
                btnDeleteDependant.Enabled = true;
            }
        }

        private void btnSaveMedical_Click(object sender, EventArgs e)
        {
            AddMedical();
            btnSaveMedical.Enabled = false;
            cancelMedicaltoolStripButton.Enabled = true;
            btnNewMedical.Enabled = true;
        }

        private void AddMedical()
        {
            var obj = (EmployeeMedicalRecord)medicalDetailBindingSource.Current;
            if (obj != null)
            {
                if (obj.IsNew)
                {
                    employee.MedicalRecords.Add(obj);
                    btnSaveMedical.Enabled = true;
                    btnDeleteMedical.Enabled = true;

                }
            }
        }

        private void btnDeleteDependant_Click(object sender, EventArgs e)
        {
            RemoveDependant();
        }

        private void gridControl4_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeMedicalRecord)medicalBindingSource.Current;
            if (obj != null)
            {
                medicalDetailBindingSource.DataSource = obj;

                btnSaveMedical.Enabled = true;
                btnDeleteMedical.Enabled = true;
            }
        }

        private void btnNewSkill_Click(object sender, EventArgs e)
        {
            skillsDetailBindingSource.DataSource = new EmployeeSkill() { IsNew = true };

            //btnSaveSkill.Enabled = true;

        }

        private void btnSaveSkill_Click(object sender, EventArgs e)
        {
            AddSkill();
            btnSaveSkill.Enabled = false;
            cancelSkilltoolStripButton.Enabled = true;
            btnNewSkill.Enabled = true;
        }

        private void AddSkill()
        {
            var obj = (EmployeeSkill)skillsDetailBindingSource.Current;
            if (obj != null)
            {
                employee.Skills.Add(obj);

                //btnDeleteSkill.Enabled = true;
            }
        }

        private void btnDeleteSkill_Click(object sender, EventArgs e)
        {
            RemoveSkill();
        }

        private void RemoveSkill()
        {
            var obj = (EmployeeSkill)skillsBindingSource.Current;

            if (obj != null)
            {
                try
                {
                    employee.Skills.Remove(obj);
                    //btnDeleteSkill.Enabled = false;
                    //btnSaveSkill.Enabled = false;

                }
                catch (Exception)
                {
                    ViewHelper.ShowErrorMessage("Unable to delete the selected skill.");
                }

            }
        }

        private void btnNewBenefit_Click(object sender, EventArgs e)
        {
            benefitDetailBindingSource.DataSource = new EmployeeBenefit { IsNew = true };

            btnSaveBenefit.Enabled = true;
        }

        private void btnSaveBenefit_Click(object sender, EventArgs e)
        {
            AddBenefit();
            btnSaveBenefit.Enabled = false;
            cancelBenefitstoolStripButton.Enabled = true;
            btnNewBenefit.Enabled = true;
        }

        private void AddBenefit()
        {
            var obj = (EmployeeBenefit)benefitDetailBindingSource.Current;

            if (obj != null)
            {
                if (obj.IsNew)
                {
                    employee.Benefits.Add(obj);

                    //btnDeleteBenefit.Enabled = true;

                }
            }
        }

        private void btnDeleteBenefit_Click(object sender, EventArgs e)
        {
            RemoveBenefit();
        }

        private void RemoveBenefit()
        {
            var obj = (EmployeeBenefit)benefitDetailBindingSource.Current;
            if (obj != null)
            {
                try
                {
                    employee.Benefits.Remove(obj);

                    //btnDeleteBenefit.Enabled = false;
                    //btnSaveBenefit.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected benefit.");
                }

            }
        }

        private void btnNewAccident_Click(object sender, EventArgs e)
        {
            accidentDetailBindingSource.DataSource = new EmployeeAccident() { IsNew = true };

            //btnSaveAccident.Enabled = true;
        }

        private void btnSaveAccident_Click(object sender, EventArgs e)
        {
            AddAccident();
            btnSaveAccident.Enabled = false;
            cancelAccidentstoolStripButton.Enabled = true;
            btnNewAccident.Enabled = true;
        }

        private void AddAccident()
        {
            var obj = (EmployeeAccident)accidentDetailBindingSource.Current;
            if (obj != null)
            {
                employee.Accidents.Add(obj);

                // btnDeleteAccident.Enabled = true;

            }
        }

        private void btnDeleteAccident_Click(object sender, EventArgs e)
        {
            var obj = (EmployeeAccident)accidentDetailBindingSource.Current;
            if (obj != null)
            {
                try
                {
                    employee.Accidents.Remove(obj);

                    //btnSaveAccident.Enabled = false;
                    //btnDeleteAccident.Enabled = false;
                }
                catch (Exception)
                {

                    ViewHelper.ShowErrorMessage("Unable to delete the selected accident.");
                }

            }
        }

        private void saveEmployeeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           try
            {
                employeeBindingSource.EndEdit();  
                _proxy.Save();

                //saveEmployeeBarButtonItem.Enabled = false;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error Occured while saving employee information", exception);
            }

        }

        private void gridControl5_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeSkill)skillsBindingSource.Current;
            if (obj != null)
            {
                skillsDetailBindingSource.DataSource = obj;

                btnSaveSkill.Enabled = true;
                btnDeleteSkill.Enabled = true;
            }

        }

        private void gridControl6_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeBenefit)benefitsBindingSource.Current;
            if (obj != null)
            {
                benefitDetailBindingSource.DataSource = obj;

                btnSaveBenefit.Enabled = true;
                btnDeleteBenefit.Enabled = true;
            }
        }

        private void gridControl7_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeAccident)accidentsBindingSource.Current;
            if (obj != null)
            {
                accidentDetailBindingSource.DataSource = obj;

                btnSaveAccident.Enabled = true;
                btnDeleteAccident.Enabled = true;
            }
        }

        private void employeeBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveEmployeeBarButtonItem.Enabled = _proxy.EntityStateChanged(employee) && employee.StatusId != Employee.StatusTerminated;
            // THIS IS ONE OF THE OF THE UGLIEST  HACKS IN THIS APPLICATION. IT IS ONLY PLACED HERE BECAUSE I FOUND IT VERY EXPENSIVE TO CHANGE
            // THE EDMX FILE FOR THIS MODULE (HrmModel.edmx).
            if(employee.JobId==null)
            {
                jobIdErrorProvider.SetError(jobIdLookUpEdit,"You must provide Postion attribute for the current employee");
            }
            else
            {
                // Since I am using this error provider only for the postion/job_id, it is safe to clear it base on only 
                // Position field.
                jobIdErrorProvider.ClearErrors();
            }
            AuthorizeForm();
        }

        private void deleteEmployeeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure to delete this employee ?");
            if (result == DialogResult.Yes)
            {
                var obj = _proxy.Context.Employees.FirstOrDefault(ep => ep.EmployeeId == employee.EmployeeId);
                if (obj != null)
                {
                    try
                    {
                        _proxy.Context.Employees.DeleteObject(obj);
                        _proxy.Save();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        ViewHelper.ShowErrorMessage("Unable to delete the selected employee.");
                    }
                }
            }
        }

        private void EmployeeDetailView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.HRM_RIBBON_NAME];
        }

        private void transferBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ntv = new NewTransferView();
            ntv.NewMode = true;
            ntv.ShowObject(employee.EmployeeId);
            ntv.ShowDialog();
        }

        private void cancelContactEditToolStripButton_Click(object sender, EventArgs e)
        {
            var address = (ContactAddress)contactAddressDetailBindingSource.Current;
            _proxy.GetOriginalValue(address);
            contactAddressDetailBindingSource.CancelEdit();
            contactAddressDetailBindingSource.Clear();
        }

        private void contactAddressDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var address = (ContactAddress)contactAddressDetailBindingSource.Current;
            if (null != address)
            {
                newContactToolStripButton.Enabled = !address.IsNew;
                deleteContactAddress.Enabled = !address.IsNew;
                cancelContactEditToolStripButton.Enabled = (address.IsNew || _proxy.EntityStateChanged(address));
                saveContactToolStripButton.Enabled = (address.IsNew || _proxy.EntityStateChanged(address)) && address.IsValid();
                saveEmployeeBarButtonItem.Enabled = (address.IsNew || _proxy.EntityStateChanged(address)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                newContactToolStripButton.Enabled = true;
                deleteContactAddress.Enabled = false;
                cancelContactEditToolStripButton.Enabled = false;
                saveContactToolStripButton.Enabled = false;
            }
        }

        private void terminateBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var terview = new TerminationView();
            if (employee.StatusId == Employee.StatusTerminated)
            {
                ViewHelper.ShowErrorMessage("This Employee is already terminated!");
                return;
            }
            else
            {
                terview.ShowObject(employee.EmployeeId);
                terview.ShowDialog();
            }
        }

        private void reloadBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowObject(employee.EmployeeId);
        }

        private void archiveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure ,you want to archive the selected employee?");
            if (result == DialogResult.Yes)
            {
                employee.StatusId = Employee.StatusArchived;
                _proxy.Save();
                Close();
            }
        }
        private void promoteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var pv = new PromotionView();
            pv.ShowObject(Convert.ToInt32(employee.EmployeeId));
            var result = pv.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void warningBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var wv = new EmployeeWarningView();
            wv.ShowObject(Convert.ToInt32(employee.EmployeeId));
            wv.ShowDialog();
        }

        private void educationDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var education = (EmployeeEducationalHistory)educationDetailBindingSource.Current;
            if (null != education)
            {
                btnNewEducation.Enabled = !education.IsNew;
                btnDeleteEducation.Enabled = !education.IsNew;
                cancelEducationtoolStripButton.Enabled = education.IsNew || _proxy.EntityStateChanged(education);
                btnSaveEducation.Enabled = (education.IsNew || _proxy.EntityStateChanged(education)) && education.IsValid();
                saveEmployeeBarButtonItem.Enabled = (education.IsNew || _proxy.EntityStateChanged(education)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewEducation.Enabled = true;
                btnDeleteEducation.Enabled = false;
                cancelEducationtoolStripButton.Enabled = false;
                btnSaveEducation.Enabled = false;
            }
        }

        private void cancelEducationtoolStripButton_Click(object sender, EventArgs e)
        {
            var emploedu = (EmployeeEducationalHistory)educationDetailBindingSource.Current;
            _proxy.RevertToOriginalValue(emploedu);
            educationDetailBindingSource.CancelEdit();
            educationDetailBindingSource.Clear();
        }

        private void workexperienceDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var experience = (EmployeeWorkExperiance)workexperienceDetailBindingSource.Current;
            if (null != experience)
            {
                btnNewExperiance.Enabled = !experience.IsNew;
                btnDeleteExperiance.Enabled = !experience.IsNew;
                cancelExperiencetoolStripButton.Enabled = experience.IsNew || _proxy.EntityStateChanged(experience);
                btnSaveExperiance.Enabled = (experience.IsNew || _proxy.EntityStateChanged(experience)) && experience.IsValid();
                saveEmployeeBarButtonItem.Enabled = (experience.IsNew || _proxy.EntityStateChanged(experience)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewExperiance.Enabled = true;
                btnDeleteExperiance.Enabled = false;
                cancelExperiencetoolStripButton.Enabled = false;
                btnSaveExperiance.Enabled = false;
            }
        }

        private void cancelExperiencetoolStripButton_Click(object sender, EventArgs e)
        {
            var experience = (EmployeeWorkExperiance)workexperienceDetailBindingSource.Current;
            _proxy.GetOriginalValue(experience);
            workexperienceDetailBindingSource.CancelEdit();
            workexperienceDetailBindingSource.Clear();
        }

        private void dependentDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var dependent = (EmployeeDependant)dependentDetailBindingSource.Current;
            if (null != dependent)
            {
                btnNewDependant.Enabled = !dependent.IsNew;
                btnDeleteDependant.Enabled = !dependent.IsNew;
                cancelDependenttoolstripButton.Enabled = dependent.IsNew || _proxy.EntityStateChanged(dependent);
                btnSaveDependant.Enabled = (dependent.IsNew || _proxy.EntityStateChanged(dependent)) && dependent.IsValid();
                saveEmployeeBarButtonItem.Enabled = (dependent.IsNew || _proxy.EntityStateChanged(dependent)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewDependant.Enabled = true;
                btnDeleteDependant.Enabled = false;
                cancelDependenttoolstripButton.Enabled = false;
                btnSaveDependant.Enabled = false;
            }
        }

        private void cancelDependenttoolstripButton_Click(object sender, EventArgs e)
        {
            var dependent = (EmployeeDependant)dependentDetailBindingSource.Current;
            _proxy.GetOriginalValue(dependent);
            dependentDetailBindingSource.CancelEdit();
            dependentDetailBindingSource.Clear();
        }

        private void medicalDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var medical = (EmployeeMedicalRecord)medicalDetailBindingSource.Current;
            if (null != medical)
            {
                btnNewMedical.Enabled = !medical.IsNew;
                btnDeleteMedical.Enabled = !medical.IsNew;
                cancelMedicaltoolStripButton.Enabled = medical.IsNew || _proxy.EntityStateChanged(medical);
                btnSaveMedical.Enabled = (medical.IsNew || _proxy.EntityStateChanged(medical)) && medical.IsValid();
                saveEmployeeBarButtonItem.Enabled = (medical.IsNew || _proxy.EntityStateChanged(medical)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewMedical.Enabled = true;
                btnDeleteMedical.Enabled = false;
                cancelMedicaltoolStripButton.Enabled = false;
                btnSaveMedical.Enabled = false;
            }
        }

        private void cancelMedicaltoolStripButton_Click(object sender, EventArgs e)
        {
            var medical = (EmployeeMedicalRecord)medicalDetailBindingSource.Current;
            _proxy.GetOriginalValue(medical);
            medicalDetailBindingSource.CancelEdit();
            medicalDetailBindingSource.Clear();
        }

        private void skillsDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var skill = (EmployeeSkill)skillsDetailBindingSource.Current;
            if (null != skill)
            {
                btnNewSkill.Enabled = !skill.IsNew;
                btnDeleteSkill.Enabled = !skill.IsNew;
                cancelSkilltoolStripButton.Enabled = skill.IsNew || _proxy.EntityStateChanged(skill);
                btnSaveSkill.Enabled = (skill.IsNew || _proxy.EntityStateChanged(skill)) && skill.IsValid();
                saveEmployeeBarButtonItem.Enabled = (skill.IsNew || _proxy.EntityStateChanged(skill)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewSkill.Enabled = true;
                btnDeleteSkill.Enabled = false;
                cancelSkilltoolStripButton.Enabled = false;
                btnSaveSkill.Enabled = false;
            }
        }

        private void cancelSkilltoolStripButton_Click(object sender, EventArgs e)
        {
            var skill = (EmployeeSkill)skillsDetailBindingSource.Current;
            _proxy.GetOriginalValue(skill);
            skillsDetailBindingSource.CancelEdit();
            skillsDetailBindingSource.Clear();
        }

        private void benefitDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var benefit = (EmployeeBenefit)benefitDetailBindingSource.Current;
            if (null != benefit)
            {
                btnNewBenefit.Enabled = !benefit.IsNew;
                btnDeleteBenefit.Enabled = !benefit.IsNew;
                cancelBenefitstoolStripButton.Enabled = benefit.IsNew || _proxy.EntityStateChanged(benefit);
                btnSaveBenefit.Enabled = (benefit.IsNew || _proxy.EntityStateChanged(benefit)) && benefit.IsValid();
                saveEmployeeBarButtonItem.Enabled = (benefit.IsNew || _proxy.EntityStateChanged(benefit)); // && employee.StatusId == Employee.StatusTerminated;
            }
            else
            {
                btnNewBenefit.Enabled = true;
                btnDeleteBenefit.Enabled = false;
                cancelBenefitstoolStripButton.Enabled = false;
                btnSaveBenefit.Enabled = false;
            }
        }

        private void cancelBenefitstoolStripButton_Click(object sender, EventArgs e)
        {
            var benfit = (EmployeeBenefit)benefitDetailBindingSource.Current;
            _proxy.GetOriginalValue(benfit);
            benefitDetailBindingSource.CancelEdit();
            benefitDetailBindingSource.Clear();
        }

        private void accidentDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var accident = (EmployeeAccident)accidentDetailBindingSource.Current;
            if (null != accident)
            {
                btnNewAccident.Enabled = !accident.IsNew;
                btnDeleteAccident.Enabled = !accident.IsNew;
                cancelAccidentstoolStripButton.Enabled = accident.IsNew || _proxy.EntityStateChanged(accident);
                btnSaveAccident.Enabled = (accident.IsNew || _proxy.EntityStateChanged(accident)) && accident.IsValid();
                saveEmployeeBarButtonItem.Enabled = (accident.IsNew || _proxy.EntityStateChanged(accident)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewAccident.Enabled = true;
                btnDeleteAccident.Enabled = false;
                cancelAccidentstoolStripButton.Enabled = false;
                btnSaveAccident.Enabled = false;
            }
        }

        private void cancelAccidentstoolStripButton_Click(object sender, EventArgs e)
        {
            var accident = (EmployeeAccident)accidentDetailBindingSource.Current;
            _proxy.GetOriginalValue(accident);
            accidentDetailBindingSource.CancelEdit();
            accidentDetailBindingSource.Clear();
        }

        private void requestLeaveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var lr = new LeaveRequestView();
            lr.EmployeeId = employee.EmployeeId;
            lr.ShowObject(null);
            lr.ShowDialog();
        }

        private void addEducationLevelHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.EducationLevelView();
            picker.ShowList();
            var result = picker.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.educationLevelBindingSource.DataSource = store.Context.EducationLevels.ToList();
            }
        }

        private void addEducationTypeHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.EducationTypeView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.educationTypeBindingSource.DataSource = store.Context.EducationTypes.ToList();
            }
        }

        private void addDependencyTypehyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.DependantTypeView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.dependancyTypeBindingSource.DataSource = store.Context.DependantTypes.ToList();
            }
        }

        private void addSkillTypehyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.EmployeeSkillTypeView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.skillTypeBindingSource.DataSource = store.Context.EmployeeSkillTypes.ToList();
            }
        }

        private void addBenefitsTypehyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.BenefitTypeView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.benefitTypeBindingSource.DataSource = store.Context.BenefitTypes.ToList();
            }
        }

        private void addNewDepartmrnthyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.OrganizationNodeTypeView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.organizationBindingSource.DataSource = store.Context.OrganizationNodeTypes.ToList();
            }
        }

        private void btnNewLeave_Click(object sender, EventArgs e)
        {
            leaveDetailBindingSource.DataSource = new EmployeeLeave() { IsNew = true };
        }

        private void leaveDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var leave = (EmployeeLeave)leaveDetailBindingSource.Current;
            if (null != leave)
            {
                btnNewLeave.Enabled = !leave.IsNew;
                btnDeleteLeave.Enabled = !leave.IsNew;
                btnCancelLeave.Enabled = (leave.IsNew || _proxy.EntityStateChanged(leave));
                btnSaveLeave.Enabled = (leave.IsNew || _proxy.EntityStateChanged(leave)) && leave.IsValid();
                saveEmployeeBarButtonItem.Enabled = (leave.IsNew || _proxy.EntityStateChanged(leave)) && employee.StatusId != Employee.StatusTerminated;
            }
            else
            {
                btnNewLeave.Enabled = true;
                btnDeleteLeave.Enabled = false;
                btnCancelLeave.Enabled = false;
                btnSaveLeave.Enabled = false;
            }
        }

        private void btnSaveLeave_Click(object sender, EventArgs e)
        {
            SaveLeave();
            btnSaveLeave.Enabled = false;
            btnCancelLeave.Enabled = true;
            btnNewLeave.Enabled = true;
        }

        private void SaveLeave()
        {
            var obj = (EmployeeLeave)leaveDetailBindingSource.Current;
            if (obj != null)
            {
                employee.EmployeeLeave.Add(obj);
            }
        }

        private void btnDeleteLeave_Click(object sender, EventArgs e)
        {
            RemoveLeave();
        }

        private void RemoveLeave()
        {
            var obj = (EmployeeLeave)leavesBindingSource.Current;
            if (obj != null)
            {
                employee.EmployeeLeave.Remove(obj);
            }
        }

        private void gridControl8_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeeLeave)leavesBindingSource.Current;
            if (obj != null)
            {
                leaveDetailBindingSource.DataSource = obj;

                btnDeleteAccident.Enabled = true;
            }
        }

        private void btnCancelLeave_Click(object sender, EventArgs e)
        {
            var leave = (EmployeeLeave)leaveDetailBindingSource.Current;
            _proxy.GetOriginalValue(leave);
            accidentDetailBindingSource.CancelEdit();
            accidentDetailBindingSource.Clear();
        }


        public void AuthorizeForm()
        {
            saveEmployeeBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                               hph.ItemName(
                                                                                   HRMPermissionHelper.Operation.
                                                                                       UpdateEmployee));
            deleteEmployeeBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                 hph.ItemName(
                                                                                     HRMPermissionHelper.Operation.
                                                                                         DeleteEmployee));
            promoteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.
                                                                                  PromoteEmployee));
            terminateBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                            hph.ItemName(
                                                                                HRMPermissionHelper.Operation.
                                                                                    TerminateEmployee));
            archiveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.
                                                                                  ArchiveEmployee));
            transferBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                           hph.ItemName(
                                                                               HRMPermissionHelper.Operation.
                                                                                   TransferEmployee));
            warningBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.WarnEmployee));
            addSkillTypehyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                               hph.ItemName(
                                                                                   HRMPermissionHelper.Operation.
                                                                                       AddLookupItem));
            addEducationLevelHyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                    hph.ItemName(
                                                                                        HRMPermissionHelper.Operation.
                                                                                            AddLookupItem));
            addEducationTypeHyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                   hph.ItemName(
                                                                                       HRMPermissionHelper.Operation.
                                                                                           AddLookupItem));
            addDependencyTypehyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                    hph.ItemName(
                                                                                        HRMPermissionHelper.Operation.
                                                                                            AddLookupItem));
            addBenefitsTypehyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                  hph.ItemName(
                                                                                      HRMPermissionHelper.Operation.
                                                                                          AddLookupItem));


        }
    }
}