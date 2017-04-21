using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Context
{
    public abstract class EntityConfiguration<T> : EntityTypeConfiguration<T> where T : M2.DeveloperTest.Entities.Entity
    {
        public EntityConfiguration()
        {
            this.Property(j => j.Version).IsRowVersion();
            this.Property(j => j.CreatedBy).HasMaxLength(255).IsRequired();
            this.Property(j => j.LastModifiedBy).HasMaxLength(255).IsRequired();
        }
    }
}
