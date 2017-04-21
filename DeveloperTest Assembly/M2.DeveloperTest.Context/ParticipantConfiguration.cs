using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2.DeveloperTest.Context
{
    public class ParticipantConfiguration : EntityConfiguration<M2.DeveloperTest.Entities.Participant>
    {
        public ParticipantConfiguration()
            : base()
        {
            Map(b => b.MapInheritedProperties());

            Property(j => j.ParticipantId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(j => j.FirstName).IsRequired().HasMaxLength(50);
            Property(j => j.LastName).IsRequired().HasMaxLength(50);
            Property(j => j.AddressLine1).IsRequired().HasMaxLength(200);
            Property(j => j.AddressLine2).HasMaxLength(200);
            Property(j => j.City).IsRequired().HasMaxLength(100);
            Property(j => j.State).IsRequired().HasMaxLength(50);
            Property(j => j.Zip).IsRequired().HasMaxLength(25);
            Property(j => j.Email).IsRequired().HasMaxLength(100);
        }
    }
}
