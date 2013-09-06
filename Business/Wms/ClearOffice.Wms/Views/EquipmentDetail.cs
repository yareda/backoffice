using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Wms.Business;
using System.Linq;
using System.IO;
namespace ClearOffice.Wms.Views
{
    public partial class EquipmentDetail : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private Equipment _equipment;
        private EquipmentPurchase _equipmentPurchase;
        private EquipmentInsurance _selectedInsurance;
        private EquipmentAttachment _selectedAttachment;
        public ContractDetailView ContractDetailView { get; set; }
        private EquipmentExpiration _expiration;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _whp;
        public EquipmentDetail()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _whp = new WorkshopPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            _context = new WmsEntities();
            //Load current object
            var equipmentId = Convert.ToInt32(keyValue);
            _equipment = _context.Equipments.First(e => e.EquipmentId == equipmentId);
            EquipemntBindingSource.DataSource = _equipment;
            //Load lookup data
            LoadLookUps();
            ControleRadioButtons();
            LoadPurchase();
            LoadInsurance();
            LoadExpiration();
            LoadAttachments();

        }

        private void LoadAttachments()
        {

            attachmentBindingSource.DataSource =
                _context.EquipmentAttachments.Where(ea => ea.EquipmentId == _equipment.EquipmentId);
        }
        private void LoadExpiration()
        {
            expirationBindingSource.DataSource = _equipment.Expiration;
        }

        private void LoadInsurance()
        {
            InsuranceListBindingSource.DataSource = _equipment.Insurance;
        }

        private void LoadPurchase()
        {
            var purchase = _context.EquipmentPurchases.FirstOrDefault(ep => ep.EquipmentId == _equipment.EquipmentId);
            if (purchase == null)
                PurchaseBindingSource.DataSource = new EquipmentPurchase(){EquipmentId = _equipment.EquipmentId};
            else
                PurchaseBindingSource.DataSource = purchase;
        }

        private void ControleRadioButtons()
        {
            if (_equipment.BaseHours != null)
            {
                BaseHoureRadioButton.Checked = true;

            }
            else if (_equipment.BaseMileage != null)
            {
                MileageRadioButton.Checked = true;
            }
        }

        private void LoadLookUps()
        {
            MakeBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.Make);
            ModelBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.Model);
            CatagoryBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.EquipmentCatagory);
            expirationTypeBindingSource.DataSource =
                _context.LookupItems.Where(l => l.LookupId == (int)LookupItems.ExpirationType);
            companyBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.InsuranceCompany);
        }
        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                             EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            EquipemntBindingSource.EndEdit();
            PurchaseBindingSource.EndEdit();
            InsuranceListBindingSource.EndEdit();
            expirationBindingSource.EndEdit();
                _equipment = (Equipment)EquipemntBindingSource.DataSource;

            _equipmentPurchase = (EquipmentPurchase) PurchaseBindingSource.DataSource;
            if(_equipmentPurchase.PurchaseId == 0)//if it is a new purchase.
                _context.EquipmentPurchases.AddObject(_equipmentPurchase);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current equipment.", ex);
            }
            BtnSave.Enabled = false;
            EquipemntBindingSource.DataSource = _equipment;
            if (ContractDetailView != null) ContractDetailView.RefreshEquipmentList();
        }

        public void DeleteObject()
        {
            _context = new WmsEntities();
            var eq = _context.Equipments.FirstOrDefault(e => e.EquipmentId == _equipment.EquipmentId);
            _context.DeleteObject(eq);
            _context.SaveChanges();
            Close();
            if (ContractDetailView != null) ContractDetailView.RefreshEquipmentList();
        }

        public bool ValidateForm()
        {
            var result = true;
            if (serialTextBox.Text == string.Empty)
            {
                EquipmentDetailErrorProvider.SetError(serialTextBox, "Serial# is required");
                result = false;
            }
            return result;
        }

        private void EquipemntBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //BtnSave.Enabled = DataChanged();
            BtnSave.Enabled = true;

            AuthorizeForm();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool val = BaseHoureRadioButton.Checked;
            if (val)
            {
                baseHoursTextBox.Enabled = true;
                baseHoursTextBox.Text = _equipment.BaseHours;
                baseMileageTextBox.Enabled = false;
                baseMileageTextBox.Text = null;
                MileageRadioButton.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool val = MileageRadioButton.Checked;
            if (val)
            {
                baseHoursTextBox.Enabled = false;
                baseMileageTextBox.Enabled = true;
                baseMileageTextBox.Text = _equipment.BaseMileage;
                baseHoursTextBox.Text = null;
            }
        }

        private void PurchaseBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;

            AuthorizeForm();
        }

        private void EquipmentDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BtnSave.Enabled)
            {
                DialogResult result =
                    ViewHelper.ShowConfirmDialog("You haven't saved changes. Do you want to save changes ?");
                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                    Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this equipment.");
            if (result == DialogResult.Yes)
                DeleteObject();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            var iv = new InsuranceView();           
            var data = new EquipmentInsurance();
            iv.ShowObject(data);
            var result = iv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _equipment.Insurance.Add(iv.CurrentObject);
            }
        }

        public void ReloadInsurances()
        {
            _context = new WmsEntities();
            InsuranceListBindingSource.DataSource = _context.EquipmentInsuranceInfoes.Where(ei => ei.EquipmentId == _equipment.EquipmentId);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
              _selectedInsurance = (EquipmentInsurance)InsuranceListBindingSource.Current;
              btnDeleteInsurance.Enabled = true;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            OpenInsuranceDetail();
        }

        private void OpenInsuranceDetail()
        {
            if (InsuranceListBindingSource.Current  != null)
            {
                var inv = new InsuranceView();
                var data = InsuranceListBindingSource.Current as EquipmentInsurance;
                inv.ShowObject(data);                
                inv.ShowDialog();
            }
        }

        private void BtnDeleteInsurance_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure to delete this insurance information ?");
            if (result == DialogResult.Yes)
            {
                if (_selectedInsurance.InsuranceId == 0)//if it hasn't been saved yet.
                {
                    _equipment.Insurance.Remove(_selectedInsurance);
                }
                else
                {
                    _context.EquipmentInsurances.DeleteObject(_selectedInsurance);
                }
            }
            
        }

        private void DeleteObjectInsurance()
        {
            try
            {
                var ins = _context.EquipmentInsurances.FirstOrDefault(ei => ei.InsuranceId == _selectedInsurance.InsuranceId);
                _context.EquipmentInsurances.DeleteObject(ins);
                SaveChanges();
                ReloadInsurances();
            }
            catch (Exception)
            {
                ViewHelper.ShowDeleteError();
                return;
            }
        }

        private void BtnIssueWorkorder_Click(object sender, EventArgs e)
        {
            var wov = new WorkOrderView();
            wov.Equipment = _equipment;
            wov.ShowObject(null);
            wov.MdiParent = this.MdiParent;
            wov.Show();
        }
        private void btnNewAttachment_Click(object sender, EventArgs e)
        {
            var av = new EquipmentAttachmentView();
            av.Equipment = _equipment;
            av.EquipmentDetail = this;
            av.ShowObject(null);
            av.ShowDialog();
        }

        internal void ReloadAttachments()
        {
           LoadAttachments();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            if (attachmentGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentAttachment)attachmentGridView.GetRow((int)attachmentGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _selectedAttachment = selected;
                    btnRead.Enabled = true;
                    btnDeleteAttachment.Enabled = true;
                }
            }

            AuthorizeForm();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //  \Temp\GUID.ext
            var tempFileName = Guid.NewGuid().ToString();
            var filePath = string.Format(@"{0}\Temp\{1}.{2}",Application.StartupPath,tempFileName,_selectedAttachment.FileType );
            var fw = new FileStream(filePath, FileMode.Create);
            fw.Write(_selectedAttachment.File,0,_selectedAttachment.File.Length);
            fw.Close();
            System.Diagnostics.Process.Start(filePath);

        }

        private void btnDeleteAttachment_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this attachment?");
            if (result == DialogResult.Yes)
            {
                var at =
                    _context.EquipmentAttachments.FirstOrDefault(a => a.AttachmentId == _selectedAttachment.AttachmentId);
                _context.EquipmentAttachments.DeleteObject(at);
                _context.SaveChanges();
                ReloadAttachments();
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if (expirationGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentExpiration)expirationGridView.GetRow((int)expirationGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _expiration = selected;
                    btnDeleteExpiration.Enabled = true;
                }
            }

            AuthorizeForm();
        }

        private void btnDeleteExpiration_Click(object sender, EventArgs e)
        {
            if (_expiration != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this expiration ?");
                if (result == DialogResult.Yes)
                {
                    _equipment.Expiration.Remove(_expiration);
                }
            }
        }

        private void expirationBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            AuthorizeForm();
        }
        public object GetEquipment()
        {
            return _equipment;
        }

        internal void InsuranceAdded(EquipmentInsurance ins)
        {
            _equipment.Insurance.Add(ins);
            BtnSave.Enabled = true;
        }

        private void InsuranceListBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;

            AuthorizeForm();
        }

        public void AuthorizeForm()
        {
            BtnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                               _whp.ItemName(WorkshopPermissionHelper.Operation.UpdateEquipment));
            btnNewInsurance.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _whp.ItemName(
                                                           WorkshopPermissionHelper.Operation.AddEquipmentAttachment));
            btnDeleteInsurance.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                          _whp.ItemName(
                                                              WorkshopPermissionHelper.Operation.
                                                                  DeleteEquipmentInsurance));
            expirationGridView.OptionsBehavior.Editable = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION, _whp.ItemName(WorkshopPermissionHelper.Operation.AddNewEquipmentExpiration));
            btnDeleteExpiration.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _whp.ItemName(
                                                               WorkshopPermissionHelper.Operation.
                                                                   DeleteEquipmentExpiration));
            btnNewAttachment.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                        _whp.ItemName(
                                                            WorkshopPermissionHelper.Operation.AddEquipmentAttachment));
            btnRead.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                               _whp.ItemName(WorkshopPermissionHelper.Operation.ReadEquipmentAttachment));
            btnDeleteAttachment.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _whp.ItemName(
                                                               WorkshopPermissionHelper.Operation.
                                                                   DeleteEquipmentAttachment));
        }
    }
}