using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Hrm.Lookup;
using ClearOffice.Infrastructure;
using ClearOffice.Hrm.Views;

namespace ClearOffice.Hrm
{
    public class HrmModuleManager:IModule
    {
        #region IModule Members
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void AddServices()
        {
            throw new NotImplementedException();
        }

        public void AddViews()
        {
            throw new NotImplementedException();
        }

        public void ExtendRibbon()
        {
            throw new NotImplementedException();
        }

        public void ExtendStatusBar()
        {
            throw new NotImplementedException();
        } 
        #endregion

        public JobListView GetJobListView()
        {
            return new JobListView();
        }

        public ReligionView GetEthnicityView()
        {
            return new ReligionView();
        }

        public EmployeeListView GetEmployeeListView()
        {
            return new EmployeeListView();
        }

        public TrainingListView GetTrainingListView()
        {
            return new TrainingListView();
        }
    }
}
