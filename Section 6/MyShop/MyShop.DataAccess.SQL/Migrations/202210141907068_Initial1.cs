namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.BasketItems", name: "Basket_Id", newName: "BasketId");
            RenameIndex(table: "dbo.BasketItems", name: "IX_Basket_Id", newName: "IX_BasketId");
            DropColumn("dbo.BasketItems", "BadketId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BasketItems", "BadketId", c => c.String());
            RenameIndex(table: "dbo.BasketItems", name: "IX_BasketId", newName: "IX_Basket_Id");
            RenameColumn(table: "dbo.BasketItems", name: "BasketId", newName: "Basket_Id");
        }
    }
}
