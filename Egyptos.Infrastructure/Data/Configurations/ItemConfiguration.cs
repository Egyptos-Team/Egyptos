using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Egyptos.Infrastructure.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        var items = new List<Item>
        {
            new Item
            {
                Id=1,
                Title="deceptive weapons",
                Description="A cane concealing a rifle, with a handle coiled in the shape of a snake's head.Date: Ottoman period.Material: Wood and ivory.",
                ImageUrl="Items/deceptive weapons.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
            new Item
            {
                Id=2,
                Title="Oil bottle",
                Description="Pear-shaped, decorated with raised fish-scale motifs, with a short neck ending in a narrow spout for pouring oil. It resembles a modern-day hand grenade.Date: Fatimid period.nMaterial: Pottery.",
                ImageUrl="Items/Oil bottle.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
            new Item
            {
                Id=3,
                Title="Ramadan Cannon",
                Description="A Krupp cannon, commonly known as the Ramadan Cannon. It consists of an iron barrel resting on an iron base with two large wooden wheels and iron frames.Date: Muhammad Ali Dynasty - 1871 AD.Material: Iron and wood.",
                ImageUrl="Items/Ramadan Cannon.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
             new Item
            {
                Id=4,
                Title="Boat",
                Description="Model of a boat: Shown to be carrying ten sailors.Date: Ancient Egyptian.Material: Wood.",
                ImageUrl="Items/Boat.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
             new Item
            {
                Id=5,
                Title="The First Fire Engine",
                Description="The world's first hand-operated fire engine: an English-made engine. It was very primitive; it consisted of a rectangular box mounted on four wheels and was transported to the fire site by horse.Date: Ottoman era - 1766 AD.Material: Wood.",
                ImageUrl="Items/The First Fire Engine.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
             new Item
            {
                Id=6,
                Title="Defensive Weapons",
                Description="Oval-shaped shield with a handle in the middle.Date: Ottoman period.Material: Wood, leather, and tortoiseshell.",
                ImageUrl="Items/Defensive Weapons.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=112
            },
             new Item
            {
                Id=7,
                Title="Incense burner",
                Description="Inlaid copper incense burner with gold and silver.Mamluk period, 8th century AH / 14th century AD Material: Copper, gold, silver Provenance: Egypt",
                ImageUrl="Items/Incense burner.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=113
            },
             new Item
            {
                Id=8,
                Title="Surgical scalpel",
                Description="The item is a long-handled surgical scalpel with a sharp blade whose tip is thinner and wider than its handle.Date: 3rd century AH / 9th century AD Material: Cast copper. Provenance: Cairo, Egypt",
                ImageUrl="Items/Surgical scalpel.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=113
            },
             new Item
            {
                Id=9,
                Title="Copper jug ​​and basin",
                Description="Copper jug ​​and basin decorated with enamel. Date: Qajar period - 13th century AH / 19th century AD Material: Copper Provenance: Iran",
                ImageUrl="Items/Copper jug ​​and basin.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=113
            },
             new Item
            {
                Id=10,
                Title="Kohl stick",
                Description="Ivory kohl stick inlaid with mother-of-pearl. Era: Mamluk or Ottoman Date: 9th-10th century AH / 15th-16th century AD Provenance: Egypt",
                ImageUrl="Items/Kohl stick.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=113
            },
             new Item
            {
                Id=11,
                Title="Wooden Qibla Guide",
                Description="Lacquered wooden Qibla guide.Türkiye - Ottoman era.12th century AH / 18th century AD.",
                ImageUrl="Items/Wooden Qibla Guide.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=113
            },
             new Item
            {
                Id=12,
                Title="Upper part of a royal statue",
                Description="This part of the statue may represent King Thutmose III, one of the greatest kings and rulers of ancient Egypt.New Kingdom, Eighteenth Dynasty, c. 1550–1295 BCMaterial: Red granite",
                ImageUrl="Items/Upper part of a royal statue.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=13,
                Title="Funerary Stele",
                Description="Funeral stele with an inscription of Sheddetef and his wife Bret. The text on the stele refers to the formula for offerings to Osiris.First Intermediate Period, c. 2181–2055 BC Nag el-Deir Colored limestone",
                ImageUrl="Items/Funerary Stele.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=14,
                Title="Bust of a Young Man",
                Description="A bust of a young man representing a scholar, his body wrapped in a Greek cloak in the form of a suspended arm, characteristic of educated and cultured Greeks.Roman period, c. 200-210 AD Material: Marble Provenance: Abusir, near Samanud",
                ImageUrl="Items/Bust of a Young Man.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=15,
                Title="Jug and basin",
                Description="A jug and basin, each decorated with naturalistic motifs including architectural forms, some of which depict Ottoman-style mosques. It is worth noting that jugs of this type, carried on basins, were used for ablution or pouring water for washing hands. Date: 13th century AH/19th century AD Provenance: Türkiye Ceramic, silver",
                ImageUrl="Items/Jug and basin.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=16,
                Title="Pocket Watch",
                Description="Pocket watch with a cover on the front featuring a picture of Muhammad Ali 13th-14th century AH / 19th-20th century AD Gold, colored dial",
                ImageUrl="Items/Pocket Watch.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=17,
                Title="Mushaf",
                Description="A Mushaf written in Naskh script, presented to Khedive Tawfiq in 1300 AH (1883 AD).Material: Leather, paper",
                ImageUrl="Items/Mushaf.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=114
            },
             new Item
            {
                Id=18,
                Title="Oil painting",
                Description=" An oil painting of King Fuad's favorite donkey, with one of the royal palaces in the background.",
                ImageUrl="Items/Oil painting.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=19,
                Title="Caravan",
                Description="A large wooden boxcar laminated with zinc sheets, manufactured in England during the reign of Khedive Ismail (1863-1879 AD), used for transporting furniture and kitchen supplies.",
                ImageUrl="Items/Caravan.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=20,
                Title="The Alai Private Carriage",
                Description="The Alai Private CarriageThe Alai Private Carriage, which is a Turkish word meaning squad or battalion, has a rich and illustrious history. It was a gift from the French Emperor Napoleon III and his wife, Empress Eugenie, to Khedive Ismail during the opening of the Suez Canal in 1869. A plaque depicting this carriage is preserved at the Marriott Hotel.",
                ImageUrl="Items/The Alai Private Carriage.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=21,
                Title="The Qamishji's clothing",
                Description="The Qamishji's clothing, the person who trots beside each horse during official processions, was responsible for cleaning and protecting the carriages during the journey, and for clearing the way. He held a bamboo stick in the morning and a torch in the evening to light the way.",
                ImageUrl="Items/The Qamishji's clothing.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=22,
                Title="A set of seals",
                Description=" A set of seals belonging to the Royal Horseback Riding Authority.",
                ImageUrl="Items/A set of seals.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=23,
                Title="Chinese statue",
                Description="Colored Chinese statue of a knight in a suit and with a wooden base - Made in Austria.",
                ImageUrl="Items/Chinese statue.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=115
            },
             new Item
            {
                Id=24,
                Title="The Diorama Hall",
                Description=" This special hall displays three-dimensional scenes illustrating Nubian history and culture. Diorama technology is used to recreate historical and cultural scenes in realistic and detailed detail.",
                ImageUrl="Items/The Diorama Hall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=116
            },
             new Item
            {
                Id=25,
                Title="King Taharqa",
                Description="  One of the most prominent kings of the Twenty-Fifth Dynasty was King Taharqa, who ruled from approximately 690 BC to 664 BC. Taharqa was one of the most prominent Nubian kings and a powerful leader, distinguished by his successful military campaigns and his support for arts and culture.",
                ImageUrl="Items/King Taharqa.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=116
            },
             new Item
            {
                Id=26,
                Title="Pottery vessel",
                Description="This pottery vessel dates back to an ancient period in Nubia's history. The symbols engraved on it typically refer to local culture, religion, or mythology. The symbols may represent a specific goddess, fertility symbols, beliefs in the afterlife, or specific celebrations and rituals prevalent during that period.",
                ImageUrl="Items/Pottery vessel.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=116
            },
              new Item
            {
                Id=27,
                Title="Statue of King Ramses II",
                Description="The Statue of King Ramses II is a colossal statue of Pharaoh Ramses II of the Nineteenth Dynasty of ancient Egypt. This monument dates back to the 13th century BC.",
                ImageUrl="Items/Statue of King Ramses II.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=116
            },
              new Item
            {
                Id=28,
                Title="Museum Garden",
                Description="The museum garden is beautifully designed and comfortable, allowing visitors to stroll around and enjoy the tranquil atmosphere and picturesque nature surrounding the museum. Visitors can also view the many artifacts and statues on display, reflecting Nubian history and culture.",
                ImageUrl="Items/Museum Garden.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=116
            },
              new Item
            {
                Id=29,
                Title="Statue of the architect Imhotep",
                Description="The architect Imhotep was an ancient Egyptian engineer during the New Kingdom (c. 1550–1069 BC). The statue of the architect Imhotep is considered one of the most famous statues representing ancient Egyptian art.",
                ImageUrl="Items/Statue of the architect Imhotep.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=117
            },
              new Item
            {
                Id=30,
                Title="brass surgical instruments",
                Description="brass surgical instruments",
                ImageUrl="Items/brass surgical instruments.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=117
            },
              new Item
            {
                Id=31,
                Title="A faience wall",
                Description=" One of the museum's most prominent artifacts, the faience wall features beautiful, colorful decorative designs that reflect the arts and crafts of the Pharaonic era in ancient Egypt.",
                ImageUrl="Items/A faience wall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=117
            },
              new Item
            {
                Id=32,
                Title="Base of a statue of King Djoser",
                Description="The base of a statue of King Djoser is part of a statue representing King Djoser, considered one of the most important pharaohs in ancient Egyptian history. The base is typically placed beneath the statue to stabilize and support it.",
                ImageUrl="Items/Base of a statue of King Djoser.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=117
            },
              new Item
            {
                Id=33,
                Title="Mery-Ra",
                Description="The mummy of King Mery-Ra is one of the oldest royal mummies discovered to date. It was discovered in a tomb in Thebes (present-day Fayum, Egypt) and dates back to the ancient Pharaonic period during the Sixth Dynasty. It was found in relatively good condition and holds many secrets about the history and culture of this era.",
                ImageUrl="Items/Mery-Ra.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=117
            },
              new Item
            {
                Id=34,
                Title="The Indian Hall",
                Description="The Indian Hall (Beit al-Kritliyya)Contains a table, some Indian-style chairs, and some decorated chests.",
                ImageUrl="Items/The Indian Hall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=118
            },
              new Item
            {
                Id=35,
                Title="Celebration Hall",
                Description="The celebration halls are among the most beautiful and important halls in the museum, containing wooden furniture, metal artifacts, a wooden ceiling, and wooden cabinets.",
                ImageUrl="Items/Celebration Hall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=118
            },
              new Item
            {
                Id=36,
                Title="The Harem",
                Description=", the Winter Hall (Beit al-Kritliya), is the women's quarters. It contains numerous decorative and inlaid wooden wardrobes, wooden furniture, metal artifacts, chandeliers, a metal incense burner, and lighting lamps.",
                ImageUrl="Items/The Harem.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=118
            },
              new Item
            {
                Id=37,
                Title="The Chinese Hall",
                Description=" (Amina bint Salem House)The hall contains the most beautiful pieces of Chinese-style furniture, including chairs, a table, paintings, and a wooden ceiling decorated with geometric and floral motifs.",
                ImageUrl="Items/The Chinese Hall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=118
            },
              new Item
            {
                Id=38,
                Title="Library Hall",
                Description=" (Amina bint Salem House)  The library contains books, a number of paintings, a display case containing a number of antiques, a table, and chairs.",
                ImageUrl="Items/Library Hall.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=118
            },
              new Item
            {
                Id=39,
                Title="A model of a wooden box decorated with colored ribbons and frames.",
                Description="A model of a wooden box decorated with colored ribbons and frames, decorated with Pharaonic symbols and hieroglyphic inscriptions, including a cartouche bearing the name of King Amenhotep III.    Material: WoodDate: 20th century. King Farouk's belongings.",
                ImageUrl="Items/model.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=119
            },
              new Item
            {
                Id=40,
                Title="Asilver cigarette case in the shape of an ancient Egyptian temple",
                Description=" This silver cigarette case features an ancient Egyptian temple, decorated with symbols inspired by ancient Egyptian art. The top of the case features a royal crown and the Egyptian flag in green, with a crescent moon and three stars. \"The Egyptian flag during the reign of King Farouk.\"    Material: Silver  Date: 20th century. \"King Farouk's belongings.\"",
                ImageUrl="Items/ancient.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=119
            },
              new Item
            {
                Id=41,
                Title="Statue of the Egyptian peasant woman by the French sculptor Charles Cordier",
                Description="Statue of the Egyptian peasant woman by the French sculptor Charles Cordier",
                ImageUrl="Items/Statue.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=119
            },
              new Item
            {
                Id=42,
                Title="A wooden chair decorated with scenes from ancient Egyptian art.",
                Description="A wooden chair decorated with scenes from ancient Egyptian art, depicting the gods Bes and Taweret, with a musical scene. On the back of the chair is a verse from a poem by the poet Ahmed Shawqi praising Khedive Abbas Hilmi (O you who wears the two crowns, live in peace... May God protect you from His veils).    Material: Wood",
                ImageUrl="Items/wooden.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=119
            },
              new Item
            {
                Id=43,
                Title="Ramesses II holding a standard",
                Description="Head of a statue of King Ramesses II, holding to his left a ceremonial standard in the temple, of which only two feathers remain at the top. The king wears a composite crown consisting of a wreath of cobras, topped with two ram's horns, a sun disk, and two tall feathers flanked by two large cobras. Behind them, a falcon spreads its wings for protection.    New Kingdom, 19th Dynasty, Ramesses II, circa 1279–1212 BC  Material: Pink granite",
                ImageUrl="Items/Ramesses.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=120
            },
              new Item
            {
                Id=44,
                Title="The couple, Thai and Naya",
                Description="This statue, which has survived in excellent condition, depicts the couple seated in elegant attire, each crowned with a wig, the artist masterfully depicting its intricate details. Naya affectionately rests her right hand on her husband's shoulder. The back of the seat is inscribed with a relief depicting the couple seated at an offering table facing the lady, Tiner.    New Kingdom, Eighteenth Dynasty [1550-1295 BC]  Provenance: Giza, Memphis, Saqqara  Material: Limestone",
                ImageUrl="Items/couple.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=120
            },
              new Item
            {
                Id=45,
                Title="Head of Hatshepsut",
                Description="Head of one of the Osirian statues (mummy-like) of Queen Hatshepsut, standing before the columns of the upper floor of her mortuary temple. Remains of the Red Crown of Lower Egypt are visible on her head. Although the head bears a false beard, as is typical of depictions of the king, the large eyes, adorned with a long line of kohl, the flowing eyebrows, and the full cheeks bear distinctly feminine features.    New Kingdom, Eighteenth Dynasty, Thutmose I [c. 1498–1483 BC]  Luxor, Deir el-Bahari, Mortuary Temple of Hatshepsut  Limestone, colored",
                ImageUrl="Items/Head of Hatshepsut.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=120
            },
              new Item
            {
                Id=46,
                Title="Nakhtmin's Wife",
                Description="The statue is considered one of the most magnificent representations of women in ancient Egypt. She wears a sheer, pleated gown of fine linen and a thick wig adorned with a band of lotus flowers. In her left hand, she holds the mannat necklace of the goddess Hathor. The back of the statue is inscribed in hieroglyphs with the titles of her husband, the leader Nakhtmin. It was originally part of a statue of the couple together.    New Kingdom, Eighteenth Dynasty [1550-1295 BC]  Source: Luxor, Sheikh Abd al-Qurna  Material: Limestone",
                ImageUrl="Items/Nakhtmin's Wife.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=120
            },
              new Item
            {
                Id=47,
                Title="Hathor-headed column",
                Description="The four sides of this column's capital are decorated with the face of the goddess Hathor, a woman's face, and the ears of a cow, topped with a model of a shrine facade. The entire composition resembles a sistrum, a percussion instrument. The column is inscribed with the name of King Apries, described as the lover of the goddess Neith, from Sais, the capital of the Twenty-sixth Dynasty in the western Delta.    Late Period, Twenty-sixth Dynasty, Apries (589-570 BC)",
                ImageUrl="Items/Hathor-headed.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=120
            },
              new Item
            {
                Id=48,
                Title="The Afterlife",
                Description="The ancient Egyptians placed great importance on the afterlife. The Nile and the agricultural cycle played a strong role in their beliefs about resurrection. They called the underworld the Duat. The deceased who crossed it was reborn and placed in the solar boat of Ra to be released into the day. The deceased was like Osiris, resurrected from death. Preparations for the afterlife began with mummification, the preservation of the body until it could be revived.",
                ImageUrl="Items/The Afterlife.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=121
            },
              new Item
            {
                Id=49,
                Title="Tell el-Amarna",
                Description="Primarily targeted the god Amun, whose main cult center was in Thebes (present-day Luxor). During his reign, Aten became the only deity worshipped. These changes coincided with the king changing his name to Akhenaten, followed by the establishment of a new capital in Middle Egypt (in present-day Minya Governorate) called Akhetaten (Horizon of Aten).",
                ImageUrl="Items/Tell el-Amarna.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=121
            },
              new Item
            {
                Id=50,
                Title="Alexandria",
                Description="Alexandria was the greatest city of the ancient world during the reign of the early Ptolemies. It remained the capital of Egypt for nearly a thousand years, from its founding by Alexander the Great in 331 BC until the Arab conquest in 641 AD. The city was completed during the reign of Ptolemy II (285–246 BC). The Greek architect Dinocrates, from the island of Rhodes, planned the city, linking the mainland (a narrow strip between the Mediterranean Sea and Lake Mariout) and the island of Pharos, which lies opposite it, by a bridge called the Heptastadion. This resulted in the eastern and western harbors.",
                ImageUrl="Items/Alexandria.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=121
            },
              new Item
            {
                Id=51,
                Title="Thebes",
                Description="Throne of the god Amun. Luxor has gained international fame for its vast cultural heritage. It is a kind of museum city, housing a large portion of the most important archaeological sites in Egypt and the world. Throughout its history, Luxor has been known by many names: It was called \"Est\" (East), and the Greeks called it \"Thebes\" (Thebes), after their city in the heart of Greece. However, they distinguished it from their city by the nickname \"The City of a Hundred Gates,\" and the name was Arabized to \"Thebes.\"",
                ImageUrl="Items/Thebes.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=121
            },
              new Item
            {
                Id=52,
                Title="Khedivial Cairo",
                Description="The Paris of the East. Egypt (and particularly Cairo) witnessed a new era after a long period of darkness when Muhammad Ali Pasha, the founder of modern Egypt, assumed power in 1805 and began his grand project to develop the country. His efforts laid the foundation for Cairo's urban expansion during the reign of his grandson, Khedive Ismail (1863-1879). His visit to the 1867 World's Fair in Paris marked the most influential transformation in the city's history.",
                ImageUrl="Items/Khedivial Cairo.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=121
            },
            new Item
            {
                Id=53,
                Title="Votive Altar",
                Description="This model illustrates a very common type of horned altar with Greek-style architectural elements: Doric columns and capitals with a pointed cornice. The frieze is decorated with two sphinxes at the corners of the altar, with a view of Harpocrates standing between them. This Greek-style altar reflects the monumental buildings of important religious centers, such as the one built by Alexander the Great in Alexandria.    Date: 2nd century AD  Material: Limestone  Source: Kafr El-Sheikh Governorate",
                ImageUrl="Items/Votive Altar.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=122
            },
            new Item
            {
                Id=54,
                Title="A painting of a physician or pharmacist",
                Description="A man dressed in a Greek chiton and himation, sitting on a high-backed chair, indicating a person of high status. The man is depicted sitting in front of a cubicle, moving something in a round dish with a small tool. The shape of the rolled papyrus in his left hand indicates that he was an educated person.    Date: Roman period, late 2nd century AD  Material: Limestone  Source: Kom Abubello/Triothis-Tarana",
                ImageUrl="Items/painting.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=122
            },
            new Item
            {
                Id=55,
                Title="Coptic textile depicting the Holy Family's journey",
                Description="This unique piece, woven on a red background, depicts the Holy Family's journey to Egypt. In the center, within a square frame, the Virgin Mary—with a halo surrounding her head—rides a donkey carrying the Christ Child. Behind her is a building. Beside the Virgin are two figures, one likely Saint Joseph and the other Salome, the Virgin's cousin, and her maids of honor.  Date: 8th-9th century  Material: Wool and linen  Provenance: Egypt",
                ImageUrl="Items/Coptic.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=122
            },
            new Item
            {
                Id=56,
                Title="Male Mummy",
                Description="The linen bandages were wrapped in an elaborate pattern. This style emerged during the Roman period, the peak of the art of mummy bandaging. The mummy's head was covered with a gilded funerary mask made of cartonnage (a mixture of linen, resin, and plaster). The forehead is decorated with a winged sun disk, a symbol of resurrection. The eyes and eyebrows are inlaid.    Roman period, 1st or 2nd century AD.  Material: Linen, cartonnage, colored, gilded.  Source: Faj al-Jamous, Fayyum.",
                ImageUrl="Items/Male Mummy.jpg",
                Date=  new DateOnly(1795,4,1),
                AreaId=122
            },


        };
        builder.HasData(items);
    }
}
