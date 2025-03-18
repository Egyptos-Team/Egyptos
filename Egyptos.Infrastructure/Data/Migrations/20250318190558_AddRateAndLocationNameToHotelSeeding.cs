using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRateAndLocationNameToHotelSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Hotels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Cairo international Airport terminal 3, Heliopolis, 11341 Cairo, Egypt", "Cairo", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Corniche El Nile, Garden City, Cairo", "Cairo", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Cairo", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Cairo", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Cairo", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Al-Sahaby Lan, In Front Of Luxor Temple, East Bank, 99999 Luxor, Egypt", "Luxor", 3.5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Luxor", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Luxor", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "17, Cornish El Nile Street, Beside Luxor Temple, East Bank, 99999 Luxor, Egypt", "Luxor", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Luxor", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Aswan, Corniche El Nile Baharive, Abu El Rish Qebli, 81111 Aswan, Egypt", "Aswan", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Location", "LocationName", "Rate" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d29139.651365378886!2d32.9054227!3d24.0854396!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367b4e73fa6fcf%3A0x11847bbcad585364!2z2YHZhtiv2YIg2KjZitix2KfZhdmK2LLYpyDYpdmK2YTYp9mG2K8g2KPYs9mI2KfZhg!5e0!3m2!1sar!2seg!4v1742150765720!5m2!1sar!2seg", "Aswan", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Aswan", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Aswan", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "In Front Of The Nubian Museum, 99999 Aswan, Egypt", "Aswan", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Fayoum", 4.5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Fayoum", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Fayoum", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Fayoum", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Port Said", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Port Said", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Port Said", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Port Said", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Atef El Sadat Street, Port Fouad", "Port Said", 3.5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "16, Mohamed aly street De Lesseps, ismailia, Egypt, 8361240 Ismailia, Egypt", "Ismailia", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Ismailia", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Ismailia", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Ismailia", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "LocationName", "PhoneNumber", "Rate" },
                values: new object[] { "Ismailia", "0792807762", 3.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Marsa Matrouh", 3.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Marsa Matrouh", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Marsa Matrouh", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Marsa Matrouh", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Almaza Bay, 37 km East Mersa Matruh, Marsa Matruh, Egypt", "Marsa Matrouh", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Hurghada", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Hurghada", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Hurghada", 3.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "LocationName", "PhoneNumber", "Rate" },
                values: new object[] { "Hurghada", "653557868", 3.3999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Hurghada", 3.6000000000000001 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Alexandria", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Alexandria", 3.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Alexandria", 3.5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "1 Digla Street, Al Ramel Station, Corniche Road, 00203 Alexandria, Egypt", "Alexandria", 3.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Alexandria", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Suez", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Suez", 3.5 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Suez", 3.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "LocationName", "Rate" },
                values: new object[] { "Sharks Bay, 99999 Sharm El Sheikh, Egypt", "Sharm El-Sheikh", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Facebook", "LocationName", "Rate" },
                values: new object[] { "https://www.facebook.com/NovotelSharmElSheikh/", "Sharm El-Sheikh", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "LocationName", "Name", "Rate" },
                values: new object[] { "Nabq Bay, 11038 Sharm El Sheikh, Egypt", "Sharm El-Sheikh", "Pickalbatros Laguna Vista", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Sharm El-Sheikh", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "LocationName", "Rate" },
                values: new object[] { "Sharm El-Sheikh", 4.5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Hotels");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Cairo international Airport  terminal 3, Heliopolis, 11341 Cairo, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Address",
                value: "Corniche El Nile, Garden City,Cairo");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "Address",
                value: "Al-Sahaby Lan,In Front Of Luxor Temple, East Bank, 99999 Luxor, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9,
                column: "Address",
                value: "17,Cornish El Nile Street,Beside Luxor Temple, East Bank, 99999 Luxor, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11,
                column: "Address",
                value: "Aswan,Corniche El Nile Baharive, Abu El Rish Qebli, 81111 Aswan, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12,
                column: "Location",
                value: "8https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d29139.651365378886!2d32.9054227!3d24.0854396!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367b4e73fa6fcf%3A0x11847bbcad585364!2z2YHZhtiv2YIg2KjZitix2KfZhdmK2LLYpyDYpdmK2YTYp9mG2K8g2KPYs9mI2KfZhg!5e0!3m2!1sar!2seg!4v1742150765720!5m2!1sar!2seg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15,
                column: "Address",
                value: "In Front Of The Nubian Museum,, 99999 Aswan, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24,
                column: "Address",
                value: "Atef El Sadat Street , Port Fouad");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25,
                column: "Address",
                value: "16, Mohamed aly street De Lesseps,ismailia,Egypt, 8361240 Ismailia, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29,
                column: "PhoneNumber",
                value: " 0792807762");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34,
                column: "Address",
                value: "Almaza Bay, 37 km East Mersa Matruh,, Marsa Matruh, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38,
                column: "PhoneNumber",
                value: " 653557868 ");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43,
                column: "Address",
                value: "1 Digla Street, Al Ramel Station, Corniche Road, 00203 Alexandria, EgyptAfter booking, all of the property’s details, including telephone and address, are provided in your booking confirmation and your account.");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48,
                column: "Address",
                value: "Sharks Bay , 99999 Sharm El Sheikh, Egypt");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49,
                column: "Facebook",
                value: "https://www.facebook.com/NovotelSharmElSheikh/,");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Name" },
                values: new object[] { "Nabq bay, 11038 Sharm El Sheikh, Egyp", "Pickalbatros Laguna Vista " });
        }
    }
}
