using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace ClearOffice.Inventory.DataAccess
{
   public class LookupProxy
    {
       // Define internal ef context
        private InventoryEntities context = new InventoryEntities();

        // Public constructor to 
        public LookupProxy()
        {
            context.SavingChanges += new EventHandler(context_SavingChanges);
        }

        // Property to expose the internal context
        public InventoryEntities Context
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
                //if (!entry.IsRelationship && (entry.Entity.GetType() == typeof(CompetencyType)))
                //{
                //    if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                //    {
                //        var ct = (CompetencyType)entry.Entity;
                //        if (string.IsNullOrEmpty(ct.Name))
                //        {
                //            throw new ApplicationException("Competency Type Name is required");
                //        }

                //        // Do business rule validation for newly added items

                //        // Throw exception if things go wrong.                        
                //    }
                }
            }
        }

       
    }
    

