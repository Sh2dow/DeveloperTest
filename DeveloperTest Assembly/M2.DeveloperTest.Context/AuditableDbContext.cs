using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Context
{
    public abstract class AuditableDbContext : DbContext
    {
        #region Constructor
        
        public AuditableDbContext(string user)
        {
            // Store our user in our read only property.
            User = user;
        }

        #endregion

        #region Properties
        
        public string User { get; private set; }

        #endregion

        #region Overrides
        
        public override int SaveChanges()
        {
            // Call our OnSaveChanges method to set common properties.
            OnSaveChanges();

            return base.SaveChanges();
        }
        
        public override Task<int> SaveChangesAsync()
        {
            // Call our OnSaveChanges method to set common properties.
            OnSaveChanges();

            return base.SaveChangesAsync();
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            // Call our OnSaveChanges method to set common properties.
            OnSaveChanges();

            return base.SaveChangesAsync(cancellationToken);
        }

        #endregion

        #region Utilities

        private void OnSaveChanges()
        {
            // Grab any IAuditableEntity entities that have been added or modified.
            var auditableEntities = this.ChangeTracker.Entries<M2.DeveloperTest.Interfaces.IAuditableEntity>().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            // Set the date and time our last modifed and created dates will be set to.
            DateTime modificationDate = DateTime.Now;

            // Loop through each entity and set the lastmodifiedby and lastmodifieddate.
            // If we are adding the entity then also set the createdby, createddate and active.
            foreach (var auditableEntity in auditableEntities)
            {
                auditableEntity.Entity.LastModifiedBy = User;
                auditableEntity.Entity.LastModifiedDate = modificationDate;

                if (auditableEntity.State == EntityState.Added)
                {
                    auditableEntity.Entity.CreatedBy = User;
                    auditableEntity.Entity.CreatedDate = modificationDate;
                    auditableEntity.Entity.Active = true;
                }
                else
                {
                    // If we are not adding then the createdby and createddate should never be modified.
                    auditableEntity.Property(p => p.CreatedBy).IsModified = false;
                    auditableEntity.Property(p => p.CreatedDate).IsModified = false;
                }
            }
        }

        #endregion
    }
}
