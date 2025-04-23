using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataInPublicTransportTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PublicTransports",
                columns: new[] { "Id", "Capacity", "ImageUrl", "IsAvailable", "Name", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 30, "bus.svg", 1, "Bus", 1001 },
                    { 2, 15, "bus.svg", 1, "Minibus", 1002 },
                    { 3, 30, "bus.svg", 1, "Bus", 1003 },
                    { 4, 15, "bus.svg", 1, "Minibus", 1004 },
                    { 5, 30, "bus.svg", 1, "Bus", 1005 },
                    { 6, 15, "bus.svg", 1, "Minibus", 1006 },
                    { 7, 30, "bus.svg", 1, "Bus", 1007 },
                    { 8, 15, "bus.svg", 1, "Minibus", 1008 },
                    { 9, 30, "bus.svg", 1, "Bus", 1009 },
                    { 10, 15, "bus.svg", 1, "Minibus", 1010 },
                    { 11, 30, "bus.svg", 1, "Bus", 1011 },
                    { 12, 15, "bus.svg", 1, "Minibus", 1012 },
                    { 13, 30, "bus.svg", 1, "Bus", 1013 },
                    { 14, 15, "bus.svg", 1, "Minibus", 1014 },
                    { 15, 30, "bus.svg", 1, "Bus", 1015 },
                    { 16, 15, "bus.svg", 1, "Minibus", 1016 },
                    { 17, 30, "bus.svg", 1, "Bus", 1017 },
                    { 18, 15, "bus.svg", 1, "Minibus", 1018 },
                    { 19, 30, "bus.svg", 1, "Bus", 1019 },
                    { 20, 15, "bus.svg", 1, "Minibus", 1020 },
                    { 21, 18, "bus.svg", 1, "Minibus", 2001 },
                    { 22, 35, "bus.svg", 1, "Bus", 2002 },
                    { 23, 18, "bus.svg", 1, "Minibus", 2003 },
                    { 24, 35, "bus.svg", 1, "Bus", 2004 },
                    { 25, 18, "bus.svg", 1, "Minibus", 2005 },
                    { 26, 35, "bus.svg", 1, "Bus", 2006 },
                    { 27, 18, "bus.svg", 1, "Minibus", 2007 },
                    { 28, 35, "bus.svg", 1, "Bus", 2008 },
                    { 29, 18, "bus.svg", 1, "Minibus", 2009 },
                    { 30, 35, "bus.svg", 1, "Bus", 2010 },
                    { 31, 18, "bus.svg", 1, "Minibus", 2011 },
                    { 32, 35, "bus.svg", 1, "Bus", 2012 },
                    { 33, 18, "bus.svg", 1, "Minibus", 2013 },
                    { 34, 35, "bus.svg", 1, "Bus", 2014 },
                    { 35, 18, "bus.svg", 1, "Minibus", 2015 },
                    { 36, 35, "bus.svg", 1, "Bus", 2016 },
                    { 37, 18, "bus.svg", 1, "Minibus", 2017 },
                    { 38, 35, "bus.svg", 1, "Bus", 2018 },
                    { 39, 18, "bus.svg", 1, "Minibus", 2019 },
                    { 40, 35, "bus.svg", 1, "Bus", 2020 },
                    { 41, 30, "bus.svg", 1, "Bus", 1041 },
                    { 42, 32, "bus.svg", 1, "Bus", 1042 },
                    { 43, 28, "bus.svg", 1, "Bus", 1043 },
                    { 44, 35, "bus.svg", 1, "Bus", 1044 },
                    { 45, 30, "bus.svg", 1, "Bus", 1045 },
                    { 46, 33, "bus.svg", 1, "Bus", 1046 },
                    { 47, 31, "bus.svg", 1, "Bus", 1047 },
                    { 48, 29, "bus.svg", 1, "Bus", 1048 },
                    { 49, 30, "bus.svg", 1, "Bus", 1049 },
                    { 50, 34, "bus.svg", 1, "Bus", 1050 },
                    { 51, 10, "boat.svg", 1, "Luxury Yacht", 1051 },
                    { 52, 8, "boat.svg", 1, "Sailing Boat", 1052 },
                    { 53, 6, "boat.svg", 1, "Speed Boat", 1053 },
                    { 54, 5, "boat.svg", 1, "Fishing Boat", 1054 },
                    { 55, 9, "boat.svg", 1, "Motor Yacht", 1055 },
                    { 56, 12, "boat.svg", 1, "House Boat", 1056 },
                    { 57, 10, "boat.svg", 1, "Pontoon Boat", 1057 },
                    { 58, 4, "boat.svg", 1, "Jet Boat", 1058 },
                    { 59, 14, "boat.svg", 1, "Catamaran", 1059 },
                    { 60, 11, "boat.svg", 1, "Cruiser Boat", 1060 },
                    { 61, 5, "jeep.svg", 1, "Jeep Wrangler", 1061 },
                    { 62, 7, "jeep.svg", 1, "Toyota Land Cruiser", 1062 },
                    { 63, 7, "jeep.svg", 1, "Nissan Patrol", 1063 },
                    { 64, 5, "jeep.svg", 1, "Range Rover Defender", 1064 },
                    { 65, 5, "jeep.svg", 1, "Jeep Grand Cherokee", 1065 },
                    { 66, 5, "jeep.svg", 1, "Ford Bronco", 1066 },
                    { 67, 8, "jeep.svg", 1, "Chevrolet Tahoe", 1067 },
                    { 68, 5, "jeep.svg", 1, "Mercedes G-Class", 1068 },
                    { 69, 7, "jeep.svg", 1, "Toyota Prado", 1069 },
                    { 70, 7, "jeep.svg", 1, "Mitsubishi Pajero", 1070 },
                    { 71, 30, "bus.svg", 1, "Bus", 10071 },
                    { 72, 15, "bus.svg", 1, "Minibus", 10072 },
                    { 73, 30, "bus.svg", 1, "Bus", 10073 },
                    { 74, 15, "bus.svg", 1, "Minibus", 10074 },
                    { 75, 30, "bus.svg", 1, "Bus", 10075 },
                    { 76, 15, "bus.svg", 1, "Minibus", 10076 },
                    { 77, 30, "bus.svg", 1, "Bus", 10077 },
                    { 78, 15, "bus.svg", 1, "Minibus", 10078 },
                    { 81, 5, "jeep.svg", 1, "Jeep Wrangler", 10081 },
                    { 82, 7, "jeep.svg", 1, "Toyota Land Cruiser", 10082 },
                    { 83, 7, "jeep.svg", 1, "Nissan Patrol", 10083 },
                    { 84, 5, "jeep.svg", 1, "Range Rover Defender", 10084 },
                    { 85, 5, "jeep.svg", 1, "Jeep Grand Cherokee", 10085 },
                    { 86, 5, "jeep.svg", 1, "Ford Bronco", 10086 },
                    { 87, 8, "jeep.svg", 1, "Chevrolet Tahoe", 10087 },
                    { 88, 5, "jeep.svg", 1, "Mercedes G-Class", 10088 },
                    { 89, 7, "jeep.svg", 1, "Toyota Prado", 10089 },
                    { 90, 7, "jeep.svg", 1, "Mitsubishi Pajero", 10090 },
                    { 91, 30, "bus.svg", 1, "Bus", 4623 },
                    { 92, 15, "bus.svg", 1, "Minibus", 5938 },
                    { 93, 30, "bus.svg", 1, "Bus", 7757 },
                    { 94, 15, "bus.svg", 1, "Minibus", 6162 },
                    { 95, 30, "bus.svg", 1, "Bus", 8114 },
                    { 96, 15, "bus.svg", 1, "Minibus", 9631 },
                    { 97, 30, "bus.svg", 1, "Bus", 4461 },
                    { 98, 15, "bus.svg", 1, "Minibus", 4216 },
                    { 99, 30, "bus.svg", 1, "Bus", 8283 },
                    { 100, 15, "bus.svg", 1, "Minibus", 3018 },
                    { 101, 30, "bus.svg", 1, "Bus", 3572 },
                    { 102, 15, "bus.svg", 1, "Minibus", 7150 },
                    { 103, 30, "bus.svg", 1, "Bus", 4507 },
                    { 104, 15, "bus.svg", 1, "Minibus", 7831 },
                    { 105, 30, "bus.svg", 1, "Bus", 6202 },
                    { 106, 15, "bus.svg", 1, "Minibus", 8287 },
                    { 107, 30, "bus.svg", 1, "Bus", 9618 },
                    { 108, 15, "bus.svg", 1, "Minibus", 9306 },
                    { 109, 30, "bus.svg", 1, "Bus", 9220 },
                    { 110, 15, "bus.svg", 1, "Minibus", 4937 },
                    { 111, 18, "bus.svg", 1, "Minibus", 7651 },
                    { 112, 35, "bus.svg", 1, "Bus", 8165 },
                    { 113, 18, "bus.svg", 1, "Minibus", 7413 },
                    { 114, 35, "bus.svg", 1, "Bus", 6657 },
                    { 115, 18, "bus.svg", 1, "Minibus", 8346 },
                    { 116, 35, "bus.svg", 1, "Bus", 6689 },
                    { 117, 18, "bus.svg", 1, "Minibus", 4791 },
                    { 118, 35, "bus.svg", 1, "Bus", 4279 },
                    { 119, 18, "bus.svg", 1, "Minibus", 8850 },
                    { 120, 35, "bus.svg", 1, "Bus", 4491 },
                    { 121, 18, "bus.svg", 1, "Minibus", 6930 },
                    { 122, 35, "bus.svg", 1, "Bus", 8701 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PublicTransports",
                keyColumn: "Id",
                keyValue: 122);
        }
    }
}
