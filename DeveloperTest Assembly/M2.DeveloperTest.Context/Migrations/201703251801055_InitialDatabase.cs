namespace M2.DeveloperTest.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ParticipantId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Gender = c.Int(nullable: false),
                        AddressLine1 = c.String(nullable: false, maxLength: 200),
                        AddressLine2 = c.String(maxLength: 200),
                        City = c.String(nullable: false, maxLength: 100),
                        State = c.String(nullable: false, maxLength: 50),
                        Zip = c.String(nullable: false, maxLength: 25),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedBy = c.String(nullable: false, maxLength: 255),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(nullable: false, maxLength: 255),
                        LastModifiedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Email = c.String(nullable: false, maxLength: 100)
                })
                .PrimaryKey(t => t.ParticipantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Participants");
        }
    }
}
