﻿namespace MEGATECH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGiamGia : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "GiamGia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "GiamGia", c => c.Int());
        }
    }
}
