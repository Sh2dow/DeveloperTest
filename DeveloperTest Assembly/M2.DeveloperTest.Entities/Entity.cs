using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Entities
{
    public abstract class Entity : M2.DeveloperTest.Interfaces.IAuditableEntity
    {
        public virtual byte[] Version { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string LastModifiedBy { get; set; }
        public virtual DateTime LastModifiedDate { get; set; }
        public virtual bool Active { get; set; }
    }
}
