using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProgramsToOldTrips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TripPrograms",
                columns: new[] { "Id", "Description", "Destination", "EndDate", "StartDate", "TripId" },
                values: new object[,]
                {
                    { 1, "Photography expedition capturing Egypt's beauty - Pyramid exploration", "Sphinx", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "Experience the magic of the eternal Nile River - Nile island hopping", "Mount Sinai", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Experience the magic of the eternal Nile River - Egyptian mythology storytelling", "Dahshur", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "Archaeological adventure with expert guides - Ancient hieroglyphs decoding", "Karnak Temple", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Archaeological adventure with expert guides - Nile felucca sailing", "Wadi El Rayan", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, "Journey through time in Egypt's sacred temples - Islamic architecture study", "Memphis", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "Educational tour of Egypt's greatest monuments - Pharaonic history tour", "Great Pyramid of Giza", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "Experience the magic of the eternal Nile River - Sand dune surfing", "Dahab", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, "Experience the magic of the eternal Nile River - Coptic Cairo walking tour", "Bent Pyramid", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Educational tour of Egypt's greatest monuments - Pyramid exploration", "Philae Temple", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Family-friendly exploration of Egyptian heritage - Snorkeling adventure", "Temple of the Oracle", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Explore the mysteries of ancient Egyptian civilization - Egyptian mythology storytelling", "Kom Ombo Temple", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Adventure through Egypt's golden deserts - Egyptian archaeology workshop", "Citadel of Saladin", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 14, "Experience the magic of the eternal Nile River - Nile felucca sailing", "Naama Bay", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 15, "Explore the mysteries of ancient Egyptian civilization - Bazaar shopping experience", "Esna Temple", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 16, "Adventure through Egypt's golden deserts - Pyramid exploration", "Karnak Temple", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 17, "Discover the wonders of the pharaohs - Desert camel trekking", "Siwa Oasis", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 18, "Explore the mysteries of ancient Egyptian civilization - Egyptian mythology storytelling", "Red Pyramid", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 19, "Immerse yourself in authentic Egyptian culture - Pyramid exploration", "Catacombs of Kom el Shoqafa", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 20, "Explore the mysteries of ancient Egyptian civilization - Nile felucca sailing", "Dahab", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 21, "Cultural immersion in traditional Egyptian life - Meditation at temples", "Red Pyramid", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 22, "Spiritual journey through Egypt's holy sites - Pyramid exploration", "Karnak Temple", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 23, "Journey through time in Egypt's sacred temples - Bedouin camp experience", "Sharm El Sheikh", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 24, "Dive into the crystal clear waters of the Red Sea - Meditation at temples", "Edfu Temple", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 25, "Explore the mysteries of ancient Egyptian civilization - Mummy wrapping demonstration", "Qaitbay Citadel", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 26, "Family-friendly exploration of Egyptian heritage - Sunset river cruise", "Temple of the Oracle", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 27, "Uncover the secrets of Alexandria's ancient glory - Egyptian mythology storytelling", "Saqqara", new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 28, "Adventure through Egypt's golden deserts - Pharaonic history tour", "Valley of the Kings", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 29, "Luxury experience of Egypt's timeless treasures - Desert camel trekking", "Mount Sinai", new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 30, "Archaeological adventure with expert guides - Meditation at temples", "Kom Ombo Temple", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 31, "Uncover the secrets of Alexandria's ancient glory - Mummy wrapping demonstration", "Great Pyramid of Giza", new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 32, "Dive into the crystal clear waters of the Red Sea - Nile felucca sailing", "Mountain of the Dead", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 33, "Journey through time in Egypt's sacred temples - Coptic Cairo walking tour", "Nubian Village", new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 34, "Discover the wonders of the pharaohs - Ancient hieroglyphs decoding", "Citadel of Saladin", new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 35, "Educational tour of Egypt's greatest monuments - Nile felucca sailing", "White Desert", new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 36, "Cultural immersion in traditional Egyptian life - Traditional craft workshop", "Nubian Village", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 37, "Dive into the crystal clear waters of the Red Sea - Pharaonic history tour", "Abu Simbel", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 38, "Adventure through Egypt's golden deserts - Ancient boat building", "Cleopatra's Bath", new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 39, "Adventure through Egypt's golden deserts - Meditation at temples", "Nubian Village", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 40, "Experience the magic of the eternal Nile River - Mummy wrapping demonstration", "Egyptian Museum", new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 41, "Archaeological adventure with expert guides - Marine life observation", "Mount Sinai", new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 42, "Spiritual journey through Egypt's holy sites - Local cuisine cooking class", "Elephantine Island", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 43, "Uncover the secrets of Alexandria's ancient glory - Mummy wrapping demonstration", "Luxor Temple", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 44, "Historical expedition through millennia of civilization - Star gazing session", "Temple of the Oracle", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 45, "Explore the mysteries of ancient Egyptian civilization - Islamic architecture study", "Nubian Village", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 46, "Journey through time in Egypt's sacred temples - Pharaonic history tour", "Luxor Temple", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 47, "Cultural immersion in traditional Egyptian life - Oasis exploration", "Lake Qarun", new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 48, "Uncover the secrets of Alexandria's ancient glory - Temple sound and light show", "Kom Ombo Temple", new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 49, "Educational tour of Egypt's greatest monuments - Egyptian archaeology workshop", "Citadel of Saladin", new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 50, "Archaeological adventure with expert guides - Star gazing session", "Mountain of the Dead", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 51, "Photography expedition capturing Egypt's beauty - Islamic architecture study", "Dahshur", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 52, "Educational tour of Egypt's greatest monuments - Egyptian archaeology workshop", "Sphinx", new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 53, "Luxury experience of Egypt's timeless treasures - Sand dune surfing", "Faiyum Oasis", new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 54, "Historical expedition through millennia of civilization - Bazaar shopping experience", "Elephantine Island", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 55, "Experience the magic of the eternal Nile River - Pharaonic history tour", "Khan El Khalili", new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 56, "Archaeological adventure with expert guides - Desert camel trekking", "Temple of the Oracle", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 57, "Uncover the secrets of Alexandria's ancient glory - Temple sound and light show", "Esna Temple", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 58, "Archaeological adventure with expert guides - Egyptian archaeology workshop", "Philae Temple", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 59, "Cultural immersion in traditional Egyptian life - Nile felucca sailing", "Siwa Oasis", new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 60, "Uncover the secrets of Alexandria's ancient glory - Islamic architecture study", "Dahshur", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 61, "Cultural immersion in traditional Egyptian life - Pharaonic history tour", "Karnak Temple", new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 62, "Luxury experience of Egypt's timeless treasures - Beach volleyball tournament", "Lahun Pyramid", new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 63, "Educational tour of Egypt's greatest monuments - Local cuisine cooking class", "Saqqara", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 64, "Spiritual journey through Egypt's holy sites - Egyptian archaeology workshop", "Karnak Temple", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 65, "Discover the wonders of the pharaohs - Coral reef photography", "Lake Qarun", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 66, "Cultural immersion in traditional Egyptian life - Sacred geometry workshop", "Elephantine Island", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22 },
                    { 67, "Dive into the crystal clear waters of the Red Sea - Pharaonic history tour", "Great Pyramid of Giza", new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 68, "Journey through time in Egypt's sacred temples - Desert camel trekking", "Dahab", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 69, "Dive into the crystal clear waters of the Red Sea - Meditation at temples", "Esna Temple", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 },
                    { 70, "Uncover the secrets of Alexandria's ancient glory - Egyptian archaeology workshop", "Great Pyramid of Giza", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 71, "Archaeological adventure with expert guides - Snorkeling adventure", "Giftun Island", new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 72, "Spiritual journey through Egypt's holy sites - Ancient rituals reenactment", "Kom Ombo Temple", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 73, "Photography expedition capturing Egypt's beauty - Pyramid exploration", "Egyptian Museum", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 74, "Dive into the crystal clear waters of the Red Sea - Oasis exploration", "El Gouna", new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 75, "Spiritual journey through Egypt's holy sites - Local cuisine cooking class", "Saqqara", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 },
                    { 76, "Photography expedition capturing Egypt's beauty - Pyramid exploration", "Qaitbay Citadel", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 77, "Photography expedition capturing Egypt's beauty - Sunset river cruise", "Naama Bay", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 78, "Educational tour of Egypt's greatest monuments - Local cuisine cooking class", "Kom Ombo Temple", new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 26 },
                    { 79, "Journey through time in Egypt's sacred temples - Pyramid exploration", "Pompey's Pillar", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 80, "Archaeological adventure with expert guides - Desert camel trekking", "Makadi Bay", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 81, "Historical expedition through millennia of civilization - Ancient rituals reenactment", "Dahshur", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 82, "Archaeological adventure with expert guides - Mummy wrapping demonstration", "Alexandria Library", new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 83, "Spiritual journey through Egypt's holy sites - Bedouin camp experience", "Sahl Hasheesh", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 84, "Archaeological adventure with expert guides - Sacred geometry workshop", "Memphis", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 85, "Journey through time in Egypt's sacred temples - Pyramid exploration", "Philae Temple", new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 86, "Explore the mysteries of ancient Egyptian civilization - Oasis exploration", "Sahl Hasheesh", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 87, "Immerse yourself in authentic Egyptian culture - Egyptian mythology storytelling", "Red Pyramid", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 88, "Adventure through Egypt's golden deserts - Egyptian archaeology workshop", "Luxor Temple", new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 89, "Historical expedition through millennia of civilization - Coral reef photography", "Mountain of the Dead", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 90, "Cultural immersion in traditional Egyptian life - Ancient rituals reenactment", "Kom Ombo Temple", new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 91, "Archaeological adventure with expert guides - Ancient hieroglyphs decoding", "Great Pyramid of Giza", new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 92, "Cultural immersion in traditional Egyptian life - Beach volleyball tournament", "Pyramid of Meidum", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 93, "Experience the magic of the eternal Nile River - Local cuisine cooking class", "Saqqara", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 94, "Discover the wonders of the pharaohs - Pyramid exploration", "Abu Simbel", new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 95, "Adventure through Egypt's golden deserts - Sand dune surfing", "Wadi El Rayan", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 96, "Journey through time in Egypt's sacred temples - Temple sound and light show", "Saqqara", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 32 },
                    { 97, "Dive into the crystal clear waters of the Red Sea - Pharaonic history tour", "Great Pyramid of Giza", new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 98, "Photography expedition capturing Egypt's beauty - Traditional fishing", "Sharm El Sheikh", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 99, "Archaeological adventure with expert guides - Egyptian mythology storytelling", "Nubian Village", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 100, "Cultural immersion in traditional Egyptian life - Ancient hieroglyphs decoding", "Luxor Temple", new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 101, "Luxury experience of Egypt's timeless treasures - Star gazing session", "Pyramid of Meidum", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 102, "Photography expedition capturing Egypt's beauty - Coptic Cairo walking tour", "Esna Temple", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 },
                    { 103, "Educational tour of Egypt's greatest monuments - Pyramid exploration", "Alexandria Library", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 104, "Luxury experience of Egypt's timeless treasures - Star gazing session", "Makadi Bay", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 105, "Adventure through Egypt's golden deserts - Traditional craft workshop", "Elephantine Island", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35 },
                    { 106, "Spiritual journey through Egypt's holy sites - Mummy wrapping demonstration", "Montaza Palace", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 107, "Educational tour of Egypt's greatest monuments - Snorkeling adventure", "Lake Qarun", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 108, "Discover the wonders of the pharaohs - Meditation at temples", "Saqqara", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 36 },
                    { 109, "Archaeological adventure with expert guides - Mummy wrapping demonstration", "Great Pyramid of Giza", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 110, "Photography expedition capturing Egypt's beauty - Ancient boat building", "Temple of the Oracle", new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 111, "Family-friendly exploration of Egyptian heritage - Islamic architecture study", "Saqqara", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 112, "Journey through time in Egypt's sacred temples - Pharaonic history tour", "Qaitbay Citadel", new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 113, "Dive into the crystal clear waters of the Red Sea - Oasis exploration", "Sahl Hasheesh", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 114, "Archaeological adventure with expert guides - Coptic Cairo walking tour", "Dahshur", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 115, "Cultural immersion in traditional Egyptian life - Mummy wrapping demonstration", "Qaitbay Citadel", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 116, "Adventure through Egypt's golden deserts - Scuba diving expedition", "Wadi El Rayan", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 117, "Explore the mysteries of ancient Egyptian civilization - Sacred geometry workshop", "Red Pyramid", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 39 },
                    { 118, "Luxury experience of Egypt's timeless treasures - Mummy wrapping demonstration", "Khan El Khalili", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 119, "Experience the magic of the eternal Nile River - Beach volleyball tournament", "Naama Bay", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 120, "Luxury experience of Egypt's timeless treasures - Bazaar shopping experience", "Kom Ombo Temple", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 121, "Uncover the secrets of Alexandria's ancient glory - Pyramid exploration", "Sphinx", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 122, "Immerse yourself in authentic Egyptian culture - Coral reef photography", "El Gouna", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 123, "Photography expedition capturing Egypt's beauty - Islamic architecture study", "Kom Ombo Temple", new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 41 },
                    { 124, "Uncover the secrets of Alexandria's ancient glory - Mummy wrapping demonstration", "Qaitbay Citadel", new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 125, "Dive into the crystal clear waters of the Red Sea - Ancient boat building", "Makadi Bay", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 126, "Discover the wonders of the pharaohs - Islamic architecture study", "Nubian Village", new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 127, "Family-friendly exploration of Egyptian heritage - Egyptian archaeology workshop", "Valley of the Kings", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 128, "Journey through time in Egypt's sacred temples - Star gazing session", "Temple of the Oracle", new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 129, "Adventure through Egypt's golden deserts - Ancient rituals reenactment", "Nubian Village", new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 130, "Dive into the crystal clear waters of the Red Sea - Egyptian archaeology workshop", "Karnak Temple", new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 131, "Immerse yourself in authentic Egyptian culture - Oasis exploration", "Cleopatra's Bath", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 132, "Dive into the crystal clear waters of the Red Sea - Bazaar shopping experience", "Edfu Temple", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 133, "Photography expedition capturing Egypt's beauty - Ancient hieroglyphs decoding", "Egyptian Museum", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 134, "Explore the mysteries of ancient Egyptian civilization - Traditional fishing", "Cleopatra's Bath", new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 135, "Adventure through Egypt's golden deserts - Egyptian mythology storytelling", "Bent Pyramid", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 136, "Explore the mysteries of ancient Egyptian civilization - Pharaonic history tour", "Great Pyramid of Giza", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 137, "Explore the mysteries of ancient Egyptian civilization - Sunset river cruise", "Ras Mohammed", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 138, "Educational tour of Egypt's greatest monuments - Sacred geometry workshop", "Memphis", new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 139, "Cultural immersion in traditional Egyptian life - Mummy wrapping demonstration", "Sphinx", new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 140, "Historical expedition through millennia of civilization - Ancient boat building", "Temple of the Oracle", new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 141, "Discover the wonders of the pharaohs - Islamic architecture study", "Dahshur", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 142, "Photography expedition capturing Egypt's beauty - Egyptian archaeology workshop", "Luxor Temple", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 143, "Archaeological adventure with expert guides - Desert camel trekking", "Lake Qarun", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 144, "Uncover the secrets of Alexandria's ancient glory - Bazaar shopping experience", "Edfu Temple", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 145, "Historical expedition through millennia of civilization - Ancient hieroglyphs decoding", "Philae Temple", new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 146, "Cultural immersion in traditional Egyptian life - Star gazing session", "Sahl Hasheesh", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 147, "Adventure through Egypt's golden deserts - Ancient rituals reenactment", "Edfu Temple", new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 148, "Explore the mysteries of ancient Egyptian civilization - Pyramid exploration", "Khan El Khalili", new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 149, "Spiritual journey through Egypt's holy sites - Traditional fishing", "Wadi El Rayan", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 150, "Adventure through Egypt's golden deserts - Sacred geometry workshop", "Dahshur", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 151, "Family-friendly exploration of Egyptian heritage - Pharaonic history tour", "Egyptian Museum", new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 },
                    { 152, "Historical expedition through millennia of civilization - Coral reef photography", "Mountain of the Dead", new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 },
                    { 153, "Uncover the secrets of Alexandria's ancient glory - Coptic Cairo walking tour", "Saqqara", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 51 },
                    { 154, "Family-friendly exploration of Egyptian heritage - Pyramid exploration", "Karnak Temple", new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 155, "Family-friendly exploration of Egyptian heritage - Scuba diving expedition", "Pyramid of Meidum", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 156, "Explore the mysteries of ancient Egyptian civilization - Traditional craft workshop", "Memphis", new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 157, "Immerse yourself in authentic Egyptian culture - Mummy wrapping demonstration", "Qaitbay Citadel", new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 },
                    { 158, "Photography expedition capturing Egypt's beauty - Beach volleyball tournament", "Wadi El Rayan", new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 },
                    { 159, "Discover the wonders of the pharaohs - Islamic architecture study", "Bent Pyramid", new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 53 },
                    { 160, "Family-friendly exploration of Egyptian heritage - Ancient hieroglyphs decoding", "Catacombs of Kom el Shoqafa", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 },
                    { 161, "Journey through time in Egypt's sacred temples - Sunset river cruise", "Wadi El Rayan", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 },
                    { 162, "Educational tour of Egypt's greatest monuments - Temple sound and light show", "Dahshur", new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 54 },
                    { 163, "Family-friendly exploration of Egyptian heritage - Pharaonic history tour", "Egyptian Museum", new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 164, "Historical expedition through millennia of civilization - Sunset river cruise", "El Gouna", new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 165, "Immerse yourself in authentic Egyptian culture - Egyptian mythology storytelling", "Kom Ombo Temple", new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 55 },
                    { 166, "Archaeological adventure with expert guides - Mummy wrapping demonstration", "Pompey's Pillar", new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 },
                    { 167, "Adventure through Egypt's golden deserts - Traditional fishing", "Naama Bay", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 },
                    { 168, "Photography expedition capturing Egypt's beauty - Meditation at temples", "Edfu Temple", new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 },
                    { 169, "Spiritual journey through Egypt's holy sites - Pyramid exploration", "Abu Simbel", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 170, "Journey through time in Egypt's sacred temples - Nile felucca sailing", "Ras Mohammed", new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 171, "Luxury experience of Egypt's timeless treasures - Local cuisine cooking class", "Edfu Temple", new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 57 },
                    { 172, "Journey through time in Egypt's sacred temples - Pyramid exploration", "Sphinx", new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 173, "Luxury experience of Egypt's timeless treasures - Sand dune surfing", "Lahun Pyramid", new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 174, "Photography expedition capturing Egypt's beauty - Sacred geometry workshop", "Dahshur", new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 58 },
                    { 175, "Journey through time in Egypt's sacred temples - Pyramid exploration", "Catacombs of Kom el Shoqafa", new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 },
                    { 176, "Cultural immersion in traditional Egyptian life - Desert camel trekking", "Lahun Pyramid", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 },
                    { 177, "Explore the mysteries of ancient Egyptian civilization - Sacred geometry workshop", "Saqqara", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 59 },
                    { 178, "Archaeological adventure with expert guides - Pharaonic history tour", "Great Pyramid of Giza", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 179, "Discover the wonders of the pharaohs - Desert camel trekking", "Mountain of the Dead", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 180, "Journey through time in Egypt's sacred temples - Ancient rituals reenactment", "Bent Pyramid", new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60 },
                    { 181, "Explore the mysteries of ancient Egyptian civilization - Egyptian archaeology workshop", "Pompey's Pillar", new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 182, "Historical expedition through millennia of civilization - Marine life observation", "Mount Sinai", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 183, "Cultural immersion in traditional Egyptian life - Islamic architecture study", "Red Pyramid", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 61 },
                    { 184, "Adventure through Egypt's golden deserts - Mummy wrapping demonstration", "Great Pyramid of Giza", new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 },
                    { 185, "Journey through time in Egypt's sacred temples - Bedouin camp experience", "White Desert", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 },
                    { 186, "Historical expedition through millennia of civilization - Local cuisine cooking class", "Bent Pyramid", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 62 },
                    { 187, "Educational tour of Egypt's greatest monuments - Pharaonic history tour", "Montaza Palace", new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 },
                    { 188, "Spiritual journey through Egypt's holy sites - Traditional fishing", "White Desert", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 },
                    { 189, "Luxury experience of Egypt's timeless treasures - Egyptian mythology storytelling", "Esna Temple", new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 63 },
                    { 190, "Cultural immersion in traditional Egyptian life - Ancient hieroglyphs decoding", "Pompey's Pillar", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 },
                    { 191, "Discover the wonders of the pharaohs - Ancient boat building", "Lake Qarun", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 },
                    { 192, "Explore the mysteries of ancient Egyptian civilization - Ancient rituals reenactment", "Dahshur", new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 64 },
                    { 193, "Photography expedition capturing Egypt's beauty - Pyramid exploration", "Alexandria Library", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 },
                    { 194, "Spiritual journey through Egypt's holy sites - Desert camel trekking", "Temple of the Oracle", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 },
                    { 195, "Uncover the secrets of Alexandria's ancient glory - Bazaar shopping experience", "Elephantine Island", new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 65 },
                    { 196, "Photography expedition capturing Egypt's beauty - Egyptian archaeology workshop", "Khan El Khalili", new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 },
                    { 197, "Experience the magic of the eternal Nile River - Desert camel trekking", "Ras Mohammed", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 },
                    { 198, "Discover the wonders of the pharaohs - Sacred geometry workshop", "Saqqara", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 66 },
                    { 199, "Historical expedition through millennia of civilization - Pharaonic history tour", "Valley of the Kings", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 67 },
                    { 200, "Immerse yourself in authentic Egyptian culture - Oasis exploration", "Hurghada Marina", new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 67 },
                    { 201, "Dive into the crystal clear waters of the Red Sea - Ancient rituals reenactment", "Dahshur", new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 67 },
                    { 202, "Journey through time in Egypt's sacred temples - Ancient hieroglyphs decoding", "Egyptian Museum", new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 },
                    { 203, "Spiritual journey through Egypt's holy sites - Nile felucca sailing", "Lake Qarun", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 },
                    { 204, "Journey through time in Egypt's sacred temples - Local cuisine cooking class", "Elephantine Island", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 68 },
                    { 205, "Discover the wonders of the pharaohs - Pyramid exploration", "Khan El Khalili", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 },
                    { 206, "Discover the wonders of the pharaohs - Desert camel trekking", "Cleopatra's Bath", new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 },
                    { 207, "Historical expedition through millennia of civilization - Temple sound and light show", "Kom Ombo Temple", new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 },
                    { 208, "Adventure through Egypt's golden deserts - Pharaonic history tour", "Khan El Khalili", new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 209, "Experience the magic of the eternal Nile River - Beach volleyball tournament", "Cleopatra's Bath", new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 210, "Immerse yourself in authentic Egyptian culture - Sacred geometry workshop", "Red Pyramid", new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 211, "Archaeological adventure with expert guides - Pharaonic history tour", "Montaza Palace", new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 },
                    { 212, "Historical expedition through millennia of civilization - Beach volleyball tournament", "Wadi El Rayan", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 },
                    { 213, "Photography expedition capturing Egypt's beauty - Islamic architecture study", "Kom Ombo Temple", new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 },
                    { 214, "Luxury experience of Egypt's timeless treasures - Mummy wrapping demonstration", "Sphinx", new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 },
                    { 215, "Journey through time in Egypt's sacred temples - Scuba diving expedition", "Makadi Bay", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 },
                    { 216, "Photography expedition capturing Egypt's beauty - Coptic Cairo walking tour", "Elephantine Island", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 72 },
                    { 217, "Luxury experience of Egypt's timeless treasures - Pharaonic history tour", "Karnak Temple", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 },
                    { 218, "Experience the magic of the eternal Nile River - Bedouin camp experience", "Pyramid of Meidum", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 },
                    { 219, "Spiritual journey through Egypt's holy sites - Bazaar shopping experience", "Elephantine Island", new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 73 },
                    { 220, "Luxury experience of Egypt's timeless treasures - Pyramid exploration", "Catacombs of Kom el Shoqafa", new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 221, "Family-friendly exploration of Egyptian heritage - Nile felucca sailing", "Makadi Bay", new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 222, "Educational tour of Egypt's greatest monuments - Sacred geometry workshop", "Edfu Temple", new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 74 },
                    { 223, "Archaeological adventure with expert guides - Pharaonic history tour", "Abu Simbel", new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 },
                    { 224, "Journey through time in Egypt's sacred temples - Marine life observation", "Siwa Oasis", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 },
                    { 225, "Photography expedition capturing Egypt's beauty - Egyptian mythology storytelling", "Dahshur", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 75 },
                    { 226, "Dive into the crystal clear waters of the Red Sea - Pyramid exploration", "Valley of the Kings", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 },
                    { 227, "Adventure through Egypt's golden deserts - Snorkeling adventure", "Faiyum Oasis", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 },
                    { 228, "Discover the wonders of the pharaohs - Temple sound and light show", "Elephantine Island", new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 76 },
                    { 229, "Spiritual journey through Egypt's holy sites - Pyramid exploration", "Sphinx", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 230, "Photography expedition capturing Egypt's beauty - Bedouin camp experience", "Giftun Island", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 231, "Cultural immersion in traditional Egyptian life - Islamic architecture study", "Saqqara", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 77 },
                    { 232, "Experience the magic of the eternal Nile River - Mummy wrapping demonstration", "Catacombs of Kom el Shoqafa", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 },
                    { 233, "Journey through time in Egypt's sacred temples - Snorkeling adventure", "Lake Qarun", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 },
                    { 234, "Cultural immersion in traditional Egyptian life - Local cuisine cooking class", "Memphis", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 78 },
                    { 241, "Archaeological adventure with expert guides - Pharaonic history tour", "Catacombs of Kom el Shoqafa", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 },
                    { 242, "Explore the mysteries of ancient Egyptian civilization - Ancient boat building", "Temple of the Oracle", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 },
                    { 243, "Family-friendly exploration of Egyptian heritage - Local cuisine cooking class", "Red Pyramid", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 81 },
                    { 244, "Immerse yourself in authentic Egyptian culture - Pharaonic history tour", "Catacombs of Kom el Shoqafa", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 },
                    { 245, "Immerse yourself in authentic Egyptian culture - Ancient boat building", "Ras Mohammed", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 },
                    { 246, "Cultural immersion in traditional Egyptian life - Meditation at temples", "Esna Temple", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 82 },
                    { 247, "Archaeological adventure with expert guides - Egyptian archaeology workshop", "Montaza Palace", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 },
                    { 248, "Photography expedition capturing Egypt's beauty - Bedouin camp experience", "El Gouna", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 },
                    { 249, "Explore the mysteries of ancient Egyptian civilization - Bazaar shopping experience", "Saqqara", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 83 },
                    { 250, "Historical expedition through millennia of civilization - Mummy wrapping demonstration", "Montaza Palace", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 },
                    { 251, "Explore the mysteries of ancient Egyptian civilization - Nile island hopping", "Wadi El Rayan", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 },
                    { 252, "Immerse yourself in authentic Egyptian culture - Bazaar shopping experience", "Edfu Temple", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 84 },
                    { 253, "Archaeological adventure with expert guides - Pyramid exploration", "Philae Temple", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 },
                    { 254, "Educational tour of Egypt's greatest monuments - Sand dune surfing", "Faiyum Oasis", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 },
                    { 255, "Family-friendly exploration of Egyptian heritage - Bazaar shopping experience", "Nubian Village", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 85 },
                    { 256, "Journey through time in Egypt's sacred temples - Ancient hieroglyphs decoding", "Citadel of Saladin", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 },
                    { 257, "Historical expedition through millennia of civilization - Nile island hopping", "Giftun Island", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 },
                    { 258, "Dive into the crystal clear waters of the Red Sea - Ancient rituals reenactment", "Nubian Village", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 86 },
                    { 259, "Journey through time in Egypt's sacred temples - Mummy wrapping demonstration", "Egyptian Museum", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 },
                    { 260, "Discover the wonders of the pharaohs - Nile felucca sailing", "Lake Qarun", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 },
                    { 261, "Adventure through Egypt's golden deserts - Meditation at temples", "Saqqara", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 87 },
                    { 262, "Adventure through Egypt's golden deserts - Egyptian archaeology workshop", "Karnak Temple", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 88 },
                    { 263, "Photography expedition capturing Egypt's beauty - Coral reef photography", "Makadi Bay", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 88 },
                    { 264, "Educational tour of Egypt's greatest monuments - Temple sound and light show", "Dahshur", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 88 },
                    { 265, "Cultural immersion in traditional Egyptian life - Mummy wrapping demonstration", "Pompey's Pillar", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 },
                    { 266, "Experience the magic of the eternal Nile River - Marine life observation", "Dahab", new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 },
                    { 267, "Discover the wonders of the pharaohs - Meditation at temples", "Saqqara", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 89 },
                    { 268, "Luxury experience of Egypt's timeless treasures - Pyramid exploration", "Valley of the Kings", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 269, "Spiritual journey through Egypt's holy sites - Sand dune surfing", "Siwa Oasis", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 270, "Adventure through Egypt's golden deserts - Ancient rituals reenactment", "Esna Temple", new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 90 },
                    { 271, "Educational tour of Egypt's greatest monuments - Pyramid exploration", "Karnak Temple", new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 272, "Adventure through Egypt's golden deserts - Coral reef photography", "Faiyum Oasis", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 273, "Family-friendly exploration of Egyptian heritage - Temple sound and light show", "Esna Temple", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 274, "Adventure through Egypt's golden deserts - Egyptian archaeology workshop", "Catacombs of Kom el Shoqafa", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 92 },
                    { 275, "Dive into the crystal clear waters of the Red Sea - Ancient boat building", "Ras Mohammed", new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 92 },
                    { 276, "Photography expedition capturing Egypt's beauty - Temple sound and light show", "Bent Pyramid", new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 92 },
                    { 277, "Historical expedition through millennia of civilization - Egyptian archaeology workshop", "Catacombs of Kom el Shoqafa", new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 },
                    { 278, "Archaeological adventure with expert guides - Bedouin camp experience", "Makadi Bay", new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 },
                    { 279, "Experience the magic of the eternal Nile River - Temple sound and light show", "Red Pyramid", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 },
                    { 280, "Adventure through Egypt's golden deserts - Mummy wrapping demonstration", "Alexandria Library", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 },
                    { 281, "Discover the wonders of the pharaohs - Ancient boat building", "Temple of the Oracle", new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 },
                    { 282, "Dive into the crystal clear waters of the Red Sea - Local cuisine cooking class", "Edfu Temple", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 94 },
                    { 283, "Discover the wonders of the pharaohs - Pharaonic history tour", "Egyptian Museum", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 95 },
                    { 284, "Explore the mysteries of ancient Egyptian civilization - Scuba diving expedition", "Sharm El Sheikh", new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 95 },
                    { 285, "Educational tour of Egypt's greatest monuments - Egyptian mythology storytelling", "Elephantine Island", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 95 },
                    { 286, "Spiritual journey through Egypt's holy sites - Mummy wrapping demonstration", "Karnak Temple", new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 },
                    { 287, "Discover the wonders of the pharaohs - Marine life observation", "Siwa Oasis", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 },
                    { 288, "Adventure through Egypt's golden deserts - Sacred geometry workshop", "Red Pyramid", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 96 },
                    { 289, "Spiritual journey through Egypt's holy sites - Mummy wrapping demonstration", "Khan El Khalili", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 },
                    { 290, "Uncover the secrets of Alexandria's ancient glory - Traditional fishing", "Hurghada Marina", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 },
                    { 291, "Experience the magic of the eternal Nile River - Sacred geometry workshop", "Elephantine Island", new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 97 },
                    { 292, "Spiritual journey through Egypt's holy sites - Pharaonic history tour", "Egyptian Museum", new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 },
                    { 293, "Explore the mysteries of ancient Egyptian civilization - Traditional fishing", "Temple of the Oracle", new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 },
                    { 294, "Explore the mysteries of ancient Egyptian civilization - Islamic architecture study", "Nubian Village", new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 98 },
                    { 295, "Historical expedition through millennia of civilization - Pyramid exploration", "Egyptian Museum", new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 99 },
                    { 296, "Adventure through Egypt's golden deserts - Sand dune surfing", "Faiyum Oasis", new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 99 },
                    { 297, "Historical expedition through millennia of civilization - Egyptian mythology storytelling", "Bent Pyramid", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 99 },
                    { 298, "Adventure through Egypt's golden deserts - Ancient hieroglyphs decoding", "Qaitbay Citadel", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 299, "Immerse yourself in authentic Egyptian culture - Traditional fishing", "El Gouna", new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 300, "Explore the mysteries of ancient Egyptian civilization - Traditional craft workshop", "Bent Pyramid", new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 301, "Uncover the secrets of Alexandria's ancient glory - Ancient hieroglyphs decoding", "Philae Temple", new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 101 },
                    { 302, "Family-friendly exploration of Egyptian heritage - Nile felucca sailing", "El Gouna", new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 101 },
                    { 303, "Explore the mysteries of ancient Egyptian civilization - Meditation at temples", "Bent Pyramid", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 101 },
                    { 304, "Historical expedition through millennia of civilization - Pharaonic history tour", "Luxor Temple", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 102 },
                    { 305, "Explore the mysteries of ancient Egyptian civilization - Desert camel trekking", "Temple of the Oracle", new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 102 },
                    { 306, "Experience the magic of the eternal Nile River - Islamic architecture study", "Red Pyramid", new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 102 },
                    { 307, "Experience the magic of the eternal Nile River - Pharaonic history tour", "Qaitbay Citadel", new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 103 },
                    { 308, "Family-friendly exploration of Egyptian heritage - Nile island hopping", "Mountain of the Dead", new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 103 },
                    { 309, "Luxury experience of Egypt's timeless treasures - Temple sound and light show", "Bent Pyramid", new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 103 },
                    { 310, "Dive into the crystal clear waters of the Red Sea - Egyptian archaeology workshop", "Luxor Temple", new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 104 },
                    { 311, "Journey through time in Egypt's sacred temples - Star gazing session", "Siwa Oasis", new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 104 },
                    { 312, "Educational tour of Egypt's greatest monuments - Egyptian mythology storytelling", "Esna Temple", new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 104 },
                    { 313, "Family-friendly exploration of Egyptian heritage - Pyramid exploration", "Alexandria Library", new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 105 },
                    { 314, "Experience the magic of the eternal Nile River - Marine life observation", "Makadi Bay", new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 105 },
                    { 315, "Cultural immersion in traditional Egyptian life - Egyptian mythology storytelling", "Nubian Village", new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 105 },
                    { 316, "Explore the mysteries of ancient Egyptian civilization - Pharaonic history tour", "Pompey's Pillar", new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 106 },
                    { 317, "Family-friendly exploration of Egyptian heritage - Beach volleyball tournament", "El Gouna", new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 106 },
                    { 318, "Experience the magic of the eternal Nile River - Temple sound and light show", "Memphis", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 106 },
                    { 319, "Adventure through Egypt's golden deserts - Pyramid exploration", "Karnak Temple", new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 320, "Discover the wonders of the pharaohs - Nile island hopping", "Lahun Pyramid", new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 321, "Family-friendly exploration of Egyptian heritage - Meditation at temples", "Dahshur", new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 107 },
                    { 322, "Immerse yourself in authentic Egyptian culture - Mummy wrapping demonstration", "Philae Temple", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 108 },
                    { 323, "Discover the wonders of the pharaohs - Sunset river cruise", "Lahun Pyramid", new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 108 },
                    { 324, "Family-friendly exploration of Egyptian heritage - Islamic architecture study", "Nubian Village", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 108 },
                    { 325, "Discover the wonders of the pharaohs - Ancient hieroglyphs decoding", "Valley of the Kings", new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 109 },
                    { 326, "Journey through time in Egypt's sacred temples - Nile island hopping", "Wadi El Rayan", new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 109 },
                    { 327, "Discover the wonders of the pharaohs - Local cuisine cooking class", "Memphis", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 109 },
                    { 328, "Adventure through Egypt's golden deserts - Pyramid exploration", "Egyptian Museum", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110 },
                    { 329, "Luxury experience of Egypt's timeless treasures - Marine life observation", "Ras Mohammed", new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 110 },
                    { 330, "Adventure through Egypt's golden deserts - Islamic architecture study", "Bent Pyramid", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 110 },
                    { 331, "Discover the wonders of the pharaohs - Pyramid exploration", "Karnak Temple", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 111 },
                    { 332, "Spiritual journey through Egypt's holy sites - Coral reef photography", "Dahab", new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 111 },
                    { 333, "Adventure through Egypt's golden deserts - Local cuisine cooking class", "Dahshur", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 111 },
                    { 334, "Family-friendly exploration of Egyptian heritage - Mummy wrapping demonstration", "Qaitbay Citadel", new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 112 },
                    { 335, "Experience the magic of the eternal Nile River - Traditional fishing", "Ras Mohammed", new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 112 },
                    { 336, "Luxury experience of Egypt's timeless treasures - Temple sound and light show", "Memphis", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 112 },
                    { 337, "Explore the mysteries of ancient Egyptian civilization - Ancient hieroglyphs decoding", "Pompey's Pillar", new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 113 },
                    { 338, "Archaeological adventure with expert guides - Sand dune surfing", "Faiyum Oasis", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 113 },
                    { 339, "Historical expedition through millennia of civilization - Ancient rituals reenactment", "Saqqara", new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 113 },
                    { 340, "Cultural immersion in traditional Egyptian life - Mummy wrapping demonstration", "Philae Temple", new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 114 },
                    { 341, "Photography expedition capturing Egypt's beauty - Nile felucca sailing", "Faiyum Oasis", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 114 },
                    { 342, "Luxury experience of Egypt's timeless treasures - Local cuisine cooking class", "Nubian Village", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 114 },
                    { 343, "Spiritual journey through Egypt's holy sites - Pyramid exploration", "Montaza Palace", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 115 },
                    { 344, "Spiritual journey through Egypt's holy sites - Sunset river cruise", "White Desert", new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 115 },
                    { 345, "Discover the wonders of the pharaohs - Local cuisine cooking class", "Nubian Village", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 115 },
                    { 346, "Family-friendly exploration of Egyptian heritage - Pharaonic history tour", "Valley of the Kings", new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 116 },
                    { 347, "Spiritual journey through Egypt's holy sites - Snorkeling adventure", "Lake Qarun", new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 116 },
                    { 348, "Family-friendly exploration of Egyptian heritage - Egyptian mythology storytelling", "Edfu Temple", new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 116 },
                    { 349, "Archaeological adventure with expert guides - Mummy wrapping demonstration", "Valley of the Kings", new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 117 },
                    { 350, "Luxury experience of Egypt's timeless treasures - Nile island hopping", "Mountain of the Dead", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 117 },
                    { 351, "Dive into the crystal clear waters of the Red Sea - Sacred geometry workshop", "Edfu Temple", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 117 },
                    { 352, "Historical expedition through millennia of civilization - Egyptian archaeology workshop", "Karnak Temple", new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 118 },
                    { 353, "Photography expedition capturing Egypt's beauty - Beach volleyball tournament", "Cleopatra's Bath", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 118 },
                    { 354, "Cultural immersion in traditional Egyptian life - Traditional craft workshop", "Elephantine Island", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 118 },
                    { 355, "Immerse yourself in authentic Egyptian culture - Pharaonic history tour", "Egyptian Museum", new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 119 },
                    { 356, "Immerse yourself in authentic Egyptian culture - Oasis exploration", "Hurghada Marina", new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 119 },
                    { 357, "Spiritual journey through Egypt's holy sites - Ancient rituals reenactment", "Kom Ombo Temple", new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 119 },
                    { 358, "Photography expedition capturing Egypt's beauty - Ancient hieroglyphs decoding", "Alexandria Library", new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 359, "Experience the magic of the eternal Nile River - Ancient boat building", "Siwa Oasis", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 360, "Cultural immersion in traditional Egyptian life - Coptic Cairo walking tour", "Bent Pyramid", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 120 },
                    { 361, "Historical expedition through millennia of civilization - Pyramid exploration", "Karnak Temple", new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 121 },
                    { 362, "Spiritual journey through Egypt's holy sites - Nile felucca sailing", "El Gouna", new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 121 },
                    { 363, "Discover the wonders of the pharaohs - Traditional craft workshop", "Bent Pyramid", new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 121 },
                    { 364, "Discover the wonders of the pharaohs - Egyptian archaeology workshop", "Khan El Khalili", new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 122 },
                    { 365, "Archaeological adventure with expert guides - Desert camel trekking", "Lake Qarun", new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 122 },
                    { 366, "Explore the mysteries of ancient Egyptian civilization - Egyptian mythology storytelling", "Memphis", new DateTime(2025, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 122 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "TripPrograms",
                keyColumn: "Id",
                keyValue: 366);
        }
    }
}
