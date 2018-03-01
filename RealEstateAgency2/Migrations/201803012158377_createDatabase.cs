namespace RealEstateAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblDistricts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        CitiesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCities", t => t.CitiesId, cascadeDelete: true)
                .Index(t => t.CitiesId);
            
            CreateTable(
                "dbo.tblStreets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        DistrictsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblDistricts", t => t.DistrictsId, cascadeDelete: true)
                .Index(t => t.DistrictsId);
            
            CreateTable(
                "dbo.tblNumbersHouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        StreetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblStreets", t => t.StreetId, cascadeDelete: true)
                .Index(t => t.StreetId);
            
            CreateTable(
                "dbo.tblRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Floor = c.Int(nullable: false),
                        CountRooms = c.Int(nullable: false),
                        Square = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Reserved = c.Boolean(nullable: false),
                        Sales = c.Boolean(nullable: false),
                        NumberRoom = c.Int(nullable: false),
                        HouseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblNumbersHouses", t => t.HouseId, cascadeDelete: true)
                .Index(t => t.HouseId);
            
            CreateTable(
                "dbo.tblRoomImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.Binary(),
                        Name = c.String(nullable: false, maxLength: 250),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblRooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblNumbersHouses", "StreetId", "dbo.tblStreets");
            DropForeignKey("dbo.tblRoomImages", "RoomId", "dbo.tblRooms");
            DropForeignKey("dbo.tblRooms", "HouseId", "dbo.tblNumbersHouses");
            DropForeignKey("dbo.tblStreets", "DistrictsId", "dbo.tblDistricts");
            DropForeignKey("dbo.tblDistricts", "CitiesId", "dbo.tblCities");
            DropIndex("dbo.tblRoomImages", new[] { "RoomId" });
            DropIndex("dbo.tblRooms", new[] { "HouseId" });
            DropIndex("dbo.tblNumbersHouses", new[] { "StreetId" });
            DropIndex("dbo.tblStreets", new[] { "DistrictsId" });
            DropIndex("dbo.tblDistricts", new[] { "CitiesId" });
            DropTable("dbo.tblRoomImages");
            DropTable("dbo.tblRooms");
            DropTable("dbo.tblNumbersHouses");
            DropTable("dbo.tblStreets");
            DropTable("dbo.tblDistricts");
            DropTable("dbo.tblCities");
        }
    }
}
