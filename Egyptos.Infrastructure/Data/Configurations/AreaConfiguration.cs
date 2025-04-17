using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Egyptos.Domain.Consts.DefaultRoles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        var areas = new List<Area>
        {
            // Fixed artifacts: 30 1:30
            new Area
            {
                Id=1,
                Name="sphinx",
                Description="Colossal statues are one of the hallmarks of ancient Egyptian civilization, and the Great Sphinx of Giza is the most famous of them. The statue was carved into the rock of the same area during the Fourth Dynasty (c. 2613-2494 BC), making it the oldest. Ancient Egyptian sphinxes represented the king with the body of a lion as a clear sign of his power. Evidence suggests that the Sphinx was carved during the reign of King Khafre (c. 2558-2532 BC), the owner of the second pyramid of Giza. The Sphinx and its temple in front of it are located directly next to the Valley Temple of Khafre and the lower part of the ascending causeway leading to his mortuary temple and pyramid. Careful archaeological analysis has revealed that the Valley Temple was completed before work on the Sphinx and its temple began, while analysis of the Sphinx’s facial features has revealed striking similarities to statues of King Khafre.The Sphinx has captured the imagination of travelers and explorers for thousands of years, even in ancient Egypt.During the Eighteenth Dynasty(c. 1550–1295 BC), it came to be seen as a manifestation of the sun god, and was called Hor - em - akhet, “Horus of the Horizon.” King Amenhotep II(c. 1427–1400 BC) built a temple next to the Sphinx dedicated to this god.His son, Thutmose IV(c. 1400–1390 BC), erected a huge stela between its forelegs, called the Dream Stele, in which he recorded a remarkable event.    The Sphinx was constructed around 2500 BCE during Egypt’s Old Kingdom, specifically during the reign of the Fourth Dynasty. This period is known for the construction of the pyramids and other massive architectural projects that demonstrated Egypt’s advanced engineering and artistic capabilities.Today, the Great Sphinx of Giza is a symbol of ancient Egypt’s enduring legacy. It attracts millions of visitors each year and continues to be studied by archaeologists and historians. The statue remains a source of fascination due to its age, symbolism, and the mysteries that still surround it One of the most famous features of the Sphinx is its missing nose. There are many theories about how it was lost. Historical records suggest that the nose might have been deliberately destroyed. One theory attributes the damage to cannon fire during the Napoleonic era, while another suggests that it was broken off by a Sufi mystic in the 14th century who saw it as a symbol of idolatry. The statue also shows signs of erosion, likely caused by wind, sand, and water over the millennia. Despite these damages, the Sphinx remains remarkably intact for its ageThe Great Sphinx of Giza stands as a timeless testament to the skill, artistry, and spiritual beliefs of ancient Egypt. Whether viewed as a symbol of royal power, a guardian of the pyramids, or a relic shrouded in mystery, the Sphinx continues to captivate the world with its imposing presence and enigmatic history. Its legacy endures, reminding us of the brilliance and complexity of one of the world’s greatest ancient civilizations.   Efforts have been made in recent years to preserve the Sphinx from further erosion and damage. Conservation projects aim to stabilize the structure and protect it from the harsh desert environment.  The Sphinx was likely carved directly from a single massive limestone outcrop that was present on the Giza Plateau. It served as a guardian figure, protecting the sacred site where the pyramids were built. Many historians and archaeologists believe that the Sphinx was intended to stand as a powerful sentinel that would ward off evil spirits and intruder.",
               Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3456.144626990087!2d31.140142324992226!3d29.9752733218457!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584f62a3aea979%3A0xc9d3f0a64066bda9!2z2KrZhdir2KfZhCDYo9io2Ygg2KfZhNmH2YjZhCDYqNin2YTYrNmK2LLYqQ!5e0!3m2!1sar!2seg!4v1743165561516!5m2!1sar!2seg",
               Address="Giza Plateau",
               ImageUrl="AreaImages/sphinx1.jpeg",
               AreaTypeId=1,
               Latitude=null,
               Longitude=null
            },
            new Area{
                   Id=2,
                   Name="Roman well",
                   Description="The first attempts to find the well were in 1991, as part of the excavation mission of Zagazig University inside the Bastet temple, and then the head of the mission announced the discovery of the well in 1997.This well follows the Roman architectural style, but many pottery vessels dating back to the period from the first to the fourth century AD were found inside it The Roman Well is a fascinating structure that showcases the advanced engineering and architectural prowess of ancient Rome.Wells were essential to Roman cities, military camps, and fortifications, providing a reliable water supply for drinking, irrigation, and sanitation. These wells, built with incredible precision and durability, have withstood the test of time and remain significant archaeological landmarks today.Roman wells were often constructed using stone, bricks, or concrete.The materials used varied depending on the location and availability, but the goal was always the same: to create a deep, stable structure that could access underground water sources. Some notable features of Roman wells include: Circular Design: Most Roman wells were circular to provide structural prevent collapse. Stone or Brick Lining: The walls were lined with stone or bricks to prevent soil erosion and keep the water clean.Pulley System: A system of pulleys, ropes, and buckets was often installed to draw water more efficiently.Drainage and Overflow Channels: To prevent flooding, Roman engineers designed channels to drain excess water The accounts and sources related to the journey of the Holy Family also stated that the family members drank from this well when they arrived at the city of Tell Basta, which the Holy Family entered on the 24th of Bashans according to the Coptic calendar, corresponding to the first of June, which is still celebrated by Christians in Egypt and the world on that day every year. In Roman times, wells were more than just practical structures; they held symbolic significance as sources of life and sustenance.Wells were sometimes associated with religious rituals and were believed to be connected to underground deities or spirits.Offerings, including coins and small objects, were often thrown into wells as part of religious practices.  The sophisticated construction of Roman wells is a testament to the ingenuity and skill of Roman engineers. Their techniques have influenced well-building practices for centuries and laid the foundation for modern water management systems.Today, many ancient Roman wells still stand as monuments to Rome’s enduring legacy in architecture, engineering, and urban planning.They remain a subject of archaeological interest, providing valuable insights into how ancient civilizations managed water resources in challenging environments.",
                   Location= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7241914.9780074395!2d36.51726925815779!3d27.590698964573267!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f587de345f359f%3A0x932ebfd03e6a6c4d!2sRoman%20well!5e0!3m2!1sar!2seg!4v1743165719659!5m2!1sar!2seg",
                   Address= "Salloum and Sidi Barrani City, Marsa Matrouh",
                   ImageUrl= "AreaImages/Roman well1.webp",
                   AreaTypeId= 1,
                    Latitude=null,
               Longitude=null
              },
            new Area
            {
                Id = 3,
                Name = "Eastern and Western Cemeteries",
                Description = "The Eastern and Western Cemeteries are among the largest and best preserved of the Old Kingdom, and form part of the pyramid complex of King Khufu (c. 2589–2566 BC) at Giza. Called the Eastern and Western Cemeteries after their locations in relation to the Great Pyramid, they include the tombs of members of the royal family and the highest-ranking nobles, and contain some of the finest tomb reliefs from this period.The Eastern and Western Cemeteries reflect the social and religious practices of ancient Egypt during the Old Kingdom.Burial near the king’s pyramid was a symbol of prestige, as ancient Egyptians believed that closeness to the pharaoh would offer spiritual benefits and enhance their chances of achieving a favorable afterlife.The careful organization of these cemeteries and the construction of mastabas and tombs indicate the importance of maintaining social hierarchies,even in death. Moreover, the decorations and inscriptions found in these tombs provide valuable insights into the daily lives, religious beliefs,and funerary customs of ancient Egyptians.Scenes depicting offerings,hunting,feasting,and religious ceremonies highlight the importance of both worldly pleasures and preparation for the afterlife.The Western Cemetery,located to the west of the Great Pyramid, is larger and primarily contains the tombs of high - ranking officials,priests,and courtiers who served the pharaohs.Unlike the Eastern Cemetery,which focused on royal family members,the Western Cemetery served as a burial ground for the elite who were close to the king in life and wanted to maintain that closeness in death. The Eastern Cemetery is situated near the Great Pyramid of Khufu(Cheops) and primarily contains the tombs of members of the royal family and high officials from the Fourth Dynasty(circa 2600–2500 BCE).This cemetery reflects the importance of proximity to the king’s pyramid, as ancient Egyptians believed that closeness to the pharaoh in death could offer spiritual protection and a better afterlife.The Eastern and Western Cemeteries near the Great Pyramids of Giza are significant burial sites that date back to the Old Kingdom of ancient Egypt.These cemeteries serve as a testament to the elaborate burial practices and social hierarchy of ancient Egyptian society.They are located on the Giza Plateau and were constructed to house the tombs of royalty,nobles,and high - ranking officials who lived during the reigns of the pharaohs who built the pyramids. Archaeological excavations in the Eastern and Western Cemeteries have revealed many artifacts,including statues,sarcophagi,and burial goods.These discoveries have helped historians better understand the funerary practices and social organization of the Old Kingdom.Efforts have been made to preserve the cemeteries and protect them from environmental damage and lootingThe Eastern and Western Cemeteries of Giza stand as silent witnesses to the grandeur and complexity of ancient Egyptian civilization.They reflect not only the architectural brilliance of the Old Kingdom but also the deep religious beliefs that shaped every aspect of Egyptian life and death.Together with the Pyramids of Giza and the Great Sphinx, these cemeteries form part of one of the most awe - inspiring archaeological complexes in the world Most of the tombs were mastabas,with some tombs carved into the rock.The term “mastaba” refers to a type of funerary structure that was generally rectangular in shape and built over a burial chamber, which was underground.Most of the mastabas of the Eastern and Western Cemeteries were built during the reign of King Khufu, along with his pyramid complex, while the rock - tombs were built later.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d884425.3835936754!2d32.451499221875004!3d30.014281800000006!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458473d9ac3017d%3A0xbd5cc7277091d33e!2z2YXZgtin2KjYsSDZh9mK2KbZhyDYp9mE2YPZiNmF2YbZiNmE2Ksg2KfZhNi52LPZg9ix2YrZhyDYqNmF2LXYsSDYp9mE2YLYr9mK2YXZhyAoKCgg2KfZhNio2LHZiti32KfZhtmK2KkgKSkp!5e0!3m2!1sar!2seg!4v1743165909053!5m2!1sar!2seg",
                Address = "Giza Plateau",
                ImageUrl = "AreaImages/Eastern and Western Cemeteries1.webp",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 4,
                Name = "Serapeum",
                Description = "The Serapeum is a crypt containing the burials of the sacred bull Apis, which was associated with the god Ptah, whose cult center was in the city of Memphis. A path lined with sphinxes leads to the Serapeum, which consists of two long corridors that once contained the remains of mummified bulls. The Serapeum was used from the reign of Amenhotep III in the New Kingdom until the Ptolemaic period.The priests chose the Apis bull based on the presence of distinctive marks on the animal.These bulls received many privileges during their lifetime,and upon their death they were mummified and placed in huge stone coffins in a grand ceremony.The Serapeum was constructed during the reign of Pharaoh Amenhotep III(circa 14th century BCE) and later expanded by other rulers,including Rameses II.It served as a necropolis specifically for the Apis bulls,who were seen as living embodiments of the god Ptah, protector of Memphis.When a bull died,it was mummified and given elaborate funerary rites before being interred in a sarcophagus inside the Serapeum. The Apis bull held immense religious importance in ancient Egypt.It was believed to be the living incarnation of the god Ptah and was associated with fertility,strength,and kingship.The death of an Apis bull was a momentous event, followed by elaborate mourning rituals,mummification,and burial.The Serapeum was rediscovered in 1850 by the French archaeologist Auguste Mariette,who stumbled upon the entrance while excavating the Saqqara necropolis.His discovery was groundbreaking and revealed the extent of ancient Egyptian religious practices and funerary customs. Inside the Serapeum Mariette found the massive sarcophagi and numerous artifacts,including statues,amulets,and votive offerings.Many of these items are now housed in museums around the world,including the Egyptian Museum in Cairo and the Louvre in Paris.The Serapeum symbolized the close connection between the gods and earthly rulers.By burying the Apis bulls in such an elaborate necropolis,the Egyptians hoped to ensure the bulls' immortality and continued protection for the pharaoh and the kingdom.The name Serapeum derives from Serapis, a Graeco - Egyptian deity whose worship became popular during the Ptolemaic era.  The Serapeum of Saqqara is one of the most mysterious and fascinating ancient structures in Egypt.Located near the Step Pyramid of Djoser in Saqqara,it served as a burial site for the sacred Apis bulls,which were worshipped as manifestations of the god Ptah in Memphis,the ancient capital of Egypt.The Serapeum reflects the Egyptians’ deep religious devotion and belief in the divine connection between humans, animals,and the gods. Inscriptions record many kings making offerings to the Serapeum, as two of Ramesses II's sons, Khaemset and Merneptah, donated many bulls, treasures, and ushabti statues to the Serapeum.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13748.959520154398!2d32.34101705169658!3d30.514255381012045!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f85fbc7d78d8b1%3A0xcd2d23a7d9ae427f!2z2LPYsdin2KjZitmI2YXYjCDYp9mE2KfYs9mF2KfYudmK2YTZitip2Iwg2YXYrdin2YHYuNipINin2YTYpdiz2YXYp9i52YrZhNmK2Kk!5e0!3m2!1sar!2seg!4v1743166147627!5m2!1sar!2seg",
                Address = "Saqqara",
                ImageUrl = "AreaImages/Serapeum1.webp",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 5,
                Name = "Titi pyramid set",
                Description = "Teti (c. 2345–2323 BC), the first ruler of the Sixth Dynasty, built a pyramid complex for himself near the Step Pyramid of Djoser (c. 267–2648 BC) at Saqqara, and it was 52.5 m high when completed. Although originally faced with blocks of fine limestone, its core consisted of small blocks of local limestone and pebbles, which meant that when the cladding was removed in ancient times, the pyramid was unable to maintain its shape, making it look little different from a natural mound today. However, the interior is intact. It is entered by a descending passage leading to a horizontal corridor, which leads to an anterior chamber. There are three storage chambers on the left, but these were found empty as a result of the pyramid being robbed in ancient times. On the right, on the western side, is the burial chamber, whose ceiling is decorated with golden stars on a dark blue background, reflecting the ancient Egyptian idea of the tomb as a miniature of the universe. The end of the corridor, as well as the front chamber and the burial chamber, are decorated with the Pyramid Texts, a set of rituals and recitations to ensure the king's safe passage to the afterlife. The inscriptions on the pyramid are not complete, indicating the king's sudden death. In the 3rd century BC, the ancient Egyptian priest and historian Manetho recorded that Teti was killed by his guards, but there is insufficient evidence to support this. Some remains of the mortuary temple of Teti's pyramid complex have been discovered, although most of its parts were stolen in antiquity, and the valley temple has yet to be found. There is also a large cemetery for the burial of Teti's officials in front of his pyramid, containing a group of the most magnificent and beautiful tombs of the Old Kingdom, such as the mastabas of the viziers Mereruka and Kagemni.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3459.621339317261!2d31.22432062499619!3d29.87519237657098!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145849815af7ae43%3A0x7a343bb248b809e8!2z2YfYsdmFINiq2KrZiiwgUHlyYW1pZCBvZiBEam9zZXIgUmTYjCDYtdmC2KfYsdip2Iwg2YXYsdmD2LIg2KfZhNio2K_Ysdi02YrZhtiMINmF2K3Yp9mB2LjYqSDYp9mE2KzZitiy2KkgMzM1MjAwMQ!5e0!3m2!1sar!2seg!4v1743166479373!5m2!1sar!2seg",
                Address = "Saqqara",
                ImageUrl = "AreaImages/Titi pyramid set1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 6,
                Name = "Pyramid complex of King Menkaure",
                Description = "The third pyramid on the Giza Plateau was built by King Menkaure (c. 2532-2503 BC), son of Khafre and grandson of Khufu. With a smaller base, the original pyramid is only 65 metres high, making the pyramid of Menkaure the smallest. This small size was due to several factors, including the small space left on the Giza Plateau, and the materials used for the outer casing of Menkaure's pyramid. His predecessors used limestone to cover their pyramids, while Menkaure used granite brought from Aswan, more than 800 km from Giza. This material was much harder to transport than limestone. However, only the lower quarter of the pyramid is covered with granite, while the rest of the pyramid is covered with limestone. As was the case with the Great Pyramid, three smaller pyramids can be seen next to Menkaure's pyramid, which were used to bury the queens of his time. However, his pyramid was never discovered, but it is believed that the largest of the three queens' pyramids was the pyramid.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3456.2396670343505!2d31.13114942499237!3d29.97254152197486!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584fd0a1d81a93%3A0xcadee82900fa8d24!2z2YfYsdmFINmF2YbZgtix2Lk!5e0!3m2!1sar!2seg!4v1743166561172!5m2!1sar!2seg",
                Address = "Giza Plateau",
                ImageUrl = "AreaImages/Pyramid complex of King Menkaure1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 7,
                Name = "The Unfinished Obelisk",
                Description = "The Unfinished Obelisk, located in an ancient granite quarry in Aswan, Egypt, is one of the most fascinating and revealing monuments of ancient Egyptian engineering. Had it been completed, it would have been the largest obelisk ever constructed, standing at an estimated height of 42 meters (137 feet) and weighing approximately 1,200 tons. This obelisk provides crucial insights into the techniques, tools, and challenges faced by ancient Egyptian stonemasons. The site has been preserved to protect the ancient quarry and ensure that future generations can learn from this incredible monument to ancient engineering. The Unfinished Obelisk was likely commissioned during the reign of Queen Hatshepsut (circa 1507–1458 BCE), one of ancient Egypt’s most powerful rulers. However, the project was abandoned due to a major flaw in the granite – a large crack that developed during the quarrying process. The incomplete obelisk was discovered in the early twentieth century after being covered in sand for thousands of years in one of the Aswan quarries famous for its hardness and high quality. It is likely that the sculpting of this incomplete obelisk began at the behest of Queen Hatshepsut (c. 1473 - 1458 BC) to erect it in front of the Temple of Amun in Karnak, but work on the lying obelisk was stopped after many cracks appeared in the stone.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3642.698997832703!2d32.89801192519799!3d24.076902176164435!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143664aa5c33aa3f%3A0xa1bf171a1b3086c6!2z2KfZhNmF2LPZhNipINin2YTZhtin2YLYtdip!5e0!3m2!1sar!2seg!4v1743217417901!5m2!1sar!2seg",
                Address = "Aswan",
                ImageUrl = "AreaImages/The Unfinished Obelisk1.jpg",
                AreaTypeId = 1, 
                Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 8,
                Name = "Rock carvings on Suhail Island",
                Description = "Suhail Island, located in the Nile River near Aswan, Egypt, is known for its ancient rock carvings that provide valuable insights into the history, culture, and daily life of ancient Egyptian and Nubian civilizations. These carvings, etched into the island’s granite surfaces, date back to various historical periods, from the Predynastic era to the New Kingdom and later times.\n\nSuhail Island is one of the largest Nile islands at the first cataract in Aswan, which was home to granite quarries, the hardest stone used in ancient Egyptian architecture. Therefore, ancient kings often sent armies and trade missions to the island until it became a port for ships and sea crews, especially those heading to Nubia.\n\nThe island contains hundreds of inscriptions, memorial plaques, and royal cartouches that immortalized many rulers and kings within the boundaries of the temple of the goddess Anket. The most famous inscription on the island is the 'Famine Stela,' which tells the story of a seven-year drought during the reign of King Djoser and his efforts to restore prosperity to Egypt.\n\nSuhail Island has long been associated with the ancient Nubian region, serving as a cultural and commercial crossroads between Egypt and sub-Saharan Africa. Today, it remains an important archaeological site, attracting researchers and visitors interested in ancient Egyptian and Nubian history.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3643.2406441700614!2d32.87623657519864!3d24.057828826905556!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143663f0529b1fc3%3A0x2c9276c662d7a1fd!2sRock%20Inscriptions%20of%20Sehel%20Island!5e0!3m2!1sar!2seg!4v1743166902012!5m2!1sar!2seg",
                Address = "Sohail Island, Second Sheikh, First Aswan, Aswan Governorate",
                ImageUrl = "AreaImages/Rock carvings on Suhail Island1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 9,
                Name = "Howard Carter's house in Thebes",
                Description = "This mud-brick house was designed and built by British archaeologist Howard Carter in 1910. It served as his residence while he conducted excavations in the Valley of the Kings, including the discovery of Tutankhamun’s tomb in 1922.\n\nThe house was strategically located near Carter’s excavation sites, allowing him to work efficiently. It included bedrooms, study rooms, a darkroom for photography, and servants’ quarters. Despite lacking modern amenities like running water and electricity, Carter furnished his home with simple, locally made furniture.\n\nAfter Carter’s death in 1939, the house was left to the Metropolitan Museum of Art before being transferred to the Egyptian Antiquities Authority. It was later converted into a museum in 2009, offering visitors a glimpse into Carter’s life and work. In 2014, a replica of Tutankhamun’s tomb was installed on the grounds of the house, further enhancing its historical significance.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3593.9600947525914!2d32.63074422514482!3d25.738833209550652!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1449159527b5107d%3A0xc337ad75fd401474!2sCarter%20House!5e0!3m2!1sar!2seg!4v1743166945091!5m2!1sar!2seg",
                Address = "At the entrance to the Valley of the Kings in Qurna, which is about 20 km from Luxor",
                ImageUrl = "AreaImages/Howard Carter's house in Thebes1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 10,
                Name = "Statue of Meritamun (The White Queen)",
                Description = "This magnificent statue represents Queen Meritamun, daughter of Ramesses II and one of his Great Royal Wives. Although her name is missing, her titles match those found on other statues of Meritamun.\n\nMeritamun wears an elaborate royal crown adorned with cobras and sun disks, likely once topped with ostrich feathers. Her detailed wig still retains traces of its original blue color, and she is adorned with golden earrings, an intricate necklace, and bracelets. She holds a 'Menat' necklace, which was used in sacred rituals.\n\nThis statue, a masterpiece of the Nineteenth Dynasty, showcases the elegance and craftsmanship of ancient Egyptian art. It remains one of the most captivating artifacts in the Egyptian Museum in Cairo, highlighting the important role of royal women in ancient Egypt.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3594.2899179637!2d32.59522022514513!3d25.727924410000913!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14493feaaaaaaaab%3A0xc7b832523fb6b163!2sQV66%20Tomb%20of%20Nefertari!5e0!3m2!1sar!2seg!4v1743166992996!5m2!1sar!2seg",
                Address = "Al-Hariri, First Section, Zagazig, Sharkia Governorate",
                ImageUrl = "AreaImages/Statue of Meritamun (The White Queen)1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 11,
                Name = "Sultan Al-Muayyad Sheikh Mosque",
                Description = "It is one of the most important Islamic mosques in Cairo, dating back to the Circassian Mamluk era. It was built by Sultan Al-Mu'ayyad Sheikh Al-Mahmoudi between 818-824 AH / 1415-1421 AD on Al-Mu'izz Li-Din Allah Street, on the ruins of the 'Khazanat Shama'il' prison, named after Prince Alam Al-Din Shama'il, the governor of Cairo during the reign of King Al-Kamil Ayyubi. The reason behind Al-Mu'ayyad building this mosque is that he was imprisoned in that prison before becoming a sultan, so he vowed during his imprisonment that if God saved him and he took over the rule of Egypt, he would build a mosque instead of the prison. Al-Mu'ayyad Sheikh fulfilled his promise, so he demolished the prison and built a congregational mosque after he became sultan of Egypt. When the Ottoman Sultan Selim I visited this mosque, he said about it, 'Truly, it is the building of kings.' The mosque has four facades, the southeastern facade is the main facade, and the main entrance is located at its eastern end. The mosque consists of a courtyard with an ablution fountain in the middle. The courtyard is surrounded by four prayer halls, the largest of which is the Qibla hall. Two domes were built on either side of the Qibla hall, one of which was destroyed and the other remained. Sultan Al-Muayyad and some of his sons were buried in one of these domes, while the other was designated for the women of his family. Al-Muayyad added other facilities to the mosque, including a bathhouse on the western side. He also built the mosque adjacent to Bab Zuweila and used the gate's two towers as bases for the mosque's two minarets, which were built in the Mamluk style and decorated with geometric engravings.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.7703019376445!2d31.260517724989544!3d30.043447018619013!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840a152fdeafd%3A0x3718ccac1489019a!2z2YXYs9is2K8g2KfZhNiz2YTYt9in2YYg2KfZhNmF2KTZitivINi02YrYrg!5e0!3m2!1sar!2seg!4v1743167465206!5m2!1sar!2seg",
                Address = "Ash Sharqiya, Al Darb Al Ahmar, Cairo Governorate",
                ImageUrl = "AreaImages/Sultan Al-Muayyad Sheikh Mosque1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 12,
                Name = "Suleiman Agha Al-Selhadar Mosque",
                Description = "It is located on Al-Muizz Li-Din Allah Street at the entrance to Barjawan Alley. It was built by Suleiman Agha Al-Salhadar, one of the princes of Muhammad Ali Pasha in 1255 AH/1839 AD. The building overlooks Al-Muizz Li-Din Allah Street with its main facade, which is built of stone and ends at the top with a wooden flap decorated with prominent ornaments. Above the door of the mosque is a foundation plaque made of marble, and there is another plaque on the facade of the fountain written in Turkish recording the date of the mosque’s construction and the name of the builder. The mosque consists of a rectangular area divided into two squares. The outer western square includes a central courtyard surrounded by four arcades covered by small, shallow domes resting on marble columns. The courtyard is covered with a wooden ceiling in the middle of which is a sakhshikha to ventilate and illuminate the courtyard. The eastern square is the qibla iwan and consists of three arcades parallel to the qibla wall resting on marble columns. The qibla iwan is covered by a wooden ceiling with simple decorations. In the middle of the qibla wall is a hollow mihrab carved entirely with its dome from a single block of marble, which is unique in its kind. On its sides are gilded marble cornices, and next to the mihrab is a wooden pulpit devoid of decorations. The minaret is located at the top of the main facade next to the mosque door. It is Ottoman in style with a cylindrical body and consists of two levels. The second level is topped by a pointed peak in the shape of a pencil.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.454695799789!2d31.26445152498921!3d30.052498418190112!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458409de2a4b541%3A0x390900d749f0e94d!2z2YXYs9is2K8g2LPZhNmK2YXYp9mGINij2LrYpyDYp9mE2LPZhNit2K_Yp9ix!5e0!3m2!1sar!2seg!4v1743167514862!5m2!1sar!2seg",
                Address = "Bargwan Alley, Al-Gamaliya, Al-Gamaliya District, Cairo Governorate",
                ImageUrl = "AreaImages/Suleiman Agha Al-Selhadar Mosque1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 13,
                Name = "Amr ibn al-Aas Mosque",
                Description = "The Mosque of Amr ibn al-Aas is the oldest and first mosque in Egypt and Africa, and is nicknamed 'the crown of mosques' and is also known as 'the old mosque'. It was built by the great companion Amr ibn al-Aas in 21 AH / 641 AD after he conquered Egypt in 20 AH / 640 AD by order of Caliph Omar ibn al-Khattab. He founded the city of Fustat, the capital of the country at that time.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.933983653723!2d31.23570682499096!3d30.010051920200436!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458477bf9a89023%3A0x8ef380c41130056b!2z2YXYs9is2K8g2LnZhdix2Ygg2KjZhiDYp9mE2LnYp9i1!5e0!3m2!1sar!2seg!4v1743167569420!5m2!1sar!2seg",
                Address = "Al-Kafour, Jamaa Square, Sidi Hassan Al-Anwar, Old Cairo Department, Cairo Governorate",
                ImageUrl = "AreaImages/Amr ibn al-Aas Mosque1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 14,
                Name = "Mosque and School of Al-Nasir Muhammad ibn Qalawun",
                Description = "This school is located on Al-Muizz Li-Din Allah Street (between the two palaces), between the Dome of Sultan Qalawun and the Barquq School. Sultan Al-Adil Zayn al-Din Kitbugha began building it in the Mamluk Bahri era in 695 AH/1296 AD, and Sultan Al-Nasir Muhammad bin Qalawun completed the construction between 698-703 AH/1298-1303 AD.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d55268.26603338604!2d31.337087751367182!3d30.029207700000022!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840aaf5783eff%3A0x834e4a7814322d0f!2z2YXYs9is2K8g2KfZhNmG2KfYtdixINmF2K3ZhdivINio2YYg2YLZhNin2YjZiNmG!5e0!3m2!1sar!2seg!4v1743167623611!5m2!1sar!2seg",
                Address = "Al-Muizz Street",
                ImageUrl = "AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 15,
                Name = "Cemetery and city of workers who built the pyramids",
                Description = "The remains of a large settlement known as Heit el-Ghurab were discovered in the southeastern area of the Giza Plateau, where the workers who participated in building the pyramid complexes of Khafre and Menkaure lived and died. These sites provide insight into the lives of the laborers who constructed the monumental Pyramids of Giza, including the Great Pyramid of Khufu.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d221072.47876625537!2d31.46070071181836!3d30.029470159942164!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145845862c936f9b%3A0xa083538ff13b41a0!2z2YXZgtio2LHYqSDYrdiq2Kgg2K3Ysdiz!5e0!3m2!1sar!2seg!4v1743167673931!5m2!1sar!2seg",
                Address = "Giza Plateau",
                ImageUrl = "AreaImages/Cemetery and city of workers who built the pyramids1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 16,
                Name = "Aswan Cemetery",
                Description = "The Aswan Cemetery, also known as the Fatimid Cemetery, is one of the oldest cemeteries in the Islamic world. Located on the eastern side of the city, it consists of two sections: one in the north and another in the south. The extremely dry climate in Aswan has helped preserve most of the cemetery's tombs and monuments, which date back from the second century AH to the Mamluk era. \n\nThis historic site witnessed the first attempt to build domes on shrines in Egypt during the Fatimid era. Among the most important structures in the cemetery are the Dome of the Seventy-Seven Saints, the Shrine of Sharif Hassan, the Shrine of Sharif Haidera, the Shrine of Abbasa bint Khadij, the Shrine of the Ja'afari Sayyids, the Shrine of Zainab bint al-Hanafiyya, and the Shrine of Lady Amina in the Qibliya Cemetery.\n\nThe Aswan Cemetery is renowned for its distinctive Islamic architecture, including domed tombs and intricately decorated gravestones. It offers valuable insights into medieval Islamic burial customs, artistic traditions, and religious practices. Over the centuries, it has faced challenges such as natural erosion, looting, and urban development. However, ongoing archaeological and preservation efforts aim to protect this significant heritage site.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d29138.866426826015!2d32.913082606209926!3d24.08889199873073!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143665e5059bd627%3A0x641fb67008f8645d!2z2YXZgtin2KjYsSDYp9mE2YbYqNmE2KfYoSAvINmF2YYg2YHZiNmCINin2KjZiCDYp9mE2YfZiNin!5e0!3m2!1sar!2seg!4v1743168005227!5m2!1sar!2seg",
                Address = "Aswan Dam, next to the Nubian Museum in Aswan",
                ImageUrl = "AreaImages/Aswan_Cemetery1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 17,
                Name = "Al-Bajwat Cemetery",
                Description = "The Al-Bajwat Cemetery in Kharga Oasis is considered one of the oldest Christian cemeteries. It comprises around 263 tombs, varying between small individual chambers and large family mausoleums. Built on the ruins of an ancient Egyptian burial site, the tombs incorporate both ancient Egyptian and Coptic artistic styles, reflecting a unique blend of cultural influences. \n\nDating from the 3rd to 7th centuries CE, Al-Bajwat is one of the best-preserved early Christian cemeteries in the world. Many of the mudbrick tombs feature domed structures resembling small chapels, adorned with biblical frescoes and symbols of Christian faith. Notably, the Exodus Shrine contains depictions of Prophet Moses leading the Israelites, alongside scenes of Adam and Eve, Noah’s Ark, Daniel in the lion’s den, and Jonah and the whale. \n\nThe cemetery served as a refuge for persecuted Christians during the Roman era and remained a significant religious site for centuries. Some inscriptions found on the tombs date back to the 9th century AD, including writings by Turkish soldiers stationed there in the 18th century.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.0360424279997!2d31.2659268249899!3d30.035823818980152!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583f57e1436007%3A0x67187c8f5200a1f!2sBab%20El-Wazir%20Cemetery!5e0!3m2!1sar!2seg!4v1743168062284!5m2!1sar!2seg",
                Address = "Darb Al-Arbaeen, Al-Wahat Al-Kharga District, New Valley Governorate",
                ImageUrl = "AreaImages/Al-Bajwat_Cemetery1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 18,
                Name = "Shatby Cemetery",
                Description = "The Shatby Cemetery, located in Alexandria, Egypt, is one of the oldest Greek burial sites in the country. Dating back to the late 4th century BCE, shortly after the city’s founding by Alexander the Great, it reflects early Hellenistic influence in Alexandria. \n\nDiscovered during excavations led by Evaristo Breccia in the early 20th century, the site spans approximately 3,500 square meters. The cemetery was used for about two centuries, providing invaluable insights into Greek settlers' burial customs, architectural styles, and daily life. \n\nExcavations have revealed pottery, coins, figurines, and funerary stelae featuring Greek gods and goddesses, demonstrating the religious beliefs of ancient Alexandrians. The tombs exhibit a mix of Greek and Egyptian cultural elements, characteristic of the Ptolemaic era. \n\nDespite challenges from erosion, urban expansion, and looting, preservation efforts continue to protect this historically significant necropolis. Visitors can explore the rock-cut tombs and artifacts that illustrate Alexandria’s role as a cultural and intellectual hub of the ancient Mediterranean world.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3412.337606107306!2d29.91964072494317!3d31.211374762344256!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c479e8cca49b%3A0x73a9427549426ab3!2z2YXZgtin2KjYsSDYp9mE2LTYp9i32KjZiSDYp9mE2KPYq9ix2YrYqQ!5e0!3m2!1sar!2seg!4v1743168094955!5m2!1sar!2seg",
                Address = "Al-Azareta and Al-Shatby, Bab Sharqi District, Alexandria Governorate",
                ImageUrl = "AreaImages/Shatby_Cemetery1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 19,
                Name = "Sultan Inal's Bath",
                Description = "Artifact No. 562 Sultan Inal ruled Egypt from 1453 to 1461 CE during the Mamluk Sultanate, a powerful dynasty that controlled Egypt and parts of the Levant. He commissioned various architectural projects, including mosques, madrasas (Islamic schools), and this bathhouse. The construction of the hammam was part of Sultan Inal’s efforts to enhance the infrastructure and urban life of Cairo. Inal’s Bath was designed to reflect both the practical and aesthetic values of the time, incorporating advanced engineering techniques for water heating and distribution, as well as artistic elements like colorful tiles and geometric patterns. Like many historical hammams in Cairo, Sultan Inal’s Bath has suffered from neglect and urban development over the centuries. However, efforts have been made to preserve the structure and its unique architectural features. Conservation projects aim to stabilize the building, restore damaged areas, and document its historical significance. Sultan Inal’s Bath is a remarkable example of Mamluk-era public architecture that highlights the importance of hygiene, social life, and architectural innovation in medieval Cairo. Its traditional layout, advanced heating system, and role as a social hub make it a fascinating part of Egypt’s Islamic heritage. Though time has taken its toll on the structure, its historical and cultural significance endures as a symbol of the grandeur of the Mamluk Sultanate. Today, remnants of the hammam still stand as a testament to Cairo’s rich Mamluk heritage. Though it is no longer in operation as a functioning bathhouse, it remains an important historical site that reflects the advanced engineering and artistic achievements of the Mamluk period. The Hammam Sultan Inal (Sultan Inal’s Bath) is a historic Mamluk-era bathhouse located in Cairo, Egypt. Built during the 15th century by Sultan Al-Ashraf Inal, this hammam (public bath) is an architectural gem that showcases the advanced water and heating systems, intricate decoration, and social significance of bathhouses during the Mamluk period. It served not only as a place for bathing but also as a center for relaxation, social gatherings, and purification rituals. Built by Sultan Al-Ashraf Abu Al-Nasr Saif Al-Din Inal in 861 AH/1456 AD as part of the social welfare facilities serving the public in the Mamluk era, Sultan Inal's bath follows the layout of Islamic baths. It consists of a broken entrance leading to the cold room, where clothes are changed to prepare for bathing, interspersed with a number of seats for sitting and cabinets for storing personal belongings. The bather then moves to the warm room to drink and relax before entering the hot room, 'the bathtub.' The exit follows the reverse path to gradually adjust body temperature upon leaving. The Muslim architect used shallow domes in both the cold and hot rooms to maintain the circulation of hot air, and the domes were also provided with colored glass openings to illuminate the place. Water flows into the bathhouse through a well connected to a waterwheel that lifts water to the stove behind the bath. Garbage was collected as fuel, and a fire was lit to heat the water in a huge pot, which was then pumped to different rooms through a system of clay pipes and metal taps.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.525252133822!2d31.263979924989208!3d30.05047511828588!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458416c217f9305%3A0x3a9e4d581188a101!2sHammam%20InaL!5e0!3m2!1sar!2seg!4v1743168741604!5m2!1sar!2seg",
                Address = "Al-Muizz Street",
                ImageUrl = "AreaImages/Sultan Inal's Bath1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 20,
                Name = "Syriac Monastery",
                Description = "Built in the 6th century AD, this monastery was named after the many Syrian monks who lived there over the centuries. The Syriac Monastery, also known as Deir al-Surian, is one of the most ancient and historically significant monasteries in Egypt. Located in Wadi El Natrun (Nitria Valley) in the Western Desert, it dates back to the 6th century CE and has served as an important religious, cultural, and spiritual center for both Coptic and Syriac Christians. This monastery is renowned for its ancient manuscripts, beautiful frescoes, and rich history, reflecting the deep ties between the Egyptian Copts and the Syriac Christian community. The main church in the monastery is dedicated to the Virgin Mary and contains magnificent murals. The sanctuary is topped by a dome decorated with biblical scenes, including the birth of Jesus Christ. The Syriac Monastery was established during the early Christian period when monasticism was flourishing in Egypt. It is believed to have been founded by Coptic monks but later became closely associated with the Syriac Orthodox Church after a community of Syriac monks settled there in the 8th century CE. These monks brought with them a rich collection of Syriac manuscripts and contributed to the monastery’s unique cultural blend. Monastic life at Deir al-Surian is characterized by prayer, fasting, and manual labor, in keeping with the traditions of early Christian monasticism. The monastery follows the Rule of St. Pachomius, one of the founders of communal monastic life in Egypt. Deir al-Surian is part of the monastic complex in Wadi El Natrun, which also includes the Monastery of St. Macarius, the Monastery of St. Bishoy, and the Monastery of the Romans (Deir al-Baramus). Visitors can explore the ancient church, admire the beautiful frescoes, and learn about the rich history of Syriac and Coptic Christianity.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3444.164561332737!2d30.357360024978952!3d30.317836705566812!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458c7db4896a56b%3A0x638e12d10c89685c!2z2K_ZitixINin2YTYs9mK2K_YqSDYp9mE2LnYsNix2KfYoSAtINin2YTYs9ix2YrYp9mG!5e0!3m2!1sar!2seg!4v1743168820140!5m2!1sar!2seg",
                Address = "Deir El-Seryan Road, Wadi El-Natrun Center, Beheira Governorate",
                ImageUrl = "AreaImages/Syriac Monastery1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 21,
                Name = "The Way and the Writers of Nafisa Al-Bayda",
                Description = "Nafisa al-Bayda was the wife of Ali Bey al-Kabir, who built this architectural complex in 1211 AH/1796 AD. After his death, she married Murad Bey, a Mamluk leader and cavalry commander. Nafisa Al-Bayda was a prominent figure in 18th-century Egypt, known for her influence, charitable works, and intellectual patronage during the Ottoman period. She supported Sufi spirituality and was associated with notable writers, poets, and scholars of her time. The complex consists of an agency, a fountain providing water to passersby, and a kuttab (school) for Quran memorization. The Ottoman-style fountain features a semi-circular facade overlooking Al-Muizz Street, adorned with geometric decorations and an inscribed marble panel. Above it, the kuttab features three arches supported by marble columns.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.784118240728!2d31.26061132498965!3d30.043050718637737!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458414274b5574d%3A0x7b96a64b0c7a1057!2z2LPYqNmK2YQg2Ygg2YPYqtin2Kgg2YbZgdmK2LPYqSDYp9mE2KjZiti22KfYoQ!5e0!3m2!1sar!2seg!4v1743168960995!5m2!1sar!2seg",
                Address = "Al-Muizz Street",
                ImageUrl = "AreaImages/The Way and the Writers of Nafisa Al-Bayda1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 22,
                Name = "Palace of King Amenemhat III",
                Description = "In 1960, archaeologist Shafiq Farid discovered the remains of a large mud-brick palace dating back to the 12th Dynasty (c. 1985-1795 BC) during the Middle Kingdom. Archaeologists Ahmed El-Sawy and Mohamed Ibrahim Bakr continued excavations in the late 1970s, 1980s, and 1990s. The Palace of King Amenemhat III, often referred to as the 'Labyrinth' by ancient historians, was one of the most magnificent and mysterious architectural wonders of ancient Egypt. This palace complex, located near the pyramid of Amenemhat III at Hawara in the Faiyum region, served as a royal residence and an administrative and religious center. The Labyrinth’s influence extended beyond Egypt, inspiring legends and myths in ancient Greek and Roman culture. However, much of it was lost due to natural decay and reuse of materials in later periods. Today, archaeological efforts continue to explore its remains and uncover its secrets.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.5239444763924!2d31.264469024989392!3d30.05051261828416!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458409e382964cb%3A0x135fafc35a85a8a9!2z2YLYtdixINin2YTYo9mF2YrYsSDYqNi02KrYp9mD!5e0!3m2!1sar!2seg!4v1743169423692!5m2!1sar!2seg",
                Address = "Hawara, near Fayoum Governorate, Egypt",
                ImageUrl = "AreaImages/Palace_of_King_Amenemhat1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 23,
                Name = "Mohamed Ali Palace in Shubra",
                Description = "The palace of Muhammad Ali Pasha (1805-1848 AD), the founder of modern Egypt, is a rare architectural masterpiece that combines elements of European decoration with the spirit of Islamic architecture. Construction began in 1808 and was completed in 1821. The palace extends over 50 acres overlooking the Nile in Shubra El-Kheima. It includes several buildings such as the Residence Palace, Fountain Palace, and Gabalaya Kiosk. It also witnessed the introduction of Egypt’s first modern lighting system. After years of neglect, restoration efforts have been made since 2018 to preserve its historical and artistic value. Today, it stands as a testament to Mohamed Ali Pasha’s vision and Egypt’s transition into modernization.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3451.238634157603!2d31.248149424986835!3d30.115984315178665!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14586aa72d17210f%3A0x8a9efa84a2e58300!2sMohamed%20Ali%20Palace!5e0!3m2!1sar!2seg!4v1743169487100!5m2!1sar!2seg",
                Address = "Nile Corniche, Shubra El-Kheima, Qalyubia Governorate",
                ImageUrl = "AreaImages/Mohamed_Ali_Palace_in_Shubra1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 24,
                Name = "Church of the Burning Bush",
                Description = "The Church of the Burning Bush, located within Saint Catherine's Monastery at Mount Sinai, is one of the world’s most revered religious sites. According to biblical tradition, this is where God spoke to Moses through the burning bush. Built by Empress Helena in the 4th century AD and later expanded by Emperor Justinian I, the church is part of a UNESCO World Heritage Site. It remains a major pilgrimage site and a center of Christian monasticism, attracting visitors and scholars worldwide. The sacred bush still thrives within the church, symbolizing divine presence and spiritual devotion.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3504.459781765063!2d33.978622925046096!3d28.555953087555167!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1454901def4fa789%3A0xc91f754605c6dadf!2z2K_ZitixINiz2KfZhtiqINmD2KfYqtix2YrZhg!5e0!3m2!1sar!2seg!4v1743169557612!5m2!1sar!2seg",
                Address = "Saint Catherine’s Monastery, Sinai Peninsula, Egypt",
                ImageUrl = "AreaImages/Church_of_the_Burning_Bush1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 25,
                Name = "Sultan Al-Ghouri Group",
                Description = "The Sultan Al-Ghouri Complex, built by Mamluk Sultan Al-Ashraf Qansuh Al-Ghouri (1501–1516 AD), is one of Cairo’s most impressive architectural ensembles. Located on Al-Muizz Street, it consists of a mosque, madrasa, mausoleum, khanqah, and sabil-kuttab. The complex reflects Mamluk grandeur with its intricate designs and monumental structures. It has undergone restoration efforts to preserve its rich Islamic heritage. Today, it is a cultural and historical landmark, hosting Sufi music performances and providing insight into Mamluk-era architecture and traditions.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6835549282987!2d31.26291262498955!3d30.04593511850112!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840a1b34e3689%3A0x4c7bb2bf8b519c9d!2z2YXYrNmF2YjYudipINin2YTYs9mE2LfYp9mGINin2YTYo9i02LHZgSDYp9mE2LrZiNix2Yo!5e0!3m2!1sar!2seg!4v1743169623788!5m2!1sar!2seg",
                Address = "Al-Muizz Street, Cairo, Egypt",
                ImageUrl = "AreaImages/Sultan_Al-Ghouri_Group1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 26,
                Name = "Sultan Qaitbay Complex in the Mamluk Desert",
                Description = "The Sultan Qaitbay Complex is one of the most magnificent Islamic architectural structures, representing the power and greatness of the Mamluk state in Egypt, as it contains all the unique architectural features that were known for the era of the Circassian Mamluks. It was built by the Mamluk Sultan Ashraf Qaitbay in 877-879 AH / 1472-1474 AD, and is located in the Mamluk Desert area, Cairo Governorate. The Sultan Qaitbay Complex is a monumental Mamluk architectural ensemble located in the Northern Cemetery, also known as the Mamluk Desert Cemetery, on the outskirts of historic Cairo.Built by Sultan Al - Ashraf Qaitbay in the late 15th century, this complex stands as a stunning example of Mamluk artistry, combining religious, educational, and funerary functions.The complex consists of a mosque, madrasa(Islamic school), khanqah(Sufi lodge), and the mausoleum of Sultan Qaitbay himself. This complex consists of a school, a fountain, a Quran memorization school for poor Muslims,and a cemetery for the family of Sultan Qaitbay. Sultan Al - Ashraf Qaitbay was one of the most prominent Mamluk sultans, ruling Egypt from 1468 to 1496 CE.His reign was marked by relative stability,economic prosperity, and a flourishing of art and architecture.Sultan Qaitbay was a great patron of architecture and commissioned numerous buildings, including mosques, fortresses(such as the famous Qaitbay Citadel in Alexandria), and public works. Over the centuries, the Sultan Qaitbay Complex faced challenges, including neglect, urban encroachment, and environmental damage. However, it has undergone extensive restoration efforts aimed at preserving its architectural and artistic heritage.The Sultan Qaitbay Complex in the Mamluk Desert is a magnificent symbol of Mamluk art, architecture, and religious devotion. Its intricate designs, innovative structures, and rich historical legacy continue to inspire admiration and reflect the grandeur of the Mamluk Sultanate during its twilight years. Visitors to the complex can explore its beautifully restored mosque, mausoleum, and other structures, gaining a deeper appreciation for the architectural brilliance and cultural achievements of late medieval Egypt. Today, the complex is part of the Historic Cairo UNESCO World Heritage Site and is a popular destination for tourists, scholars, and pilgrims interested in Mamluk history and architecture. The Sultan Qaitbay Complex in the Northern Cemetery was built between 1472 and 1474 CE and served as a religious, educational, and funerary center. The choice of location in the City of the Dead reflected the Mamluk tradition of building grand funerary complexes in desert cemeteries on the outskirts of Cairo.The school is one of the most important structures in the complex, as the building engineer was keen to apply harmony and symmetry in all the architectural and artistic details of the school, as each side of the school is similar to what is opposite it on the other side. The school consists of a central courtyard surrounded by four iwans. The most important features of the school are the main entrance decorated with colored marble and various inscriptions, the entrance door decorated with openwork copper works, and its graceful and beautiful minaret bearing the name of the muezzin at its entrance, as the school’s muezzin was skilled in stone engraving. The school also contains exquisitely crafted woodwork, including a wooden pulpit and a chair for the Qur’an, both inlaid with ivory, and the wooden sashkhiya in the middle of the school’s ceiling with its beautiful golden decorations. The sabil and the kuttab are located to the left of the school entrance, and the sabil is distinguished by its floor covered with colored marble pieces.",
                   Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13815.019585297008!2d31.29405441284179!3d30.0438889!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583f681d72ee8b%3A0xfcfe00283c33470b!2z2YXYs9is2K8g2KfZhNiz2YTYt9in2YYg2KfZhNij2LTYsdmBINmC2KfZitiq2KjYp9mK!5e0!3m2!1sar!2seg!4v1743169747498!5m2!1sar!2seg",
                   Address = "Cairo",
                   ImageUrl = "AreaImages/Sultan Qaitbay Complex in the Mamluk Desert1.jpg",
                   AreaTypeId = 1,
                    Latitude=null,
               Longitude=null
              },
            new Area
            {
                Id = 27,
                Name = "Step Pyramid of Djoser",
                Description = "The Step Pyramid of King Djoser is one of the most famous monuments in Egypt, and represents an important historical turning point in ancient Egyptian funerary monuments, and is considered a revolution in stone architecture and royal burial. In addition to its massive size, it is the first pyramid built by the ancient Egyptians and the oldest known stone structure. The Step Pyramid of Djoser, located in Saqqara,Egypt, is one of the most important monuments in the history of architecture and ancient Egyptian civilization.It is considered the world’s first large - scale stone structure and the earliest pyramid built in Egypt.This iconic structure was constructed during the 27th century BCE, during the reign of Pharaoh Djoser(also spelled Zoser), the second king of Egypt’s Third Dynasty. Pharaoh Djoser ruled Egypt during the Old Kingdom period(c. 2670 BCE – 2640 BCE).His reign was marked by political stability and architectural innovation.The Step Pyramid was designed by Imhotep, a brilliant architect, engineer, and high priest,who is often credited as the world’s first known architect.Imhotep’s innovative design marked a significant departure from the traditional mastaba tombs used to bury earlier pharaohs The Step Pyramid was not just a tomb but a symbol of Djoser’s divine power and eternal life.It was designed to protect the king’s body and serve as a gateway for his soul to ascend to the heavens.The pyramid’s stepped design likely represented a stairway to the afterlife,aligning with ancient Egyptian beliefs about the journey of the pharaoh’s soul. The Step Pyramid of Djoser is credited to Imhotep, who was later deified for his contributions to architecture, medicine, and science.Imhotep’s innovative use of stone construction and his ambitious vision set a precedent for the later pyramids, including the famous pyramids at Giza. Over the millennia, the Step Pyramid suffered from natural erosion, earthquakes, and neglect.However, it has undergone extensive restoration efforts to stabilize its structure and preserve its historical integrity. The Step Pyramid of Djoser remains one of Egypt’s most iconic monuments and a must - visit site for tourists and history enthusiasts.Visitors can explore the pyramid and its surrounding complex, gaining insight into ancient Egyptian beliefs,architectural innovations,and the legacy of Pharaoh Djoser Imhotep. The site offers a fascinating glimpse into the early stages of pyramid construction and the religious and cultural practices of the Old Kingdom of Egypt.In 2020,after a lengthy restoration process, the Step Pyramid was reopened to the public, allowing visitors to explore its magnificent architecture and learn about its historical significance. The Step Pyramid also marked a shift in royal ideology, emphasizing the pharaoh’s divine status and his role as a mediator between the gods and the people. The surrounding complex, with its ceremonial spaces and chapels, was intended to support the king’s continued spiritual existence and provide a setting for offerings and rituals The Step Pyramid was constructed as a royal burial complex and intended to ensure Djoser’s journey to the afterlife, in keeping with ancient Egyptian beliefs about death and rebirth. The construction of the Step Pyramid dates back to the beginning of the Third Dynasty, during the reign of King Netrekht (c. 2667-2648 BC), now known as Djoser, which is more commonly known. Before his reign, Egyptian kings and elite were buried in mastabas, the term mastabas refers to a type of funerary building that was generally rectangular in shape and built over a burial shaft, which was underground. The Step Pyramid consists of six mastabas that give it a stepped shape, and the architect Imhotep was the owner of this great innovation. At one end of the pyramid complex is a building known as the Southern Tomb, which is a symbolic tomb for King Djoser, perhaps reflecting his role as king of Upper and Lower Egypt. The pyramid complex contains some distinctive elements. The courtyard in front of the pyramid was used for the Sed festival, a celebration symbolizing the king's rejuvenation and renewal of his strength. The stone shrines on the eastern side of the courtyard were used for this celebration, ensuring that the king would remain eternally rejuvenated.",
                   Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3459.757452320796!2d31.219349924996337!3d29.87126802675601!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584bd553b25c81%3A0x8c577a7fabef89d!2z2KfZhNmH2LHZhSDYp9mE2YXYr9ix2Kw!5e0!3m2!1sar!2seg!4v1743169931834!5m2!1sar!2seg",
                   Address = "Saqqara",
                   ImageUrl = "AreaImages/Step Pyramid of Djoser1.jpeg",
                   AreaTypeId = 1,
                    Latitude=null,
               Longitude=null
              },
            new Area
            {
                Id = 28,
                Name = "Sultan Al-Ghouri School",
                Description = "Sultan Qansuh al-Ghuri is the creator of this architectural complex; he is one of the most famous sultans of the Circassian Mamluk state. He assumed the rule of Egypt in 906 AH / 1501 AD, and remained on the throne of the Sultanate until he was killed in the Battle of Marj Dabiq north of Aleppo in Syria by the Ottomans in 922 AH / 1516 AD.The Madrasa of Sultan Al - Ghouri, located in the historic district of Al - Azhar in Cairo, is a remarkable Mamluk architectural structure built during the reign of Sultan Al - Ashraf Qansuh Al - Ghouri,the last Mamluk Sultan of Egypt.This madrasa(Islamic school) was part of a larger religious and cultural complex constructed between 1503 and 1505 CE,near the end of the Mamluk Sultanate.The complex includes a mosque,mausoleum,sabil - kuttab(water dispensary and Quran school),and khanqah(Sufi lodge). Sultan Qansuh Al - Ghouri ruled Egypt from 1501 to 1516 CE,during a time of political and military challenges, including increasing threats from the Ottoman Empire.Despite these challenges, Al - Ghouri was a patron of the arts and architecture, and he commissioned many grand structures in Cairo.His madrasa and mosque complex is one of the most significant surviving monuments of late Mamluk architecture. The Madrasa of Sultan Al - Ghouri was not just a center for Islamic education but also a symbol of Sultan Al - Ghouri’s piety,power,and patronage of the arts.The architectural elements, including the ornate decorations and monumental scale, reflect the Mamluk emphasis on religious devotion, royal authority,and artistic achievement. Over the centuries, the Madrasa of Sultan Al - Ghouri faced challenges due to neglect,urban encroachment, and environmental factors.However,it has undergone restoration efforts aimed at preserving its architectural heritage and cultural significance.Today, the madrasa is part of the Historic Cairo UNESCO World Heritage Site and remains an important site for tourists, scholars, and worshippers The complex also had a funerary function, as it included a mausoleum intended to house the tomb of Sultan Al - Ghouri.However,Al - Ghouri was killed in battle against the Ottomans in 1516,and his body was never recovered. The madrasa served as a center for Islamic education,where students studied Quranic recitation, Islamic law(fiqh),Hadith(sayings of the Prophet Muhammad),and other religious sciences.It also functioned as a place of worship and a hub for Sufi practices.Visitors to the Madrasa of Sultan Al - Ghouri can explore its stunning architectural features, including the central courtyard,iwans, sabil - kuttab,and entrance portal.The site offers a fascinating glimpse into the religious,educational,and artistic traditions of the Mamluk era and provides a deeper understanding of Cairo’s rich historical and cultural heritage.The madrasa also hosts cultural events,including Sufi music performances,which revive its historical role as a hub for spiritual and cultural activities. This complex was established during the period between 909 - 910 AH / 1503 - 1504 AD, and it is a unique architectural model in terms of location and architectural design in one of the most beautiful architectural complexes in Cairo. The complex includes a mosque for prayer and a school for teaching jurisprudence and hadith,opposite it is a dome of a shrine and a khanqah for Sufis,a water fountain for passersby, a school for memorizing the Qur’an, a seat and a residential house.The two ends of the al - Ghuri complex are connected by a wooden shed,under which is a market for textiles and clothing.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.601615018207!2d31.262865374989325!3d30.04828516838976!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145838a718462963%3A0x29ebc7ba0f8d8b3e!2z2YXYr9ix2LPYqSDZiCDZgtio2Kkg2KfZhNiz2YTYt9in2YYg2KfZhNmG2KfYtdixINmF2K3ZhdivINio2YYg2YLZhNin2YjZhg!5e0!3m2!1sar!2seg!4v1743170212406!5m2!1sar!2seg",
                Address = "Al-Muizz Street",
                ImageUrl = "AreaImages/Sultan Al-Ghouri School1.jpg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 29,
                Name = "School, Mausoleum and Hospital of Al-Mansur Qalawun",
                Description = "The architectural complex is located in the Al-Muizz li-Din Allah Shrine, and was built by Sultan Al-Mansur Sayf al-Din Qalawun in 683-684 AH/1283-1284 AD. It is one of the most beautiful architectural complexes in the Bahri Mamluk era. It consists of a mosque for prayer, a school for education, a burial dome, and a hospital (a Persian word that means in Arabic the house of the sick). The architectural complex contained entrances that were distinguished by their great artistic richness in the use of silver and gold in their cladding and decoration with plant, animal, and geometric shapes. Therefore, this architectural masterpiece occupies a prominent position among the Islamic monuments in Cairo. The hospital was established to treat nervous and psychological diseases, and it still operates as an ophthalmology and dental hospital.The Complex of Sultan Al - Mansur Qalawun is one of the most remarkable monuments in Islamic Cairo and a masterpiece of Mamluk architecture.It was built in 1284 - 1285 CE by Sultan Al - Mansur Qalawun,the seventh Sultan of the Mamluk Dynasty, and is located on Al - Muizz Street, Cairo’s historic and architectural heart.The complex consists of three main structures: a school(madrasa), a mausoleum, and a hospital(bimaristan). Sultan Al - Mansur Qalawun rose to power after a series of political and military successes, including the defeat of the Crusaders at Acre.During his reign(1280–1290 CE),Qalawun focused on strengthening Egypt’s political, military, The Complex of Al - Mansur Qalawun is considered one of the finest examples of Mamluk architecture,with its elaborate decorations,innovative design,and multifunctional purpose.Each structure within the complex has unique architectural and functional elements The complex was built on the site of a former Fatimid palace, symbolizing the transition of power from the Fatimid Caliphate to the Mamluks.It was completed in just 13 months, showcasing the skill and dedication of the Mamluk architects and craftsmen.",
                   Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.5597807288136!2d31.26366302498936!3d30.04948491833286!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145838a718462963%3A0x29ebc7ba0f8d8b3e!2z2YXYr9ix2LPYqSDZiCDZgtio2Kkg2KfZhNiz2YTYt9in2YYg2KfZhNmG2KfYtdixINmF2K3ZhdivINio2YYg2YLZhNin2YjZhg!5e0!3m2!1sar!2seg!4v1743170367595!5m2!1sar!2seg",
                   Address = "Al-Muizz Street",
                   ImageUrl = "AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun1.jpeg",
                   AreaTypeId = 1,
                    Latitude=null,
               Longitude=null
              },
            new Area
            {
                Id = 30,
                Name = "School and Khanqah of Sultan al-Zahir Barquq",
                Description = "It was built by Sultan Al-Zahir Barquq between 786-788 AH/1384-1386 AD. This complex is located on Al-Muizz Street and is in the middle of one of the largest architectural heritage complexes in the world. The facility has charitable religious functions, as it was used as a school to teach the four schools of jurisprudence and a mosque and a khanqah for Sufis. It has a domed shrine where his father and a number of his wives and sons were buried. The school consists of an open courtyard surrounded by four iwans, the largest of which is the southeastern iwan, which contains a marble mihrab, a wooden pulpit, a chair for the Qur’an, and a preacher’s bench. The facility also includes Sufi floors, student rooms, a kitchen, a bathroom, and a pen for animals as service facilities for the school. The entrance facade is topped by a minaret with a Mamluk-style top. The facility is a magnificent architectural masterpiece with all its architectural and decorative elements. The facility is distinguished by its Naskh scriptures containing Quranic verses, the name of the builder and the date of construction. It is also distinguished by its coloured marble cladding and the ceiling of the Qibla Iwan with its wonderful decorations.The School and Khanqah of Sultan Al - Zahir Barquq is an iconic Mamluk structure located in the historic district of Al - Muizz Street in Islamic Cairo.Built between 1384 and 1386 CE during the reign of Sultan Al - Zahir Barquq,the structure served as a madrasa(Islamic school) and a khanqah(Sufi lodge). It is a stunning example of Mamluk architecture, showcasing the grandeur, religious devotion, and architectural expertise of the period. Sultan Al - Zahir Barquq was the first sultan of the Burji Mamluk dynasty,which succeeded the Bahri Mamluks.He ruled Egypt during a turbulent time but managed to consolidate power and establish a stable reign.Barquq was a patron of the arts,architecture, and education, and he commissioned this religious and educational complex to demonstrate his authority and piety.The School and Khanqah of Sultan Al - Zahir Barquq symbolized the sultan’s piety,power,and support for Islamic education and Sufi practices.It also reflected the Mamluk emphasis on monumental architecture as a means of asserting royal authority and securing spiritual rewards.Over the centuries, the School and Khanqah of Sultan Al - Zahir Barquq faced challenges due to neglect, urban encroachment, and environmental factors. However, it has undergone several restoration efforts, most notably in the 20th and 21st centuries, to preserve its architectural beauty and historical significance. Today, it is part of the Historic Cairo UNESCO World Heritage Site and remains a major tourist attraction. Visitors to the School and Khanqah of Sultan Al - Zahir Barquq can explore its stunning architectural features,including the central courtyard, iwans, mihrab, minbar, and dome.The site offers a fascinating glimpse into the religious, educational, and architectural traditions of the Mamluk period and provides a deeper understanding of Cairo’s rich historical and cultural heritage.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6945941185363!2d31.283178603210448!3d30.045618500000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583f697536c5e9%3A0xdb6e5ab109258975!2z2YXYr9ix2LPYqSDYp9mE2LPZhNi32KfZhiDYqNix2YLZiNmC!5e0!3m2!1sar!2seg!4v1743170483571!5m2!1sar!2seg",
                Address = "Sultan Al-Zahir Barquq Mosque, Al-Muizz li-Din Allah Al-Fatimi, Al-Gamaleya, Al-Gamaleya District, Cairo Governorate",
                ImageUrl = "AreaImages/School and Khanqah of Sultan al-Zahir Barquq1.jpeg",
                AreaTypeId = 1,
                 Latitude=null,
               Longitude=null
            },
            //Archaeological sites: 20 31:50 
            new Area
            {
                Id=31,
                Name="The Pyramids of Giza and the Sphinx",
                Description="The Pyramids of Giza and the Sphinx are among the greatest archaeological landmarks in the world, serving as a living testament to the ingenuity of the ancient Egyptians in architecture and astronomy. This majestic complex is located on the Giza Plateau, west of the Nile River, near the capital, Cairo. These pyramids were built during the Old Kingdom (Fourth Dynasty, around 2580-2500 BC) as royal tombs for the pharaohs and were part of vast funerary complexes designed to ensure the kings' afterlife. The pyramids were not merely tombs but symbols of the pharaoh's divine power and his connection to the gods.They were meticulously designed, reflecting the ancient Egyptians' advanced knowledge of astronomy and mathematics. Researchers believe that the workers who built them were not slaves but rather teams of skilled artisans and farmers who worked on the project during the Nile’s flood season when agriculture was halted. The method of constructing the pyramids remains a mystery, but theories suggest that they used long ramps or sleds moistened with water to reduce friction while dragging the massive stones.",
                Location = "https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d13824.79127303692!2d31.123623047963367!3d29.9737444372732!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1sThe%20Pyramids%20of%20Giza%20and%20the%20Sphinx!5e0!3m2!1sen!2seg!4v1743173329265!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/1000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=32,
                Name="Karnak Temple",
                Description="The Karnak Temple is one of the greatest religious complexes of the ancient world, serving as a unique testament to the grandeur of ancient Egyptian civilization and its architectural and religious prowess. Located in the city of Luxor, on the eastern bank of the Nile River, it was known in ancient times as IpeSut, meaning The Most Selected of Places. Its construction began during the Middle Kingdom, but it underwent significant expansions over more than 2,000 years, with contributions from many pharaohs, especially those of the New Kingdom, such as Thutmose I, Hatshepsut, and Ramses II. The Karnak Temple was dedicated to the worship of the god Amun-Ra, the principal deity of ancient Egypt, alongside his wife Mut and their son Khonsu, forming what is known as the Theban Triad. The temple is an immense complex that includes many pylons and subsidiary temples.One of its most prominent structures is the Great Pylon, built by Pharaoh Nectanebo I, which leads to the Avenue of Sphinxes—an avenue lined with sphinx statues with ram heads.This path connected Karnak to the Luxor Temple and was used during grand religious festivals such as the Opet Festival.Inside the temple, the famous Hypostyle Hall stands as a true architectural marvel. It contains 134 massive columns adorned with intricate carvings depicting victories and religious ceremonies, with some columns reaching about 23 meters in height, creating a majestic scene that reflects the power and ambition of the pharaohs who oversaw its construction.",
                Location= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3594.564499871422!2d32.65469537485459!3d25.71883941037597!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1449159228fec0cd%3A0xc71ae8c008c259d8!2sKarnak!5e0!3m2!1sen!2seg!4v1743173652819!5m2!1sen!2seg",
                Address= "Luxor",
                ImageUrl= "AreaImages/14000.jpg",
                AreaTypeId= 2,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=33,
                Name="Valley of the Kings",
                Description="The Valley of the Kings is one of the most significant archaeological sites in Egypt and the world. It served as the principal royal burial ground for the pharaohs of the New Kingdom (18th, 19th, and 20th Dynasties), who ruled Egypt between the 16th and 11th centuries BCE. The valley is located on the west bank of the Nile near the city of Luxor and is part of the sacred Theban mountains. It was chosen as a burial site due to its natural landscape, which provided protection against tomb robbers and environmental factors. The valley contains more than 60 tombs carved into the rock, some of which feature beautifully preserved decorations and colorful inscriptions depicting scenes of daily life, religious rituals, and the journey to the afterlife according to ancient Egyptian beliefs. The primary reason for selecting the Valley of the Kings as a burial site was to safeguard the tombs from looting.Unlike the pyramids, which were highly visible and frequently plundered, these tombs were carved into remote cliffs to keep them hidden.Despite these precautions, most of the tombs were eventually robbed, with the notable exception of King Tutankhamun's tomb, which was discovered intact by British archaeologist Howard Carter in 1922. This discovery provided the world with a rare glimpse into the wealth of the pharaohs and their beliefs regarding the afterlife.The tombs in the valley vary in complexity; some are small and simple, while others, such as the tombs of Ramesses VI and Thutmose III, are intricately decorated with detailed inscriptions from funerary texts like the Book of the Dead, the Book of Gates, and the Book of Caverns.These texts were intended to guide the pharaoh’s soul on its journey to the afterlife.One of the most magnificent tombs is that of Seti I, renowned for its vibrant paintings and deeply carved inscriptions. In modern times, the Valley of the Kings has become a major destination for tourism and archaeological studies, with ongoing excavations continuously revealing new secrets.Despite the passage of thousands of years, the valley remains a testament to the architectural brilliance of the ancient Egyptians and their profound concern with the afterlife, reflecting their meticulous preparations for eternity.",
                Location="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d57512.99508324119!2d32.61607041810255!3d25.71891575935775!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1z2YjYp9iv2Yog2KfZhNmF2YTZiNmD!5e0!3m2!1sen!2seg!4v1743173975357!5m2!1sen!2seg",
                Address="Cairo",
                ImageUrl="AreaImages/29000.jpg",
                AreaTypeId=2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 34,
                Name = "Baron Empain Palace",
                Description = "Baron Empain Palace is one of Egypt’s most unique and mysterious architectural landmarks, located in Heliopolis, Cairo. This palace, inspired by Hindu and Khmer architecture, was built by Baron Édouard Empain, a Belgian industrialist and the founder of Heliopolis, in the early 20th century. Its design, heavily influenced by Indian temples such as Angkor Wat in Cambodia, makes it a rare example of Indo-European architecture in Egypt.Architectural Design of the PalaceConstructed between 1907 and 1911,the palace was designed by French architect Alexandre Marcel and features intricate Hindu and Buddhist motifs.The palace is made of reinforced concrete and is adorned with sculptures of mythical creatures,elephants,serpents,and deities.One of its most fascinating features is its rotating tower,which was designed to turn 360 degrees to provide a panoramic view of the city.The palace consists of two floors and a rooftop terrace,with beautifully carved columns and large windows that allow natural light to enter.The interiors were once decorated with Italian marble,Belgian wood,and exquisite murals,giving it a luxurious and mystical ambiance.Historical Significance and LegendsOver the decades,the Baron’s Palace became surrounded by mystery and legends,with many locals believing it was haunted due to its eerie appearance and abandonment for many years.Stories of ghost sightings and supernatural events have added to its intrigue,making it a subject of fascination and speculation.After Baron Empain’s death,the palace changed ownership multiple times,eventually falling into neglect.However,due to its historical and architectural value,it was restored and reopened to the public in 2020 as a museum showcasing the history of Heliopolis and the Baron himself.Baron Palace TodayToday, the palace is a major tourist attraction, drawing visitors interested in its unique architecture, rich history, and mysterious reputation. It hosts exhibitions, cultural events, and guided tours that provide insight into Heliopolis’ foundation and early 20th-century Cairo’s elite lifestyle. The restoration has revived the palace’s former grandeur, making it one of the most remarkable landmarks in Egypt.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d110520.96076000192!2d31.16510309224626!3d30.043168163470174!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583e21f28cf1d7%3A0x30bcfb14f962d52c!2sBaron%20Empain%20Palace!5e0!3m2!1sen!2seg!4v1743175902981!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/800000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 35,
                Name = "Philae Temple",
                Description = "The Temple of Philae is one of the most stunning and well-preserved temples of ancient Egypt, dedicated primarily to the goddess Isis, the mother of Horus and the wife of Osiris. Located on Philae Island in the Nile near Aswan, the temple complex was an important religious and cultural center during the Ptolemaic and Roman periods. Due to its significance, it continued to be a place of worship even after the decline of the ancient Egyptian civilization, with some of its structures later converted into early Christian churches.The temple is renowned for its exquisite carvings and elegant architecture, reflecting the grandeur of Ptolemaic temple construction.Its entrance is marked by a massive pylon adorned with reliefs depicting Pharaoh Ptolemy XII offering sacrifices to the gods.Inside,the temple features a series of halls, sanctuaries, and courtyards, each bearing intricate reliefs portraying the myths of Isis and Osiris, including the resurrection of Osiris and the divine birth of Horus. One of the most remarkable aspects of the Temple of Philae is its relocation in the 20th century.When the Aswan High Dam was constructed in the 1960s, Philae Island became submerged, threatening the temple’s survival.In a remarkable UNESCO - led rescue mission, the temple was carefully dismantled and relocated to Agilkia Island, preserving its historical and artistic value for future generations. Today,the Temple of Philae remains a major tourist attraction, enchanting visitors with its breathtaking beauty and rich mythology.At night,the temple’s sound and light show brings its history to life, allowing visitors to immerse themselves in the legends of ancient Egypt in an unforgettable setting.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d929496.4492469042!2d32.22243808483727!3d24.49080933093972!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143662bfbe299cbf%3A0xd571ef8bf3780147!2sPhilae!5e0!3m2!1sen!2seg!4v1743174187841!5m2!1sen!2seg",
                Address = "Aswan",
                ImageUrl = "AreaImages/15000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 36,
                Name = "Step Pyramid of Djoser",
                Description = "The Pyramid of Djoser, also known as the Step Pyramid, is one of the most significant monuments in ancient Egyptian history and the world’s earliest large-scale stone structure. Located in Saqqara, near Memphis, it was built during the 27th century BCE for Pharaoh Djoser of the Third Dynasty. Designed by the brilliant architect and high priest Imhotep, this pyramid marks a revolutionary shift in funerary architecture, transitioning from traditional mastaba tombs to stepped pyramid structures. The Step Pyramid consists of six distinct layers stacked atop one another,  reaching a height of approximately 60 meters.It was originally encased in smooth limestone, though much of this outer layer has eroded over time.Surrounding the pyramid is an extensive mortuary complex, including temples,courtyards,  and ceremonial halls,  all enclosed within a massive limestone wall.This entire structure was designed to serve as an eternal resting place for Djoser, ensuring his transition to the afterlife in accordance with ancient Egyptian religious beliefs.What makes the Pyramid of Djoser particularly significant is its role in shaping the later pyramid - building traditions of Egypt.It laid the foundation for the grand pyramids of the Fourth Dynasty,including the famous Pyramids of Giza.Additionally, the complex is a testament to the advanced engineering skills of the ancient Egyptians, showcasing precise stone - cutting techniques and a deep understanding of construction principles. Despite being over 4, 600 years old, the Step Pyramid remains one of Egypt’s most visited and admired sites.Extensive restoration efforts have been carried out to preserve its structure, allowing modern visitors to witness the architectural genius of Imhotep and the grandeur of one of the earliest and most influential monuments of ancient civilization.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3459.7574523207945!2d31.214200075003603!3d29.871268026756056!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584bd553b25c81%3A0x8c577a7fabef89d!2sStep%20Pyramid%20of%20Djoser!5e0!3m2!1sen!2seg!4v1743174302262!5m2!1sen!2seg",
                Address = " Giza ",
                ImageUrl = "AreaImages/30000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            }, 
            new Area
            {
                Id = 37,
                Name = "Abu Simbel Temples",
                Description = "The Abu Simbel Temples are among the most magnificent and iconic monuments of ancient Egypt, reflecting the grandeur and power of Pharaoh Ramses II. Located in southern Egypt near the modern border with Sudan, these temples were carved directly into the mountainside during the 13th century BCE (19th Dynasty) to commemorate Ramses II’s victory at the Battle of Kadesh and to assert Egypt’s dominance over Nubia. The complex consists of two temples: the Great Temple dedicated to Ramses II himself and the Small Temple dedicated to his beloved wife, Queen Nefertari.The Great Temple is a masterpiece of ancient engineering and art.Its façade features four colossal statues of Ramses II, each standing about 20 meters tall, seated in a commanding pose.The temple’s interior is equally impressive, with grand halls adorned with detailed reliefs depicting Ramses II’s military triumphs,religious rituals,and divine status.One of its most extraordinary features is the solar alignment phenomenon: twice a year,on February 22 and October 22, sunlight penetrates the temple’s sanctuary, illuminating the statues of the gods Ptah, Amun - Ra, Ramses II(deified), and Ra - Horakhty—except for Ptah,associated with the underworld, who remains in darkness. The Small Temple, located nearby, is dedicated to Queen Nefertari and the goddess Hathor.Its façade showcases six statues—four of Ramses II and two of Nefertari, a rare honor as queens were usually depicted much smaller than pharaohs.The temple’s interior is adorned with elaborate carvings of Nefertari in the presence of deities, emphasizing her divine status and the deep affection Ramses II had for her. One of the most remarkable aspects of Abu Simbel’s history is its relocation. In the 1960s, the construction of the Aswan High Dam threatened to submerge the temples under Lake Nasser.In an extraordinary UNESCO - led rescue operation, the temples were carefully cut into massive blocks and reassembled 65 meters higher and 200 meters back from their original location, preserving them for future generations. Today, the Abu Simbel Temples stand as a testament to ancient Egyptian architectural genius, the might of Ramses II, and the global efforts to protect humanity’s cultural heritage.The site continues to attract visitors from around the world, marveling at its grandeur, historical significance, and the incredible feat of its preservation.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3690.4339734070672!2d31.623224074750464!3d22.337236841556635!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143aa988b126055b%3A0xa7d3cc6618f898d2!2sAbu%20Simbel%20Temples!5e0!3m2!1sen!2seg!4v1743174527094!5m2!1sen!2seg",
                Address = "Aswan",
                ImageUrl = "AreaImages/37000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 38,
                Name = "Alexandria Ancient Roman Theater",
                Description = "The Roman Amphitheater of Alexandria is one of Egypt's most remarkable Greco-Roman monuments and the only known Roman theater in the country. Located in the Kom El-Dikka area in the heart of Alexandria, this site dates back to the 2nd century CE, during the Roman era, and was originally part of a larger complex that included a bathhouse, lecture halls, and residential quarters. The theater was discovered in 1960 during excavation work, revealing a well-preserved structure that offers valuable insight into the architectural and cultural life of ancient Alexandria. The amphitheater consists of 13 semicircular rows of white marble seating arranged in a horseshoe shape, supported by granite columns.These rows could accommodate around 600 spectators and were designed for optimal acoustics, ensuring that sounds projected from the stage could be clearly heard throughout the venue.The structure originally featured a domed roof, enhancing its acoustics, though only remnants of this remain today.The seats are inscribed with Greek letters, possibly marking designated spots for specific individuals, suggesting its use for official gatherings, musical performances, and theatrical productions. Beneath the seating area, excavation has uncovered intricate mosaic floors and remnants of an underground passage, which may have been used by performers or staff during events.Additionally, the site contains a collection of ancient artifacts, including statues and decorative elements, indicating that the theater was part of a larger cultural and administrative center. During later periods, particularly in the Byzantine era, the function of the structure evolved, and it was possibly used for public assemblies or as a council hall. The surrounding archaeological site also includes Roman baths, a residential district, and lecture halls, reinforcing Alexandria’s status as a major intellectual and cultural hub in antiquity. Today, the Roman Amphitheater of Alexandria stands as a testament to the city's rich Greco-Roman heritage. It is a popular tourist attraction and an important site for historians and archaeologists studying the intersection of Egyptian, Greek, and Roman influences in ancient Alexandria.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3412.940965822202!2d29.90145017505611!3d31.194650163163256!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c3eb59fbc5c3%3A0xf53cf227d8ca06e4!2sAlexandria%20Ancient%20Roman%20Theater!5e0!3m2!1sen!2seg!4v1743174637379!5m2!1sen!2seg",
                Address = "Alexandria",
                ImageUrl = "AreaImages/50000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 39,
                Name = "Dendera Temple of Hathor",
                Description = "The Dendera Temple Complex, one of the best-preserved temple sites in Egypt, is a stunning testament to the architectural and religious grandeur of ancient Egyptian civilization. Located near the city of Qena on the west bank of the Nile, the temple is primarily dedicated to the goddess Hathor, the deity of love, beauty, music, and motherhood. Although the site has older origins dating back to the Old Kingdom, the current temple structure was built during the Ptolemaic and early Roman periods, between 125 BCE and 60 CE, with contributions from rulers such as Ptolemy XII and the Roman Emperor Tiberius. The temple is renowned for its elaborate carvings, vibrant ceiling decorations, and astronomical significance.The hypostyle hall, with its 24 massive Hathoric columns topped with carvings of the goddess’s face,leads into a series of chambers,sanctuaries, and chapels.The ceiling of the temple is one of its most striking features, covered in detailed astronomical depictions,including a zodiac map that showcases the constellations and celestial cycles.The famous Dendera Zodiac, now housed in the Louvre Museum, was originally part of this temple. One of the temple’s most intriguing elements is the so - called Dendera Light relief,located in the crypts beneath the structure.Some researchers speculate that these carvings represent ancient electrical technology,although most Egyptologists interpret them as religious symbols related to creation and rebirth.Dendera is also home to the rooftop chapels,offering panoramic views of the surrounding landscape.These chapels were used for rituals associated with the goddess Hathor, and their walls contain inscriptions illustrating the temple's religious functions. Nearby, the mammisi (birth house) commemorates the divine birth of the child god Ihy, reinforcing the temple’s association with fertility and renewal. The temple complex includes additional structures such as a sacred lake,a Roman - period gate,and remnants of Coptic Christian occupation,illustrating its continued significance through different historical periods.Today,the Temple of Dendera stands as one of the most well - preserved and richly decorated monuments of ancient Egypt, drawing visitors and scholars alike to admire its intricate artistry and deep spiritual symbolism.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3581.6809964311915!2d32.667628174868604!3d26.14194229278987!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144ecbd376622d75%3A0x55c5acd6d797167f!2sDendera%20Temple%20of%20Hathor!5e0!3m2!1sen!2seg!4v1743174708967!5m2!1sen!2seg",
                Address = "Qena",
                ImageUrl = "AreaImages/61000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 40,
                Name = "Kom Ombo Temple",
                Description = "The Temple of Kom Ombo is one of the most unique and fascinating temples of ancient Egypt, distinguished by its rare double design, which reflects the dual worship of two deities. Located on the east bank of the Nile, about 50 km north of Aswan, the temple was built during the Ptolemaic period (around 180–47 BCE) and later expanded by Roman rulers. It was dedicated to two gods: Sobek, the crocodile-headed god of fertility and protector against dangers of the Nile, and Horus the Elder (Haroeris), the falcon-headed god of kingship and healing.Kom Ombo’s architectural layout is symmetrical,with two identical sections running parallel to each other.Each side has its own entrance,hypostyle hall,sanctuaries,and offering halls, emphasizing the dual nature of the temple.The walls are adorned with beautifully preserved reliefs depicting religious rituals, divine processions,and offerings made to both deities.Among the most significant carvings is an ancient medical scene that illustrates surgical instruments and medical practices used by the Egyptians,showcasing their advanced knowledge in healthcare.The temple complex also includes a sacred well and a small chapel dedicated to Hathor, as well as an underground chamber believed to have been used for oracles or healing rituals.Near the temple,a crocodile museum displays mummified crocodiles that were once worshipped in the area as incarnations of Sobek,further emphasizing the importance of the deity to the local population.Despite suffering damage from natural elements and past looting,the Temple of Kom Ombo remains architectural marvel and a testament to the religious and cultural fusion of ancient Egypt.Today,it is a popular site for visitors who come to admire its artistic detailsits strategic riverside location,and the unique concept of a dual temple honoring two powerful gods side by side.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3631.961008763133!2d32.92585697481371!3d24.452138061475942!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14360fb1581ad7a5%3A0x3cbfefca02f424fc!2sKom%20Ombo%20Temple!5e0!3m2!1sen!2seg!4v1743174817929!5m2!1sen!2seg",
                Address = "Aswan",
                ImageUrl = "AreaImages/70000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 41,
                Name = "The Hanging Church",
                Description = "The Hanging Church (Al-Muallaqa) is one of the most significant and oldest Christian monuments in Egypt, representing a masterpiece of Coptic architecture and a symbol of the deep-rooted Christian heritage in the country. Located in Old Cairo, near the Babylon Fortress, the church was built above a Roman gatehouse, giving it the appearance of being suspended in the air, which is why it is known as The Hanging Church. The structure dates back to the 3rd or 4th century AD, making it one of the earliest churches in Egypt, though it underwent several renovations over the centuries.The Hanging Church served as the seat of the Coptic Orthodox Patriarchate for many years and played a crucial role in the religious and political history of Coptic Christians.It was a place where important decisions regarding the church and its leadership were made.The church’s interior is a striking example of Coptic artistic excellence,featuring wooden ceilings designed to resemble Noah's Ark, beautiful marble columns, intricate wooden screens, and stunning icons that depict Christ, the Virgin Mary, and various saints.One of the most remarkable features of the church is its pulpit,made of white marble and supported by 13 columns symbolizing Jesus and his 12 disciples.The sanctuary screen is an exquisite wooden work of art,decorated with intricate carvings and inlaid with ivory.The walls and ceilings are adorned with religious motifs and Coptic inscriptions that reflect the deep spirituality of the place.The Hanging Church remains a major pilgrimage site for Christians and an important tourist attraction in Cairo.It stands as a testament to Egypt’s religious diversity and the enduring legacy of Coptic heritage,attracting visitors from around the world who come to admire its history,architecture,and spiritual significance.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3455.10143993756!2d31.227593975008944!3d30.005243520428092!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458471046a8759f%3A0xd4e2e0e982021bba!2sThe%20Hanging%20Church!5e0!3m2!1sen!2seg!4v1743174923438!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/80000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 42,
                Name = "Saint Catherine's Monastery",
                Description = "Saint Catherine’s Monastery is one of the oldest and most important Christian monasteries in the world, located at the foot of Mount Sinai in Egypt’s Sinai Peninsula. Built during the 6th century AD by the Byzantine Emperor Justinian I, the monastery has remained a center of Christian worship and monastic life for over 1,400 years. It is named after Saint Catherine of Alexandria, a Christian martyr who, according to tradition, was tortured and executed for her faith, and whose relics are believed to be housed within the monastery.The monastery’s location is of immense religious significance, as it is traditionally believed to be near the site where Moses saw the Burning Bush and received the Ten Commandments.One of its most sacred features is the Chapel of the Burning Bush,where a rare species of bush still grows,said to be a descendant of the biblical plant.The monastery is also home to an unparalleled collection of Christian manuscripts,second only to the Vatican Library,with ancient texts in Greek,Syriac,Arabic,and other languagesArchitecturally,Saint Catherine’s Monastery is a fortress - like structure,with massive stone walls built to protect it from invasions over the centuries.Inside,it houses a stunning basilica with beautifully preserved mosaics,icons,and religious artifacts.The monastery’s Icon Gallery features some of the world’s oldest surviving icons,many of which date back to the early centuries of Christianity.Despite its remote location in the rugged mountains of Sinai,the monastery has been a pilgrimage destination for Christians,Muslims,and Jews alike.It is recognized as a UNESCO World Heritage Site for its historical,religious,and cultural significance.To this day,Saint Catherine’s Monastery remains an active religious institution,with Greek Orthodox monks maintaining its traditions and preserving its vast historical treasures.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3504.459781765066!2d33.97347307495391!3d28.555953087555057!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1454901def4fa789%3A0xc91f754605c6dadf!2sSaint%20Catherine&#39;s%20Monastery!5e0!3m2!1sen!2seg!4v1743175004814!5m2!1sen!2seg",
                Address = "South Sinai",
                ImageUrl = "AreaImages/90000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id=43,
                Name="Montaza Palace",
                Description="Montaza Palace is one of Egypt’s most stunning royal palaces, located on the Mediterranean coast in Alexandria. It was originally built as a summer retreat for the Egyptian royal family, offering breathtaking views of the sea and surrounded by vast gardens. Today, the palace complex remains a significant historical and tourist attraction, known for its elegant architecture, lush greenery, and serene atmosphere. Montaza Palace was built in 1892 by Khedive Abbas II, the last Khedive of Egypt and Sudan, as a royal summer residence. It was later expanded by King Fuad I and King Farouk, who added new architectural elements to the complex. The palace was used by the Egyptian monarchy until the 1952 revolution, after which it became a public landmark. The palace showcases a unique blend of Ottoman, Florentine, and Moorish architectural styles, reflecting the royal family's preference for European-inspired elegance combined with traditional Islamic elements. The most famous part of the palace complex is the Al-Haramlik Palace, which features high towers, ornate balconies, and beautifully carved arches. Another notable structure is the Salamlek Palace, originally built as a hunting lodge and later converted into a luxury hotel. One of the palace’s most captivating features is its vast gardens, covering around 370 acres of beautifully landscaped land. The gardens are home to rare tropical plants, towering palm trees, and vibrant flowers, making them a perfect escape from the city’s hustle and bustle. The area also includes royal beaches, where members of the royal family once swam in the crystal-clear Mediterranean waters. After the abolition of the monarchy in 1952, the palace complex was transformed into a presidential residence, used occasionally for official state events. However, the gardens and surrounding areas were opened to the public, becoming one of Alexandria’s most popular tourist attractions. Visitors can enjoy relaxing walks, boat rides, and picnics while admiring the breathtaking views of the palace and the sea. In recent years, Montaza Palace has undergone restoration projects to preserve its historic beauty and enhance its appeal as a cultural and heritage site. Whether exploring its majestic architecture, stunning gardens, or peaceful beaches, Montaza Palace remains a symbol of Egypt’s royal elegance and historical grandeur.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3409.634261135725!2d30.013481025059804!3d31.28621040867458!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5d05ef533eccb%3A0xae82154762ef9858!2sMontaza%20Palace!5e0!3m2!1sen!2seg!4v1743175983510!5m2!1sen!2seg",
                Address="Alexandria",
                ImageUrl="AreaImages/900.jpg",
                AreaTypeId=2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 44,
                Name = "Cairo Citadel",
                Description = "The Citadel of Saladin (Salah El-Din Citadel) is one of the most iconic and historically significant fortresses in Egypt, standing as a testament to medieval Islamic military architecture. Located on a high plateau in Cairo, the citadel was built in the late 12th century by the famous Muslim military leader Salah El-Din (Saladin) to defend Egypt against Crusader invasions. Its strategic position provided a commanding view of the city, making it a powerful stronghold for centuries.The construction of the citadel began around 1176 AD and continued after Saladin’s reign,with successive rulers adding their own modifications and expansions.The fortress was built using limestone from the nearby Mokattam Hills and included massive walls, watchtowers, and deep moats to withstand enemy attacks. Over time, it evolved into not only a military base but also a political and administrative center, serving as the seat of Egypt’s rulers until the 19th century.One of the most striking features within the citadel is the Mosque of Muhammad Ali, also known as the Alabaster Mosque, which was built in the 19th century by Muhammad Ali Pasha. With its large central dome, towering minarets, and intricate Ottoman-style decorations, the mosque dominates the citadel’s skyline and is one of Cairo’s most famous landmarks. Inside, the mosque boasts a magnificent prayer hall with a grand chandelier and elaborate Islamic calligraphy.Other significant structures within the citadel include the Mosque of Al-Nasir Muhammad, which reflects Mamluk architectural style, and the Military Museum, housed in a former Ottoman palace. Visitors can also explore the Gawhara Palace, which once served as a royal residence, and the Well of Joseph, a deep well dug into the rock to provide water in times of siege.Throughout its history, the citadel has witnessed numerous battles, political upheavals, and royal ceremonies. Today, it stands as a symbol of Egypt’s rich past and offers breathtaking panoramic views of Cairo. As a UNESCO World Heritage site, the Citadel of Saladin remains a must-visit destination for those interested in Egypt’s military, architectural, and cultural heritage.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.2825659940386!2d31.257139475009716!3d30.02875031931506!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840ac90c2ed63%3A0x2fdb96e4e9f72e6f!2sCairo%20Citadel!5e0!3m2!1sen!2seg!4v1743175258318!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/100000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 45,
                Name = "Ibn Tulun Mosque",
                Description = "The Ibn Tulun Mosque is one of the oldest and most well-preserved mosques in Egypt, representing a masterpiece of Islamic architecture. Located in the heart of Old Cairo, it was commissioned by Ahmad Ibn Tulun, the founder of the Tulunid dynasty, and completed in 879 AD. The mosque was designed to accommodate large congregations and reflects the architectural influences of the Abbasid era, particularly those seen in the mosques of Samarra, Iraq.Spanning approximately 26,000 square meters,the Ibn Tulun Mosque is the largest mosque in Cairo in terms of land area.It was constructed primarily from red brick and plaster,with intricate stucco decorations and geometric patterns adorning its walls and arches.The mosque's design features a vast open courtyard surrounded by arched porticos, allowing for natural ventilation and light. The qibla wall, facing Mecca, is adorned with a beautifully carved mihrab (prayer niche) and a simple yet elegant minbar (pulpit).One of the most distinctive elements of the mosque is its unique spiral minaret,inspired by the Great Mosque of Samarra.The minaret,which can be accessed via an external staircase,offers a panoramic view of the surrounding historic district.The mosque is also notable for its covered walkways,supported by massive piers and columns,creating a sense of grandeur and serenity.The Ibn Tulun Mosque has withstood the test of time,surviving centuries of political and social changes.Unlike many other historic mosques in Cairo,it has remained largely unaltered since its construction.It continues to serve as a place of worship and a cultural landmark,attracting visitors and historians alike.As a remarkable example of early Islamic architecture,the mosque stands as a symbol of Egypt’s rich artistic and religious heritage.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.2807225340034!2d31.24699167500978!3d30.028803219312568!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458474d2b6e49a7%3A0x4082ac9340e4d952!2sIbn%20Tulun%20Mosque!5e0!3m2!1sen!2seg!4v1743175342083!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/200000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 46,
                Name = "Khan el-Khalili",
                Description = "Khan El Khalili is one of Cairo's most famous and vibrant historical markets, known for its rich heritage, traditional craftsmanship, and bustling atmosphere. Located in the heart of Islamic Cairo, the bazaar dates back to the 14th century, when it was established during the Mamluk era by Emir Dajaharks Al-Khalili. Over the centuries, it has evolved into a major cultural and commercial hub, attracting both locals and tourists alike.The market is a labyrinth of narrow alleyways lined with shops selling a wide variety of goods,including handmade jewelry,intricate brass lanterns,colorful textiles,traditional spices,perfumes,antiques,and authentic Egyptian souvenirs.Many of the workshops and stalls have been passeddown through generations,preserving traditional craftsmanship that has been practiced for centuries.Khan El Khalili is not just a marketplace; it is also a center of social and cultural life.Among its many historical attractions is the famous Al - Fishawi Café,which has been serving visitors for over 200 years.This café,known for its ornate mirrors and cozy ambiance,was once a favorite spot of the renowned Egyptian writer Naguib Mahfouz.Other significant landmarks include the historic Al - Hussein Mosque,located near the bazaar,adding to the spiritual and architectural significance of the area.The market comes alive especially in the evenings,when its streets are filled with the sounds of merchants calling out to customers,the aroma of traditional Egyptian food from nearby restaurants,and the melodies of live performances by local musicians.Whether visitors come to shop,explore,or simply soak in the atmosphere,Khan El Khalili offers a unique glimpse into the living history of Cairo,making it one of the city's most enchanting and enduring attractions.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6057783145206!2d31.259175975010617!3d30.048165768395464!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840eb2c0e580f%3A0x1761e0e461027d11!2sKhan%20el-Khalili!5e0!3m2!1sen!2seg!4v1743175427821!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/300000.jpg",
                AreaTypeId = 2, 
                Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 47,
                Name = "Bab al-Futuh",
                Description = "Bab Zuweila and Bab al-Futuh are two of the most significant and well-preserved medieval gates of Cairo, offering a glimpse into the city's rich Islamic architectural heritage. These gates were part of the fortified walls built during the Fatimid era in the 11th century to protect the city from external invasions. Each gate has its own historical and architectural significance, reflecting the grandeur of medieval Cairo. Bab Zuweila Bab Zuweila, constructed in 1092 during the reign of the Fatimid vizier Badr al - Jamali, is the only surviving southern gate of Fatimid Cairo.It is renowned for its imposing twin minarets,which were added later during the Mamluk period.Historically,the gate served not only as a defensive structure but also as a site for public executions during the Mamluk and Ottoman eras. One of the most famous incidents was the execution of Tuman Bay, the last Mamluk sultan, who was hanged at the gate by the Ottomans in 1517. Today, visitors can climb the minarets for a panoramic view of Old Cairo, offering a breathtaking perspective of the city's historical skyline.Bab al-FutuhBab al-Futuh, meaning Gate of Conquests, is located on the northern side of Fatimid Cairo and was built in 1087 as part of the city's fortifications. This massive stone gate was designed to withstand attacks and features rounded towers that were innovative for military architecture at the time. Bab al-Futuh served as a crucial entrance to the city, symbolizing the strength and resilience of the Fatimid Caliphate. The intricate carvings and sturdy construction of the gate reflect the advanced engineering skills of the period. It stands near Al-Muizz Street, one of Cairo’s most famous historical streets, lined with mosques, palaces, and madrasas from different Islamic eras.Both Bab Zuweila and Bab al-Futuh are significant cultural landmarks, representing Cairo's medieval past and its strategic importance throughout history. Today, they attract visitors, historians, and architects who admire their intricate designs, historical importance, and the role they played in shaping the city’s defensive system.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.351641570124!2d31.26078527501087!3d30.055453418050096!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583f6290708523%3A0x81fccd2457179839!2sBab%20al-Futuh!5e0!3m2!1sen!2seg!4v1743175524552!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/400000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 48,
                Name = "Al-Azhar Mosque",
                Description = "Al-Azhar Mosque is one of the most iconic and historically significant mosques in Egypt and the Islamic world. Located in the heart of Cairo, it was founded in 970 AD during the Fatimid Caliphate under the rule of Caliph Al-Mu'izz li-Din Allah. It is not only a place of worship but also a renowned center for Islamic learning, making it one of the oldest and most influential institutions of higher education in the world.Historical and Architectural SignificanceAl - Azhar Mosque was initially built as a Shia Fatimid mosque but later became the center of Sunni Islam after the Ayyubid dynasty took control of Egypt.Over the centuries,various rulers,including the Mamluks and Ottomans,contributed to its expansion and renovation,adding domes,minarets,and madrasas(Islamic schools).Today,the mosque features a blend of architectural styles that reflect different Islamic periods,with its five minarets standing as prominent landmarks in Cairo's skyline.Al - Azhar as an Educational InstitutionIn addition to being a mosque,Al - Azhar evolved into one of the most prestigious centers for Islamic studies.It became a leading institution in theology,Islamic jurisprudence,Arabic literature,and various sciences.Scholars from around the world have traveled to study at Al - Azhar,and it remains an influential authority in issuing fatwas(Islamic legal rulings) and shaping Islamic thought.Modern - Day ImportanceToday,Al - Azhar Mosque continues to serve as a place of worship and education,drawing thousands of students and visitors annually.Its university,Al - Azhar University, is one of the oldest continuously operating universities in the world,maintaining its role as a beacon of Islamic scholarship.The mosque also stands as a symbol of Egypt's deep-rooted Islamic heritage, attracting tourists, historians, and scholars interested in its rich history and architectural beauty.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6876133315814!2d31.259989075010456!3d30.04581871850663!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840a2f3fd21f5%3A0x676752c74b1e52e8!2sAl-Azhar%20Mosque!5e0!3m2!1sen!2seg!4v1743175614042!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/500000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 49,
                Name = "Mosque-Madrasa of Sultan Hassan",
                Description = "Mosque of Sultan Hassan is one of the most magnificent and architecturally significant mosques in Cairo, renowned for its grand scale, exquisite decoration, and historical importance. Located near the Citadel of Saladin, the mosque was commissioned by Sultan Hassan ibn Al-Nasir Muhammad ibn Qalawun during the Mamluk era in 1356 AD. It stands as a masterpiece of Islamic architecture, reflecting the power and sophistication of the Mamluk dynasty.Architectural MarvelThe mosque is famous for its massive structure,covering an area of approximately 7,900 square meters,with walls soaring up to 36 meters high.Its monumental entrance,one of the tallest in Cairo, is adorned with intricate stone carvings.Inside,the mosque follows a cruciform(four - iwan) layout,where each iwan(vaulted hall) faces the central courtyard.The largest iwan,which serves as the prayer hall,features an impressive mihrab(prayer niche) and a beautifully decorated wooden minbar(pulpit).The ceiling and walls are adorned with stunning Arabic calligraphy,geometric patterns,and marble inlays,showcasing the artistic excellence of Mamluk craftsmen.Religious and Historical SignificanceOriginally designed to function as both a mosque and a madrasa(Islamic school),the complex included separate halls for teaching the four Sunni schools of Islamic jurisprudence.The mosque was also intended to house the tomb of Sultan Hassan himself,though he mysteriously disappeared before its completion,and his body was never buried there.Instead,the mausoleum within the mosque remains empty.Legacy and InfluenceOver the centuries,the Mosque of Sultan Hassan has remained one of the most admired structures in Islamic architecture,influencing the design of many later mosques,including some in the Ottoman Empire.Today,it continues to be an active place of worship and a major historical site,attracting visitors for its breathtaking beauty and rich history.Its imposing presence near the Citadel makes it a defining landmark of medieval Cairo,embodying the grandeur and sophistication of the Mamluk era.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.16123634711!2d31.253730475009963!3d30.03223181915026!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840ac0ae91775%3A0x74c6b9904c0f8ce4!2sMosque-Madrasa%20of%20Sultan%20Hassan!5e0!3m2!1sen!2seg!4v1743175723828!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/600000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 50,
                Name = "Abdeen Palace Museum",
                Description = "Abdeen Palace is one of the most important historical palaces in Egypt and one of the most luxurious, reflecting a significant era in the country's history from the time of the Muhammad Ali Dynasty to the modern age. Located in the heart of Cairo, the palace is an architectural masterpiece that blends European and Islamic styles, making it one of the most beautiful royal palaces in the Middle East. It was commissioned by Khedive Ismail in 1863 to serve as the seat of government instead of the Citadel of Saladin, and its construction took around ten years, undergoing several expansions and renovations over the years.Design and Features of the PalaceAbdeen Palace covers a vast area and includes over 500 lavishly decorated rooms adorned with gold and intricate ornaments.It features multiple royal wings and grand reception halls.The palace façade is elegantly designed with intricate carvings and ornate balconies, while the interior décor showcases refined taste,incorporating the finest marble,crystal,and luxurious European furniture.The palace houses several museums,such as:The Weapons Museum,displaying a rare collection of historical weapons.The Royal Collections Museum,featuring gifts and belongings of the ruling family.The Historical Documents Museum,which holds rare manuscripts and documents from Egypt’s modern history.Historical Significance of Abdeen PalaceAbdeen Palace has witnessed major political events in Egypt’s history and served as the royal residence from Khedive Ismail to King Farouk.It played a crucial role in key decisions that shaped Egypt’s future,including the abolition of foreign privileges and the nationalization of the Suez Canal.It also hosted important political negotiations between Egyptian and foreign leaders.After the 1952 Revolution and the fall of the monarchy,the palace became one of Egypt’s presidential palaces,yet it still stands as a symbol of the royal era.Abdeen Palace TodayIn modern times,Abdeen Palace has been opened to the public as a museum, allowing visitors to explore its rich history and experience the luxurious lifestyle of Egypt’s monarchy in the 19th and early 20th centuries. It remains one of the greatest historical landmarks in Egypt, attracting thousands of visitors annually to admire its stunning architecture and rare artifacts.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.7844703573205!2d31.244930075010373!3d30.04304061863821!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840baf551f617%3A0xbafb145a268367fd!2sAbdeen%20Palace%20Museum!5e0!3m2!1sen!2seg!4v1743175793994!5m2!1sen!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/700000.jpg",
                AreaTypeId = 2,
                 Latitude=null,
               Longitude=null
            },
            // Sea and Nile Cruises: 10 51:60
            new Area{
                Id=51,
                Name="Nile Maxim Cruise",
                Description="Nile Maxim Cruise is one of the most prestigious and luxurious dinner cruises in Cairo, offering a unique blend of fine dining, live entertainment, and breathtaking views of the Nile. The cruise takes guests on a two-hour journey along the historic river, providing a magical experience under the city’s twinkling skyline. The boat itself is a high-end floating restaurant, known for its elegant décor, panoramic glass windows, and spacious open-air decks, allowing visitors to admire the beauty of Cairo from the water. The dining experience features a five-star menu, serving a variety of Egyptian and international cuisines, including gourmet seafood, grilled meats, and traditional Egyptian delicacies. Guests are entertained throughout the journey with a live cultural performance, featuring a Tanoura dance show, live music, and an authentic belly dancing performance, creating an immersive Egyptian ambiance. As the boat gently sails past famous landmarks such as Tahrir Square, Cairo Opera House, and the illuminated bridges of the Nile, visitors can relax on the deck, taking in the romantic and serene atmosphere of the river at night. Nile Maxim is ideal for romantic dinners, special celebrations, and tourists looking for an upscale dining and entertainment experience on the Nile. The cruise operates daily, offering multiple departure times, usually in the evening, to maximize the enchanting night-time views of the capital. Combining luxury, culture, and entertainment, Nile Maxim Cruise is one of Cairo’s top-rated tourism experiences, giving visitors a taste of Egyptian hospitality with world-class service.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.302716994375!2d31.226318!3d30.056856199999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840dc06ee868b%3A0xcf8422aad0e415d7!2sNile%20Maxim!5e0!3m2!1sen!2seg!4v1743088289940!5m2!1sen!2seg",
                Address=" Corniche El Nil, Near Four Seasons Hotel, Garden City, Cairo, Egypt.",
                ImageUrl="AreaImages/101.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=52,
                Name="Dahabiya Nile Cruises",
                Description="Dahabiya Nile Cruises offer a luxurious yet traditional way to explore the timeless wonders of Upper Egypt. The word Dahabiya (or Dahabeya) means golden boat in Arabic, reflecting the grandeur of these elegant two-masted sailing boats that date back to the 19th century, when they were used by royalty and aristocrats traveling along the Nile. Unlike larger motorized cruise ships, Dahabiyas provide a serene, intimate, and eco-friendly journey, relying mainly on the wind to sail. These boats typically accommodate 8-12 guests, creating a personalized and exclusive atmosphere. Each Dahabiya is beautifully crafted with wooden decks, shaded seating areas, spacious cabins with en-suite bathrooms, and panoramic windows offering uninterrupted views of the Nile.The journey typically starts from Esna (near Luxor) and ends in Aswan, lasting between 4 to 7 nights, depending on the itinerary. Along the way, guests visit hidden archaeological treasures such as El Kab (the ancient city of Nekhen), Gebelein, and the rock-cut tombs of Horemheb at Silsila, where larger cruise ships cannot dock. The Dahabiya also stops at Edfu’s Temple of Horus, Kom Ombo Temple, and Philae Temple in Aswan, while allowing travelers to experience authentic local culture by visiting rural villages and markets. Unlike large cruise ships that rush between destinations, Dahabiya cruises offer leisurely mornings, relaxed afternoons, and breathtaking sunsets, making the journey just as important as the destinations.Onboard, guests enjoy five-star dining, featuring a mix of Egyptian and international cuisine prepared by private chefs using fresh local ingredients. The smaller group size ensures personalized service, flexibility in excursions, and a relaxed, intimate setting. Activities include felucca rides, stargazing, desert walks, and bonfire nights on the Nile’s shores. Whether enjoying a glass of wine on the sun deck, watching local fishermen sail past, or listening to stories from knowledgeable Egyptologists, every moment on a Dahabiya cruise feels like stepping back in time to an era of luxury and discovery.Dahabiya Nile Cruises are perfect for honeymooners, history enthusiasts, photographers, and those seeking an off-the-beaten-path experience of the Nile. The combination of privacy, breathtaking scenery, and cultural immersion makes it one of the most enchanting ways to explore the heart of Egypt.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.728633036534!2d31.217205117443847!3d30.04464219999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584122bc039161%3A0x3d447b59c2c4ca4d!2sDahabiya%20Cairo!5e0!3m2!1sen!2seg!4v1743088935102!5m2!1sen!2seg",
                Address="Various docking points in Luxor, Esna, Edfu, Kom Ombo, and Aswan, depending on the cruise provider.",
                ImageUrl="AreaImages/106.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=53,
                Name="Sonesta St. George Nile Cruise",
                Description="The Sonesta St. George Nile Cruise is a luxury five-star cruise that combines elegance, comfort, and world-class hospitality to create an unforgettable journey through the heart of ancient Egypt. This modern and sophisticated vessel is part of the renowned Sonesta fleet, known for its high standards in river cruising. The ship offers 47 Deluxe Cabins, 9 Presidential Suites, and 1 Royal Suite, each designed with rich wood paneling, plush furnishings, and panoramic French windows that provide breathtaking views of the Nile. The cabins are fully equipped with air conditioning, LCD TVs, mini-bars, Wi-Fi access, electronic safe boxes, and marble bathrooms with spa showers and Jacuzzis, ensuring maximum comfort for travelers.The cruise follows a carefully curated itinerary, allowing guests to explore the temples, tombs, and historical sites of Luxor and Aswan while enjoying a relaxing journey along the Nile. The itinerary includes visits to Karnak and Luxor Temples, the Valley of the Kings, Queen Hatshepsut’s Temple, the Colossi of Memnon, Edfu’s Temple of Horus, Kom Ombo Temple, and the iconic Philae Temple in Aswan. Optional excursions include a traditional felucca sail around Elephantine Island, a visit to the High Dam, and a tour of Abu Simbel (for extended cruises).Onboard, guests can indulge in gourmet dining at the main restaurant, which serves a mix of Egyptian, Mediterranean, and international cuisine, prepared by skilled chefs. The lounge and bar area offers a refined space to unwind with a cocktail while enjoying live entertainment, including traditional music, belly dancing, and folklore performances. The cruise also features a fully-equipped spa and wellness center, with a sauna, gym, and massage services, as well as a sun deck with a heated swimming pool and jacuzzi, where travelers can soak up the sun while watching the serene Nile landscapes drift by.With impeccable service, lavish accommodations, and a perfectly curated itinerary, the Sonesta St. George Nile Cruise offers an unparalleled blend of history, luxury, and relaxation. It is an ideal choice for honeymooners, families, history enthusiasts, and those seeking a refined, all-inclusive experience of the Nile River’s timeless wonders. Whether exploring ancient temples or sipping afternoon tea while watching the sunset over the river, guests are guaranteed a magical and memorable journey.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3597.017789126058!2d32.596458!3d25.637535099999997!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144911383815138b%3A0xe2e2a67d7cec0c61!2sSonesta%20St.%20George%20Nile%20Cruise%20Luxor!5e0!3m2!1sen!2seg!4v1743089229698!5m2!1sen!2seg",
                Address="El-dabiya, El-Boghdady, Luxor, Luxor Governorate, Egypt",
                ImageUrl="AreaImages/111.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=54,
                Name="MS Amarco Nile Cruise",
                Description="The MS Amarco Nile Cruise is a luxurious five-star deluxe cruise ship that blends modern comfort with classic Egyptian elegance. This award-winning vessel is known for its spacious suites, exceptional service, and world-class amenities, making it one of the most sought-after Nile cruise experiences. With high safety standards, eco-friendly operations, and accessible facilities, the MS Amarco stands out as an ideal choice for both luxury travelers and those requiring mobility-friendly accommodations.The ship features 49 spacious cabins and suites, including Standard Cabins, Junior Suites, Executive Suites, and the lavish Royal Suite. Each cabin is designed with modern furnishings, panoramic windows, and private balconies that offer stunning views of the Nile. The rooms are equipped with air conditioning, satellite TVs, mini-bars, in-room safes, and en-suite bathrooms with bathtubs, ensuring a comfortable stay.Passengers on the MS Amarco embark on a carefully curated sightseeing itinerary, guided by expert Egyptologists. Key highlights include the majestic Karnak and Luxor Temples, the awe-inspiring Valley of the Kings, Queen Hatshepsut’s Temple, the twin Colossi of Memnon, the well-preserved Temple of Horus in Edfu, the fascinating double temple of Kom Ombo, and the picturesque Philae Temple in Aswan. Optional excursions include a felucca ride around Elephantine Island, a visit to the High Dam, and an early morning trip to Abu Simbel for longer cruise itineraries.Onboard, the MS Amarco Nile Cruise offers an array of luxury facilities and entertainment options. The main restaurant serves a variety of Egyptian, Mediterranean, and international cuisines, prepared by top chefs. The lounge bar provides a relaxing atmosphere with cocktails, live music, and folklore performances, including belly dancing shows and Nubian cultural entertainment. The sun deck features a swimming pool and jacuzzi, offering guests a tranquil spot to relax while enjoying the Nile’s breathtaking scenery.For those looking to rejuvenate, the ship’s spa and wellness center includes a sauna, steam bath, and massage services. A fully equipped fitness center is also available for health-conscious travelers. Additionally, the cruise caters to business travelers with conference and meeting facilities, making it a versatile choice for leisure and corporate trips alike.With elegant interiors, world-class amenities, and a rich itinerary that showcases Egypt's ancient wonders, the MS Amarco Nile Cruise offers a perfect balance of relaxation, cultural exploration, and luxury. Whether you are a history enthusiast, a honeymooner, or a family looking for an unforgettable vacation, this cruise ensures a once-in-a-lifetime journey along the Nile.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6745077926566!2d31.218026899999998!3d30.046194600000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840d7ca29a80f%3A0x2d3e1302a8207cd0!2sM%2FS%20AMARCO%20NILE%20CRUISE%20Co.!5e0!3m2!1sen!2seg!4v1743089849794!5m2!1sen!2seg",
                Address="Dokki, Giza Governorate, Egypt",
                ImageUrl="AreaImages/116.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=55,
                Name="MS Oberoi Zahra",
                Description="The MS Oberoi Zahra Nile Cruise is an ultra-luxurious, five-star floating hotel designed to provide an exclusive and intimate cruising experience along the Nile. Operated by the renowned Oberoi Group, the Oberoi Zahra is known for its world-class hospitality, elegant accommodations, and exceptional service. Unlike most Nile cruises that run on shorter schedules, the Oberoi Zahra offers extended itineraries, allowing guests to explore ancient Egyptian wonders at a relaxed and unhurried pace.With only 27 luxury cabins and suites, this boutique-style cruise ensures a high level of privacy and personalized attention. Each spacious cabin features floor-to-ceiling windows that provide panoramic views of the Nile, a king-size bed or twin beds with plush bedding, an LCD TV, a personal safe, a well-stocked mini-bar, and a luxurious en-suite bathroom with a rainfall shower and a bathtub. The Luxury Suites offer additional amenities, including a private terrace and an outdoor jacuzzi, perfect for enjoying the breathtaking Nile scenery in complete privacy.The MS Oberoi Zahra takes guests on a curated sightseeing experience, accompanied by expert Egyptologists who provide deep historical insights into Egypt’s ancient temples and tombs. Highlights include private visits to Karnak Temple, exclusive access to select tombs in the Valley of the Kings, guided tours of the temples of Edfu and Kom Ombo, and visits to the stunning Philae Temple and Aswan High Dam. Optional excursions include a felucca ride around Elephantine Island, visits to the Nubian villages, and an early morning trip to Abu Simbel for extended itineraries.Onboard, the Oberoi Zahra redefines luxury with world-class facilities. The fine-dining restaurant offers an à la carte menu featuring Egyptian, Mediterranean, and international cuisine, prepared with the freshest ingredients by expert chefs. Unlike traditional buffet-style cruise dining, meals are served in a sophisticated setting with gourmet presentations.For relaxation, guests can unwind at the sun deck, which features a temperature-controlled swimming pool with comfortable loungers, allowing for peaceful moments while admiring the Nile’s picturesque landscapes. The full-service spa and wellness center offers luxurious massages, facials, and holistic treatments, making it the only Nile cruise with an onboard spa experience. There is also a modern gym, a library lounge, and a cigar lounge for those who enjoy reading, socializing, or indulging in fine cigars.Evening entertainment includes live classical music, folkloric performances, and cultural storytelling sessions, ensuring a refined yet immersive Egyptian experience. Business travelers can also take advantage of conference and meeting facilities onboard, combining luxury with productivity.The MS Oberoi Zahra Nile Cruise is perfect for discerning travelers who seek exclusivity, relaxation, and a refined cultural journey. Whether you're celebrating a honeymoon, seeking an intimate getaway, or indulging in an unparalleled luxury experience on the Nile, this award-winning cruise offers the ultimate blend of history, elegance, and tranquility.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3455.095851503436!2d31.116956!3d30.005404!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458450c4dd9fec7%3A0x7faf51438a80bcc0!2sThe%20Oberoi%20Zahra%2C%20Luxury%20Nile%20Cruiser!5e0!3m2!1sen!2seg!4v1743090220871!5m2!1sen!2seg",
                Address="Luxor Corniche (near Luxor Temple) and Aswan Corniche, Egypt",
                ImageUrl="AreaImages/121.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=56,
                Name="Sindbad Submarine Cruise",
                Description="The Sindbad Submarine Cruise in Hurghada is Egypt’s only deep-sea submarine experience, offering a once-in-a-lifetime journey into the mesmerizing underwater world of the Red Sea. This adventure takes passengers 100 feet (30 meters) below the surface, allowing them to witness the breathtaking marine ecosystem without getting wet. The submarine, which can accommodate up to 44 passengers, is designed with large panoramic windows, ensuring everyone gets a clear view of the vibrant coral reefs, exotic fish, and other fascinating sea creatures. The journey begins at Sindbad Club, where guests board a boat that transports them to the submarine docking station in the open sea. Upon descending into the depths of the Red Sea, passengers are greeted with an explosion of color as they observe a thriving underwater world teeming with life, from dazzling clownfish and angelfish to graceful rays and even occasional sightings of small sharks. The submarine’s expert crew provides live commentary, sharing insights about the diverse marine species and delicate coral formations that make the Red Sea one of the top diving and snorkeling destinations in the world. Unlike traditional glass-bottom boat tours, the Sindbad Submarine allows for an immersive experience, bringing visitors into an environment usually reserved for divers. The excursion lasts around two hours, with approximately 50 minutes underwater, making it a perfect choice for families, non-swimmers, and anyone who wants to explore the underwater wonders of the Red Sea in a safe and comfortable setting. The Sindbad Submarine Cruise is a unique attraction in Egypt, making it a must-visit for tourists in Hurghada, providing an unforgettable journey into the mysterious and stunning depths of one of the world’s most beautiful seas.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d28386.84009302646!2d33.83795995!3d27.20800165!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287586075cfab%3A0x7175c276a7245d93!2sSindbad%20Submarine!5e0!3m2!1sen!2seg!4v1743091260524!5m2!1sen!2seg",
                Address="New Marina, Hurghada 1, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/126.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=57,
                Name="El Gouna Catamaran Cruise",
                Description="The El Gouna Catamaran Cruise is a luxurious and unforgettable sailing experience along the stunning Red Sea coast, offering tourists the chance to enjoy a smooth, stable, and elegant journey aboard a spacious catamaran. Departing from Abu Tig Marina in El Gouna, this excursion allows visitors to soak in the breathtaking seascapes while gliding over the crystal-clear turquoise waters. The modern double-hulled catamaran is specially designed for comfort, featuring shaded lounge areas, open sun decks, and cozy seating arrangements where passengers can relax and take in the spectacular views.During the cruise, the catamaran sails to some of the best snorkeling spots in the Red Sea, allowing guests to explore the vibrant underwater world teeming with colorful coral reefs, tropical fish, and exotic marine life. With high-quality snorkeling equipment provided on board, travelers can dive into the warm waters to swim among mesmerizing reef formations, where they may encounter clownfish, angelfish, rays, and even playful dolphins. For those who prefer to stay on deck, the catamaran offers glass-bottom viewing sections, providing a window into the Red Sea’s rich marine ecosystem without needing to get wet.One of the highlights of the El Gouna Catamaran Cruise is its relaxing and luxurious atmosphere. Passengers can sip on refreshing beverages, enjoy delicious onboard snacks, and unwind to the soothing sounds of the waves as the boat sails past the pristine beaches and untouched islands of the Red Sea. Some tours also include a sunset sailing option, where guests can witness the sun setting over the water, painting the sky in hues of orange, pink, and gold, creating an enchanting and romantic experience.The El Gouna Catamaran Cruise is perfect for families, couples, and adventure seekers looking for a unique and relaxing way to explore the Red Sea. Whether snorkeling in crystal-clear lagoons, sunbathing on the open deck, or simply enjoying the peaceful sailing experience, this catamaran adventure promises an unforgettable day at sea, making it one of the most sought-after excursions in El Gouna.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d226710.11612248895!2d33.537890016406244!3d27.39614669999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145267e1fecf1c25%3A0x19ae805d50a2245d!2sEl%20gouna%20lagoon%20trip%20-%20best%20lagoon%20trip!5e0!3m2!1sen!2seg!4v1743091703935!5m2!1sen!2seg",
                Address="El Gouna, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/131.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=58,
                Name="Mahmya Island Cruise",
                Description="Mahmya Island Cruise is one of the most luxurious and breathtaking island excursions in Egypt, offering visitors a chance to escape into a tropical paradise in the heart of the Giftun Islands, part of a protected marine reserve in the Red Sea. Mahmya, which means protected area in Arabic, is a stunning eco-tourism destination that blends relaxation, adventure, and conservation. The journey starts from Hurghada Marina, where guests board a comfortable yacht for a scenic cruise across the crystal-clear waters of the Red Sea. The 45-minute boat ride to Mahmya Island offers breathtaking views of turquoise lagoons, coral reefs, and marine life, setting the stage for an unforgettable day. Once on the island, guests step onto powdery white sandy beaches and are greeted by a luxurious beach setting with wooden cabanas, palm-thatched umbrellas, and sun loungers, creating an exclusive and serene environment. The pristine waters surrounding the island are home to some of the most vibrant coral reefs in the world, making it a paradise for snorkelers and divers. Guided snorkeling trips allow visitors to explore the rich marine biodiversity, including exotic fish, sea turtles, and vibrant corals. The coral reefs are part of the Giftun Islands National Park, a protected area that ensures the preservation of marine life.For those seeking adventure, the Mahmya Island Cruise also offers kayaking, paddleboarding, and beach volleyball, providing an active and fun-filled experience. The on-site beach restaurant serves a delicious variety of fresh seafood, Mediterranean, and Egyptian dishes, all while offering panoramic views of the Red Sea. Guests can enjoy refreshing tropical cocktails at the Mahmya Beach Bar, creating a true island getaway experience. Unlike some other Red Sea excursions, Mahmya emphasizes eco-friendly tourism, ensuring that the island’s natural beauty remains untouched. The island follows strict conservation rules, prohibiting plastic waste and promoting sustainable practices. After a relaxing day of swimming, sunbathing, and enjoying the serene surroundings, guests embark on the return cruise to Hurghada, often catching a stunning sunset over the Red Sea. The Mahmya Island Cruise is an unforgettable escape, offering visitors a blend of relaxation, adventure, luxury, and nature conservation—a must-do experience for anyone visiting the Red Sea.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3549.159678668513!2d33.95963030000001!3d27.182717700000005!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145284d89826aff5%3A0x19ffcf335924977d!2sMahmya%20Island!5e0!3m2!1sen!2seg!4v1743092271406!5m2!1sen!2seg",
                Address="Big Giftun Island, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/136.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=59,
                Name="Orange Bay Island Cruise",
                Description="The Orange Bay Island Cruise is one of the most popular and breathtaking sea excursions in Egypt, offering visitors a chance to experience the crystal-clear waters, pristine white sandy beaches, and vibrant marine life of the Giftun Islands National Park. Located about 40 minutes by boat from Hurghada, Orange Bay is a hidden gem in the Red Sea, often referred to as the Maldives of Egypt due to its shallow turquoise waters and picturesque scenery. The journey begins with a luxurious boat ride departing from Hurghada’s marina, where guests are welcomed with refreshments and a relaxing atmosphere on board. Along the way, the cruise stops at two of the best snorkeling sites in the Red Sea, allowing visitors to explore the mesmerizing coral reefs teeming with colorful fish, exotic marine species, and even playful dolphins if lucky. The snorkeling experience is guided by professional instructors, making it suitable for both beginners and experienced divers.Upon arrival at Orange Bay, visitors step onto the soft, powdery sands of the island, where they can unwind on sunbeds, wade in the shallow waters, or enjoy the island’s tropical-styled wooden walkways and shaded relaxation areas. The bay is part of the Giftun Islands protected area, ensuring that its natural beauty remains unspoiled. Guests can indulge in fresh seafood, tropical drinks, and Egyptian delicacies at the beachfront restaurants while taking in panoramic views of the endless blue sea. The island also offers activities such as beach volleyball, kayaking, and paddleboarding, making it a fantastic getaway for both relaxation and adventure seekers.As the day comes to an end, the return trip to Hurghada offers a spectacular view of the sun setting over the Red Sea, painting the sky in shades of orange, pink, and gold. Whether it's the incredible snorkeling, the crystal-clear waters, or the tranquil beachside relaxation, the Orange Bay Island Cruise provides an unforgettable tropical escape and is a must-visit experience for anyone traveling to Egypt’s Red Sea coast. ",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3548.343159531645!2d33.9265071!3d27.208373899999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145286b2fefa8723%3A0x1bc68880daea217e!2sOrange%20Bay!5e0!3m2!1sen!2seg!4v1743093034885!5m2!1sen!2seg",
                Address="Giftun island, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/141.jpg",
                AreaTypeId=5,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 60,
                Name = "Ain Sokhna Luxury Yacht Cruise",
                Description = "The Ain Sokhna Luxury Yacht Cruise is a premium sailing experience that offers an exclusive escape along the pristine waters of the Red Sea’s Gulf of Suez. Located just 120 kilometers east of Cairo, Ain Sokhna is the closest Red Sea resort to the Egyptian capital, making it a popular getaway for both locals and international tourists. The yacht cruise typically departs from the Ain Sokhna Marina, where guests are welcomed aboard luxurious private or shared yachts, equipped with modern amenities, sun decks, and shaded lounging areas. As the yacht sails across the calm turquoise waters, passengers are treated to stunning coastal views, with the Suez Mountains on one side and the endless expanse of the Red Sea on the other.During the journey, the yacht stops at secluded swimming spots where guests can take a refreshing dip in the crystal-clear waters. The vibrant coral reefs of Ain Sokhna provide an excellent opportunity for snorkeling, allowing visitors to witness colorful marine life, exotic fish species, and unique underwater landscapes. For those who enjoy fishing, many luxury yacht tours include deep-sea fishing excursions, where guests can try their luck at catching Red Sea fish while enjoying the serenity of the open sea. Some yacht packages also offer water sports activities such as jet skiing and paddleboarding, adding an element of adventure to the experience.Onboard, guests can relax on plush sun loungers, sip on refreshing drinks, and enjoy a gourmet lunch prepared by the yacht’s crew, featuring fresh seafood, Mediterranean dishes, and Egyptian delicacies. As the sun sets, the cruise takes on an even more magical atmosphere, with breathtaking views of the horizon painted in hues of orange, pink, and purple, creating a romantic and serene setting for couples and families alike.The Ain Sokhna Luxury Yacht Cruise is an ideal option for those looking for a short but indulgent Red Sea escape. Whether it's a private yacht rental for a special occasion, a corporate retreat, or simply a day of relaxation and adventure, this cruise provides a unique blend of luxury, nature, and recreation. Its proximity to Cairo makes it a perfect day trip or weekend getaway, allowing visitors to experience the beauty of the Red Sea without traveling far from the city.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d111108.91320144219!2d32.41912475!3d29.51188355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456f92823a1d05b%3A0x67e45d57a9707384!2sPrince%20Omar%20Yacht%20Charter!5e0!3m2!1sen!2seg!4v1743093393122!5m2!1sen!2seg",
                Address = "Ain El Sokhna - Zafarana Rd, Attaka, Suez Governorate, Egypt",
                ImageUrl = "AreaImages/146.jpg",
                AreaTypeId = 5,
                 Latitude=null,
               Longitude=null
            },
            // Safari: 10 61:70
            new Area
            {
                 Id=61,
                 Name="Ras Mohammed National Park",
                 Description=" Ras Mohammed is one of Egypt's most famous protected areas, known for its stunning coral reefs and marine biodiversity. It's a top destination for scuba diving and snorkeling, but you can also experience safari-like adventures in the park’s desert areas. Visitors can explore unique landscapes with salt flats, cliffs, and mangrove forests.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3529.520088042942!2d34.17803970000001!3d27.7937578!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145323f1925aa68d%3A0xd286ed81c3549345!2z2YXYrdmF2YrYqSDYsdij2LMg2YXYrdmF2K8!5e0!3m2!1sar!2seg!4v1743127700504!5m2!1sar!2seg",
                Address="South Sinai/near Sharm El Sheikh/Egypt",
                ImageUrl="AreaImages/download.jpeg",
                AreaTypeId=4,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=62,
                  Name="Wadi El Rayan",
                  Description="Wadi El Rayan is a beautiful nature reserve that features two large lakes, waterfalls, and stunning desert landscapes. It's home to several species of wildlife, such as gazelles, wild boars, and numerous bird species. Safari tours here include desert excursions, bird watching, and visits to the waterfalls and lakes.",
                  Location="https://www.google.com/maps/embed?pb=!1m12!1m8!1m3!1d222744.52824114964!2d30.4265728!3d29.2710744!3m2!1i1024!2i768!4f13.1!2m1!1sWadi%20El%20Rayan!5e0!3m2!1sar!2seg!4v1743128097733!5m2!1sar!2seg",
                  Address="Faiyum Governorate/Egypt",
                  ImageUrl="AreaImages/download (7).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=63,
                  Name="White Desert National Park",
                  Description="The White Desert is renowned for its striking white limestone formations that have been shaped by the wind. The desert safari here includes exploring surreal rock formations, sand dunes, and the famous White Desert or White Canyon. It's also home to rare wildlife like desert foxes and wild rabbits.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3545.965267928668!2d28.201003099999998!3d27.282963700000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14698f820dd216bb%3A0x7d7fc510e8b79ede!2sWhite%20Desert%20National%20Park!5e0!3m2!1sar!2seg!4v1743128386025!5m2!1sar!",
                  Address="Western Desert/Egypt",
                  ImageUrl="AreaImages/download (12).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=64,
                  Name="Siwa Oasis",
                  Description="Siwa Oasis is one of the most culturally rich locations in Egypt, famous for its ancient ruins, salt lakes, and lush palm groves. Safari tours here explore the desert landscape, visit the Temple of the Oracle (where Alexander the Great was reportedly confirmed as a god), and experience traditional Berber culture. It's a perfect spot for both cultural and desert safaris.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d55721.647680432594!2d25.526837849999996!3d29.2058135!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x147aaface8f3a523%3A0x6f335df8f19a074d!2z2LPZitmI2KnYjCDYs9mK2YjZh9iMINmF2K3Yp9mB2LjYqSDZhdi32LHZiNit!5e0!3m2!1sar!2seg!4v1743128634988!5m2!1sar!2seg",
                  Address="Western Desert/Egypt",
                  ImageUrl="AreaImages/images (2).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=65,
                  Name="Gilf Kebir National Park",
                  Description="Gilf Kebir is one of the most remote and untouched areas in Egypt. Known for its vast, unspoiled wilderness, the park offers incredible desert safaris through rugged terrain, ancient rock art, and prehistoric sites. It is one of the best places for experienced safari enthusiasts looking for a more challenging adventure in Egypt's deep deserts.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d58568.459942430316!2d25.874741553879776!3d23.441384693968104!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1410063ab7347f57%3A0x12e873630ff135b3!2z2KfZhNis2YTZgSDYp9mE2YPYqNmK2LE!5e0!3m2!1sar!2seg!4v1743129824061!5m2!1sar!2seg",
                  Address="Southern Egypt in the Western Desert/Egypt",
                  ImageUrl="AreaImages/download (18).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=66,
                  Name=" The Black Desert",
                  Description="The Black Desert gets its name from the scattered black volcanic rocks that cover the area. The landscape here is dotted with small mountains and valleys that provide perfect spots for desert safaris. You can explore these volcanic rock formations, climb the hills, and experience the silence and beauty of the desert.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3516.1794518460406!2d28.733067484927044!3d28.201859982589703!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1442a882b7230e65%3A0xc1daf109010ad569!2z2KfZhNi12K3Ysdin2KEg2KfZhNiz2YjYr9in2KE!5e0!3m2!1sar!2seg!4v1743130043213!5m2!1sar!2seg",
                  Address="Near the town of Bahariya in the Western Desert/Egypt",
                  ImageUrl="AreaImages/download (24).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=67,
                  Name="Lake Qarun",
                  Description="Lake Qarun is one of Egypt's largest lakes and is located in the Faiyum Oasis. It’s an ideal spot for birdwatching safaris, as it’s home to many migratory bird species, such as flamingos and pelicans. The surrounding area offers opportunities for desert safaris and exploring the nearby historical sites, like the ancient city of Herakleopolis.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d222305.23592434684!2d30.615244249999996!3d29.472043749999994!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145968cde9c10527%3A0xf5824db951045a46!2z2KjYsdmD2Kkg2YLYp9ix2YjZhg!5e0!3m2!1sar!2seg!4v1743130302913!5m2!1sar!2seg",
                  Address="Faiyum Governorate/Egypt",
                  ImageUrl="AreaImages/download (29).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=68,
                  Name="St. Katherine Protectorate",
                  Description="St. Katherine Protectorateis a vast protected area encompassing the famous St. Katherine Monastery and the surrounding mountains. It offers desert safaris in a unique mountainous landscape with breathtaking views. Visitors can hike in the mountains, see rare flora and fauna, and even try a sunrise safari to Mount Sinai, where Moses is said to have received the Ten Commandments.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3504.584523242638!2d33.9657163!3d28.5522054!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14548ffaeeef294d%3A0xa1ed9e3511c0a065!2z2YXYrdmF2YrYqSDYs9in2YbYqiDZg9in2KrYsdmK2YY!5e0!3m2!1sar!2seg!4v1743130596059!5m2!1sar!2seg",
                  Address=" South Sinai/Egypt",
                  ImageUrl="AreaImages/images (7).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=69,
                  Name="Ras Shaitan",
                  Description="  Ras Shaitan is a beautiful and remote desert area located on the Sinai Peninsula, near the Red Sea. This area is famous for its striking desert landscapes, clear waters, and scenic views of the surrounding mountains. It's a great spot for desert safaris and is less crowded than other areas in Sinai, offering a peaceful and unique experience. Visitors can enjoy desert camping, hiking, and diving in the Red Sea's coral reefs. The area is known for its relaxed vibe and offers a mix of desert and beach adventures.",
                  Location="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d27876.17318434005!2d34.70722276088889!3d29.149296511856704!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1sRas%20Shaitan!5e0!3m2!1sar!2seg!4v1743131052897!5m2!1sar!2seg",
                  Address=" Sinai Peninsula, near Nuweiba and Taba/Egypt",
                  ImageUrl="AreaImages/download (38).jpeg",
                  AreaTypeId=4,
                Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=70,
                  Name="Hurghada Desert Safari",
                  Description="Hurghada Desert Safari offers a perfect blend of desert exploration and coastal relaxation. Located near the Red Sea, this safari includes trips into the surrounding desert, camel rides, visits to Bedouin camps, and exciting activities like quad biking. The safari also gives visitors a chance to explore the mountains and desert near the coastal city, making it ideal for both desert and sea lovers.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7101.568105536557!2d33.78699002229003!3d27.131610900000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14527fc216288f41%3A0x1ea55533d38b31!2sSafari%20Sahara%20Hurghada!5e0!3m2!1sar!2seg!4v1743127460217!5m2!1sar!2seg",
                  Address=" Red Sea near Hurghada/Egypt",
                  ImageUrl="AreaImages/download (3).jpeg",
                  AreaTypeId=4,
                   Latitude=null,
               Longitude=null
            },
            //Sunken artifacts: 8 71:78
            new Area{
                  Id=71,
                  Name="Wadi Al Jarf Port",
                  Description="Hurghada Desert Safari offers a perfect blend of desert exploration and coastal relaxation. Located near the Red Sea, this safari includes trips into the surrounding desert, camel rides, visits to Bedouin camps, and exciting activities like quad biking. The safari also gives visitors a chance to explore the mountains and desert near the coastal city, making it ideal for both desert and sea lovers.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1784777.199303783!2d35.10118214375003!3d29.10884109999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456eb4f7ba1f903%3A0x8bc9e73622ab5e43!2sWadi%20Al%20Jarf!5e0!3m2!1sar!2seg!4v1743213027720!5m2!1sar!2seg",
                  Address="Red Sea / Egypt",
                  ImageUrl="AreaImages/Wadi Al Jarf.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=72,
                  Name="Qaitbay Fort site",
                  Description="The site lies at a depth of 6–8 m, covering an area of 2.25 ha in Alexandria. It dated to the Greco-Roman period but it includes artifacts from the Pharaonic period. Some of these artifacts are the remains of the lighthouse itself and the rest were brought from the Serapeum and thrown at the entrance of the harbor to prevent the entry of enemy fleets in the twelfth century A.C. Most important discoveries: - At a depth from 6 to 8 meters more than 3000 pieces were located, including statues, sphinxes, and columns of different shapes, capitals and bases of columns and parts of obelisks. - Blocks from different sizes and weights (some of them weighing75 tons). The artifacts’ materials aresuch as: granite, calcite, quartzite, limestone, sandstone and greywacke. - North of Qaitbay three wrecks were located. No wood remained, but amphorae, daily utensils as well as metal and stone anchors were found. The wrecks span from the third century BC to the seventh century AD. - fourth wreck was located to the west, carrying blocks of limestone probably from EI-Mex quarry, some 10 km west of Qaitbay, that were likely intended for construction purposes in Alexandria.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1706.12687214843!2d29.887773901605215!3d31.213698699999995!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c352282911bb%3A0xe59f8308f8b23d1f!2z2YLZhNi52Kkg2YLYp9mK2KrYqNin2You2KfYs9mD2YbYr9ix2YrYqQ!5e0!3m2!1sar!2seg!4v1743213309166!5m2!1sar!2seg",
                  Address="Alexandria / Egypt",
                  ImageUrl="AreaImages/Wonderful-pictures-of-Qaitbay-Citadel.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=73,
                  Name="Shatby",
                  Description="Submerged site has many pieces and architectural components and monuments where was located at the city's Royal Quarter and believed to contain remains of the Temple of ISIS . East of the Eastern Harbor of Alexandria, from Cape Silsileh to sidiBishr promontory. Most important discoveries: - Many site were discovered at El-Hassan reef,Chatby,Ibrahimieh,Sporting EL-Kour islets and BirMas’oud. - A large number of amphorae, concreted on the seabed, cover the El-Hassan reef and its contours marking the location of several shipwreck -Two sites were discovered in Shatby , and one is the sub-merged part of cape Silsileh that formed part of the Royal Ptolemaic quarters - 400 architectural elements of various stones lie on the seafloor - At Ibrahimieh, two sites have also been discovered. Some 50 small- and medium-size stone anchors dating to the Islamic period were raised from the first site that lies on a large reef at 13–15 m depth, 450 m from the shore. The second site lies in the shallows and consists of a large stone quarry, some shaft tombs as well as a complex grid of fish tanks. - At El-Dahab, El-Kour islets and BirMas’oud promontory demonstrated that these three sites and the submerged areas between them formed a large necropolis dating to the Graeco-Roman period. - -Numerous stone anchors and fishing tackle was found on the seabed north of El-Kour islet",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6824.7927010071835!2d29.916556558465164!3d31.209746773578306!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c477b40c63e5%3A0xc9d9b086a7ffac6b!2z2KfZhNi02KfYt9io2YrigI7YjCDYp9mE2KPYstin2LHZitiq2Kkg2YjYp9mE2LTYp9i32KjZitiMINmC2LPZhSDYqNin2Kgg2LTYsdmC2YrYjCDZhdit2KfZgdi42Kkg2KfZhNil2LPZg9mG2K_YsdmK2Kk!5e0!3m2!1sar!2seg!4v1743213365188!5m2!1sar!2seg",
                  Address="Alexandria / Egypt",
                  ImageUrl="AreaImages/11A.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },  
            new Area{
                  Id=74,
                  Name="Mamoura Bay",
                  Description="The Mamoura Bay at Alexandria is a vast bay stretching from the royal Montaza gardens in the west to the gulf of Abu Qir in the east. The bay was the gateway to the ships coming from the Mediterranean on their way to the Nile. By hugging the coast of the bay, the ships traveled to the Canopic branch of the Nile and transported their goods to all of Egypt.\r\nPottery sherds and amphorae were found scattered on the bay’s seabed, a testament to the many shipwrecks that took place here. The artifacts testify to the flourishing trade between Egypt and the world. A survey of the seabed revealed an ancient Roman shipwreck, remains of which are still present today.\r\nLittle is known about Mamoura Bay, but excavations are gradually providing us with information on the area. A small port and paving dating to the Greco-Roman Period were found, along with the limestone quarry that was used to build them.\r\nRock cut basins were also discovered and are thought to be evidence of fish farming, raising the possibility of a settlement that was once located here",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3409.4674770704523!2d30.03324282494!3d31.29082215844822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5d0dc8232f1b5%3A0xca05b625c94574ea!2z2LTYp9i32YnYoSDYp9mE2YXYudmF2YjYsdip!5e0!3m2!1sar!2seg!4v1743213469763!5m2!1sar!2seg",
                  Address="Alexandria / Egypt",
                  ImageUrl="AreaImages/photo-alexandria-8.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=75,
                  Name="Saadana Island",
                  Description="Saadana Island, on the Red Sea coast north of Safaga in Red Sea governorate, is home to a shipwreck that offers us a rare glimpse into 18th Century trade. This area in the sea is difficult to navigate due to its shallow waters and multitude of corals, which is probably the reason the ship sank in the 1760’s.\r\n\r\nThe ship was 50 meters long and was carrying about 900 tons of cargo. Excavations revealed that the ship was carrying Chinese Qing Dynasty porcelain that was fashioned for the Middle East. Many spices were also found aboard the ship including pepper, cardamom and nutmeg from India; frankincense from Oman; as well as, coconuts, olives and hazelnuts among other things.\r\n\r\nThe ship does not resemble other ships from this period, and so its origin remains unknown. However, its contents shed light on the intensive and far reaching trade that occurred during this time, and Egypt’s ports as the link between the east and the west.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d57003.65944190454!2d33.97678757262218!3d26.753031890907597!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d0d2c5606c925%3A0x67d911822e470041!2z2LPZgdin2KzYp9iMINmF2K3Yp9mB2LjYqSDYp9mE2KjYrdixINin2YTYo9it2YXYsQ!5e0!3m2!1sar!2seg!4v1743213765278!5m2!1sar!2seg",
                  Address=" Red Sea / Egypt",
                  ImageUrl="AreaImages/A15.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=76,
                  Name="Eastern Harbor",
                  Description="ounded by Alexander the Great, Alexandria was once a thriving city among the most prominent cities in the ancient world, and the capital of Ptolemaic Egypt. The eastern harbor was the royal port of Alexandria and once had palaces, temples and the legendary Pharos Lighthouse, one of the Seven Wonders of the World. Today, the remains of the city have been submerged under the Mediterranean Sea.\r\nThe most prominent monument from the harbor was the Pharos Lighthouse that was commissioned by Ptolemy I Soter I in 297 B.C, and that was a landmark in the ancient city. The lighthouse stood 130 meters tall and had a beacon that guided ships to the port from up to 50 kilometers at sea. The beacon consisted of a fire that was reflected off of a massive bronze mirror. The lighthouse deteriorated with time and after an earthquake in the 14th Century, it collapsed.\r\nRecent excavations at the harbor discovered a marble floor believed to be part of Cleopatra’s palace. A temple to Isis, sphinxes and statues were also found at the harbor submerged on the seabed. Continued excavations at the site will undoubtedly reveal a lot more.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13649.720738297334!2d29.906281701250546!3d31.208809092264904!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c3f73051e53b%3A0x143a6bd9d978d9e2!2z2KfZhNmF2YrZhtin2KEg2KfZhNi02LHZgtmK2Kk!5e0!3m2!1sar!2seg!4v1743214020068!5m2!1sar!2seg",
                  Address="Eastern Port / Alexander / Egypt",
                  ImageUrl="AreaImages/images-_4_.png",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=77,
                  Name="Abu Qir Bay",
                  Description="The two cities Canopies and Heraklion occupied their position in Abu Qir Bay before the construction of Alexandria. They were very prosperous and derived their wealth from taxes levied on goods brought into nearby ports to be carried to the Nile.\r\nThe ruins of the two cities are recently discovered, as parts of a temple and statues of deities appeared, and the archaeological evidence indicates their collapse in the fourth century BC and their drowning in the sea, but the mystery surrounds the details of their fall. Eighteenth-century travelers used to search along the ancient ports hoping to find the remains of the two stricken cities.\r\nTo this day, it is not known exactly what catastrophe led to their disappearance, as some have suggested that an earthquake or a flood led to their demise.",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13636.539449166281!2d30.176966751191184!3d31.300017473861775!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f678af6c2a2b4b%3A0xa24bf0e677080bdf!2z2K7ZhNmK2Kwg2KPYqNmKINmC2YrYsQ!5e0!3m2!1sar!2seg!4v1743213980141!5m2!1sar!2seg",
                  Address="Abu Qir / Alexandria / Egypt",
                  ImageUrl="AreaImages/csm_01_Hera-CG-035_373aa8da94.jpg",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            new Area{
                  Id=78,
                  Name="Aswan",
                  Description="During ancient times, the Nile was the primary mode of transportation in Egypt. Massive stones were transported on ships from quarries in the south intended for tombs, temples and other monuments in the north.\r\nAswan had two quarries that were extensively used; granite was brought from Aswan, and sandstone from Gebel El Silsila.\r\nThe journey undertaken by the ships carrying such heavy loads was not always successful, and some sunk in the Nile. In addition, some massive stones fell during their transfer onto the ships and now lie in the river’s depths. A quay for the transport of the heavy stones has been identified at Elephantine, called El -Ahly Quay, and is believed to have been one of the primary quays used. A smaller quay was also found at El Naga El Bahari",
                  Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d29138.075015084505!2d32.92070585620299!3d24.092372397516648!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367b5ab1a30e5f%3A0xfb109fe337cabccb!2z2KPYs9mI2KfZhtiMINmF2K3Yp9mB2LjYqSDYo9iz2YjYp9mG!5e0!3m2!1sar!2seg!4v1743213929428!5m2!1sar!2seg",
                  Address="Aswan / Egypt",
                  ImageUrl="AreaImages/Gebel_el-Silsila,_Asuan,_Egypt.JPG",
                  AreaTypeId=3,
                   Latitude=null,
               Longitude=null
            },
            // Gblya: 10 81:90
            new Area{
                Id=81,
                Name="Mount Sinai (Jebel Musa)",
                Description="Mount Sinai, also known as Jebel Musa, is one of Egypt’s most iconic and sacred mountains, rising 2,285 meters (7,497 feet) above sea level. Located in the heart of the Sinai Peninsula, this mountain holds deep religious and historical significance, making it a major pilgrimage site for Christians, Muslims, and Jews alike. According to biblical tradition, it is believed to be the mountain where Moses received the Ten Commandments from God.The mountain is famous for its spectacular sunrise and sunset views, attracting thousands of visitors who embark on the challenging hike to the summit. There are two main routes to reach the top:The Camel Path (Siket Sayidna Musa) – A longer but easier route with a gradual incline, often used by those riding camels partway.The Steps of Repentance (Siket El Bashait) – A more challenging route with 3,750 stone steps, carved by monks centuries ago.At the summit, visitors find a small chapel and a mosque, both commemorating the site’s religious importance. The view from the peak is breathtaking, offering a panoramic view of the surrounding mountains under a sky that turns fiery red, orange, and gold at sunrise.At the base of Mount Sinai lies the Saint Catherine’s Monastery, one of the oldest Christian monasteries in the world, built in the 6th century. It houses ancient manuscripts, mosaics, and the Burning Bush, which, according to tradition, is where God spoke to Moses.Mount Sinai is not only a religious site but also a paradise for hikers, adventurers, and nature lovers. The rugged landscape, the tranquility of the Sinai Desert, and the spiritual atmosphere make it an unforgettable destination.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14020.02726993186!2d33.97531525!3d28.5395148!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1454855532dfc1cf%3A0x8f6d107a766ebf7!2sJabal%20Mousa!5e0!3m2!1sen!2seg!4v1743003896495!5m2!1sen!2seg",
                Address="South Sinai, Saint Catherine, Egypt",
                ImageUrl="AreaImages/1.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=82,
                Name="Saint Catherine Mountain",
                Description="Saint Catherine Mountain (Jebel Katarina) is Egypt’s highest peak, towering at 2,629 meters (8,625 feet) above sea level. It is located in the rugged and dramatic landscape of South Sinai, surrounded by breathtaking valleys and ancient religious sites. The mountain is named after Saint Catherine of Alexandria, an early Christian martyr, and is considered a sacred site in Christianity.This mountain is a hiker’s paradise, offering one of the most challenging and rewarding climbs in Egypt. Unlike its more famous neighbor, Mount Sinai (Jebel Musa), Saint Catherine Mountain is less crowded, making it an ideal destination for adventurers seeking solitude and unspoiled natural beauty. 1- The Hiking Experience The ascent takes 4-6 hours depending on fitness level. The most popular route starts near Saint Catherine’s Monastery, passing through rocky pathways, ancient Bedouin trails, and steep slopes.The summit offers one of the best panoramic views in Egypt, with clear skies revealing the Red Sea, the Gulf of Aqaba, and even Saudi Arabia on a clear day.At the top, there is a small chapel, built in honor of Saint Catherine, where pilgrims and visitors reflect in silence. 2- History & Significance. Saint Catherine Mountain is deeply intertwined with Biblical and monastic history. According to Christian tradition, Saint Catherine’s relics were miraculously transported to the mountain’s peak by angels, leading to the construction of Saint Catherine’s Monastery in the 6th century.The region is also home to the Jebeliya Bedouin tribe, who have lived in the area for centuries, offering hospitality to travelers and maintaining ancient traditions. 3- Flora & Fauna.The mountain is part of the Saint Catherine Protectorate, a national park known for its unique biodiversity. It hosts:Rare medicinal plants found only in Sinai.Desert foxes, ibexes, and wild rabbits.Migratory birds and Sinai’s unique butterfly species. 4- Best Time to Visit.Autumn (September-November) and Spring (March-May) are the best seasons for hiking, with mild temperatures.Winter (December-February) can bring snowfall, making it a magical but challenging trek.Summer (June-August) is extremely hot and should be avoided.Saint Catherine Mountain is not just a mountain—it is a spiritual retreat, a natural wonder, and a historic treasure. Whether you are looking for a thrilling adventure, a spiritual journey, or breathtaking scenery, this peak offers it all.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14023.990158363955!2d33.95527769999998!3d28.509721750000008!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145485210abc0239%3A0x41281dd36680e7b4!2sMount%20Catherine!5e0!3m2!1sen!2seg!4v1743005728911!5m2!1sen!2seg",
                Address="South Sinai, Saint Catherine, Egypt",
                ImageUrl="AreaImages/6.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=83,
                Name="Jebel Serbal",
                Description="Jebel Serbal is one of the most stunning and historically significant mountains in Egypt, rising 2,070 meters (6,791 feet) above sea level. Located in South Sinai, it stands out with its jagged, granite peaks, making it one of the most dramatic landscapes in the region. Unlike Mount Sinai (Jebel Musa) and Saint Catherine Mountain, Jebel Serbal is less visited and more remote, offering an off-the-beaten-path adventure for trekkers and explorers.The Trekking Experience :One of the most difficult climbs in Sinai, requiring 2 to 3 days to fully explore. Trails start from Wadi Feiran, an oasis with deep historical and religious significance. The route is rugged and steep, with dramatic cliffs, hidden valleys, and ancient rock formations.The summit offers one of the best panoramic views in Sinai, with breathtaking sights of the Gulf of Suez, the Red Sea, and the endless desert beyond. Unlike Mount Sinai, which is famous for its religious pilgrimages, Jebel Serbal is more associated with ancient Egyptian history and Bedouin culture.Historical & Religious Significance: Jebel Serbal was once considered the true biblical Mount Sinai by some early historians before Mount Sinai (Jebel Musa) was widely accepted as the sacred mountain where Moses received the Ten Commandments.At the foot of the mountain lies Wadi Feiran, known as the Pearl of Sinai. This oasis is rich with Christian and Bedouin heritage, home to ancient churches, monastic ruins, and palm groves. It is believed to be the site where the Israelites camped during their exodus from Egypt.Ancient Byzantine monks once lived in the caves and rock shelters of Jebel Serbal, leaving behind inscriptions and ruins of small monasteries. Rock carvings and petroglyphs dating back to early human civilizations can still be found in the area. Nature & Wildlife: Jebel Serbal is located within the Saint Catherine Protectorate, home to a diverse range of rare plant species, mountain foxes, ibexes, and eagles. The mountain's hidden valleys shelter natural springs, making it an important ecological site in the arid Sinai landscape. Bedouin Culture & Traditions: The Jebeliya Bedouin tribe, who have lived in the Sinai region for centuries, consider Jebel Serbal a sacred and powerful place. Local Bedouin guides lead camel-assisted treks and hikes, sharing their deep knowledge of the land, medicinal plants, and ancient legends.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14005.780405291913!2d33.651666999999996!3d28.6463885!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14546524b6e1dea5%3A0x735068ac12e53a4d!2sMount%20Serbal!5e0!3m2!1sen!2seg!4v1743006302246!5m2!1sen!2seg",
                Address="South Sinai, Saint Catherine, Egypt",
                ImageUrl="AreaImages/11.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=84,
                Name="Jebel Umm Shomer",
                Description="Jebel Umm Shomer is the second-highest mountain in Egypt, reaching 2,586 meters (8,484 feet) above sea level. Located in South Sinai, this rugged peak is known for its remote, untouched beauty and extreme difficulty, making it one of the most challenging hikes in the region. Unlike Mount Sinai or Saint Catherine Mountain, which have marked trails and religious significance, Jebel Umm Shomer is a wild, off-the-grid adventure best suited for experienced hikers and mountaineers.The landscape surrounding Jebel Umm Shomer is characterized by steep granite cliffs, deep valleys, and breathtaking panoramic views. The trek to the summit takes hikers through narrow canyons, rocky plateaus, and challenging ascents, with the final climb requiring scrambling over boulders and loose rock.At the summit, trekkers are rewarded with spectacular 360-degree views of the Red Sea, the Gulf of Suez, and even Saudi Arabia on a clear day. The region is part of the Saint Catherine Protectorate, home to rare wildlife, Bedouin culture, and ancient rock inscriptions left by early travelers.Due to its remote location and lack of marked trails, hiking Jebel Umm Shomer requires a local Bedouin guide, a high level of fitness, and strong navigation skills. The best time to visit is during spring (March-May) and autumn (September-November) when temperatures are moderate.Jebel Umm Shomer is perfect for those seeking solitude, adventure, and a true wilderness experience, making it one of Egypt’s most rewarding yet least-explored mountains.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14043.517065336086!2d33.9152778!3d28.362499550000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14537dba75afdb83%3A0x59044524169158bd!2sJabal%20Umm%20Sh%C5%ABmar!5e0!3m2!1sen!2seg!4v1743007336654!5m2!1sen!2seg",
                Address="South Sinai, Saint Catherine, Egypt",
                ImageUrl="AreaImages/16.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=85,
                Name="The Red Mountain (Gabal Ahmar)",
                Description="Gabal Ahmar, meaning The Red Mountain, is an ancient hill and quarry site located on the eastern edge of Cairo. It is historically significant as one of Egypt’s most famous sources of red and pink quartzite, a stone that was used extensively in ancient Egyptian temples, statues, and obelisks.Dating back to Pharaonic times, Gabal Ahmar was one of the primary quarries where hard quartzite stone was extracted and transported along the Nile River to be used in monumental structures such as temples, pyramids, and royal tombs. Some of the most famous artifacts carved from Gabal Ahmar quartzite include statues of Amenhotep III and Ramses II.The mountain itself is not very high, but its deep red-hued rock formations give it a striking appearance. Over centuries, extensive quarrying has changed its shape, leaving behind rugged cliffs and exposed rock faces that tell the story of ancient Egyptian stonework.Today, Gabal Ahmar is partly urbanized, with modern developments surrounding the area, but it remains an important archaeological and geological site. Researchers and archaeologists continue to study the quarry to learn more about ancient Egyptian stone-cutting techniques and construction methods.Although not a traditional tourist destination for hiking or climbing, Gabal Ahmar is a fascinating site for those interested in ancient Egyptian history, geology, and archaeology.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3530943.4631648134!2d32.99444445!3d30.2032105!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14548518eded8d33%3A0x223325c4d33f0517!2sGabal%20Al%20Ahmar!5e0!3m2!1sen!2seg!4v1743010399067!5m2!1sen!2seg",
                Address="Cairo, Egypt",
                ImageUrl="AreaImages/21.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=86,
                Name="Gebel Elba",
                Description="Gebel Elba, also known as Jabal Elba, is a mountain and protected biosphere reserve in southeastern Egypt. Standing at 1,435 meters (4,708 feet) above sea level, it is one of the tallest mountains in Egypt and part of the Hala’ib Triangle region, a remote and ecologically unique area.Unlike the arid landscapes typical of Egypt, Gebel Elba has a surprisingly lush environment, earning it the nickname Egypt’s Hidden Rainforest. This is due to a phenomenon known as orographic rainfall, where moisture from the Red Sea condenses on the mountain slopes, creating a microclimate that supports rare plant and animal species.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14776.221723002536!2d36.3333333!3d22.199999650000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x15cec16a21a4547d%3A0xf41c571c9b577e0d!2sJabal%20%60Ilbah!5e0!3m2!1sen!2seg!4v1743011014086!5m2!1sen!2seg",
                Address=" Halayeb, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/26.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=87,
                Name="Gebel Shayeb El-Banat",
                Description="Located approximately 80 km west of Hurghada, in Egypt’s Eastern Desert.Accessible via off-road vehicles from Hurghada or Safaga, requiring a local guide due to rough terrain.Closest major road: Hurghada-Safaga Highway, from which an off-road journey leads into the mountain area. Description of Gebel Shayeb El-Banat Gebel Shayeb El-Banat is one of the highest peaks in Egypt’s Eastern Desert, reaching 2,187 meters (7,175 feet) above sea level. It is part of the Red Sea Mountain Range and is notable for its rugged granite formations, steep cliffs, and breathtaking desert landscapes.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14222.380043047953!2d33.486389!3d26.97972155!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d93ab2c654871%3A0xd276c48ba35c31f9!2sShaiyb%20al-Banat!5e0!3m2!1sen!2seg!4v1743011594254!5m2!1sen!2seg",
                Address="Hurghada, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/31.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=88,
                Name="Black Mountain (Gebel Dokhan)",
                Description="Located approximately 120 km west of Hurghada in the Eastern Desert of Egypt.Accessible from Hurghada, Safaga, or Qena via off-road desert routes.A 4x4 vehicle and an experienced local guide are highly recommended due to the harsh terrain.Description of Gebel Dokhan (Black Mountain). Gebel Dokhan, commonly known as Black Mountain, is a historically significant mountain range in Egypt's Eastern Desert. It reaches an altitude of 1,091 meters (3,579 feet) and is famous for its ancient quarries of Porphyry of the Pharaohs, a rare purple-hued volcanic rock that was prized in ancient Egypt and the Roman Empire. Geological & Natural Features Volcanic origin: The mountain is composed of igneous rock, mainly porphyry, giving it a dark, rugged appearance.Harsh desert environment: The surrounding landscape consists of rocky plateaus, dry wadis (valleys), and steep cliffs.Extreme temperatures: Summers are extremely hot, while winter nights can be cold and windy. Historical & Archaeological Importance Famous for its ancient porphyry quarries, which were extensively mined by the Romans from 18 BCE onwards.Porphyry from Gebel Dokhan was used for royal palaces, columns, and statues, especially in Rome and Constantinople.Ruins of ancient Roman quarrying sites, including workshops, tools, and workers' settlements, can still be seen today.Some of the most famous structures built with this stone include the columns of Hagia Sophia in Istanbul and various Roman palaces. Adventure & Exploration :Gebel Dokhan is an excellent destination for off-road desert expeditions, hiking, and historical exploration.The area is remote and requires preparation, including water, supplies, and navigation equipment.Trekking through the ancient quarries provides a glimpse into the past, showcasing how early civilizations extracted and transported heavy stone blocks across the desert.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14192.528719556518!2d33.275000000000006!3d27.214999549999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144df790cf93e8f5%3A0xce9d7761279dc840!2zSmFiYWwgQWLFqyBEdWtoxIFu!5e0!3m2!1sen!2seg!4v1743012706390!5m2!1sen!2seg",
                Address=" Hurghada, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/36.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=89,
                Name="Gebel Qatrani",
                Description="Gebel Qatrani is a significant geological and archaeological site located in the Fayoum region of Egypt. Known for its ancient fossil beds, prehistoric artifacts, and basalt quarries, it provides a unique window into Egypt’s prehistoric past. The mountain’s landscape consists of rocky plateaus, wind-eroded formations, and vast desert expanses, making it an important site for both geologists and archaeologists.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d13867.363929072875!2d30.5975!3d29.666388449999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1459146806891bcd%3A0x86591d80c7e608db!2zSmFiYWwgUWHFo3LEgW7Eqw!5e0!3m2!1sen!2seg!4v1743013274438!5m2!1sen!2seg",
                Address="Fayoum Governorate, Egypt",
                ImageUrl="AreaImages/41.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            new Area{
                Id=90,
                Name="Gebel Zeit (Jebel Zayt)",
                Description="Gebel Zeit, also known as Jebel Zayt, is a majestic mountain range rising along Egypt’s eastern desert, overlooking the Red Sea. Known for its dramatic rock formations, mineral-rich landscape, and powerful desert winds, the area holds both natural and industrial significance.The rugged cliffs and slopes of Gebel Zeit are composed of ancient sedimentary rock formations, some dating back millions of years. Fossilized marine life, including coral and shell imprints, can be found in the limestone, offering evidence of the Red Sea’s prehistoric past. The surrounding desert is an expanse of golden sands, rocky plateaus, and hidden valleys.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14100.27270340208!2d33.51222219999999!3d27.93055515!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1453b43c761ffd21%3A0x32f04710b52c27b!2sJabal%20Zayt!5e0!3m2!1sen!2seg!4v1743013654960!5m2!1sen!2seg",
                Address="Ras Gharib and Hurghada, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/46.jpg",
                AreaTypeId=6,
                 Latitude=null,
               Longitude=null
                },
            // Ryfya & 6by3ya W Astgmam: 10 91:100
            new Area{
                Id=91,
                Name="Siwa Oasis",
                Description = "Siwa Oasis, located in Egypt’s Western Desert near the Libyan border, is one of the country’s most enchanting and isolated destinations. Situated about 750 km west of Cairo and 300 km south of Marsa Matrouh, it is known for its stunning landscapes, ancient history, and unique Berber culture. Surrounded by vast golden dunes of the Great Sand Sea, Siwa is a lush paradise filled with palm groves, freshwater springs, and salt lakes with mesmerizing turquoise hues. Historically, Siwa gained fame when Alexander the Great visited the Temple of the Oracle of Amun in 331 BCE, seeking confirmation of his divine ancestry. The temple, located on Aghurmi Hill, still stands as a testament to the oasis’s historical significance. Another major attraction is the Shali Fortress, a medieval mudbrick citadel that once protected the Siwan people from invaders. The fortress offers stunning panoramic views of the surrounding oasis and remains a symbol of Siwa’s unique architectural heritage. Visitors can also explore Cleopatra’s Spring, a natural hot spring believed to have been used by the legendary queen, where locals and tourists alike swim in its refreshing waters. Not far from there, Bir Wahed, a hidden gem in the desert, offers both a hot spring and a cold freshwater spring, providing a surreal bathing experience in the middle of the sands. Siwa’s salt lakes, including Fatnas Island and Maraqi Lake, are known for their high salinity, allowing visitors to float effortlessly while enjoying breathtaking scenery. The oasis is also famous for Gebel Dakrur, a mountain believed to have therapeutic sand with healing properties, attracting those seeking natural remedies for joint pain and rheumatism. Apart from its natural wonders, Siwa boasts a rich cultural heritage, being home to one of Egypt’s last remaining Berber communities. The Siwan people have their own distinct language, traditions, and crafts, particularly famous for handmade silver jewelry, pottery, and intricately embroidered clothing. The local markets, particularly in Shali, offer a chance to buy authentic Berber souvenirs. Siwan cuisine, featuring traditional Berber bread, dates, olives, and aromatic herbal tea, provides a delightful culinary experience. For adventure seekers, Siwa is a gateway to the **Great Sand Sea**, offering thrilling desert safaris, sandboarding, and camel trekking, while its remote location makes it one of Egypt’s top destinations for **stargazing and overnight desert camping, where visitors can enjoy traditional music and Bedouin-style feasts under the vast, star-filled sky. Whether exploring its ancient ruins, relaxing in its crystal-clear springs, or venturing into the endless dunes, Siwa Oasis offers a rare combination of history, nature, and cultural richness, making it one of Egypt’s most extraordinary rural tourism destinations.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d55721.647680432594!2d25.526837849999996!3d29.2058135!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x147aaface8f3a523%3A0x6f335df8f19a074d!2sSiwa%20Oasis%2C%20Siwa%2C%20Marsa%20Matrouh%20Governorate!5e0!3m2!1sen!2seg!4v1743074607783!5m2!1sen!2seg",
                Address="Matrouh Governorate, Egypt",
                ImageUrl="AreaImages/51.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=92,
                Name="Bahariya Oasis",
                Description = "Bahariya Oasis is located in Egypt's Western Desert, approximately 370 kilometers southwest of Cairo. Nestled amidst the vast expanse of golden dunes and rugged desert terrain, Bahariya is one of the country's most famous oases, known for its lush palm groves, natural springs, and rich archaeological heritage. This oasis, which has been inhabited since ancient times, served as an important agricultural and trade center in Pharaonic and Greco-Roman periods, with evidence of its historical significance found in its well-preserved tombs and temples. One of its most famous discoveries is the Valley of the Golden Mummies, an extensive Greco-Roman necropolis that revealed over 200 mummies adorned with gilded masks, offering a glimpse into the wealth and artistry of the region's ancient inhabitants. Other significant sites include the Temple of Alexander the Great, which stands as one of the few temples in Egypt dedicated to the Macedonian ruler, and the Tombs of the Nobles, featuring intricately painted burial chambers belonging to high-ranking officials of the 26th Dynasty. The oasis is also home to the Black Desert, a surreal landscape characterized by volcanic hills covered in black basalt, and the White Desert, a stunning area of chalk rock formations sculpted by wind erosion into bizarre and otherworldly shapes. Bahariya is renowned for its hot and cold springs, such as Bir Sigam and the Ain El-Beshmo spring, which are believed to have therapeutic properties due to their high mineral content. These natural pools offer a refreshing escape from the desert heat and attract both locals and tourists seeking relaxation and rejuvenation. The oasis is surrounded by striking mountainous landscapes, including Gebel Dist and Gebel Maghrafa, where fossilized remains of prehistoric creatures, such as the enormous dinosaur Paralititan stromeri, have been unearthed. Traditional Bedouin culture is still vibrant in Bahariya, with its local inhabitants, known as the Wahati people, preserving customs that date back centuries. Visitors can experience their warm hospitality, sample authentic desert cuisine featuring dishes like tagine, fresh dates, and hand-baked bread, and explore traditional crafts such as handmade pottery and woven textiles. For adventure enthusiasts, Bahariya offers numerous desert excursions, including jeep safaris, sandboarding, and overnight camping under the starlit sky, where the serenity of the desert provides an unparalleled experience. The unique combination of ancient history, breathtaking landscapes, and deep-rooted traditions makes Bahariya Oasis an extraordinary destination for those seeking to uncover Egypt's hidden desert treasures.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d7020.340051405335!2d28.909345300000002!3d28.38393215!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145d4c4dbf085545%3A0x5529fee10bed8fdc!2sBahariya%20Oasis%2C%20Al%20Wahat%20Al%20Baharia%2C%20Giza%20Governorate!5e0!3m2!1sen!2seg!4v1743076524206!5m2!1sen!2seg",
                Address="Cairo, Egypt",
                ImageUrl="AreaImages/56.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=93,
                Name="Fayoum & Tunis Village",
                Description="Fayoum is a picturesque region in Egypt, located approximately 100 kilometers southwest of Cairo, making it one of the easiest rural escapes from the capital. Known as Egypt’s oldest oasis, Fayoum is fed by the Bahr Yussef, a branch of the Nile, which sustains its fertile lands, vast lakes, and lush palm groves. It has been a center of civilization for thousands of years, with evidence of human settlement dating back to Pharaonic times, and it is renowned for its archaeological treasures, including the Pyramid of Hawara built by Pharaoh Amenemhat III, the ancient city of Karanis with its well-preserved Greco-Roman ruins, and the stunning Valley of the Whales (Wadi Al-Hitan), a UNESCO World Heritage Site where visitors can see the fossilized remains of prehistoric whales that lived millions of years ago when the area was covered by an ancient sea. In addition to its rich history, Fayoum is famous for its breathtaking natural beauty, especially Lake Qarun, one of Egypt’s largest and oldest lakes, where visitors can enjoy boat rides, birdwatching, and fishing, with migratory flamingos and pelicans often seen along its shores. The region is also home to Wadi El Rayan, a protected area featuring Egypt’s only waterfalls, formed by man-made channels connecting two picturesque lakes, attracting nature lovers, hikers, and those seeking tranquil desert landscapes. Within this oasis lies Tunis Village, a hidden gem that has become one of the most artistic and culturally rich destinations in Egypt. Originally a quiet farming village, Tunis has been transformed into an artistic hub, particularly famous for its pottery scene, which was introduced in the 1980s by Swiss artist Evelyne Porret, who established a pottery school that continues to train local artisans and children in the craft. The village is dotted with charming mud-brick houses, boutique lodges, and artisan workshops where visitors can learn traditional pottery-making techniques or purchase beautifully handcrafted ceramics. The village exudes a peaceful, bohemian atmosphere, attracting artists, writers, and travelers seeking a break from urban life. Surrounded by verdant farmland, palm groves, and scenic desert hills, Tunis Village is also a haven for eco-tourism, offering activities such as horseback riding, cycling, and hiking through the stunning Fayoum countryside. The annual Tunis Village Pottery Festival brings together artisans from across Egypt, showcasing local craftsmanship and cultural performances, making it a must-visit event for art and culture enthusiasts. The culinary scene in Fayoum and Tunis Village is equally inviting, with small local restaurants and eco-lodges serving delicious home-cooked meals, featuring fresh ingredients from nearby farms, including locally produced honey, cheese, and traditional Egyptian dishes like fatta and roasted duck. The combination of Fayoum’s ancient heritage, natural wonders, and the artistic vibrancy of Tunis Village makes this region one of Egypt’s most unique rural tourism destinations, offering an enchanting blend of history, nature, and culture.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d6951.817404004012!2d30.486290749999995!3d29.402226749999997!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14595dcfd694f1e1%3A0x32c03a30b7f6f530!2sTunis%2C%20Qaroun%2C%20Youssef%20Al%20Seddik%2C%20Faiyum%20Governorate!5e0!3m2!1sen!2seg!4v1743078504182!5m2!1sen!2seg",
                Address="Faiyum Governorate, Egypt",
                ImageUrl="AreaImages/61.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=94,
                Name="Nubian Villages(Aswan)",
                Description="The Nubian Villages are located along the banks of the Nile in southern Egypt, primarily around Aswan and Lake Nasser, with some of the most famous villages being Gharb Soheil, Siou, and Heissa Island. These villages are home to the indigenous Nubian people, one of Egypt’s oldest and most culturally distinct communities, whose history dates back thousands of years to the time of the ancient Kingdom of Kush. The Nubians have preserved their unique traditions, language, and architectural style despite historical challenges, including displacement following the construction of the Aswan High Dam in the 1960s, which led to the flooding of Old Nubia and the loss of many ancestral lands. Today, Nubian villages are known for their vibrant, colorful houses painted in bright blues, yellows, and pinks, often adorned with intricate murals depicting scenes of daily life, geometric patterns, and religious symbols. The villages are characterized by a warm and welcoming atmosphere, where visitors are greeted with traditional hospitality, including offers of hibiscus tea, fresh dates, and local delicacies. Nubian culture is deeply rooted in music and dance, with traditional instruments such as the tar and tambour playing a central role in celebrations, while folklore and storytelling remain essential aspects of community life. Visitors can explore local markets filled with handcrafted jewelry, woven baskets, and textiles, often featuring bold patterns and bright colors reflecting Nubian aesthetics. One of the best ways to experience the villages is by taking a felucca or motorboat ride along the Nile, offering stunning views of the palm-fringed shores, golden sand dunes, and the lush greenery that contrasts sharply with the arid desert landscape. Many visitors also stop at Heissa Island, one of the last remaining inhabited Nubian islands, where they can learn about the community’s efforts to preserve their heritage and sustainable way of life. Beyond their cultural richness, the Nubian villages serve as gateways to some of Aswan’s most famous landmarks, including the majestic Philae Temple, dedicated to the goddess Isis, and the colossal Abu Simbel Temples, relocated stone by stone to save them from being submerged by the rising waters of Lake Nasser. The natural beauty of the region is equally mesmerizing, with golden sands meeting the deep blue of the Nile, making it a perfect place for relaxation and photography. The Nubian people take great pride in their identity, and their villages remain one of the best places in Egypt to experience an authentic, living culture that has endured for millennia. Whether exploring the narrow alleys lined with hand-painted houses, engaging in lively conversations with locals, or enjoying a traditional Nubian meal, a visit to the Nubian villages offers a deeply immersive and unforgettable experience into one of Egypt’s most vibrant and historically significant communities.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3641.790808474387!2d32.884882!3d24.108850999999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143664c528a76499%3A0x480311bcfc70b666!2sNubian%20Eco%20Village!5e0!3m2!1sen!2seg!4v1743078894684!5m2!1sen!2seg",
                Address="Aswan, Egypt",
                ImageUrl="AreaImages/66.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=95,
                Name="Al-Qasr Village (Dakhla Oasis)",
                Description="Al-Qasr Village is located in Dakhla Oasis, one of the most remote and picturesque oases in Egypt’s Western Desert, approximately 750 kilometers southwest of Cairo and 350 kilometers west of the Nile Valley. Nestled between vast golden sand dunes and lush palm groves, Al-Qasr is a remarkable example of a well-preserved medieval Islamic village, offering visitors a rare glimpse into Egypt’s rich history beyond the famous Pharaonic sites. Founded during the Ayyubid period in the 12th century, the village flourished under Mamluk and Ottoman rule, becoming an important administrative and cultural center in the region. Its architecture is a striking blend of traditional mudbrick and Islamic designs, featuring narrow alleys, wooden mashrabiya (latticed windows), and intricately carved doorways, many of which are inscribed with Quranic verses and the names of former residents. One of the village’s most iconic landmarks is the Ayyubid Mosque, which dates back to the 12th century and is distinguished by its tall, slender minaret that rises above the surrounding buildings, offering a panoramic view of the oasis. The mosque remains a focal point of the village, embodying its spiritual and historical significance. Nearby, the Ottoman-era madrasa (Islamic school) and courthouse still stand as testaments to Al-Qasr’s role as a center of learning and governance. Walking through the village, visitors will find ancient houses that were once home to craftsmen, merchants, and scholars, with some still bearing wooden lintels engraved with dates and Arabic calligraphy. Among the notable residences is the House of Abu Nafir, one of the best-preserved examples of traditional Islamic domestic architecture, showcasing wooden ceilings, inner courtyards, and small windows designed to keep interiors cool during the desert’s scorching summers. Beyond its architectural wonders, Al-Qasr is surrounded by the natural beauty of Dakhla Oasis, where visitors can explore nearby hot springs, verdant date palm plantations, and stunning rock formations, such as those found in the White Desert. The local community continues to maintain many of its centuries-old traditions, including pottery-making and weaving, offering visitors the chance to witness artisans at work or purchase authentic handcrafted souvenirs. A visit to Al-Qasr Village is like stepping back in time, providing a unique opportunity to experience the enduring heritage of Egypt’s desert settlements while enjoying the tranquility and scenic beauty of Dakhla Oasis. Whether wandering through its maze-like streets, admiring the historical inscriptions, or engaging with the friendly locals, Al-Qasr remains one of Egypt’s most fascinating rural tourism destinations, preserving a way of life that has existed for centuries amidst the vast expanse of the Western Desert.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14400.86512132302!2d28.94754105!3d25.531171649999997!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143ff6809fca87bd%3A0x459a26e66f78e698!2sDakhla%20Oasis!5e0!3m2!1sen!2seg!4v1743079207341!5m2!1sen!2seg",
                Address="Dakhla Oasis, The New Valley Governorate, Egypt",
                ImageUrl="AreaImages/71.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=96,
                Name="Wadi El-Hitan (Valley of the Whales)",
                Description="Wadi El-Hitan, known as the Valley of the Whales, is located in the Western Desert of Egypt, approximately 150 kilometers southwest of Cairo and 90 kilometers from Fayoum. This UNESCO World Heritage Site is one of the world’s most important paleontological sites, renowned for its well-preserved fossils that provide invaluable insight into the evolution of early whales. The valley, once covered by a prehistoric ocean over 40 million years ago, holds an extraordinary collection of fossils belonging to the Basilosaurus and Dorudon, ancient whale species that mark the transition from land-dwelling mammals to fully aquatic creatures. These fossils, remarkably intact and often preserved with their vestigial hind limbs, offer definitive evidence of how whales evolved from four-legged land animals into the marine giants of today. The site is also home to fossilized remains of other prehistoric marine life, including sharks, rays, and various shellfish, painting a vivid picture of the region’s ancient ecosystem. The landscape of Wadi El-Hitan is equally breathtaking, featuring vast stretches of wind-sculpted sandstone formations, towering cliffs, and undulating dunes that create an otherworldly atmosphere. Visitors can explore the site via well-marked trails that lead past the largest and most impressive fossils, many of which are displayed in their natural positions. The Wadi El-Hitan Fossil and Climate Change Museum, an eco-friendly visitor center, provides further context with detailed exhibits, interactive displays, and life-size models of the ancient whales, allowing visitors to grasp the immense significance of the findings. The valley is also a prime destination for ecotourism, offering opportunities for hiking, desert camping, and stargazing in a pristine and protected environment. The surrounding Fayoum region, known for its stunning lakes and wildlife, adds to the appeal, with nearby attractions such as Wadi El-Rayan, a beautiful nature reserve with waterfalls and sand dunes, and Tunis Village, famous for its pottery workshops. Wadi El-Hitan’s combination of scientific importance, dramatic landscapes, and environmental conservation makes it a must-visit for paleontology enthusiasts, nature lovers, and adventure seekers alike. Whether tracing the evolutionary footsteps of ancient whales, marveling at the surreal desert scenery, or experiencing the tranquility of Egypt’s remote wilderness, a visit to Wadi El-Hitan offers a truly unique and unforgettable journey through time.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3480.503547934593!2d30.0225123!3d29.2675411!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145c0598b628f5b1%3A0x6ef3d6cb2a5abfb3!2sWadi%20Hitan%20National%20Park!5e0!3m2!1sen!2seg!4v1743079704414!5m2!1sen!2seg",
                Address="Faiyum Governorate, Egypt",
                ImageUrl="AreaImages/76.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=97,
                Name="Al-Tod Village (Luxor)",
                Description="Al-Tod Village is located in Upper Egypt, approximately 20 kilometers south of Luxor, on the east bank of the Nile. This small yet historically significant village is home to the Temple of Al-Tod, an ancient Egyptian sanctuary dedicated to the falcon-headed god Montu, the war deity worshipped primarily in the Theban region. Al-Tod’s history dates back to the Old Kingdom, but it flourished particularly during the Middle Kingdom and the reigns of later rulers such as the Ptolemies and Romans, who expanded and modified the temple complex. One of the most remarkable discoveries from the site is the Tod Treasure, a hoard of silver and gold artifacts of Mesopotamian origin, found beneath the temple’s foundations, suggesting long-distance trade and cultural connections between Egypt and the Near East. Today, the village offers visitors an authentic experience of rural Egyptian life, where traditional mudbrick houses, narrow alleyways, and lush agricultural fields along the Nile reflect a way of life that has changed little over centuries. The local economy is primarily based on farming, with crops such as sugarcane, wheat, and corn cultivated in the fertile lands surrounding the village. Walking through Al-Tod, visitors can observe farmers tending their fields using ancient irrigation techniques, women crafting handmade textiles and pottery, and children playing near the village’s small markets. The atmosphere is warm and welcoming, with villagers eager to share their traditions and way of life. In addition to its archaeological significance, Al-Tod provides an excellent opportunity for cultural immersion, where visitors can enjoy homemade Egyptian dishes, listen to traditional folk music, and witness local festivals that celebrate agricultural cycles and religious traditions. The proximity to Luxor makes it a perfect off-the-beaten-path destination for those interested in experiencing Egypt beyond its grand temples and tombs. Whether exploring the ancient ruins of the Temple of Montu, engaging with the hospitable villagers, or simply taking in the serene beauty of the surrounding landscape, Al-Tod Village offers a unique blend of history, culture, and rural charm that makes it a hidden gem in the Luxor region.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d28789.612314488673!2d32.53513995000001!3d25.581594649999996!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1449101a871080c9%3A0x68b804b99b437cb2!2sAl%20Toud%20City%2C%20Luxor%2C%20Luxor%20Governorate!5e0!3m2!1sen!2seg!4v1743080056664!5m2!1sen!2seg",
                Address="Luxor Governorate, Egypt",
                ImageUrl="AreaImages/81.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=98,
                Name="Wadi El-Gemal National Park",
                Description="Wadi El-Gemal National Park is located in Egypt’s southeastern desert, along the Red Sea coast, approximately 45 kilometers south of Marsa Alam and 350 kilometers southeast of Luxor. Covering an area of about 7,450 square kilometers, it is one of Egypt’s most diverse and ecologically significant protected areas, boasting a stunning combination of coastal, marine, and desert ecosystems. The park is named after Wadi El-Gemal, or Valley of the Camels, a dry riverbed that once served as an important trade route. Today, the park is celebrated for its breathtaking landscapes, rich biodiversity, and cultural heritage, making it a must-visit destination for nature lovers, adventure seekers, and history enthusiasts alike. The coastline of Wadi El-Gemal features pristine beaches, mangrove forests, and some of the Red Sea’s most vibrant coral reefs, teeming with marine life, including dolphins, dugongs (sea cows), and countless species of tropical fish. Snorkelers and divers can explore the untouched coral gardens near Hamata Islands, while bird watchers can spot rare species such as ospreys and sooty falcons in the coastal wetlands. Inland, the rugged mountains and vast desert plains are home to the endangered Nubian ibex, wild camels, and various reptiles, while acacia trees and desert plants provide a striking contrast to the arid environment. The park also holds significant historical and cultural importance, with evidence of ancient human settlements dating back thousands of years. The region was once a major center for emerald mining during the Ptolemaic and Roman periods, and visitors can still see the ruins of the Sikait and Nugrus mines, where Egypt’s prized emeralds were extracted. These archaeological sites, along with ancient inscriptions and petroglyphs left by early travelers, shed light on the area’s long history as a crossroads of trade and civilization. Wadi El-Gemal is also home to the Ababda Bedouins, a semi-nomadic community that has lived in harmony with the desert for generations. Visitors can engage with the local people, learn about their traditions, and experience authentic Bedouin hospitality through guided eco-tours, camel treks, and traditional tea gatherings. Sustainable tourism initiatives in the park aim to protect its fragile ecosystems while allowing visitors to explore its natural wonders responsibly. Whether hiking through its rugged valleys, camping under its star-filled sky, or diving into its crystal-clear waters, Wadi El-Gemal National Park offers an unparalleled opportunity to connect with nature, history, and the timeless beauty of Egypt’s eastern wilderness.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3631.311457053204!2d35.0987374!3d24.474663099999997!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x15b56a61bdf20451%3A0x46542e41964f13b6!2sWadi%20el%20Gemal%20Reserve!5e0!3m2!1sen!2seg!4v1743080681667!5m2!1sen!2seg",
                Address="Marsa Alam, Red Sea Governorate, Egypt",
                ImageUrl="AreaImages/86.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=99,
                Name="Al Tarfa Desert Lodge (Dakhla Oasis)",
                Description="Al Tarfa Desert Lodge is located in Dakhla Oasis, deep within Egypt’s Western Desert, approximately 750 kilometers southwest of Cairo and 300 kilometers west of Luxor. It is nestled in a serene desert landscape, surrounded by golden sand dunes, lush palm groves, and ancient mudbrick villages. The lodge is situated on the outskirts of the oasis town of Al-Qasr, offering a tranquil and immersive retreat into the heart of Egypt’s untouched desert beauty.Al Tarfa Desert Lodge is a luxurious yet eco-friendly hideaway that blends seamlessly into the rugged beauty of Dakhla Oasis, offering guests a rare and exclusive experience of Egypt’s vast and mystical Western Desert. This boutique lodge, set amidst rolling dunes, verdant palm plantations, and ancient villages, is designed to reflect the oasis’s natural charm and deep-rooted history while providing world-class hospitality. Built with traditional mudbrick, stone, and wood, Al Tarfa harmoniously integrates with its surroundings, preserving the authenticity of desert architecture while offering modern comforts. The lodge features spacious suites and private villas, each elegantly furnished with handcrafted local décor, antique furniture, and soft ambient lighting that enhances the feeling of warmth and seclusion. Many rooms offer breathtaking views of the desert, particularly at sunrise and sunset, when the golden sands take on hues of pink, orange, and deep red. Guests at Al Tarfa can indulge in authentic Egyptian and Bedouin cuisine, prepared with fresh, locally sourced ingredients, and served in a variety of scenic locations, from candlelit dining rooms to open-air terraces under the stars. The lodge’s infinity pools, shaded courtyards, and relaxation areas provide a perfect escape from the heat, while spa treatments using desert herbs and essential oils offer rejuvenation in a tranquil setting. Beyond its luxurious accommodations, Al Tarfa is a gateway to exploring the rich history, culture, and natural wonders of Dakhla Oasis. Visitors can embark on guided desert safaris, discovering vast landscapes filled with ancient fossils, hidden caves, and unique rock formations. A short journey away lies Al-Qasr, an ancient Islamic village dating back to the Ayyubid era, where mudbrick houses, old mosques, and winding alleyways reveal stories of the past. Another highlight is the Roman Temple of Deir El-Hagar, a remarkably preserved sandstone temple dedicated to the Theban triad, set against the stunning backdrop of the desert. Adventure seekers can enjoy camel trekking, off-road excursions, and sandboarding, while those seeking tranquility can partake in meditative walks through the oasis, listening to the whisper of the wind through the palm trees. As night falls, Al Tarfa transforms into a haven of celestial beauty, offering one of the most incredible stargazing experiences in Egypt, where the Milky Way and countless constellations shine brilliantly in the desert sky, untainted by city lights. Whether exploring ancient sites, relaxing in eco-luxury, or immersing oneself in the raw beauty of the desert, Al Tarfa Desert Lodge provides a truly unforgettable escape, making it one of Egypt’s most exclusive and enchanting rural retreats.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3597.958013390736!2d28.926620099999997!3d25.606311400000003!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144009bc3a16c923%3A0x6c95a9e69d4b9872!2sAl%20Tarfa%20Desert%20Sanctuary%20Lodge%20%26%20Spa!5e0!3m2!1sen!2seg!4v1743080808504!5m2!1sen!2seg",
                Address="Dakhla Oasis, The New Valley Governorate, Egypt",
                ImageUrl="AreaImages/91.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=100,
                Name="Wadi Degla Protectorate",
                Description="Wadi Degla Protectorate is one of Egypt’s most unique and geologically significant nature reserves, offering a stunning contrast to the urban sprawl of Cairo. Covering an area of 60 square kilometers, this breathtaking valley is part of Egypt’s Eastern Desert and is characterized by dramatic limestone canyons, rugged cliffs, and a network of dry riverbeds, which were carved out by ancient water flows over millions of years. The wadi (valley) dates back to the Eocene Epoch, around 50 million years ago, when it was submerged under a vast prehistoric sea. Today, visitors can still find fossilized marine creatures, such as corals, shells, and the remains of ancient fish, embedded in the rock formations—an incredible testament to its ancient past. The protectorate is home to a surprising variety of wildlife, despite its arid conditions. Foxes, desert hares, hedgehogs, and various species of reptiles thrive in the valley, while over 50 species of birds, including falcons and eagles, can be spotted soaring above the cliffs. The sparse desert vegetation includes acacia trees, desert shrubs, and resilient plants that have adapted to the harsh environment. One of Wadi Degla’s main attractions is its vast hiking and biking trails, which wind through the canyon and provide stunning panoramic views of the surrounding landscape. The rocky terrain and rolling hills make it a popular spot for outdoor activities such as rock climbing, trail running, and mountain biking, attracting both amateur adventurers and seasoned athletes. For those seeking tranquility, the reserve offers perfect stargazing opportunities, as its remote location minimizes light pollution, allowing visitors to witness a spectacular night sky. The protectorate is also a favored spot for camping and picnicking, where visitors can enjoy the peaceful desert atmosphere just minutes away from the bustling metropolis of Cairo. With its rich geological history, diverse ecosystem, and thrilling outdoor activities, Wadi Degla Protectorate serves as an extraordinary natural retreat for hikers, nature lovers, and anyone looking to experience Egypt’s raw desert beauty without venturing far from the capital.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3457.0742720958037!2d31.377253599999996!3d29.948542200000002!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145839a2719ca36d%3A0xdaa75ea3a1e28aec!2sWadi%20Degla%20Reserve!5e0!3m2!1sen!2seg!4v1743081131569!5m2!1sen!2seg",
                Address="Wadi Degla Protectorate, Zahraa Al Maadi, Maadi, Cairo, Egypt.",
                ImageUrl="AreaImages/96.jpg",
                AreaTypeId=7,
                 Latitude=null,
               Longitude=null
            },
            //Museums: 22 101:122
            new Area{
                Id=101,
                Name="The Graeco-Roman Museum",
                Description="The Graeco-Roman Museum in Alexandria is one of Egypt's major museums, the oldest building in Egypt architecturally designed for the purpose of preserving and displaying antiquities. It is the only museum specialized in the antiquities and civilization of Egypt during the Graeco-Roman periods.Since 1889, the Italian Giuseppe Botti sought to establish a museum for Alexandria to protect its antiquities from displacement and destruction.He continued working on this until the decision to create the museum was issued on June 1, 1892.The museum began in a simple rented property and was inaugurated by Khedive Abbas Helmi II on October 17, 1892, with Giuseppe Botti as its first director.From its inception, the museum achieved a cultural awakening towards archaeological work in the city, leading to increased discoveries and the urgent need for a new, more spacious building.On September 12, 1894, Nubar Pasha laid the foundation stone for a new museum on land owned by and adjacent to the Municipal Council.The new building was designed by architects Dietrich and Steenon in a neoclassical style.Construction took one year, and it was inaugurated again by Khedive Abbas Helmi II on September 26, 1895. After Botti's death in October 1903, the museum's management remained Italian, with Evaristo Breccia taking over in April 1904, followed by Achille Adriani from 1932 to 1940.Alan Rowe managed the museum from 1940 to 1947, and Adriani returned for a second term from 1948 to 1953.Since 1953, Egyptian archaeologists have managed the museum.In 1982, a development project was implemented, adding a new wing connecting the western and eastern wings.In September 2005, a decision was issued to close the museum for a comprehensive expansion and development project.The project was delayed for ten years until work resumed in April 2015.A new design was created with the addition of an upper floor, and a new museum display format was implemented.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3412.777388657894!2d29.909175425261928!3d31.199185174362654!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c33529a0fac1%3A0xe8132f86930de461!2z2KfZhNmF2KrYrdmBINin2YTZitmI2YbYp9mG2Yog2KfZhNix2YjZhdin2YbZig!5e0!3m2!1sar!2seg!4v1743194297231!5m2!1sar!2seg",
                Address = "Al-Masalla Sharq, Al-Attarin, Alexandria Governorate 5372053",
                ImageUrl = "AreaImages/01.jpeg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=102,
                Name="The Coptic Museum",
                Description="The Coptic Museum houses the largest collection of Coptic antiquities in the world, opened in 1910. The museum was established through the efforts of Marcus Simaika Pasha, a prominent Christian figure who was keen on preserving Coptic heritage. Simaika Pasha collected Coptic antiquities and various architectural elements from old churches undergoing renovations, using them to build the museum and establish its collection. The museum's collection reflects Coptic history from its beginnings in Egypt when it flourished as a leading center of Christianity in the world. The origins of Coptic Christianity in Egypt date back to the visit of Saint Mark to Alexandria in the first century AD. The displayed antiquities reflect the blending of Coptic art with prevailing cultures, including Pharaonic, Greek, Roman, Byzantine, and Ottoman, evolving into its own distinct identity.The museum's extensive collection includes beautifully decorated manuscripts, icons, intricately carved wooden works, and exquisite frescoes adorned with religious scenes preserved from ancient monasteries and churches.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3455.0832984643926!2d31.232972125319147!3d30.005764474943025!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145847105643425d%3A0x5c7b299fa692161a!2z2KfZhNmF2KrYrdmBINin2YTZgtio2LfZiQ!5e0!3m2!1sar!2seg!4v1743194397346!5m2!1sar!2seg",
                Address="3 Mari Girgis, Kom Ghorab, Old Cairo District, Cairo Governorate 4244001",
                ImageUrl="AreaImages/02.jpg",
                AreaTypeId=8,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=103,
                Name="The National Museum of Egyptian Civilization",
                Description="The National Museum of Egyptian Civilization is the first of its kind in Egypt and the Arab world. It is a comprehensive global cultural complex that offers visitors the opportunity to embark on a journey through history to explore Egypt's successive civilizations. The idea of establishing the museum began when UNESCO, at the request of the Egyptian government, announced an international campaign to create the Nubia Museum in Aswan and the National Museum of Egyptian Civilization in Cairo in 1982. The foundation stone was laid in 2002 in the heart of Fustat, the first and oldest Islamic capital in Africa, after Egyptian architect Dr. El Ghazzali Kosseiba won an international architectural competition to design the museum. Construction work stalled until it was completed, and a temporary exhibition hall on Egyptian crafts through different eras was opened in 2017, attended by former UNESCO Director-General Irina Bokova, showcasing four crafts: pottery, woodwork, textiles, and jewelry. All preparations for the museum's other halls were completed, and His Excellency the President inaugurated the central exhibition hall and received 22 royal mummies transferred from the Egyptian Museum in Tahrir in a grand procession in 2021. A textile hall was also opened in 2022. The museum hosts the Egyptian Civilization School in September 2022, aimed at increasing tourist and archaeological awareness among citizens and introducing foreign residents to ancient Egyptian civilization. The museum features a variety of artifacts highlighting Egypt's tangible and intangible heritage, helping visitors understand Egyptian civilization across different eras, from prehistoric times through ancient Egyptian, Greek, Roman, Coptic, Islamic, and modern and contemporary periods. The museum also includes a hall for mummies and a hall for Egyptian textiles.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.98479861792!2d31.250814225318944!3d30.00859287494161!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458476863e39e8f%3A0xc2e058446f8f145d!2z2KfZhNmF2KrYrdmBINin2YTZgtmI2YXZiiDZhNmE2K3Yttin2LHYqSDYp9mE2YXYtdix2YrYqQ!5e0!3m2!1sar!2seg!4v1743194488897!5m2!1sar!2seg",
                Address="Ain Al-Sira, Old Cairo District, Cairo Governorate 4245001",
                ImageUrl="AreaImages/03.jpeg",
                AreaTypeId=8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 104,
                Name = "The Egyptian Museum",
                Description = "The Egyptian Museum is the oldest archaeological museum in the Middle East and houses the largest collection of ancient Egyptian antiquities in the world. The museum displays a vast collection spanning from the Predynastic Period to the Greek and Roman eras. The architect of the building was selected through an international competition in 1895,the first of  won by French architect Marcel Dourgnon.Khedive Abbas Helmi II inaugurated the museum in 1902, making it a historical landmark in downtown Cairo and home to the finest ancient Egyptian artifacts.Among the museum's unparalleled collections are the funerary items of Yuya and Thuya, the treasures of Psusennes I from Tanis, and the Narmer Palette, which commemorates the unification of Upper and Lower Egypt under one king. These are among the priceless artifacts in the museum. The museum also features magnificent statues of great kings like Khufu, Khafre, and Menkaure, the pyramid builders of the Giza Plateau, as well as a vast collection of papyri, coffins, and jewelry that complement its distinguished collection.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.6005164308294!2d31.23624232531716!3d30.048316674921633!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458b14d72adf029%3A0x9a38f9bbb6edbfe4!2z2KfZhNmF2KrYrdmBINin2YTZhdi12LHZiiDYqNin2YTZgtin2YfYsdip!5e0!3m2!1sar!2seg!4v1743194540602!5m2!1sar!2seg",
                Address = "Tahrir Square, Ismailia, Qasr El Nil District, Cairo Governorate 4272083",
                ImageUrl = "AreaImages/04.jpeg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 105,
                Name = "The Mummification Museum",
                Description = "The ancient Egyptians believed in the importance of preserving the body after death to ensure immortality in the afterlife. Thus, mummification was a fundamental element of their funerary practices, overseen symbolically by the god Anubis.The mummification process involved many complex steps, taking about 70 days,accompanied by numerous rituals and incantations.The deceased's organs were carefully removed through a small incision in the body and preserved in jars known as canopic jars. The body was then dried using natron salt and wrapped in linen bandages. Magical amulets were placed within the wrappings around various parts of the mummy to protect the body. Finally, the deceased's family carried the mummy to be placed in a coffin for burial.The Mummification Museum provides a comprehensive explanation of the entire process,detailing the religious significance of mummification and its associated rituals.It displays many of the tools used, as well as a collection of canopic jars,mummified remains,elaborately decorated coffins,amulets,and statues of deities.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3595.063648646853!2d32.64242462550831!3d25.702316577389222!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144915c82f8983a9%3A0x6189ac424f113e64!2z2YXYqtit2YEg2KfZhNiq2K3ZhtmK2Lc!5e0!3m2!1sar!2seg!4v1743194591962!5m2!1sar!2seg",
                Address = "Corniche El Nile Street, Luxor City, Luxor Governorate 1362501",
                ImageUrl = "AreaImages/05.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 106,
                Name = "The Crocodile Museum",
                Description = "The Crocodile Museum is located near the Kom Ombo Temple, on the eastern side of the Nile River north of Aswan. This museum highlights the god Sobek, one of the deities of Kom Ombo, and was opened in 2012. The main exhibition hall displays mummified Nile crocodiles, the largest of which measures 4.30 meters, while the smallest is 2 meters long. The museum also features a collection of crocodile embryos and models of golden and ivory eyes and teeth from the mummified crocodiles.The museum also houses statues of various sizes of the god Sobek and a tomb replica mimicking what was discovered in the Shatb Necropolis, illustrating burial methods and displaying the clay coffins that contained the mummies of this sacred animal.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3631.9352416946313!2d32.93022292555817!3d24.453031978197433!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14360fb13a19e359%3A0x37f27cc59eedbef6!2z2YXYqtit2YEg2KfZhNiq2YXYp9iz2YrYrQ!5e0!3m2!1sar!2seg!4v1743194657347!5m2!1sar!2seg",
                Address = "FW3H+636, Nagaa Al-Shatb, Daraw, Aswan Governorate 1281301",
                ImageUrl = "AreaImages/06.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 107,
                Name = "The Suez Museum",
                Description = "The idea of the Suez National Museum emerged after the collapse of the old museum during the 1967 war, when all the artifacts displayed there were transferred to the storerooms of the Egyptian Museum in Tahrir. The new museum was established to be a cultural beacon and tourist attraction highlighting the history of the Suez Canal, which connects the Red Sea and the Mediterranean. The museum displays the heritage, antiquities, and history of Suez City from prehistoric times to the modern era. It was opened in 2012 and consists of two floors separated by an open exhibition hall featuring various styles of columns. The museum sheds light on the history of the Suez Canal and other waterways,such as the Necho Canal that connected the Nile to the Red Sea,and their role in maritime navigation.It also highlights Egypt's trade relations, mining, and shipbuilding industries, as well as the importance of Suez City for pilgrimage journeys to the Holy Land. Additionally, a hall is dedicated to documenting the struggle of the people of Suez against British occupation and during the October 1973 war. The mummification hall is one of the museum's most important sections,replicating the interior of a tomb and providing a complete depiction of the mummification process.Among the museum's most prominent exhibits is the statue of King Senusret III from the Middle Kingdom (12th Dynasty), which is one of the main pieces on display. The museum also houses the stela of the Persian King Darius I, one of four commemorative stelae erected to celebrate the digging of a canal connecting the Nile to the Red Sea at four different sites along the canal's bank.The museum also includes a library and an educational activities section.In the museum's garden, there is a recently built model of one of Queen Hatshepsut's fleet ships(18th Dynasty, New Kingdom), which were sent for trade exchange with other countries.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3456.848496217493!2d32.569512225321496!3d29.95503617496862!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456250e1595d9b9%3A0xe90a0e698784614d!2z2YXYqtit2YEg2KfZhNiz2YjZitizINin2YTZgtmI2YXZig!5e0!3m2!1sar!2seg!4v1743194696062!5m2!1sar!2seg",
                Address = "XH48+2Q7, July-23, Suez, Suez Governorate 8144030",
                ImageUrl = "AreaImages/07.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 108,
                Name = "The Hurghada Museum",
                Description = "The Hurghada Museum is the first antiquities museum in the Red Sea Governorate. It is also the first museum to be built in partnership with the private sector, with its management entirely under the responsibility of the Ministry of Tourism and Antiquities. The construction of the museum was funded by the private sector. The Hurghada Museum houses nearly 2,000 artifacts that narrate the history of Egyptian civilization, starting from ancient Egyptian, Greek, and Roman times, through the Christian and Islamic periods, up to the modern era. These artifacts highlight the museum's theme, which is to showcase the concept of beauty in Egypt.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3549.884377369029!2d33.82400467544725!3d27.1599278765007!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14528133e3b8a3cf%3A0xf016d76812a5930b!2sHurghada%20Museum!5e0!3m2!1sar!2seg!4v1743194730692!5m2!1sar!2seg",
                Address = "Al-Nasr, First Hurghada District, Red Sea Governorate 84511",
                ImageUrl = "AreaImages/08.jpeg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 109,
                Name = "The Prince Mohamed Ali Palace Museum (Al Manial)",
                Description = "The Prince Mohamed Ali Palace Museum in Al Manial is one of the most beautiful and important historical museums in Egypt. It reflects a significant period in Egypt's modern history and stands out for its stunning architectural design, built in a modern Islamic style inspired by Persian and Mamluk schools of art. It also includes some Syrian, Moroccan, and Andalusian decorations, along with Ottoman influences. Thus, it serves as a comprehensive artistic school encompassing various elements of Islamic art.The palace was built by Prince Mohamed Ali Tewfik between 1319-1348 AH (1900-1929 AD). It consists of an outer wall surrounding the palace entrance, and within its walls are the Reception Hall, the Clock Tower, the Sabil (water fountain), the Mosque, the Hunting Museum, the Residence Hall, the Throne Hall, the Private Museum, and the Golden Hall, in addition to the magnificent garden surrounding the palace, which is unique in its design.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.2824804207394!2d31.23246302531802!3d30.028752774931498!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145847326973319b%3A0x2bb659e7c0bb809d!2z2YLYtdixINin2YTYo9mF2YrYsSDZhdit2YXYryDYudmE2Yog2KjYp9mE2YXZhtmK2YQ!5e0!3m2!1sar!2seg!4v1743194761857!5m2!1sar!2seg",
                Address = "1 Al-Saraya, Al Manial Al Sharqi, Old Cairo District, Cairo Governorate 4240291",
                ImageUrl = "AreaImages/09.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 110,
                Name = "The Royal Jewelry Museum",
                Description = "The Royal Jewelry Museum was established to display the possessions of the Muhammad Ali Dynasty, which ruled Egypt for more than 150 years, starting in 1805 until 1952.The palace was built in the Zizinia area in 1919 by Mrs.Zainab Fahmy and completed by her daughter, Princess Fatima, the daughter of Prince Ali Haydar, a descendant of Muhammad Ali Pasha.The palace serves as a stunning backdrop for the magnificent possessions of the Muhammad Ali Dynasty,reflecting the princess's refined taste in paintings, gilded ceilings, and mosaics that adorn many of the palace's rooms.The palace consists of eastern and western wings connected by a corridor,each with two floors and a basement. The museum displays the possessions collected by the family throughout their reign in all the palace's magnificent halls, reflecting their luxurious lifestyle. Among the museum's exhibits is a necklace adorned with diamonds and emeralds belonging to the dynasty's founder, Muhammad Ali Pasha, as well as a golden chessboard, golden binoculars encrusted with diamonds, rubies, and emeralds, and golden cups inlaid with precious stones. The museum also showcases dazzling jewelry prepared by leading European designers, worn by the queens and princesses of Egypt's royal family.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3411.282227370376!2d29.965859725259925!3d31.24060957434322!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c5293b29f3cb%3A0xf790955947954877!2z2YXYqtit2YEg2KfZhNmF2KzZiNmH2LHYp9iqINin2YTZhdmE2YPZitipINio2KfZhNij2LPZg9mG2K_YsdmK2Kk!5e0!3m2!1sar!2seg!4v1743194805908!5m2!1sar!2seg",
                Address = "27 Ahmed Yehia, San Stefano, Second Al-Raml District, Alexandria Governorate 5451010",
                ImageUrl = "AreaImages/010.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 111,
                Name = "Suez National Museum",
                Description = "The idea for the Suez National Museum arose after the collapse of the old museum during the 1967 war—all the artifacts on display were transferred to the storerooms of the Egyptian Museum in Tahrir—as a cultural beacon and tourist attraction highlighting the history of the Suez Canal, which connects the Red Sea and the Mediterranean. The museum showcases the heritage, antiquities, and history of the city of Suez, from prehistoric times to the modern era. The museum opened in 2012. It consists of two floors separated by an open-air exhibition hall displaying various styles of columns.\r\nThe museum highlights the history of the Suez Canal and waterways, such as the Nekau Canal, which connected the Nile to the Red Sea. It also highlights Egypt's trade relations, mining, and shipbuilding, and the importance of Suez for pilgrimages to the Holy Land. In addition, a hall has been dedicated to documenting the struggle of the people of Suez against the British occupation, as well as during the October 1973 Battle. The Mummification Hall is one of the museum's most important halls, as it simulates the interior of a tomb and contains a complete depiction of the mummification process.\r\nAmong the museum's most prominent exhibits is the statue of King Senusret III, dating back to the Middle Kingdom (Twelfth Dynasty), which is one of the museum's main exhibits. The museum also houses the stela of the Persian King Darius I, one of four founding stela he ordered erected to celebrate the digging of a canal linking the Nile to the Red Sea in four different parallel locations along the canal bank.\r\nThe museum also includes a library and a section for educational activities. The museum garden houses a recently constructed model of one of Queen Hatshepsut's (18th Dynasty, New Kingdom) fleet ships, which she sent for trade with other countries..",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3456.8483346104676!2d32.56951222499309!3d29.955040822802175!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456250e1595d9b9%3A0xe90a0e698784614d!2z2YXYqtit2YEg2KfZhNiz2YjZitizINin2YTZgtmI2YXZig!5e0!3m2!1sar!2seg!4v1743210639184!5m2!1sar!2seg",
                Address = "Suez, Egypt",
                ImageUrl = "AreaImages/011.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id=112,
                Name="National Police Museum",
                Description="The National Police Museum is one of the museums of the Saladin Citadel in Cairo. Located in the northern part of the citadel, it showcases the efforts and continuous struggles of the Egyptian police throughout history. The museum includes a group of halls, each dedicated to a specific era in the history of the Egyptian police. One hall displays the history of the police in ancient Egypt, another displays the history of the Egyptian police in the Islamic era, and a hall displays firefighter equipment.You can learn about the history of major battles, political assassinations, and social crimes in the modern era, as well as models of the development of weapons and uniforms for police officers. You can also view some of the fire trucks used by the police during the 18th and 19th centuries.You can also explore the history of the most important battles fought by Egyptian police by wandering among the models depicting the Egyptian police's struggle against colonialism in the Battle of January 25, 1952 in Ismailia. The building rests on the Tower of Lions, which was discovered during the construction of the museum.This tower was named after the prominent carvings of a number of lions in combat on the upper frame of the tower.Which is likely attributed to Al - Zahir Baybars, and it is the only tower that remains of the Mamluk castle towers until now.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.2157826789426!2d31.262188584885134!3d30.03066668188732!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840abaa152f39%3A0xef90943486c3aa1e!2z2YXYqtit2YEg2KfZhNi02LHYt9ipINin2YTZgtmI2YXZig!5e0!3m2!1sar!2seg!4v1743211413629!5m2!1sar!2seg",
                    Address = "Cairo",
                    ImageUrl = "AreaImages/National Police Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=113,
                Name="Museum of Islamic Art",
                Description="The Museum of Islamic Art houses the largest and most impressive collection of Islamic artifacts in the world. The idea of ​​collecting and displaying Islamic artifacts began in 1880, and the museum building was established there. It was inaugurated in 1903 during the reign of Khedive Abbas Hilmi II. Its facade was designed in the style of Mamluk architecture and is located next to the National Library building. The museum was damaged in the 2014 bombing of the Cairo Security Directorate building.It was renovated and reopened in 2017. Consisting of two floors, the museum houses the largest collection of artifacts from across the Islamic world, allowing visitors to explore all periods of Islamic history.The themes range from astronomy, medicine, architecture, and more. The materials used are also varied, including finely carved woodwork, exquisitely decorated ceramic pieces, and extremely rare manuscripts. Among the museum's most important treasures are a key to the Kaaba from the Mamluk era and a piece of textile bearing the oldest Kufic inscription.",
                Location= "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3453.725931892621!2d31.255296124750014!3d30.04471967492343!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14583f7d6211c891%3A0xad7d1092373bae8b!2z2YXYqtit2YEg2KfZhNmB2YYg2KfZhNil2LPZhNin2YXZiiDYqNin2YTZgtin2YfYsdip!5e0!3m2!1sar!2seg!4v1743211823708!5m2!1sar!2seg",
                Address= "Cairo",
                ImageUrl= "AreaImages/Museum of Islamic Art.jpeg",
                AreaTypeId= 8,
                 Latitude=null,
               Longitude=null
            },
            new Area{
                Id=114,
                Name="Cairo International Airport Museum",
                Description="The idea of ​​establishing a museum in Terminal 2 of Cairo International Airport began in 2020. It was intended to serve as a starting point for introducing visitors to Egypt's ancient history. The museum was established in collaboration with the Ministry of Tourism and Antiquities and the Ministry of Civil Aviation, covering an area of ​​approximately 100 square meters. The museum's display reflects the luminous touches of Egypt's history throughout its ages.It displays unique artifacts that highlight the artistic and historical characteristics of each era, beginning with ancient Egyptian times, as well as Roman, Coptic, Islamic, and modern art.It also showcases pieces that highlight Egypt's status as a cradle of all monotheistic religions and religious sects, who lived together in peace and harmony.",
                Location="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3451.3578263696772!2d31.40186682474709!3d30.11257277488927!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458172d904d2e3b%3A0xb7313122381687b4!2z2YXYqtit2YEg2KfZhNmF2LfYp9ix!5e0!3m2!1sar!2seg!4v1743212105363!5m2!1sar!2seg",
                Address="Cairo",
                ImageUrl="AreaImages/Cairo International Airport Museum.jpg",
                AreaTypeId=8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 115,
                Name = "Royal Chariots Museum",
                Description = "The Royal Chariots Museum in Bulaq is one of the oldest museums of its kind in the world. It was specifically created to display and preserve the cultural heritage of royal chariots dating back to the Muhammad Ali dynasty and everything related to them. It also highlights the interest in horse breeding during this period. The idea of ​​establishing the museum building dates back to the reign of Khedive Ismail, who ruled Egypt from 1863 to 1879. He was the first to consider establishing a building dedicated to the Khedivial carriages and horses. Initially called the Khedivial Riding Service, this name continued until 1922, during the reign of King Fuad I (1917–1936), when it was renamed the Royal Stables Administration. This service was a major focus of interest to the royal palace at the time, which provided it with specialized experts and skilled workers. The building was converted into a historical museum after the 1952 revolution.The museum houses a magnificent collection of royal carriages of various sizes and types,dating back to the reign of the Muhammad Ali Pasha dynasty in Egypt.The most famous of these is the carriage known as the Grand Alai Private Carriage,distinguished by its fine craftsmanship and exquisite decoration.It was a gift from Emperor Napoleon III and his wife, Empress Eugenie, to Khedive Ismail at the time of the opening of the Suez Canal in 1869.The king ordered the construction of the building.King Farouk I renovated it and used it at the opening of Parliament in 1924.It also houses a collection of horse harnesses and accessories, as well as clothing belonging to the staff of the Horsemen's Department, whose jobs were related to carriages. It also houses a collection of oil paintings of kings and princesses dating back to the same historical period. It's worth noting that there are a few museums specializing in displaying this type of royal carriage in some European countries",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d27630.38767904798!2d31.268034877469002!3d30.04263934513201!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840e9cd7ea781%3A0xc8a404d934549270!2z2YXYqtit2YEg2KfZhNmF2LHZg9io2KfYqiDYp9mE2YXZhNmD2YrYqQ!5e0!3m2!1sar!2seg!4v1743212481410!5m2!1sar!2seg",
                Address = "Cairo-bolak",
                ImageUrl = "AreaImages/Royal Chariots Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 116,
                Name = "Nubian Museum",
                Description = "The idea for the Nubian Museum emerged during the International Campaign to Save the Monuments of Nubia, launched by UNESCO at the request of the Egyptian government in 1960. The museum was intended to house the archaeological, historical, cultural, and environmental heritage of Nubia. Studies for the museum project began in the early 1980s, with committees formed by the Supreme Council of Antiquities and experts from Egyptian universities and UNESCO. The engineering designs were awarded to architect Dr. Mahmoud El-Hakim, while the museum display was assigned to Mexican architect Pedro Ramirez Vazquez.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3642.6273277248856!2d32.891749824974234!3d24.079424878447274!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143663597d21e809%3A0xca27e595fe005147!2z2YXYqtit2YEg2KfZhNmG2YjYqNip!5e0!3m2!1sar!2seg!4v1743212667673!5m2!1sar!2seg",
                Address = "Assuan",
                ImageUrl = "AreaImages/Nubian Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 117,
                Name = "Imhotep Museum",
                Description = "The museum was built in the Saqqara archaeological site to commemorate the architect Imhotep, the engineer of the pyramid tomb of King Djoser, and the first to extensively use stone in the construction of an integrated pyramid complex. The museum consists of six halls displaying a diverse collection of statues, coffins, stelae, vessels, architectural elements, and other artifacts from excavations at the Saqqara archaeological site. The museum features a special hall designed in the form of a complete tomb, displaying a mummy, a wooden coffin, and a number of funerary furnishings. Another hall commemorates the engineer and archaeologist Jean-Philippe, who dedicated his life to the restoration of King Djoser's pyramid complex.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3459.791573904343!2d31.227586924757112!3d29.870284175011715!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14584bd525ff4feb%3A0xf6749ed66df17c58!2sImhotep%20Museum!5e0!3m2!1sar!2seg!4v1743212853108!5m2!1sar!2seg",
                Address = "Giza",
                ImageUrl = "AreaImages/Imhotep Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 118,
                Name = "Gayer-Anderson Museum",
                Description = "Gayer Anderson Pasha was an English officer who completed his medical studies in London and was appointed to the British Army Medical Department in 1904. He then transferred to the British Army's service in Egypt in 1907. In 1935, Gayer Anderson approached the Committee for the Preservation of Arab Antiquities to request that he live in the two houses, furnish them in the Arab-Islamic style, and display his collection of Pharaonic, Islamic, and Asian antiquities. The request was for this furniture and his collection of antiquities to become the property of the Egyptian people after his death or when he finally left Egypt. The committee agreed. As soon as Anderson left the house in 1942, his will was executed, and the two houses and their contents were transferred to the Arab Antiquities Authority, which turned them into a museum named after Gayer Anderson. The house consists of two Ottoman-era houses from the 16th and 17th centuries that were combined into one. The first house was built by the teacher Abdul Qadir Al Haddad in the year (947 AH / 1545 AD), and at a later date its ownership was transferred to Mrs. Amina bint Salem, and the second house was built by Hajj Muhammad bin Salem bin Jalmaam Al Jazzar in the year (1041 AH / 1631 AD), and families succeeded each other inhabited it until a woman from the island of Crete inhabited it, so the house was known as the Cretan House in reference to her.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3454.296747100549!2d31.25339012475078!3d30.02834337493163!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1458474d2b6e49a7%3A0xb1f4a75076659e7f!2z2YXYqtit2YEg2KzYp9mK2LEg2KPZhtiv2LHYs9mI2YY!5e0!3m2!1sar!2seg!4v1743213098158!5m2!1sar!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/Gayer-Anderson Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 119,
                Name = "Helwan Corner Museum",
                Description = "The museum building, shaped like a sailboat moored on the Nile, was built in 1942 in Helwan. Originally a royal guest house for King Farouk I, it was renovated and reopened in 2016. The museum displays a collection of royal artifacts, including statues and souvenirs, as well as photographs and oil paintings of the royal family. It also displays replicas of King Tutankhamun's funerary furniture, which were part of King Farouk's guest house at the Giza pyramids. The museum features a large garden housing various rare plant species, including rare mango trees brought from Albania.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3460.5987477786184!2d31.297291824758148!3d29.84700177502364!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145835d85c30e367%3A0x9cddab2983deeae!2z2YXYqtit2YEg2LHZg9mGINmB2KfYsdmI2YI!5e0!3m2!1sar!2seg!4v1743213233736!5m2!1sar!2seg",
                Address = "Cairo-Helwan",
                ImageUrl = "AreaImages/Helwan Corner Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 120,
                Name = "Sharm El Sheikh Museum",
                Description = "The idea for building the museum dates back to 2006, and construction was completed in 2017.The museum's display scenario reflects the various aspects of civilization in general, and ancient Egyptian civilization in particular, through the display of a select group of artifacts carefully selected from the museum's storage. The museum's main display hall depicts people and wildlife in ancient Egypt, their interests in science, sports, industry, crafts, family life, and their love for animals, to the point of veneration. Some stuffed animals are also on display. Among the most important pieces included in the Hall of Civilizations are the inner and outer coffins of Isetemheb, wife of Panedjem II, the High Priest of Amun and holder of the title: “Priestess of the Goddess Isis and the Gods Min and Horus in Akhmim.” There are also her canopic jar boxes, the Isetemheb papyrus, a collection of perfume and cosmetic jars, a head of Queen Hatshepsut, and a group of Tanagra statues of women in different clothing and styles, in addition to exhibits from Sinai heritage.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14100.04175948584!2d34.36479341284179!3d27.932325199999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1453379dede99f63%3A0xe6401eff7e5a4c60!2z2YXYqtit2YEg2LTYsdmFINin2YTYtNmK2K4!5e0!3m2!1sar!2seg!4v1743213563039!5m2!1sar!2seg",
                Address = "South Sinai",
                ImageUrl = "AreaImages/Sharm El Sheikh Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 121,
                Name = "Kafr El Sheikh Museum",
                Description = "Since the earliest historical eras, Kafr El-Sheikh Governorate has had a large share of contribution to the history of Egyptian civilization due to the presence of the city of Buto, which is currently known as Tell el-Fara'een, as it was the first capital of the first organized state in Lower Egypt. The museum aims to display the regional history and many of the artifacts that were discovered in Kafr El-Sheikh Governorate. The museum includes three halls, containing the artifacts that were found in the cemetery of Buto the Great and the temple area, where a number of important artifacts were discovered that embody the story of the conflict between Horus and his uncle Set, in addition to other archaeological sites in Kafr El-Sheikh, including a statue of the god Horus the falcon, one of the most wonderful statues discovered in Egypt so far, and is considered a unique copy that is only rivaled by its counterpart in Edfu Temple. A hall in the museum was also allocated to display the artifacts that embody the period when the city of Sakha hosted the journey of the Holy Family during its visit to Egypt, in addition to displaying the history of science during different historical eras such as medicine, veterinary medicine and pharmacy, as well as some topics related to the city of Fuwwah, which has a rich Islamic heritage. It includes all of Kafr El-Sheikh's cultural heritage. Sheikh Zayed is considered the third heritage city after Cairo and Rashid.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3416.227049590443!2d30.94923982470548!3d31.103420874407558!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f7ac78ca1dea3f%3A0xa7bf0bba9cd94f14!2z2YXYqtit2YEg2YPZgdixINin2YTYtNmK2K4!5e0!3m2!1sar!2seg!4v1743213758897!5m2!1sar!2seg",
                Address = "Kafr-Elshikh",
                ImageUrl = "AreaImages/Kafr El Sheikh Museum.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
            new Area
            {
                Id = 122,
                Name = "Museum of the Capitals of Egypt",
                Description = "The museum is located in the Arts and Culture City in Egypt's New Administrative Capital. It showcases the story of Egyptian capitals and their development throughout Egypt's history, from its oldest capital, Memphis, to its newest capital. The museum is unique in Egypt, focusing primarily on Egyptian capitals.Six major capitals were selected to be the highlights of the exhibition: Memphis, Thebes, Tell el-Amarna, Alexandria, Islamic Cairo, and Khedivial Cairo. These capitals played important roles in Egyptian history.The museum contains two main halls; one is dedicated to the Egyptian capitals, and the other explains ancient Egyptian beliefs and the afterlife.",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d221104.912892451!2d32.02575230546876!3d30.014924600000008!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1457f387bfc3ccd5%3A0xb7c3959fa549e1fa!2z2YXYqtit2YEg2LnZiNin2LXZhSDZhdi12LE!5e0!3m2!1sar!2seg!4v1743213992301!5m2!1sar!2seg",
                Address = "Cairo",
                ImageUrl = "AreaImages/Museum of the Capitals of Egypt.jpg",
                AreaTypeId = 8,
                 Latitude=null,
               Longitude=null
            },
        };
        builder.HasData(areas);
    }
}
