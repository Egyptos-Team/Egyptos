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
            new Item
            {
                 Id=57,
                 Title="ivory comb",
                 Description="Combs were used in Egypt around five thousand years ago, having been found buried with both men and women. This custom continued into the Byzantine period, when combs were found on the chests of the deceased. Wood was the most commonly used material for combs, while some ivory models were found among the wealthy, some of which had religious uses. 6th century AD. Material: Ivory.",
                 ImageUrl = "Items/ivorycomb.jpg",
                 Date = new DateOnly(1795, 4, 1),
                 AreaId = 101
             },
            new Item
            {
                 Id=58,
                 Title="Three huge keys to the monasteries",
                 Description="Three massive keys to monasteries in Sohag, two of which are decorated with the capital of a Corinthian column, while the third is decorated with a cross.Material: Iron, bronze, copperSource: SohagDate: 12th–13th centuries",
                 ImageUrl="Items/Three huge keys to the monasteries.jpg",
                 Date=  new DateOnly(1795,4,1),
                 AreaId=101
            },
            new Item
            {
                 Id=59,
                 Title="A reproach illustrating the scene of Jesus Christ's entry into the city of Jerusalem",
                 Description="A rectangular lintel with a relief carving depicting the entry of Jesus Christ into Jerusalem riding on a beast and being welcomed by the city's inhabitants as king. The anniversary of Christ's entry into Jerusalem is celebrated annually on the seventh Sunday of Lent and is known as Palm Sunday. Date: 4th or 5th century AD Material: Wood Source: The Hanging Church, Ancient Egypt",
                 ImageUrl="Items/A reproach illustrating the scene of Jesus Christ's entry into the city of Jerusalem.jpg",
                 Date=  new DateOnly(1795,4,1),
                 AreaId=101
            },
            new Item
            {
                Id = 60,
                Title = "Icon of the Holy Family's Flight to Egypt",
                Description = "An icon depicting the Holy Family's flight from Palestine to Egypt, depicting the Virgin Mary on a white horse and Jesus Christ sitting on Saint Joseph's right shoulder Date: 18th century AD Material: Wood",
                ImageUrl = "Items/Icon of the Holy Family's Flight to Egypt.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 101
            },
            new Item
            {
                Id = 61,
                Title = "Pulpit of Anba Ermia",
                Description = "A pillar known as the pulpit of Anba JeremiahDate: 6th century AD Material: StoneProvenance: Monastery of Anba Jeremiah in Saqqara,Egypt",
                ImageUrl = "Items/Pulpit of Anba Ermia.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 101
            },
            new Item
            {
                Id = 62,
                Title = "Coffin of Najm Ankh",
                Description = "The coffin of Najm Ankh made of cartonnage covered with gold foil, retrieved from the Metropolitan Museum and dates back to the Ptolemaic period.Material: Cartonnage covered with gold foil.Date: Ptolemaic period.",
                ImageUrl = "Items/Coffin of Nedjem Ankh.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 102
            },
            new Item
            {
                Id = 63,
                Title = "Coffin of King Ramses II",
                Description = "Coffin of King Ramses II Material: Wood Place of discovery: Deir el - Bahari cache in Thebes,1881",
                ImageUrl = "Items/Coffin of King Ramses II.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 102
            },
            new Item
            {
                Id = 64,
                Title = "Coffin of Sennedjem",
                Description = "Coffin of Sennedjem from his tomb in Deir el-MedinaDate: 19th Dynasty of the New Kingdom",
                ImageUrl = "Items/Coffin of Sennedjem.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 102
            },
            new Item
            {
                Id = 65,
                Title = "King Thutmose III",
                Description = "Granite statue of King Thutmose III Material: GranitePlace of discovery: Karnak",
                ImageUrl = "Items/King Thutmose III.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 102
            },
            new Item
            {
                Id = 66,
                Title = "Belt of Prince Ptah-Shepses",
                Description = "Belt of Prince Ptah-Shepses made of gold, carnelian, and volcanic glass. Date: Old Kingdom 6th Dynasty,around 2323–2150 B.C.Material: GoldPlace of discovery: Saqqara",
                ImageUrl = "Items/Belt of Prince Ptah-Shepses.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 102
            },
            new Item
            {
                Id = 67,
                Title = "Statue of Amenhotep III",
                Description = "This colossal statue represents King Amenhotep III and Queen Tiye. It is considered a group statue of King Amenhotep III, his royal wife Tiye, and their three daughters. It is the largest group statue ever carved.Dynasty: 18th Dynasty – New KingdomMaterial: LimestonePlace of discovery: Luxor",
                ImageUrl = "Items/Statue of Amenhotep III.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 68,
                Title = "Coffin of Kawit",
                Description = "Coffin of Queen Kawit, wife of King Mentuhotep II (Nebhepetre), founder of the Middle Kingdom. The outer surface of the coffin is decorated with scenes from daily life. One side shows the queen drinking in front of a table full of food while a servant adjusts her wig, and another servant pours her next drink.Date: Middle Kingdom,11th Dynasty,reign of Mentuhotep II,around 2055–2004 B.C.Material: LimestonePlace of discovery: Deir el - Bahari",
                ImageUrl = "Items/Coffin of Kawit.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 69,
                Title = "Group Statue of King Menkaure",
                Description = "A group statue of King Menkaure made of schist. The statue shows the king standing between two women: the goddess Hathor on his right and the lady of the Bat province on his left. The king wears the white crown of Upper Egypt. Hathor wears the sun disk and cow horns, while the lady of Bat province wears the emblem of her region on her head.Source: GizaValley Temple of MenkaureDate: Old Kingdom 4th Dynasty,reign of King Menkaure(2490–2472 B.C.)Material: Grey - green schist stone",
                ImageUrl = "Items/11111.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 70,
                Title = "Masks of Yuya and Thuya",
                Description = "The mummies of Yuya and Thuya were discovered wearing cartonnage masks covered in gold leaf. Yuya was the father of Queen Tiye, wife of King Amenhotep III, and husband of Thuya. He came from the town of Akhmim, where he was believed to be a prominent landowner and priest of the god Min. Thuya held important religious titles and was also titled 'Royal Mother of the Great Royal Wife. Date: New Kingdom 18th Dynasty, reign of Amenhotep III(1390–1352 B.C.) Material: Cartonnage,gold Place of discovery: Luxor, Valley of the Kings, Tomb of Yuya and Thuya(KV46)",
                ImageUrl = "Items/Masks of Yuya and Thuya.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 71,
                Title = "Statue of Khafre",
                Description = "This statue depicts King Khafre, builder of the second-largest pyramid in Giza. It was found in the Valley Temple of his pyramid complex. The king is shown seated on a throne, with the two sides of the throne decorated with the symbol of 'Sema-Tawy,' representing the unity of Upper and Lower Egypt. Behind the king's head, the falcon god Horus stands with wings spread, symbolizing protection.Date: Old Kingdom, 4th Dynasty, reign of Khafre(c. 2555–2532 B.C.)Material: DioritePlace of discovery: Giza",
                ImageUrl = "Items/Statue of Khafre.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 72,
                Title = "Statue of Khufu",
                Description = "This small statue depicts King Khufu, builder of the Great Pyramid at Giza. It stands only 7.5 cm tall and is the only confirmed statue of this king. When it was first discovered, the head was missing. Sir Flinders Petrie noticed the break was recent and, realizing the importance of the find, ordered a search for the missing head, which was found three weeks later.Date: Old Kingdom 4th Dynasty, reign of Khufu(c. 2589–2566 B.C.) Material: Ivory Place of discovery: Abydos",
                ImageUrl = "Items/Statue of Khufu.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 103
            },
            new Item
            {
                Id = 73,
                Title = "Plaster Piece Depicting Agricultural Scene",
                Description = "In the ancient Greek era, plaster pieces depicting agricultural scenes were especially popular. These pieces reflected the importance of agriculture in Greek society and depicted farmers, animals, and agricultural crops.",
                ImageUrl = "Items/Plaster Piece Depicting Agricultural Scene.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 74,
                Title = "Statue of the God Serapis",
                Description = "Serapis is an ancient Egyptian god considered the deity of fertility, agricultural life, and protector of the dead. Serapis is usually depicted with a human body and the head of a toufa or lion, carrying a staff or rod and a basket of grain on his head. He was beloved and well-known in ancient Egyptian culture and had a significant influence on various arts and statues.",
                ImageUrl = "Items/Statue of the God Serapis.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 75,
                Title = "Statue of the God Hermanubis",
                Description = "The statue of the god Hermanubis depicts an ancient Egyptian deity considered a fusion between the Greek god Hermes and the Egyptian god Anubis. Hermanubis was believed to be a local deity in the city of Hermopolis in ancient Egypt.",
                ImageUrl = "Items/Statue of the God Hermanubis.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 76,
                Title = "Statue of the God Mars",
                Description = "The statue of the god Mars is one of the ancient Roman statues that depicts the Roman god of war, Mars. He is considered one of the principal gods in the ancient Roman religion. Mars is known as the god of military strength, war, and bravery.",
                ImageUrl = "Items/Statue of the God Mars.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 77,
                Title = "Statue of the Apis Bull",
                Description = "The Apis bull is a statue from ancient Egyptian civilization representing the god Apis, the deity of agriculture and natural wealth in ancient Egyptian religion. The Apis bull is considered a symbol of creative power and fertility.",
                ImageUrl = "Items/Statue of the Apis Bull.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 78,
                Title = "Statue of Emperor Diocletian",
                Description = "This statue depicts the Roman Emperor Diocletian, who ruled from 284 to 305 AD. Diocletian was a famous and powerful emperor who implemented many reforms and changes during his reign.",
                ImageUrl = "Items/Statue of Emperor Diocletian.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 104
            },
            new Item
            {
                Id = 79,
                Title = "Pocket Watch Collection",
                Description = "A collection of gold pocket watches in various shapes. Some feature portraits, names, or different decorative motifs.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt",
                ImageUrl = "Items/PocketWatchCollection.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 80,
                Title = "Desk Set (9 Pieces in Wooden Box)",
                Description = "A nine-piece desk set inside a wooden box, consisting of:\n- Three gold inkwells\n- One gold sponge vessel\n- One double pen case\n- One steel scissors\n- An ivory ruler pen\n- One paper knife (letter opener)\n- One sand container\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Various materials\nDiscovery Location: Egypt",
                ImageUrl = "Items/DeskSet.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 81,
                Title = "Necklace of Muhammad Ali Pasha",
                Description = "A necklace belonging to Muhammad Ali Pasha, composed of 16 decorative units:\n- 8 units inscribed with the name 'Muhammad Ali'\n- 8 units shaped like gold roses with a central ring set with diamonds\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt",
                ImageUrl = "Items/MuhammadAliNecklace.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 82,
                Title = "Gold Set of Princess Malak Tousson",
                Description = "A gold set consisting of a brush, drinking cups, and a sword decorated with floral motifs and the letter 'M'.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Gold\nDiscovery Location: Egypt",
                ImageUrl = "Items/PrincessMalakSet.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 83,
                Title = "Princess Shwikar's Set",
                Description = "A set made of platinum and diamonds, including a crown and earrings.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Platinum and diamonds\nDiscovery Location: Egypt",
                ImageUrl = "Items/PrincessShwikarSet.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 84,
                Title = "Queen Farida's Set",
                Description = "A set made of platinum and 18-karat gold. The crown consists of five graduated flowers, with the largest in the center.\n\nPeriod: Muhammad Ali Dynasty\nMaterial: Platinum and gold\nDiscovery Location: Egypt",
                ImageUrl = "Items/QueenFaridaSet.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 105
            },
            new Item
            {
                Id = 121,
                Title = "Great Court of Ramses II",
                Description = "The massive courtyard built by Ramses II, featuring 74 columns in double rows and numerous statues of the pharaoh. The walls are decorated with scenes of Ramses' military campaigns and religious ceremonies.\n\nPeriod: New Kingdom, 19th Dynasty\nMaterial: Sandstone",
                ImageUrl = "Items/RamsesCourt.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 106
            },
            new Item
            {
                Id = 122,
                Title = "Colossi of Ramses II",
                Description = "Towering seated statues of Ramses II that once flanked the temple entrance. The remaining colossus stands 15 meters tall and shows the pharaoh wearing the double crown of Upper and Lower Egypt.\n\nPeriod: New Kingdom, 19th Dynasty\nMaterial: Granite",
                ImageUrl = "Items/RamsesColossi.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 106
            },
            new Item
            {
                Id = 123,
                Title = "Birth Chamber of Amenhotep III",
                Description = "The sacred chamber depicting the divine birth of Amenhotep III, with reliefs showing the god Amun impregnating the queen and the birth sequence supervised by various deities.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Sandstone",
                ImageUrl = "Items/BirthChamber.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 106
            },
            new Item
            {
                Id = 124,
                Title = "Processional Colonnade of Amenhotep III",
                Description = "The magnificent 100-meter long colonnade with 14 papyrus-cluster columns, originally built to connect Luxor Temple with Karnak during the Opet Festival.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Sandstone",
                ImageUrl = "Items/ProcessionalColonnade.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 106
            },
            new Item
            {
                Id = 85,
                Title = "Throne Palace",
                Description = "The Throne Palace consists of two floors. The ground floor contains a rectangular hall with the throne chair, covered by a ceiling featuring a sun disk at its center with golden rays emanating from it. The hall is adorned with a painting depicting Muhammad Ali Pasha (1769-1849 AD). On both sides of the hall, there is gilded furniture upholstered with red velvet.",
                ImageUrl = "Items/ThronePalace.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 86,
                Title = "Mosque and Clock Tower",
                Description = "The mosque is distinguished externally by its diverse decorative elements and exquisite Arabic calligraphic inscriptions executed in Islamic style. The mosque has an entrance with a pointed arch adorned with relief decorations. On either side of the entrance are two panels containing inscriptions - the right panel includes the foundation text of the mosque, while the other lists the names of workers and artists who participated in building the mosque, along with its founding date in 1235 AH (1819 AD).",
                ImageUrl = "Items/MosqueClockTower.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 87,
                Title = "Reception Palace (Salamlik)",
                Description = "The Reception Palace consists of two floors. The ground floor contains two reception halls separated by a door. The first was designated for receiving official guests, senior state officials, and others coming to congratulate Prince Muhammad Ali Tawfiq during official celebrations. The second hall was designated for receiving senior worshippers coming to perform Friday prayers at the mosque within the palace.",
                ImageUrl = "Items/ReceptionPalace.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 88,
                Title = "Residence Palace",
                Description = "The Residence Palace is one of the oldest buildings in the palace, with construction beginning in 1228 AH/1813 AD. The palace consists of a basement topped by two floors plus a tower. The basement contains several rooms. The ground floor includes the Fountain Hall or Reception Hall, which is surrounded by several side rooms and halls: the Fireplace Room, Dining Hall, Mother-of-Pearl Hall (named because all its furnishings are inlaid with mother-of-pearl), and the Shukma Hall (a Turkish term meaning the protruding part of the building) - a ladies' room designated for them during evening parties, covered with ceramic tiles and containing a fireplace.",
                ImageUrl = "Items/ResidencePalace.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 89,
                Title = "Harem Quarters",
                Description = "The hall contains chairs, an oval table, mashrabiya (traditional wooden lattice), some cabinets holding various glass artifacts, porcelain plates, a hanging carpet, and some calligraphic inscriptions.",
                ImageUrl = "Items/HaremQuarters.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 90,
                Title = "Celebration Hall",
                Description = "The Celebration Hall is one of the most beautiful and important halls in the museum, containing wooden furniture, metal artifacts, wooden ceilings, and wooden cabinets.",
                ImageUrl = "Items/CelebrationHall.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 107
            },
            new Item
            {
                Id = 91,
                Title = "Djed Pillar",
                Description = "The 'Djed' pillar symbolizes stability and continuity. In the Old Kingdom, it may have represented the pillars that held up the heavens, and later it sometimes referred to the backbone of the god Osiris.",
                ImageUrl = "Items/DjedPillar.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 92,
                Title = "Statue of Goddess Nephthys",
                Description = "Nephthys, considered one of the most important protective goddesses for the deceased.",
                ImageUrl = "Items/NephthysStatue.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 93,
                Title = "Statue of Osiris",
                Description = "Osiris was considered the lord of the afterlife. Since prehistoric times, the ancient Egyptians associated him with the annual Nile flood, making him also the god of agriculture, fertility, and resurrection.",
                ImageUrl = "Items/OsirisStatue.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 94,
                Title = "Ram Mummy",
                Description = "A mummified ram wrapped in linen cloth with a gilded cartonnage mask covering its face. The ram was a symbol of the god Khnum, who was believed to shape every child born on his potter's wheel. His main cult center was on Elephantine Island.",
                ImageUrl = "Items/RamMummy.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 95,
                Title = "Cat Statue and Mummy",
                Description = "A statue and mummy of a cat. In ancient Egypt, cats symbolized the goddess Bastet, whose popularity increased during the Late Period, particularly in Bubastis (modern Zagazig). The statue is made of sycamore wood - from Qurna.",
                ImageUrl = "Items/CatMummy.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 96,
                Title = "Canopic Jars",
                Description = "A set of four jars belonging to Wahibre-em-akhet, son of Psamtik. These jars were used to preserve the deceased's embalmed internal organs. Their lids represent the four sons of Horus. They are called Canopic jars after the city of Canopus in Abu Qir, Alexandria.",
                ImageUrl = "Items/CanopicJars.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 108
            },
            new Item
            {
                Id = 97,
                Title = "Crocodile-Headed Statue",
                Description = "Ancient Egyptian culture was deeply connected to the Nile River, particularly its annual flood and fertility. This connection manifested in their religion through the worship of the Nile crocodile as the god Sobek. Originally a local deity, Sobek became culturally significant due to his Nile associations, revered as a symbol of fertility, power, and protection. His popularity peaked during the Middle Kingdom, influencing kings and politics, marking a turning point in his role within Egyptian religion.",
                ImageUrl = "Items/CrocodileHeadedStatue.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 98,
                Title = "Crocodiles in Ancient Egypt",
                Description = "Crocodiles were common along the Nile in ancient Egypt. Egyptians depicted the god Sobek as a crocodile or human with crocodile head, worshiping him for protection, human fertility, and crop productivity.",
                ImageUrl = "Items/CrocodilesAncientEgypt.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 99,
                Title = "God Sobek",
                Description = "Ancient Egyptians revered crocodiles as Sobek, depicted as crocodile-headed human or full crocodile. His main cult center was in Faiyum, later spreading to Kom Ombo and Thebes. Originally symbolizing water and fertility, Sobek became associated with the dead's protection in the afterlife. He merged with Ra as 'Sobek-Ra', becoming a royal protector. Worship continued through Ptolemaic and Roman periods, especially in Faiyum and Kom Ombo where many mummified crocodiles were found.",
                ImageUrl = "Items/GodSobek.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 100,
                Title = "Tomb Model",
                Description = "A model replicating an original tomb containing crocodile burials, demonstrating Sobek's burial practices. Includes replica coffins and pottery vessels used in these rituals.",
                ImageUrl = "Items/TombModel.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 101,
                Title = "Nile Crocodile",
                Description = "The Nile crocodile symbolized both good and evil - revered yet hunted. As Earth's largest living reptiles, Egyptians deified them, creating sacred statues and pottery with crocodile-headed lids, acknowledging their power and danger to Nile fishermen.",
                ImageUrl = "Items/NileCrocodile.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 102,
                Title = "Symbolism Scene from Ancient Egypt",
                Description = "A scene from the tomb of Ramses VI in the Valley of the Kings, representing the concept of resurrection after death. The crocodile in ancient Egypt was considered the lord of eternal waters in the afterlife, protecting Osiris and resurrecting him from death in the form of the White Crown. The head of Osiris emerging from the crocodile's back symbolizes rebirth. The crocodile, as an aquatic creature, serves as a protective vessel for the deceased in the afterlife, guarding against dangers. The emerging head of Osiris represents resurrection and rebirth, while the White Crown symbolizes Osiris as the god of resurrection and renewal.",
                ImageUrl = "Items/SymbolismScene.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 109
            },
            new Item
            {
                Id = 103,
                Title = "Statue of Meritamen",
                Description = "This magnificent statue is one of the unique pieces of ancient Egyptian art, representing Queen Meritamen, daughter of Ramses II and the great royal wife. Although her name is missing here, the titles and phrases match those on the princess's statue (who became the great wife after her mother's death) found in Akhmim.\n\n19th Dynasty, Reign of Ramses II\nMaterial: Painted limestone",
                ImageUrl = "Items/MeritamenStatue.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 104,
                Title = "Offering Table",
                Description = "For ancient Egyptians, both deities and the deceased had the same needs as the living, requiring constant provision of food and drink. The early embodiment of this concept appeared in the form of offering tables - stone slabs where various food items and drinks could be placed for consumption by the deceased or deity.\n\nNew Kingdom, 18th Dynasty, Thutmose III (c. 1497-1425 BC)\nMaterial: Granite",
                ImageUrl = "Items/OfferingTable.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 105,
                Title = "Canopic Jars of Istemkheb",
                Description = "During mummification, specific organs (liver, lungs, intestines, and stomach) were removed from the deceased, wrapped separately, and placed in four jars known as canopic jars.",
                ImageUrl = "Items/IstemkhebJars.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 106,
                Title = "Statue of a Servant Grinding Flour",
                Description = "Bread was a staple food in ancient Egypt, as it remains today. The deceased - just like the living - needed constant food supplies to survive in the afterlife, hence many servant statues found in tombs show them engaged in various bread-making stages, like this statue.\n\nOld Kingdom (c. 2686-2125 BC)\nMaterial: Painted limestone\nDiscovery Location: Egypt",
                ImageUrl = "Items/FlourGrinder.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 107,
                Title = "Red Sea Tourism Icon",
                Description = "The 'Tourism Icon' statue in Hurghada Museum is a miniature replica of the original statue located in the Red Sea.",
                ImageUrl = "Items/TourismIcon.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 108,
                Title = "Tutankhamun Statue",
                Description = "This statue dates back to the Pharaonic era, depicting Pharaoh Tutankhamun seated on his throne with his name and title inscribed on the base. Considered an important artifact reflecting the sculptural art of the 18th Dynasty.",
                ImageUrl = "Items/TutankhamunStatue.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 110
            },
            new Item
            {
                Id = 109,
                Title = "Statue Head of Goddess Hathor",
                Description = "Hathor is considered the oldest goddess in Egyptian mythology, symbolizing love, generosity, and motherhood.\n\nMaterial: Black granite",
                ImageUrl = "Items/HathorHead.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            },
            new Item
            {
                Id = 110,
                Title = "Fragment of Stone Slab with Queen Hatshepsut's Name",
                Description = "Queen Hatshepsut was the greatest woman of her time, whose reign was marked by prosperity, power, and strengthened diplomatic relations through expeditions to Punt.\n\nPeriod: New Kingdom, 18th Dynasty\nMaterial: Limestone",
                ImageUrl = "Items/HatshepsutSlab.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            },
            new Item
            {
                Id = 111,
                Title = "Rectangular Piece of Queen Shepenupet",
                Description = "A rectangular piece depicting Queen Shepenupet with the curved beard, holding the ankh symbol in one hand and the royal scepter in the other.\n\nPeriod: Third Intermediate Period\n22nd Dynasty\nMaterial: Sandstone",
                ImageUrl = "Items/ShepenupetPiece.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            },
            new Item
            {
                Id = 112,
                Title = "Upper Part of King Nectanebo II's Sarcophagus",
                Description = "The upper part of King Nectanebo II's sarcophagus depicts the king offering wine to god Anhur. The king wears a short wig with uraeus and a four-feathered crown, holding an ankh in his right hand and was scepter in his left. Goddess Bastet holds an ankh while god Shu wears similar headdress and holds same symbols. A winged vulture appears at the top.\n\nPeriod: Late Period, 30th Dynasty, Nectanebo II\nMaterial: Green diorite",
                ImageUrl = "Items/NectaneboSarcophagus.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            },
            new Item
            {
                Id = 113,
                Title = "Icon of Saint Simon on Throne",
                Description = "An icon showing Saint Simon seated on a throne decorated with two winged angels above. His head is surrounded by a halo of connected beads, holding a paper scroll in his hands, wearing folded garments. Two birds flank the throne's base, one wearing a crown.\n\nMaterial: Wood\nPeriod: 18th century AD",
                ImageUrl = "Items/SaintSimonIcon.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            },
            new Item
            {
                Id = 114,
                Title = "Mechanical Gunpowder Measure",
                Description = "A mechanical gunpowder measure decorated with plant motifs in silver and gold. The wooden handle features silver-inlaid plant designs and ends with a copper ornament bearing raised decorations.\n\nPeriod: Modern (Muhammad Ali Dynasty)\nMaterial: Metal",
                ImageUrl = "Items/6.jpg",
                Date = new DateOnly(1795, 4, 1),
                AreaId = 111
            }
        };
        builder.HasData(items);
    }
}
