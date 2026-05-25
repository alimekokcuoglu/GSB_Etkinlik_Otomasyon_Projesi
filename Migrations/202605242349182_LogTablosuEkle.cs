namespace Otomasyon_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogTablosuEkle : DbMigration
    {
        public override void Up()
        {
            
           
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Islem = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        Detay = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }

        public override void Down()
        {

            DropTable("dbo.Logs");
        }    
    }
}
