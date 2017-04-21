using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Interfaces
{
    public interface IAuditableEntity
    {
        byte[] Version { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string LastModifiedBy { get; set; }
        DateTime LastModifiedDate { get; set; }
        bool Active { get; set; }
    }
}
