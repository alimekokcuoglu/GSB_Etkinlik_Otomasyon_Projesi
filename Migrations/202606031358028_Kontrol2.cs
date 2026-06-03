namespace Otomasyon_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kontrol2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Table_Etkinlik", "Kayitlar_Kayit_Id", "dbo.Table_Kayitlar");
            DropForeignKey("dbo.Table_Etkinlik", "Memur1_Memur_Id", "dbo.Table_Memur");
            DropForeignKey("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id1", "dbo.Table_Etkinlik");
            DropForeignKey("dbo.Table_Etkinlik", "Memur_Memur_Id1", "dbo.Table_Memur");
            DropForeignKey("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id", "dbo.Table_Etkinlik");
            DropForeignKey("dbo.Table_Etkinlik", "Memur_Memur_Id", "dbo.Table_Memur");
            DropIndex("dbo.Table_Etkinlik", new[] { "Kayitlar_Kayit_Id" });
            DropIndex("dbo.Table_Etkinlik", new[] { "Memur_Memur_Id" });
            DropIndex("dbo.Table_Etkinlik", new[] { "Memur_Memur_Id1" });
            DropIndex("dbo.Table_Etkinlik", new[] { "Memur1_Memur_Id" });
            DropIndex("dbo.Table_Kayitlar", new[] { "Etkinlik_Etkinlik_Id" });
            DropIndex("dbo.Table_Kayitlar", new[] { "Etkinlik_Etkinlik_Id1" });
            DropColumn("dbo.Table_Etkinlik", "Memur_Id");
            DropColumn("dbo.Table_Etkinlik", "Memur_Id");
            DropColumn("dbo.Table_Kayitlar", "Etkinlik_Id");
            DropColumn("dbo.Table_Kayitlar", "Etkinlik_Id");
            RenameColumn(table: "dbo.Table_Kayitlar", name: "Etkinlik_Etkinlik_Id1", newName: "Etkinlik_Id");
            RenameColumn(table: "dbo.Table_Etkinlik", name: "Memur_Memur_Id1", newName: "Memur_Id");
            RenameColumn(table: "dbo.Table_Kayitlar", name: "Etkinlik_Etkinlik_Id", newName: "Etkinlik_Id");
            RenameColumn(table: "dbo.Table_Etkinlik", name: "Memur_Memur_Id", newName: "Memur_Id");
            AlterColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Table_Etkinlik", "Memur_Id");
            CreateIndex("dbo.Table_Kayitlar", "Etkinlik_Id");
            AddForeignKey("dbo.Table_Kayitlar", "Etkinlik_Id", "dbo.Table_Etkinlik", "Etkinlik_Id", cascadeDelete: true);
            AddForeignKey("dbo.Table_Etkinlik", "Memur_Id", "dbo.Table_Memur", "Memur_Id", cascadeDelete: true);
            DropColumn("dbo.Table_Etkinlik", "Kayitlar_Kayit_Id");
            DropColumn("dbo.Table_Etkinlik", "Memur1_Memur_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Table_Etkinlik", "Memur1_Memur_Id", c => c.Int());
            AddColumn("dbo.Table_Etkinlik", "Kayitlar_Kayit_Id", c => c.Int());
            DropForeignKey("dbo.Table_Etkinlik", "Memur_Id", "dbo.Table_Memur");
            DropForeignKey("dbo.Table_Kayitlar", "Etkinlik_Id", "dbo.Table_Etkinlik");
            DropIndex("dbo.Table_Kayitlar", new[] { "Etkinlik_Id" });
            DropIndex("dbo.Table_Etkinlik", new[] { "Memur_Id" });
            AlterColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int());
            AlterColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int());
            AlterColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int());
            AlterColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int());
            RenameColumn(table: "dbo.Table_Etkinlik", name: "Memur_Id", newName: "Memur_Memur_Id");
            RenameColumn(table: "dbo.Table_Kayitlar", name: "Etkinlik_Id", newName: "Etkinlik_Etkinlik_Id");
            RenameColumn(table: "dbo.Table_Etkinlik", name: "Memur_Id", newName: "Memur_Memur_Id1");
            RenameColumn(table: "dbo.Table_Kayitlar", name: "Etkinlik_Id", newName: "Etkinlik_Etkinlik_Id1");
            AddColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Table_Kayitlar", "Etkinlik_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Table_Etkinlik", "Memur_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id1");
            CreateIndex("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id");
            CreateIndex("dbo.Table_Etkinlik", "Memur1_Memur_Id");
            CreateIndex("dbo.Table_Etkinlik", "Memur_Memur_Id1");
            CreateIndex("dbo.Table_Etkinlik", "Memur_Memur_Id");
            CreateIndex("dbo.Table_Etkinlik", "Kayitlar_Kayit_Id");
            AddForeignKey("dbo.Table_Etkinlik", "Memur_Memur_Id", "dbo.Table_Memur", "Memur_Id");
            AddForeignKey("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id", "dbo.Table_Etkinlik", "Etkinlik_Id");
            AddForeignKey("dbo.Table_Etkinlik", "Memur_Memur_Id1", "dbo.Table_Memur", "Memur_Id");
            AddForeignKey("dbo.Table_Kayitlar", "Etkinlik_Etkinlik_Id1", "dbo.Table_Etkinlik", "Etkinlik_Id");
            AddForeignKey("dbo.Table_Etkinlik", "Memur1_Memur_Id", "dbo.Table_Memur", "Memur_Id");
            AddForeignKey("dbo.Table_Etkinlik", "Kayitlar_Kayit_Id", "dbo.Table_Kayitlar", "Kayit_Id");
        }
    }
}
