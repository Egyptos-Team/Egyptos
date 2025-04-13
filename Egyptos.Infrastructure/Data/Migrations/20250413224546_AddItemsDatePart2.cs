using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddItemsDatePart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AreaId", "Date", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 57, 101, new DateOnly(1795, 4, 1), "Combs were used in Egypt around five thousand years ago, having been found buried with both men and women. This custom continued into the Byzantine period, when combs were found on the chests of the deceased. Wood was the most commonly used material for combs, while some ivory models were found among the wealthy, some of which had religious uses. 6th century AD. Material: Ivory.", "Items/ivorycomb", "ivory comb" },
                    { 58, 101, new DateOnly(1795, 4, 1), "Three massive keys to monasteries in Sohag, two of which are decorated with the capital of a Corinthian column, while the third is decorated with a cross.Material: Iron, bronze, copperSource: SohagDate: 12th–13th centuries", "Items/Three huge keys to the monasteries.jpg", "Three huge keys to the monasteries" },
                    { 59, 101, new DateOnly(1795, 4, 1), "A rectangular lintel with a relief carving depicting the entry of Jesus Christ into Jerusalem riding on a beast and being welcomed by the city's inhabitants as king. The anniversary of Christ's entry into Jerusalem is celebrated annually on the seventh Sunday of Lent and is known as Palm Sunday. Date: 4th or 5th century AD Material: Wood Source: The Hanging Church, Ancient Egypt", "Items/", "A reproach illustrating the scene of Jesus Christ's entry into the city of Jerusalem" },
                    { 60, 101, new DateOnly(1795, 4, 1), "An icon depicting the Holy Family's flight from Palestine to Egypt, depicting the Virgin Mary on a white horse and Jesus Christ sitting on Saint Joseph's right shoulder Date: 18th century AD Material: Wood", "Items/Icon of the Holy Family's Flight to Egypt.jpg", "Icon of the Holy Family's Flight to Egypt" },
                    { 61, 101, new DateOnly(1795, 4, 1), "A pillar known as the pulpit of Anba JeremiahDate: 6th century AD Material: StoneProvenance: Monastery of Anba Jeremiah in Saqqara,Egypt", "Items/Pulpit of Anba Ermia.jpg", "Pulpit of Anba Ermia" },
                    { 62, 102, new DateOnly(1795, 4, 1), "The coffin of Najm Ankh made of cartonnage covered with gold foil, retrieved from the Metropolitan Museum and dates back to the Ptolemaic period.Material: Cartonnage covered with gold foil.Date: Ptolemaic period.", "Items/Coffin of Najm Ankh.jpg", "Coffin of Najm Ankh" },
                    { 63, 102, new DateOnly(1795, 4, 1), "Coffin of King Ramses II Material: Wood Place of discovery: Deir el - Bahari cache in Thebes,1881", "Items/Coffin of King Ramses II.jpg", "Coffin of King Ramses II" },
                    { 64, 102, new DateOnly(1795, 4, 1), "Coffin of Sennedjem from his tomb in Deir el-MedinaDate: 19th Dynasty of the New Kingdom", "Items/Coffin of Sennedjem.jpg", "Coffin of Sennedjem" },
                    { 65, 102, new DateOnly(1795, 4, 1), "Granite statue of King Thutmose III Material: GranitePlace of discovery: Karnak", "Items/King Thutmose III.jpg", "King Thutmose III" },
                    { 66, 102, new DateOnly(1795, 4, 1), "Belt of Prince Ptah-Shepses made of gold, carnelian, and volcanic glass. Date: Old Kingdom 6th Dynasty,around 2323–2150 B.C.Material: GoldPlace of discovery: Saqqara", "Items/Belt of Prince Ptah-Shepses.jpg", "Belt of Prince Ptah-Shepses" },
                    { 67, 103, new DateOnly(1795, 4, 1), "This colossal statue represents King Amenhotep III and Queen Tiye. It is considered a group statue of King Amenhotep III, his royal wife Tiye, and their three daughters. It is the largest group statue ever carved.Dynasty: 18th Dynasty – New KingdomMaterial: LimestonePlace of discovery: Luxor", "Items/Statue of Amenhotep III.jpg", "Statue of Amenhotep III" },
                    { 68, 103, new DateOnly(1795, 4, 1), "Coffin of Queen Kawit, wife of King Mentuhotep II (Nebhepetre), founder of the Middle Kingdom. The outer surface of the coffin is decorated with scenes from daily life. One side shows the queen drinking in front of a table full of food while a servant adjusts her wig, and another servant pours her next drink.Date: Middle Kingdom,11th Dynasty,reign of Mentuhotep II,around 2055–2004 B.C.Material: LimestonePlace of discovery: Deir el - Bahari", "Items/Coffin of Kawit.jpg", "Coffin of Kawit" },
                    { 69, 103, new DateOnly(1795, 4, 1), "A group statue of King Menkaure made of schist. The statue shows the king standing between two women: the goddess Hathor on his right and the lady of the Bat province on his left. The king wears the white crown of Upper Egypt. Hathor wears the sun disk and cow horns, while the lady of Bat province wears the emblem of her region on her head.Source: GizaValley Temple of MenkaureDate: Old Kingdom 4th Dynasty,reign of King Menkaure(2490–2472 B.C.)Material: Grey - green schist stone", "Items/Group Statue of Menkaure.jpg", "Group Statue of King Menkaure" },
                    { 70, 103, new DateOnly(1795, 4, 1), "The mummies of Yuya and Thuya were discovered wearing cartonnage masks covered in gold leaf. Yuya was the father of Queen Tiye, wife of King Amenhotep III, and husband of Thuya. He came from the town of Akhmim, where he was believed to be a prominent landowner and priest of the god Min. Thuya held important religious titles and was also titled 'Royal Mother of the Great Royal Wife. Date: New Kingdom 18th Dynasty, reign of Amenhotep III(1390–1352 B.C.) Material: Cartonnage,gold Place of discovery: Luxor, Valley of the Kings, Tomb of Yuya and Thuya(KV46)", "Items/Masks of Yuya and Thuya.jpg", "Masks of Yuya and Thuya" },
                    { 71, 103, new DateOnly(1795, 4, 1), "This statue depicts King Khafre, builder of the second-largest pyramid in Giza. It was found in the Valley Temple of his pyramid complex. The king is shown seated on a throne, with the two sides of the throne decorated with the symbol of 'Sema-Tawy,' representing the unity of Upper and Lower Egypt. Behind the king's head, the falcon god Horus stands with wings spread, symbolizing protection.Date: Old Kingdom, 4th Dynasty, reign of Khafre(c. 2555–2532 B.C.)Material: DioritePlace of discovery: Giza", "Items/Statue of Khafre.jpg", "Statue of Khafre" },
                    { 72, 103, new DateOnly(1795, 4, 1), "This small statue depicts King Khufu, builder of the Great Pyramid at Giza. It stands only 7.5 cm tall and is the only confirmed statue of this king. When it was first discovered, the head was missing. Sir Flinders Petrie noticed the break was recent and, realizing the importance of the find, ordered a search for the missing head, which was found three weeks later.Date: Old Kingdom 4th Dynasty, reign of Khufu(c. 2589–2566 B.C.) Material: Ivory Place of discovery: Abydos", "Items/Statue of Khufu.jpg", "Statue of Khufu" },
                    { 73, 104, new DateOnly(1795, 4, 1), "In the ancient Greek era, plaster pieces depicting agricultural scenes were especially popular. These pieces reflected the importance of agriculture in Greek society and depicted farmers, animals, and agricultural crops.", "Items/Plaster Piece Depicting Agricultural Scene.jpg", "Plaster Piece Depicting Agricultural Scene" },
                    { 74, 104, new DateOnly(1795, 4, 1), "Serapis is an ancient Egyptian god considered the deity of fertility, agricultural life, and protector of the dead. Serapis is usually depicted with a human body and the head of a toufa or lion, carrying a staff or rod and a basket of grain on his head. He was beloved and well-known in ancient Egyptian culture and had a significant influence on various arts and statues.", "Items/Statue of the God Serapis.jpg", "Statue of the God Serapis" },
                    { 75, 104, new DateOnly(1795, 4, 1), "The statue of the god Hermanubis depicts an ancient Egyptian deity considered a fusion between the Greek god Hermes and the Egyptian god Anubis. Hermanubis was believed to be a local deity in the city of Hermopolis in ancient Egypt.", "Items/Statue of the God Hermanubis.jpg", "Statue of the God Hermanubis" },
                    { 76, 104, new DateOnly(1795, 4, 1), "The statue of the god Mars is one of the ancient Roman statues that depicts the Roman god of war, Mars. He is considered one of the principal gods in the ancient Roman religion. Mars is known as the god of military strength, war, and bravery.", "Items/Statue of the God Mars.jpg", "Statue of the God Mars" },
                    { 77, 104, new DateOnly(1795, 4, 1), "The Apis bull is a statue from ancient Egyptian civilization representing the god Apis, the deity of agriculture and natural wealth in ancient Egyptian religion. The Apis bull is considered a symbol of creative power and fertility.", "Items/Statue of the Apis Bull.jpg", "Statue of the Apis Bull" },
                    { 78, 104, new DateOnly(1795, 4, 1), "This statue depicts the Roman Emperor Diocletian, who ruled from 284 to 305 AD. Diocletian was a famous and powerful emperor who implemented many reforms and changes during his reign.", "Items/Statue of Emperor Diocletian.jpg", "Statue of Emperor Diocletian" },
                    { 79, 105, new DateOnly(1795, 4, 1), "A collection of gold pocket watches in various shapes. Some feature portraits, names, or different decorative motifs.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt", "Items/PocketWatchCollection.jpg", "Pocket Watch Collection" },
                    { 80, 105, new DateOnly(1795, 4, 1), "A nine-piece desk set inside a wooden box, consisting of:\n- Three gold inkwells\n- One gold sponge vessel\n- One double pen case\n- One steel scissors\n- An ivory ruler pen\n- One paper knife (letter opener)\n- One sand container\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Various materials\nDiscovery Location: Egypt", "Items/DeskSet.jpg", "Desk Set (9 Pieces in Wooden Box)" },
                    { 81, 105, new DateOnly(1795, 4, 1), "A necklace belonging to Muhammad Ali Pasha, composed of 16 decorative units:\n- 8 units inscribed with the name 'Muhammad Ali'\n- 8 units shaped like gold roses with a central ring set with diamonds\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt", "Items/MuhammadAliNecklace.jpg", "Necklace of Muhammad Ali Pasha" },
                    { 82, 105, new DateOnly(1795, 4, 1), "A gold set consisting of a brush, drinking cups, and a sword decorated with floral motifs and the letter 'M'.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt", "Items/PrincessMalakSet.jpg", "Gold Set of Princess Malak Tousson" },
                    { 83, 105, new DateOnly(1795, 4, 1), "A set made of platinum and diamonds, including a crown and earrings.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Platinum and diamonds\nDiscovery Location: Egypt", "Items/PrincessShwikarSet.jpg", "Princess Shwikar's Set" },
                    { 84, 105, new DateOnly(1795, 4, 1), "A set made of platinum and 18-karat gold. The crown consists of five graduated flowers, with the largest in the center.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Platinum and gold\nDiscovery Location: Egypt", "Items/QueenFaridaSet.jpg", "Queen Farida's Set" },
                    { 85, 107, new DateOnly(1795, 4, 1), "The Throne Palace consists of two floors. The ground floor contains a rectangular hall with the throne chair, covered by a ceiling featuring a sun disk at its center with golden rays emanating from it. The hall is adorned with a painting depicting Muhammad Ali Pasha (1769-1849 AD). On both sides of the hall, there is gilded furniture upholstered with red velvet.", "Items/ThronePalace.jpg", "Throne Palace" },
                    { 86, 107, new DateOnly(1795, 4, 1), "The mosque is distinguished externally by its diverse decorative elements and exquisite Arabic calligraphic inscriptions executed in Islamic style. The mosque has an entrance with a pointed arch adorned with relief decorations. On either side of the entrance are two panels containing inscriptions - the right panel includes the foundation text of the mosque, while the other lists the names of workers and artists who participated in building the mosque, along with its founding date in 1235 AH (1819 AD).", "Items/MosqueClockTower.jpg", "Mosque and Clock Tower" },
                    { 87, 107, new DateOnly(1795, 4, 1), "The Reception Palace consists of two floors. The ground floor contains two reception halls separated by a door. The first was designated for receiving official guests, senior state officials, and others coming to congratulate Prince Muhammad Ali Tawfiq during official celebrations. The second hall was designated for receiving senior worshippers coming to perform Friday prayers at the mosque within the palace.", "Items/ReceptionPalace.jpg", "Reception Palace (Salamlik)" },
                    { 88, 107, new DateOnly(1795, 4, 1), "The Residence Palace is one of the oldest buildings in the palace, with construction beginning in 1228 AH/1813 AD. The palace consists of a basement topped by two floors plus a tower. The basement contains several rooms. The ground floor includes the Fountain Hall or Reception Hall, which is surrounded by several side rooms and halls: the Fireplace Room, Dining Hall, Mother-of-Pearl Hall (named because all its furnishings are inlaid with mother-of-pearl), and the Shukma Hall (a Turkish term meaning the protruding part of the building) - a ladies' room designated for them during evening parties, covered with ceramic tiles and containing a fireplace.", "Items/ResidencePalace.jpg", "Residence Palace" },
                    { 89, 107, new DateOnly(1795, 4, 1), "The hall contains chairs, an oval table, mashrabiya (traditional wooden lattice), some cabinets holding various glass artifacts, porcelain plates, a hanging carpet, and some calligraphic inscriptions.", "Items/HaremQuarters.jpg", "Harem Quarters" },
                    { 90, 107, new DateOnly(1795, 4, 1), "The Celebration Hall is one of the most beautiful and important halls in the museum, containing wooden furniture, metal artifacts, wooden ceilings, and wooden cabinets.", "Items/CelebrationHall.jpg", "Celebration Hall" },
                    { 91, 108, new DateOnly(1795, 4, 1), "The 'Djed' pillar symbolizes stability and continuity. In the Old Kingdom, it may have represented the pillars that held up the heavens, and later it sometimes referred to the backbone of the god Osiris.", "Items/DjedPillar.jpg", "Djed Pillar" },
                    { 92, 108, new DateOnly(1795, 4, 1), "Nephthys, considered one of the most important protective goddesses for the deceased.", "Items/NephthysStatue.jpg", "Statue of Goddess Nephthys" },
                    { 93, 108, new DateOnly(1795, 4, 1), "Osiris was considered the lord of the afterlife. Since prehistoric times, the ancient Egyptians associated him with the annual Nile flood, making him also the god of agriculture, fertility, and resurrection.", "Items/OsirisStatue.jpg", "Statue of Osiris" },
                    { 94, 108, new DateOnly(1795, 4, 1), "A mummified ram wrapped in linen cloth with a gilded cartonnage mask covering its face. The ram was a symbol of the god Khnum, who was believed to shape every child born on his potter's wheel. His main cult center was on Elephantine Island.", "Items/RamMummy.jpg", "Ram Mummy" },
                    { 95, 108, new DateOnly(1795, 4, 1), "A statue and mummy of a cat. In ancient Egypt, cats symbolized the goddess Bastet, whose popularity increased during the Late Period, particularly in Bubastis (modern Zagazig). The statue is made of sycamore wood - from Qurna.", "Items/CatMummy.jpg", "Cat Statue and Mummy" },
                    { 96, 108, new DateOnly(1795, 4, 1), "A set of four jars belonging to Wahibre-em-akhet, son of Psamtik. These jars were used to preserve the deceased's embalmed internal organs. Their lids represent the four sons of Horus. They are called Canopic jars after the city of Canopus in Abu Qir, Alexandria.", "Items/CanopicJars.jpg", "Canopic Jars" },
                    { 97, 109, new DateOnly(1795, 4, 1), "Ancient Egyptian culture was deeply connected to the Nile River, particularly its annual flood and fertility. This connection manifested in their religion through the worship of the Nile crocodile as the god Sobek. Originally a local deity, Sobek became culturally significant due to his Nile associations, revered as a symbol of fertility, power, and protection. His popularity peaked during the Middle Kingdom, influencing kings and politics, marking a turning point in his role within Egyptian religion.", "Items/CrocodileHeadedStatue.jpg", "Crocodile-Headed Statue" },
                    { 98, 109, new DateOnly(1795, 4, 1), "Crocodiles were common along the Nile in ancient Egypt. Egyptians depicted the god Sobek as a crocodile or human with crocodile head, worshiping him for protection, human fertility, and crop productivity.", "Items/CrocodilesAncientEgypt.jpg", "Crocodiles in Ancient Egypt" },
                    { 99, 109, new DateOnly(1795, 4, 1), "Ancient Egyptians revered crocodiles as Sobek, depicted as crocodile-headed human or full crocodile. His main cult center was in Faiyum, later spreading to Kom Ombo and Thebes. Originally symbolizing water and fertility, Sobek became associated with the dead's protection in the afterlife. He merged with Ra as 'Sobek-Ra', becoming a royal protector. Worship continued through Ptolemaic and Roman periods, especially in Faiyum and Kom Ombo where many mummified crocodiles were found.", "Items/GodSobek.jpg", "God Sobek" },
                    { 100, 109, new DateOnly(1795, 4, 1), "A model replicating an original tomb containing crocodile burials, demonstrating Sobek's burial practices. Includes replica coffins and pottery vessels used in these rituals.", "Items/TombModel.jpg", "Tomb Model" },
                    { 101, 109, new DateOnly(1795, 4, 1), "The Nile crocodile symbolized both good and evil - revered yet hunted. As Earth's largest living reptiles, Egyptians deified them, creating sacred statues and pottery with crocodile-headed lids, acknowledging their power and danger to Nile fishermen.", "Items/NileCrocodile.jpg", "Nile Crocodile" },
                    { 102, 109, new DateOnly(1795, 4, 1), "A scene from the tomb of Ramses VI in the Valley of the Kings, representing the concept of resurrection after death. The crocodile in ancient Egypt was considered the lord of eternal waters in the afterlife, protecting Osiris and resurrecting him from death in the form of the White Crown. The head of Osiris emerging from the crocodile's back symbolizes rebirth. The crocodile, as an aquatic creature, serves as a protective vessel for the deceased in the afterlife, guarding against dangers. The emerging head of Osiris represents resurrection and rebirth, while the White Crown symbolizes Osiris as the god of resurrection and renewal.", "Items/SymbolismScene.jpg", "Symbolism Scene from Ancient Egypt" },
                    { 103, 110, new DateOnly(1795, 4, 1), "This magnificent statue is one of the unique pieces of ancient Egyptian art, representing Queen Meritamen, daughter of Ramses II and the great royal wife. Although her name is missing here, the titles and phrases match those on the princess's statue (who became the great wife after her mother's death) found in Akhmim.\n\n19th Dynasty, Reign of Ramses II\nMaterial: Painted limestone", "Items/MeritamenStatue.jpg", "Statue of Meritamen" },
                    { 104, 110, new DateOnly(1795, 4, 1), "For ancient Egyptians, both deities and the deceased had the same needs as the living, requiring constant provision of food and drink. The early embodiment of this concept appeared in the form of offering tables - stone slabs where various food items and drinks could be placed for consumption by the deceased or deity.\n\nNew Kingdom, 18th Dynasty, Thutmose III (c. 1497-1425 BC)\nMaterial: Granite", "Items/OfferingTable.jpg", "Offering Table" },
                    { 105, 110, new DateOnly(1795, 4, 1), "During mummification, specific organs (liver, lungs, intestines, and stomach) were removed from the deceased, wrapped separately, and placed in four jars known as canopic jars.", "Items/IstemkhebJars.jpg", "Canopic Jars of Istemkheb" },
                    { 106, 110, new DateOnly(1795, 4, 1), "Bread was a staple food in ancient Egypt, as it remains today. The deceased - just like the living - needed constant food supplies to survive in the afterlife, hence many servant statues found in tombs show them engaged in various bread-making stages, like this statue.\n\nOld Kingdom (c. 2686-2125 BC)\nMaterial: Painted limestone\nDiscovery Location: Egypt", "Items/FlourGrinder.jpg", "Statue of a Servant Grinding Flour" },
                    { 107, 110, new DateOnly(1795, 4, 1), "The 'Tourism Icon' statue in Hurghada Museum is a miniature replica of the original statue located in the Red Sea.", "Items/TourismIcon.jpg", "Red Sea Tourism Icon" },
                    { 108, 110, new DateOnly(1795, 4, 1), "This statue dates back to the Pharaonic era, depicting Pharaoh Tutankhamun seated on his throne with his name and title inscribed on the base. Considered an important artifact reflecting the sculptural art of the 18th Dynasty.", "Items/TutankhamunStatue.jpg", "Tutankhamun Statue" },
                    { 109, 111, new DateOnly(1795, 4, 1), "Hathor is considered the oldest goddess in Egyptian mythology, symbolizing love, generosity, and motherhood.\n\nMaterial: Black granite", "Items/HathorHead.jpg", "Statue Head of Goddess Hathor" },
                    { 110, 111, new DateOnly(1795, 4, 1), "Queen Hatshepsut was the greatest woman of her time, whose reign was marked by prosperity, power, and strengthened diplomatic relations through expeditions to Punt.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Limestone", "Items/HatshepsutSlab.jpg", "Fragment of Stone Slab with Queen Hatshepsut's Name" },
                    { 111, 111, new DateOnly(1795, 4, 1), "A rectangular piece depicting Queen Shepenupet with the curved beard, holding the ankh symbol in one hand and the royal scepter in the other.\n\nPeriod: Third Intermediate Period\n22nd Dynasty\nMaterial: Sandstone", "Items/ShepenupetPiece.jpg", "Rectangular Piece of Queen Shepenupet" },
                    { 112, 111, new DateOnly(1795, 4, 1), "The upper part of King Nectanebo II's sarcophagus depicts the king offering wine to god Anhur. The king wears a short wig with uraeus and a four-feathered crown, holding an ankh in his right hand and was scepter in his left. Goddess Bastet holds an ankh while god Shu wears similar headdress and holds same symbols. A winged vulture appears at the top.\n\nPeriod: Late Period, 30th Dynasty, Nectanebo II\nMaterial: Green diorite", "Items/NectaneboSarcophagus.jpg", "Upper Part of King Nectanebo II's Sarcophagus" },
                    { 113, 111, new DateOnly(1795, 4, 1), "An icon showing Saint Simon seated on a throne decorated with two winged angels above. His head is surrounded by a halo of connected beads, holding a paper scroll in his hands, wearing folded garments. Two birds flank the throne's base, one wearing a crown.\n\nMaterial: Wood\nPeriod: 18th century AD", "Items/SaintSimonIcon.jpg", "Icon of Saint Simon on Throne" },
                    { 114, 111, new DateOnly(1795, 4, 1), "A mechanical gunpowder measure decorated with plant motifs in silver and gold. The wooden handle features silver-inlaid plant designs and ends with a copper ornament bearing raised decorations.\n\nPeriod: Modern (Muhammad Ali Dynasty)\nMaterial: Metal", "Items/GunpowderMeasure.jpg", "Mechanical Gunpowder Measure" },
                    { 121, 106, new DateOnly(1795, 4, 1), "The massive courtyard built by Ramses II, featuring 74 columns in double rows and numerous statues of the pharaoh. The walls are decorated with scenes of Ramses' military campaigns and religious ceremonies.\n\nPeriod: New Kingdom, 19th Dynasty\nMaterial: Sandstone", "Items/RamsesCourt.jpg", "Great Court of Ramses II" },
                    { 122, 106, new DateOnly(1795, 4, 1), "Towering seated statues of Ramses II that once flanked the temple entrance. The remaining colossus stands 15 meters tall and shows the pharaoh wearing the double crown of Upper and Lower Egypt.\n\nPeriod: New Kingdom, 19th Dynasty\nMaterial: Granite", "Items/RamsesColossi.jpg", "Colossi of Ramses II" },
                    { 123, 106, new DateOnly(1795, 4, 1), "The sacred chamber depicting the divine birth of Amenhotep III, with reliefs showing the god Amun impregnating the queen and the birth sequence supervised by various deities.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Sandstone", "Items/BirthChamber.jpg", "Birth Chamber of Amenhotep III" },
                    { 124, 106, new DateOnly(1795, 4, 1), "The magnificent 100-meter long colonnade with 14 papyrus-cluster columns, originally built to connect Luxor Temple with Karnak during the Opet Festival.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Sandstone", "Items/ProcessionalColonnade.jpg", "Processional Colonnade of Amenhotep III" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124);
        }
    }
}
