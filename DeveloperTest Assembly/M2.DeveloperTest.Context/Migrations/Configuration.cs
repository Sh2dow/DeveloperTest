namespace M2.DeveloperTest.Context.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<M2.DeveloperTest.Context.DeveloperTest>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(M2.DeveloperTest.Context.DeveloperTest context)
        {
            //  This method will be called after migrating to the latest version.

#if DEBUG
            // Instantiate the list of participants. 
            List<M2.DeveloperTest.Entities.Participant> participants = new List<M2.DeveloperTest.Entities.Participant>() {
                new Entities.Participant()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Gender = M2.DeveloperTest.Enumerators.Gender.Male,
                    AddressLine1 = "501 Cambria Ave",
                    City = "Bensalem",
                    State = "PA",
                    Zip = "19020",
                    Email = "JohnDoe@M2mail.com",
                    Active = true
                },
                new Entities.Participant()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Gender = M2.DeveloperTest.Enumerators.Gender.Female,
                    AddressLine1 = "5 High Ridge Park",
                    AddressLine2 = "2nd Floor",
                    City = "Stamford",
                    State = "CT",
                    Zip = "06905",
                    Email = "JaneDoe@M2mail.com",
                    Active = true
                }
            };

            foreach (var participant in participants)
            {
                context.Participants.AddOrUpdate(p => new { p.FirstName, p.LastName }, participant);
            }

            context.SaveChanges();
#endif
        }
    }
}
