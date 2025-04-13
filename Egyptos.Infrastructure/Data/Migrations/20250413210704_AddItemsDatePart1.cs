using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItemsDatePart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AreaId", "Date", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 112, new DateOnly(1795, 4, 1), "A cane concealing a rifle, with a handle coiled in the shape of a snake's head.Date: Ottoman period.Material: Wood and ivory.", "Items/deceptive weapons.jpg", "deceptive weapons" },
                    { 2, 112, new DateOnly(1795, 4, 1), "Pear-shaped, decorated with raised fish-scale motifs, with a short neck ending in a narrow spout for pouring oil. It resembles a modern-day hand grenade.Date: Fatimid period.nMaterial: Pottery.", "Items/Oil bottle.jpg", "Oil bottle" },
                    { 3, 112, new DateOnly(1795, 4, 1), "A Krupp cannon, commonly known as the Ramadan Cannon. It consists of an iron barrel resting on an iron base with two large wooden wheels and iron frames.Date: Muhammad Ali Dynasty - 1871 AD.Material: Iron and wood.", "Items/Ramadan Cannon.jpg", "Ramadan Cannon" },
                    { 4, 112, new DateOnly(1795, 4, 1), "Model of a boat: Shown to be carrying ten sailors.Date: Ancient Egyptian.Material: Wood.", "Items/Boat.jpg", "Boat" },
                    { 5, 112, new DateOnly(1795, 4, 1), "The world's first hand-operated fire engine: an English-made engine. It was very primitive; it consisted of a rectangular box mounted on four wheels and was transported to the fire site by horse.Date: Ottoman era - 1766 AD.Material: Wood.", "Items/The First Fire Engine.jpg", "The First Fire Engine" },
                    { 6, 112, new DateOnly(1795, 4, 1), "Oval-shaped shield with a handle in the middle.Date: Ottoman period.Material: Wood, leather, and tortoiseshell.", "Items/Defensive Weapons.jpg", "Defensive Weapons" },
                    { 7, 113, new DateOnly(1795, 4, 1), "Inlaid copper incense burner with gold and silver.Mamluk period, 8th century AH / 14th century AD Material: Copper, gold, silver Provenance: Egypt", "Items/Incense burner.jpg", "Incense burner" },
                    { 8, 113, new DateOnly(1795, 4, 1), "The item is a long-handled surgical scalpel with a sharp blade whose tip is thinner and wider than its handle.Date: 3rd century AH / 9th century AD Material: Cast copper. Provenance: Cairo, Egypt", "Items/Surgical scalpel.jpg", "Surgical scalpel" },
                    { 9, 113, new DateOnly(1795, 4, 1), "Copper jug ​​and basin decorated with enamel. Date: Qajar period - 13th century AH / 19th century AD Material: Copper Provenance: Iran", "Items/Copper jug ​​and basin.jpg", "Copper jug ​​and basin" },
                    { 10, 113, new DateOnly(1795, 4, 1), "Ivory kohl stick inlaid with mother-of-pearl. Era: Mamluk or Ottoman Date: 9th-10th century AH / 15th-16th century AD Provenance: Egypt", "Items/Kohl stick.jpg", "Kohl stick" },
                    { 11, 113, new DateOnly(1795, 4, 1), "Lacquered wooden Qibla guide.Türkiye - Ottoman era.12th century AH / 18th century AD.", "Items/Wooden Qibla Guide.jpg", "Wooden Qibla Guide" },
                    { 12, 114, new DateOnly(1795, 4, 1), "This part of the statue may represent King Thutmose III, one of the greatest kings and rulers of ancient Egypt.New Kingdom, Eighteenth Dynasty, c. 1550–1295 BCMaterial: Red granite", "Items/Upper part of a royal statue.jpg", "Upper part of a royal statue" },
                    { 13, 114, new DateOnly(1795, 4, 1), "Funeral stele with an inscription of Sheddetef and his wife Bret. The text on the stele refers to the formula for offerings to Osiris.First Intermediate Period, c. 2181–2055 BC Nag el-Deir Colored limestone", "Items/Funerary Stele.jpg", "Funerary Stele" },
                    { 14, 114, new DateOnly(1795, 4, 1), "A bust of a young man representing a scholar, his body wrapped in a Greek cloak in the form of a suspended arm, characteristic of educated and cultured Greeks.Roman period, c. 200-210 AD Material: Marble Provenance: Abusir, near Samanud", "Items/Bust of a Young Man.jpg", "Bust of a Young Man" },
                    { 15, 114, new DateOnly(1795, 4, 1), "A jug and basin, each decorated with naturalistic motifs including architectural forms, some of which depict Ottoman-style mosques. It is worth noting that jugs of this type, carried on basins, were used for ablution or pouring water for washing hands. Date: 13th century AH/19th century AD Provenance: Türkiye Ceramic, silver", "Items/Jug and basin.jpg", "Jug and basin" },
                    { 16, 114, new DateOnly(1795, 4, 1), "Pocket watch with a cover on the front featuring a picture of Muhammad Ali 13th-14th century AH / 19th-20th century AD Gold, colored dial", "Items/Pocket Watch.jpg", "Pocket Watch" },
                    { 17, 114, new DateOnly(1795, 4, 1), "A Mushaf written in Naskh script, presented to Khedive Tawfiq in 1300 AH (1883 AD).Material: Leather, paper", "Items/Mushaf.jpg", "Mushaf" },
                    { 18, 115, new DateOnly(1795, 4, 1), " An oil painting of King Fuad's favorite donkey, with one of the royal palaces in the background.", "Items/Oil painting.jpg", "Oil painting" },
                    { 19, 115, new DateOnly(1795, 4, 1), "A large wooden boxcar laminated with zinc sheets, manufactured in England during the reign of Khedive Ismail (1863-1879 AD), used for transporting furniture and kitchen supplies.", "Items/Caravan.jpg", "Caravan" },
                    { 20, 115, new DateOnly(1795, 4, 1), "The Alai Private CarriageThe Alai Private Carriage, which is a Turkish word meaning squad or battalion, has a rich and illustrious history. It was a gift from the French Emperor Napoleon III and his wife, Empress Eugenie, to Khedive Ismail during the opening of the Suez Canal in 1869. A plaque depicting this carriage is preserved at the Marriott Hotel.", "Items/The Alai Private Carriage.jpg", "The Alai Private Carriage" },
                    { 21, 115, new DateOnly(1795, 4, 1), "The Qamishji's clothing, the person who trots beside each horse during official processions, was responsible for cleaning and protecting the carriages during the journey, and for clearing the way. He held a bamboo stick in the morning and a torch in the evening to light the way.", "Items/The Qamishji's clothing.jpg", "The Qamishji's clothing" },
                    { 22, 115, new DateOnly(1795, 4, 1), " A set of seals belonging to the Royal Horseback Riding Authority.", "Items/A set of seals.jpg", "A set of seals" },
                    { 23, 115, new DateOnly(1795, 4, 1), "Colored Chinese statue of a knight in a suit and with a wooden base - Made in Austria.", "Items/Chinese statue.jpg", "Chinese statue" },
                    { 24, 116, new DateOnly(1795, 4, 1), " This special hall displays three-dimensional scenes illustrating Nubian history and culture. Diorama technology is used to recreate historical and cultural scenes in realistic and detailed detail.", "Items/The Diorama Hall.jpg", "The Diorama Hall" },
                    { 25, 116, new DateOnly(1795, 4, 1), "  One of the most prominent kings of the Twenty-Fifth Dynasty was King Taharqa, who ruled from approximately 690 BC to 664 BC. Taharqa was one of the most prominent Nubian kings and a powerful leader, distinguished by his successful military campaigns and his support for arts and culture.", "Items/King Taharqa.jpg", "King Taharqa" },
                    { 26, 116, new DateOnly(1795, 4, 1), "This pottery vessel dates back to an ancient period in Nubia's history. The symbols engraved on it typically refer to local culture, religion, or mythology. The symbols may represent a specific goddess, fertility symbols, beliefs in the afterlife, or specific celebrations and rituals prevalent during that period.", "Items/Pottery vessel.jpg", "Pottery vessel" },
                    { 27, 116, new DateOnly(1795, 4, 1), "The Statue of King Ramses II is a colossal statue of Pharaoh Ramses II of the Nineteenth Dynasty of ancient Egypt. This monument dates back to the 13th century BC.", "Items/Statue of King Ramses II.jpg", "Statue of King Ramses II" },
                    { 28, 116, new DateOnly(1795, 4, 1), "The museum garden is beautifully designed and comfortable, allowing visitors to stroll around and enjoy the tranquil atmosphere and picturesque nature surrounding the museum. Visitors can also view the many artifacts and statues on display, reflecting Nubian history and culture.", "Items/Museum Garden.jpg", "Museum Garden" },
                    { 29, 117, new DateOnly(1795, 4, 1), "The architect Imhotep was an ancient Egyptian engineer during the New Kingdom (c. 1550–1069 BC). The statue of the architect Imhotep is considered one of the most famous statues representing ancient Egyptian art.", "Items/Statue of the architect Imhotep.jpg", "Statue of the architect Imhotep" },
                    { 30, 117, new DateOnly(1795, 4, 1), "brass surgical instruments", "Items/brass surgical instruments.jpg", "brass surgical instruments" },
                    { 31, 117, new DateOnly(1795, 4, 1), " One of the museum's most prominent artifacts, the faience wall features beautiful, colorful decorative designs that reflect the arts and crafts of the Pharaonic era in ancient Egypt.", "Items/A faience wall.jpg", "A faience wall" },
                    { 32, 117, new DateOnly(1795, 4, 1), "The base of a statue of King Djoser is part of a statue representing King Djoser, considered one of the most important pharaohs in ancient Egyptian history. The base is typically placed beneath the statue to stabilize and support it.", "Items/Base of a statue of King Djoser.jpg", "Base of a statue of King Djoser" },
                    { 33, 117, new DateOnly(1795, 4, 1), "The mummy of King Mery-Ra is one of the oldest royal mummies discovered to date. It was discovered in a tomb in Thebes (present-day Fayum, Egypt) and dates back to the ancient Pharaonic period during the Sixth Dynasty. It was found in relatively good condition and holds many secrets about the history and culture of this era.", "Items/Mery-Ra.jpg", "Mery-Ra" },
                    { 34, 118, new DateOnly(1795, 4, 1), "The Indian Hall (Beit al-Kritliyya)Contains a table, some Indian-style chairs, and some decorated chests.", "Items/The Indian Hall.jpg", "The Indian Hall" },
                    { 35, 118, new DateOnly(1795, 4, 1), "The celebration halls are among the most beautiful and important halls in the museum, containing wooden furniture, metal artifacts, a wooden ceiling, and wooden cabinets.", "Items/Celebration Hall.jpg", "Celebration Hall" },
                    { 36, 118, new DateOnly(1795, 4, 1), ", the Winter Hall (Beit al-Kritliya), is the women's quarters. It contains numerous decorative and inlaid wooden wardrobes, wooden furniture, metal artifacts, chandeliers, a metal incense burner, and lighting lamps.", "Items/The Harem.jpg", "The Harem" },
                    { 37, 118, new DateOnly(1795, 4, 1), " (Amina bint Salem House)The hall contains the most beautiful pieces of Chinese-style furniture, including chairs, a table, paintings, and a wooden ceiling decorated with geometric and floral motifs.", "Items/The Chinese Hall.jpg", "The Chinese Hall" },
                    { 38, 118, new DateOnly(1795, 4, 1), " (Amina bint Salem House)  The library contains books, a number of paintings, a display case containing a number of antiques, a table, and chairs.", "Items/Library Hall.jpg", "Library Hall" },
                    { 39, 119, new DateOnly(1795, 4, 1), "A model of a wooden box decorated with colored ribbons and frames, decorated with Pharaonic symbols and hieroglyphic inscriptions, including a cartouche bearing the name of King Amenhotep III.    Material: WoodDate: 20th century. King Farouk's belongings.", "Items/model.jpg", "A model of a wooden box decorated with colored ribbons and frames." },
                    { 40, 119, new DateOnly(1795, 4, 1), " This silver cigarette case features an ancient Egyptian temple, decorated with symbols inspired by ancient Egyptian art. The top of the case features a royal crown and the Egyptian flag in green, with a crescent moon and three stars. \"The Egyptian flag during the reign of King Farouk.\"    Material: Silver  Date: 20th century. \"King Farouk's belongings.\"", "Items/ancient.jpg", "Asilver cigarette case in the shape of an ancient Egyptian temple" },
                    { 41, 119, new DateOnly(1795, 4, 1), "Statue of the Egyptian peasant woman by the French sculptor Charles Cordier", "Items/Statue.jpg", "Statue of the Egyptian peasant woman by the French sculptor Charles Cordier" },
                    { 42, 119, new DateOnly(1795, 4, 1), "A wooden chair decorated with scenes from ancient Egyptian art, depicting the gods Bes and Taweret, with a musical scene. On the back of the chair is a verse from a poem by the poet Ahmed Shawqi praising Khedive Abbas Hilmi (O you who wears the two crowns, live in peace... May God protect you from His veils).    Material: Wood", "Items/wooden.jpg", "A wooden chair decorated with scenes from ancient Egyptian art." },
                    { 43, 120, new DateOnly(1795, 4, 1), "Head of a statue of King Ramesses II, holding to his left a ceremonial standard in the temple, of which only two feathers remain at the top. The king wears a composite crown consisting of a wreath of cobras, topped with two ram's horns, a sun disk, and two tall feathers flanked by two large cobras. Behind them, a falcon spreads its wings for protection.    New Kingdom, 19th Dynasty, Ramesses II, circa 1279–1212 BC  Material: Pink granite", "Items/Ramesses.jpg", "Ramesses II holding a standard" },
                    { 44, 120, new DateOnly(1795, 4, 1), "This statue, which has survived in excellent condition, depicts the couple seated in elegant attire, each crowned with a wig, the artist masterfully depicting its intricate details. Naya affectionately rests her right hand on her husband's shoulder. The back of the seat is inscribed with a relief depicting the couple seated at an offering table facing the lady, Tiner.    New Kingdom, Eighteenth Dynasty [1550-1295 BC]  Provenance: Giza, Memphis, Saqqara  Material: Limestone", "Items/couple.jpg", "The couple, Thai and Naya" },
                    { 45, 120, new DateOnly(1795, 4, 1), "Head of one of the Osirian statues (mummy-like) of Queen Hatshepsut, standing before the columns of the upper floor of her mortuary temple. Remains of the Red Crown of Lower Egypt are visible on her head. Although the head bears a false beard, as is typical of depictions of the king, the large eyes, adorned with a long line of kohl, the flowing eyebrows, and the full cheeks bear distinctly feminine features.    New Kingdom, Eighteenth Dynasty, Thutmose I [c. 1498–1483 BC]  Luxor, Deir el-Bahari, Mortuary Temple of Hatshepsut  Limestone, colored", "Items/Head of Hatshepsut.jpg", "Head of Hatshepsut" },
                    { 46, 120, new DateOnly(1795, 4, 1), "The statue is considered one of the most magnificent representations of women in ancient Egypt. She wears a sheer, pleated gown of fine linen and a thick wig adorned with a band of lotus flowers. In her left hand, she holds the mannat necklace of the goddess Hathor. The back of the statue is inscribed in hieroglyphs with the titles of her husband, the leader Nakhtmin. It was originally part of a statue of the couple together.    New Kingdom, Eighteenth Dynasty [1550-1295 BC]  Source: Luxor, Sheikh Abd al-Qurna  Material: Limestone", "Items/Nakhtmin's Wife.jpg", "Nakhtmin's Wife" },
                    { 47, 120, new DateOnly(1795, 4, 1), "The four sides of this column's capital are decorated with the face of the goddess Hathor, a woman's face, and the ears of a cow, topped with a model of a shrine facade. The entire composition resembles a sistrum, a percussion instrument. The column is inscribed with the name of King Apries, described as the lover of the goddess Neith, from Sais, the capital of the Twenty-sixth Dynasty in the western Delta.    Late Period, Twenty-sixth Dynasty, Apries (589-570 BC)", "Items/Hathor-headed.jpg", "Hathor-headed column" },
                    { 48, 121, new DateOnly(1795, 4, 1), "The ancient Egyptians placed great importance on the afterlife. The Nile and the agricultural cycle played a strong role in their beliefs about resurrection. They called the underworld the Duat. The deceased who crossed it was reborn and placed in the solar boat of Ra to be released into the day. The deceased was like Osiris, resurrected from death. Preparations for the afterlife began with mummification, the preservation of the body until it could be revived.", "Items/The Afterlife.jpg", "The Afterlife" },
                    { 49, 121, new DateOnly(1795, 4, 1), "Primarily targeted the god Amun, whose main cult center was in Thebes (present-day Luxor). During his reign, Aten became the only deity worshipped. These changes coincided with the king changing his name to Akhenaten, followed by the establishment of a new capital in Middle Egypt (in present-day Minya Governorate) called Akhetaten (Horizon of Aten).", "Items/Tell el-Amarna.jpg", "Tell el-Amarna" },
                    { 50, 121, new DateOnly(1795, 4, 1), "Alexandria was the greatest city of the ancient world during the reign of the early Ptolemies. It remained the capital of Egypt for nearly a thousand years, from its founding by Alexander the Great in 331 BC until the Arab conquest in 641 AD. The city was completed during the reign of Ptolemy II (285–246 BC). The Greek architect Dinocrates, from the island of Rhodes, planned the city, linking the mainland (a narrow strip between the Mediterranean Sea and Lake Mariout) and the island of Pharos, which lies opposite it, by a bridge called the Heptastadion. This resulted in the eastern and western harbors.", "Items/Alexandria.jpg", "Alexandria" },
                    { 51, 121, new DateOnly(1795, 4, 1), "Throne of the god Amun. Luxor has gained international fame for its vast cultural heritage. It is a kind of museum city, housing a large portion of the most important archaeological sites in Egypt and the world. Throughout its history, Luxor has been known by many names: It was called \"Est\" (East), and the Greeks called it \"Thebes\" (Thebes), after their city in the heart of Greece. However, they distinguished it from their city by the nickname \"The City of a Hundred Gates,\" and the name was Arabized to \"Thebes.\"", "Items/Thebes.jpg", "Thebes" },
                    { 52, 121, new DateOnly(1795, 4, 1), "The Paris of the East. Egypt (and particularly Cairo) witnessed a new era after a long period of darkness when Muhammad Ali Pasha, the founder of modern Egypt, assumed power in 1805 and began his grand project to develop the country. His efforts laid the foundation for Cairo's urban expansion during the reign of his grandson, Khedive Ismail (1863-1879). His visit to the 1867 World's Fair in Paris marked the most influential transformation in the city's history.", "Items/Khedivial Cairo.jpg", "Khedivial Cairo" },
                    { 53, 122, new DateOnly(1795, 4, 1), "This model illustrates a very common type of horned altar with Greek-style architectural elements: Doric columns and capitals with a pointed cornice. The frieze is decorated with two sphinxes at the corners of the altar, with a view of Harpocrates standing between them. This Greek-style altar reflects the monumental buildings of important religious centers, such as the one built by Alexander the Great in Alexandria.    Date: 2nd century AD  Material: Limestone  Source: Kafr El-Sheikh Governorate", "Items/Votive Altar.jpg", "Votive Altar" },
                    { 54, 122, new DateOnly(1795, 4, 1), "A man dressed in a Greek chiton and himation, sitting on a high-backed chair, indicating a person of high status. The man is depicted sitting in front of a cubicle, moving something in a round dish with a small tool. The shape of the rolled papyrus in his left hand indicates that he was an educated person.    Date: Roman period, late 2nd century AD  Material: Limestone  Source: Kom Abubello/Triothis-Tarana", "Items/painting.jpg", "A painting of a physician or pharmacist" },
                    { 55, 122, new DateOnly(1795, 4, 1), "This unique piece, woven on a red background, depicts the Holy Family's journey to Egypt. In the center, within a square frame, the Virgin Mary—with a halo surrounding her head—rides a donkey carrying the Christ Child. Behind her is a building. Beside the Virgin are two figures, one likely Saint Joseph and the other Salome, the Virgin's cousin, and her maids of honor.  Date: 8th-9th century  Material: Wool and linen  Provenance: Egypt", "Items/Coptic.jpg", "Coptic textile depicting the Holy Family's journey" },
                    { 56, 122, new DateOnly(1795, 4, 1), "The linen bandages were wrapped in an elaborate pattern. This style emerged during the Roman period, the peak of the art of mummy bandaging. The mummy's head was covered with a gilded funerary mask made of cartonnage (a mixture of linen, resin, and plaster). The forehead is decorated with a winged sun disk, a symbol of resurrection. The eyes and eyebrows are inlaid.    Roman period, 1st or 2nd century AD.  Material: Linen, cartonnage, colored, gilded.  Source: Faj al-Jamous, Fayyum.", "Items/Male Mummy.jpg", "Male Mummy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);
        }
    }
}
