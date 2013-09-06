using System;
using System.Data.Objects;
using System.Data;
using System.Linq;
using ClearOffice.Hrm.Business.Data;

namespace ClearOffice.Hrm.Business
{
    public class JobProxy
    {
        // Define internal ef context
        private HrmEntities context = new HrmEntities();

        // Public constructor to 
        public JobProxy()
        {
            context.SavingChanges+=new EventHandler(context_SavingChanges);
        }

        // Property to expose the internal context
        public HrmEntities Context
        {
            get { return context; }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }
        public bool IsDirty()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }
        // SavingChanges event handler
        private void context_SavingChanges(object sender, EventArgs e)
        {
            // Get a reference to the current context object
            var ctx = sender as ObjectContext;
            
            // Do validation for all newly added and modified items in the context
            foreach (var entry in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                // Do this for objects which need business rule processing.
                if(!entry.IsRelationship && (entry.Entity.GetType()==typeof(Job)))
                {                    
                    if(entry.State==EntityState.Added)
                    {
                        var j = (Job) entry.Entity;
                        

                        // Do business rule validation for newly added items

                        // Throw exception if things go wrong.                        
                    }

                    if(entry.State==EntityState.Modified)
                    {
                        // Do business rule validation for modified items
                    }
                }
            }
        }
    }
}
