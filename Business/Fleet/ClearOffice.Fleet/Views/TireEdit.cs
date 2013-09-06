using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Fleet.Properties;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class TireEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FleetEntities context;
        private Tire tire;
        private bool cancelChanges;

        public TireEdit()
        {
            InitializeComponent();
            context = new FleetEntities();
        }

        public void ShowObject(object keyValue)
        {
            LoadLookupData();
            var info = keyValue as TireInfo;
            if (null != info)
            {
                try
                {
                    tire = context.Tires.SingleOrDefault(t => t.TireId == info.TireId);
                    tireBindingSource.DataSource = tire;
                    usageHistoryBindingSource.DataSource = tire.UsageHistory;
                    this.Text = string.Format("Tire Detail:{0}", tire.SerialNo);
                }
                catch (Exception exception)
                {
                    ViewHelper.ShowErrorMessage("Error loading tire information", exception);
                }
            }
        }

        private void LoadLookupData()
        {
            var tireBrands = context.TireBrandInfoes.ToList();
            tireBrandBindingSource.DataSource = tireBrands.ToList();

            var tireSizes = context.TireSizeInfoes.ToList();
            tireSizeBindingSource.DataSource = tireSizes.ToList();

            var tireTypes = context.TireTypeInfoes.ToList();
            tireTypeBindingSource.DataSource = tireTypes.ToList();

            var vendors = from v in context.LookupItems where v.LookupId == 13 select v;
            vendorBindingSource.DataSource = vendors;

            var vehicles = context.VehicleInfoes.ToList();
            vehiclesBindingSource.DataSource = vehicles;

            var tireStatus = context.TireStatusInfoes.ToList();
            tireStatusBindingSource.DataSource = tireStatus.ToList();
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
          EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            tireBindingSource.EndEdit();
            usageHistoryBindingSource.EndEdit();

            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving tire information", exception);
            }
        }

        public void DeleteObject()
        {
            tireBindingSource.EndEdit();
            usageHistoryBindingSource.EndEdit();

            try
            {
                var result =
                    ViewHelper.ShowConfirmDialog(
                        "Are you sure you want to delete the current tire and its associated data?");
                if (result == DialogResult.Yes)
                {
                    context.Tires.DeleteObject(tire);
                    context.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting tire information", exception);
            }
        }

        public bool ValidateForm()
        {
            return tire.IsValid();
        }

        public void AuthorizeForm()
        {
            useTireBarButtonItem.Enabled = (tire.Status != FleetHelper.TIRE_STATUS_DISPOSED);
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void tireBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveBarButtonItem.Enabled = tire.IsValid();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void useTireBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MountUnmountTire();
        }

        private void MountUnmountTire()
        {
            // If tire is currently mounted:
            // 1. Change status of the tire to Unmounted
            // 2. Request user to provide information regarding unmounted milage, date and remark
            // 3. Refresh usage history grid.

            if (tire.Status == FleetHelper.TIRE_STATUS_MOUNTED)
            {
                var result = ViewHelper.ShowConfirmDialog(
                    "This tire is currently mounted and in use. Do you want to UnMount it?");

                if (result == DialogResult.Yes)
                {
                    ShowTireTransaction();
                }
            }
            else
                ShowTireTransaction();
        }

        private void ShowTireTransaction()
        {
            VehicleTire transaction;
            var form = new UnMountTireView();
            // This is the first time the tire is being used
            if (tire.UsageHistory.Count == 0 || tire.Status == FleetHelper.TIRE_STATUS_UNMOUNTED)
            {
                transaction = new VehicleTire();
                transaction.TireId = tire.TireId;
                form.CurrentTask = UnMountTireView.TireTask.Mount;
                tire.UsageHistory.Add(transaction);
            }
            else
            {
                transaction = tire.UsageHistory.SingleOrDefault(t => t.Status == FleetHelper.TIRE_STATUS_MOUNTED);
                form.CurrentTask = UnMountTireView.TireTask.Unmount;
            }

            form.ShowObject(transaction);
            var result = form.ShowDialog(this);

            if (result == DialogResult.Cancel && form.CurrentTask == UnMountTireView.TireTask.Mount)
            {
                tire.UsageHistory.Remove(transaction);
            }
            else
            {
                SaveChanges();
            }
        }

        private void TireEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelChanges)
            {
                if (this.DataChanged())
                {
                    var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }
    }
}