using System;
using System.Data;
using System.Data.Objects;
using System.Linq;
using ClearOffice.Hrm.Business.Data;

namespace ClearOffice.Hrm.Business
{
    public class ProfileProxy
    {
        // Define internal ef context
        private HrmEntities context = new HrmEntities();

        // Public constructor to 
        public ProfileProxy()
        {
            context.SavingChanges += new EventHandler(context_SavingChanges);
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
        public bool IsEducationiDirty()
        {
            foreach (var entry in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                // Checking whether education is adde,modified
                if (!entry.IsRelationship && (entry.Entity.GetType() == typeof(EmployeeEducationalHistory)))
                {
                    return true;
                }
            }
            return false;
        }

        // SavingChanges event handler
        private void context_SavingChanges(object sender, EventArgs e)
        {
            //// Get a reference to the current context object
            //var ctx = sender as ObjectContext;

            //// Do validation for all newly added and modified items in the context
            //foreach (var entry in ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            //{
            //    // Do this for objects which need business rule processing.
            //    if (!entry.IsRelationship && (entry.Entity.GetType() == typeof(Person)))
            //    {
            //        if (entry.State == EntityState.Added)
            //        {
            //            var p = (Person)entry.Entity;


            //            // Do business rule validation for newly added items

            //            // Throw exception if things go wrong.                        
            //        }

            //        if (entry.State == EntityState.Modified)
            //        {
            //            // Do business rule validation for modified items
            //        }
            //    }
            //}
        }

        public bool EntityStateChanged(object entity)
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified).Any(entry => !entry.IsRelationship && (entry.Entity.GetType() == entity.GetType()));
        }

        public void RevertToOriginalValue(object entity)
        {
            // Do validation for all newly added and modified items in the context
            foreach (var entry in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                // Do this for objects which need business rule processing.
                if (!entry.IsRelationship && (entry.Entity.GetType() == entity.GetType()))
                {
                    entry.ApplyOriginalValues(entry.Entity);
                }
            }            
        }
        public void GetOriginalValue(object entity)
        {
            foreach (var entry in context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified))
            {
                // Do this for objects which need business rule processing.
                if (!entry.IsRelationship && (entry.Entity.GetType() == entity.GetType()))
                {
                   for(int i=0;i<entry.OriginalValues.FieldCount;i++)
                   {
                       entry.CurrentValues.SetValue(i,entry.OriginalValues[i]);
                   }
                    entry.AcceptChanges();
                }
            }           
        }


    }
}
