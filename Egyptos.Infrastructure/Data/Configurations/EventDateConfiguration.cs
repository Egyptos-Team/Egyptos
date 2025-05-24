using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Egyptos.Domain.Entities;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventDateConfiguration : IEntityTypeConfiguration<EventDate>
{
    public void Configure(EntityTypeBuilder<EventDate> builder)
    {
        var eventDate = new List<EventDate>
        {
            new EventDate
            {
                Id = 1,
                StartDate = new DateTime(2025, 7, 10, 10, 00, 00),
                EndDate = new DateTime(2025, 7, 10, 23, 59, 00),
                StartSubscription = new DateTime(2025, 10, 1, 00, 00, 00),
                EndSubscription = new DateTime(2025, 10, 9, 23, 59, 00),
                Description = "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.",
                Location = "Ismailia, Egypt",
                Price = 100,
                EventId = 1,
            },
            new EventDate
            {
                Id = 2,
                StartDate = new DateTime(2025, 10, 15, 18, 0, 0),
                EndDate = new DateTime(2025, 10, 20, 23, 0, 0),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 10, 10, 23, 59, 0),
                Description = "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.",
                Location = "Alexandria, Egypt",
                Price = 150,
                EventId = 2,
            },
            new EventDate
            {
                Id = 3,
                StartDate = new DateTime(2025, 3, 8, 17, 0, 0),
                EndDate = new DateTime(2025, 3, 15, 22, 0, 0),
                StartSubscription = new DateTime(2025, 2, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 3, 5, 23, 59, 0),
                Description = "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.",
                Location = "Cairo, Egypt",
                Price = 120,
                EventId = 3,
            },
            new EventDate
            {
                Id = 4,
                StartDate = new DateTime(2025, 2, 21, 6, 0, 0),
                EndDate = new DateTime(2025, 2, 21, 8, 0, 0),
                StartSubscription = new DateTime(2025, 1, 10, 0, 0, 0),
                EndSubscription = new DateTime(2025, 2, 18, 23, 59, 0),
                Description = "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.",
                Location = "Karnak Temple, Luxor, Egypt",
                Price = 250,
                EventId = 4,
            },
            new EventDate
            {
                Id = 5,
                StartDate = new DateTime(2025, 11, 10, 19, 0, 0),
                EndDate = new DateTime(2025, 11, 20, 23, 59, 0),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 11, 5, 23, 59, 0),
                Description = "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.",
                Location = "Cairo, Egypt",
                Price = 200,
                EventId = 5,
            },
            new EventDate
            {
                Id = 6,
                StartDate = new DateTime(2025, 5, 1, 20, 0, 0),
                EndDate = new DateTime(2025, 5, 1, 21, 0, 0),
                StartSubscription = new DateTime(2025, 4, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 4, 30, 23, 59, 0),
                Description = "A spectacular multimedia experience that brings ancient Egyptian history to life through state-of-the-art sound systems and dramatic light projections onto the Great Pyramids and Sphinx. This nightly show narrates the epic story of ancient Egypt, from the reign of the pharaohs to the construction of these eternal monuments. The production features multiple language options, with the pyramids serving as a colossal backdrop while colored lights dance across their surfaces, synchronized with a powerful musical score and compelling narration. The show covers 5,000 years of history in 45 minutes, creating an unforgettable journey through time that showcases the achievements, mysteries, and legends of ancient Egyptian civilization.",
                Location = "Giza Pyramids, Egypt",
                Price = 180,
                EventId = 6,
            },
            new EventDate
            {
                Id = 7,
                StartDate = new DateTime(2025, 10, 25, 18, 0, 0),
                EndDate = new DateTime(2025, 11, 2, 23, 0, 0),
                StartSubscription = new DateTime(2025, 8, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 8, 23, 23, 59, 0),
                Description = "A magical celebration that illuminates Egyptian cities during the holy month of Ramadan with thousands of traditional fanous (lanterns) creating an enchanting atmosphere throughout historic neighborhoods. This beloved festival features elaborate lantern displays crafted by skilled artisans, showcasing both traditional designs and contemporary artistic interpretations. The event includes live performances of traditional Islamic music, Quranic recitations, storytelling sessions featuring tales from Islamic heritage, and family-oriented activities. Local markets sell handcrafted lanterns, traditional sweets, and Ramadan decorations. Cultural workshops teach visitors about the significance of Ramadan traditions, while nightly iftars (breaking of fast) bring communities together in celebration of unity and spiritual reflection.",
                Location = "Cairo, Egypt",
                Price = 80,
                EventId = 7,
            },
            new EventDate
            {
                Id = 8,
                StartDate = new DateTime(2025, 8, 15, 12, 0, 0),
                EndDate = new DateTime(2025, 8, 20, 23, 0, 0),
                StartSubscription = new DateTime(2025, 7, 25, 0, 0, 0),
                EndSubscription = new DateTime(2025, 8, 10, 23, 59, 0),
                Description = "An exhilarating beachside celebration that transforms Hurghada into a vibrant festival destination with international music performances, dance competitions, water sports demonstrations, and beach parties that continue from sunset to sunrise. The festival features world-class DJs, live bands performing various genres from electronic dance music to traditional Arabic music, and cultural fusion performances. Water activities include jet ski exhibitions, windsurfing competitions, scuba diving experiences, and beach volleyball tournaments. The event also showcases Red Sea marine life through underwater photography exhibitions, environmental awareness programs, and coral reef conservation workshops. Local and international food vendors offer diverse culinary experiences, while beach clubs host exclusive parties and networking events.",
                Location = "Hurghada, Egypt",
                Price = 150,
                EventId = 8,
            },
            new EventDate
            {
                Id = 9,
                StartDate = new DateTime(2025, 12, 5, 17, 0, 0),
                EndDate = new DateTime(2025, 12, 10, 23, 0, 0),
                StartSubscription = new DateTime(2025, 10, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 12, 1, 23, 59, 0),
                Description = "A prestigious theatrical event that transforms the resort city of Sharm El Sheikh into a cultural hub, featuring outstanding international theatre productions performed against the backdrop of the Red Sea. The festival presents diverse theatrical works ranging from classical dramas to contemporary experimental performances, bringing together acclaimed theatre companies from across the globe. Professional workshops led by renowned directors and actors offer intensive training in various theatrical techniques, while panel discussions explore the evolution of modern theatre. The unique setting allows for both indoor venue performances and outdoor amphitheater shows under the stars, creating an intimate connection between performers and audiences in one of Egypt's most beautiful locations.",
                Location = "Sharm El Sheikh, Egypt",
                Price = 170,
                EventId = 9,
            },
            new EventDate
            {
                Id = 10,
                StartDate = new DateTime(2025, 3, 15, 10, 0, 0),
                EndDate = new DateTime(2025, 3, 15, 18, 0, 0),
                StartSubscription = new DateTime(2025, 2, 15, 0, 0, 0),
                EndSubscription = new DateTime(2025, 3, 10, 23, 59, 59),
                Description = "An extraordinary journey into the life and treasures of Egypt's most famous pharaoh, featuring an extensive collection of artifacts from Tutankhamun's tomb including golden sarcophagi, intricate jewelry, ceremonial weapons, and personal belongings that remained hidden for over 3,000 years. This comprehensive exhibition utilizes cutting-edge display technology, interactive multimedia presentations, and virtual reality experiences that transport visitors back to the Valley of the Kings. Expert Egyptologists provide guided tours revealing the latest archaeological discoveries and theories about the young pharaoh's mysterious death. The exhibition also includes replicas that visitors can touch, educational programs for students, and workshops on ancient Egyptian burial practices and the significance of the afterlife in pharaonic culture.",
                Location = "Cairo Museum",
                Price = 300,
                EventId = 10,
            },
            new EventDate
            {
                Id = 11,
                StartDate = new DateTime(2025, 9, 26, 18, 0, 0),
                EndDate = new DateTime(2025, 9, 26, 23, 0, 0),
                StartSubscription = new DateTime(2025, 8, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 9, 20, 23, 59, 59),
                Description = "A deeply spiritual and joyous celebration commemorating the birth of Prophet Muhammad, transforming mosques and neighborhoods across Egypt into centers of devotion and cultural expression. The festivities include special prayer services, recitations of the Quran and prophetic traditions, religious lectures exploring the Prophet's teachings, and community gatherings that strengthen bonds between families and neighbors. Colorful processions wind through historic streets featuring traditional Islamic banners, while nasheed (Islamic songs) performances create an atmosphere of reverence and celebration. Local communities organize charity drives, distribute food to the needy, and host educational programs about Islamic history and values. The celebrations also include traditional crafts workshops, calligraphy exhibitions, and storytelling sessions sharing tales from Islamic heritage.",
                Location = "Al Azhar Mosque",
                Price = 200,
                EventId = 11,
            },
            new EventDate
            {
                Id = 12,
                StartDate = new DateTime(2025, 6, 10, 17, 0, 0),
                EndDate = new DateTime(2025, 6, 10, 23, 0, 0),
                StartSubscription = new DateTime(2025, 5, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 6, 5, 23, 59, 59),
                Description = "A magnificent cultural celebration that honors Egypt's rich pharaonic heritage with traditional music performances, ancient storytelling traditions, folk dance exhibitions, and artisan craft demonstrations set against the iconic backdrop of the Great Sphinx of Giza. The festival features authentic recreations of ancient Egyptian ceremonies, with performers dressed in historically accurate costumes presenting dramatic interpretations of mythological tales and historical events. Master craftsmen demonstrate traditional techniques for creating papyrus, pottery, jewelry, and textiles using methods passed down through generations. Interactive workshops allow visitors to learn hieroglyphic writing, ancient Egyptian games, and traditional cooking methods. The event culminates in a grand procession recreating pharaonic pageantry, complete with horse-drawn chariots and ceremonial performances.",
                Location = "Giza Plateau",
                Price = 150,
                EventId = 12,
            },
            new EventDate
            {
                Id = 13,
                StartDate = new DateTime(2025, 10, 20, 19, 0, 0),
                EndDate = new DateTime(2025, 10, 28, 23, 59, 59),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 10, 15, 23, 59, 59),
                Description = "An exclusive international film festival held in the luxurious Red Sea resort town of El Gouna, combining high-quality cinema with stunning natural beauty and world-class hospitality. This boutique festival focuses on supporting emerging filmmakers from the Middle East and North Africa while attracting established international talent. The event features competitive screenings in state-of-the-art venues, exclusive premieres of highly anticipated films, and intimate industry gatherings that foster meaningful connections between filmmakers, distributors, and investors. Masterclasses with acclaimed directors, producers, and actors provide invaluable learning opportunities, while the festival's industry hub facilitates co-production deals and international collaborations. The unique resort setting allows for beachside screenings, yacht parties, and networking events that create an unforgettable festival experience.",
                Location = "El Gouna, Red Sea",
                Price = 500,
                EventId = 13,
            },
            new EventDate
            {
                Id = 14,
                StartDate = new DateTime(2025, 9, 20, 20, 0, 0),
                EndDate = new DateTime(2025, 9, 24, 23, 59, 59),
                StartSubscription = new DateTime(2025, 9, 1, 0, 0, 0),
                EndSubscription = new DateTime(2025, 9, 19, 23, 59, 59),
                Description = "A once-in-a-lifetime spectacle that captivated the world as 22 royal mummies were transferred from the Egyptian Museum to their new home at the National Museum of Egyptian Civilization in a grand procession through the streets of Cairo. This historic event featured specially designed climate-controlled vehicles decorated with pharaonic motifs, accompanied by a stunning cultural program including orchestra performances, traditional Egyptian music, and theatrical presentations depicting ancient Egyptian funeral rites. The parade route was adorned with elaborate decorations inspired by ancient Egyptian art, while millions of viewers worldwide witnessed this unprecedented celebration of Egypt's archaeological treasures. The event included educational programs about each royal mummy, their historical significance, and the advanced preservation techniques used to protect these 3,000-year-old remains.",
                Location = "Cairo, Egypt",
                Price = 450,
                EventId = 14,
            },
            new EventDate
            {
                Id = 15,
                StartDate = new DateTime(2025, 3, 31, 7, 00, 00),
                EndDate = new DateTime(2025, 4, 2, 12, 00, 00),
                StartSubscription = new DateTime(2025, 3, 17, 8, 00, 00),
                EndSubscription = new DateTime(2025, 3, 30, 8, 00, 00),
                Description = "A nationwide celebration marking the joyous conclusion of Ramadan's month-long fasting period, transforming Egypt into a country-wide festival of gratitude, family reunions, and community solidarity. The festivities begin with special dawn prayers in mosques and public squares, followed by traditional family gatherings featuring elaborate feasts with special Eid delicacies, sweets, and traditional dishes. Children receive new clothes and gifts while families visit relatives and friends, strengthening social bonds. Public spaces host cultural performances, traditional music concerts, folk dance exhibitions, and carnival-style entertainment for children. Charity organizations coordinate food distribution to underprivileged families, ensuring everyone can participate in the celebration. Markets and bazaars stay open late, offering special Eid merchandise, handicrafts, and traditional sweets that are integral to the holiday traditions.",
                Location = "Egypt",
                Price = 150,
                EventId = 15,
            },
            new EventDate
            {
                Id = 16,
                StartDate = new DateTime(2025, 2, 2, 10, 00, 00),
                EndDate = new DateTime(2025, 2, 16, 12, 00, 00),
                StartSubscription = new DateTime(2025, 1, 19, 7, 50, 00),
                EndSubscription = new DateTime(2025, 1, 30, 7, 50, 00),
                Description = "A vibrant celebration of Nubian culture that showcases the rich traditions, music, art, and heritage of Egypt's Nubian community in the beautiful setting of Aswan and its surrounding villages. The festival features authentic Nubian music performances with traditional instruments like the oud and tabla, colorful folk dances that tell stories of Nubian history, and exhibitions of traditional crafts including intricate beadwork, pottery, and textiles with distinctive geometric patterns. Visitors can experience traditional Nubian hospitality in decorated houses painted in bright colors, participate in cooking workshops featuring Nubian cuisine, and learn about the community's unique customs and oral traditions. The festival also addresses contemporary Nubian issues, celebrates their contributions to Egyptian culture, and promotes cultural preservation efforts through educational programs and documentary screenings.",
                Location = "Aswan, Egypt",
                Price = 550,
                EventId = 16,
            },
            new EventDate
            {
                Id = 17,
                StartDate = new DateTime(2025, 4, 12, 7, 00, 00),
                EndDate = new DateTime(2025, 4, 18, 12, 00, 00),
                StartSubscription = new DateTime(2025, 4, 1, 8, 00, 00),
                EndSubscription = new DateTime(2025, 4, 10, 8, 00, 00),
                Description = "A prestigious international squash tournament that attracts the world's top-ranked players to compete in the stunning resort town of El Gouna, featuring state-of-the-art glass courts with spectacular Red Sea views as the backdrop. This PSA World Tour event brings together elite athletes competing for significant prize money and world ranking points, while spectators enjoy world-class squash in an unparalleled setting. The tournament includes professional coaching clinics, junior development programs, and community outreach initiatives promoting squash among Egyptian youth. VIP hospitality packages offer exclusive access to player meet-and-greets, coaching sessions with professionals, and luxury accommodations. The event also features a festival atmosphere with beachside entertainment, water sports activities, and cultural performances celebrating both international sport and local Egyptian hospitality.",
                Location = "El Gouna, Egypt",
                Price = 1100,
                EventId = 17,
            },
            new EventDate
            {
                Id = 18,
                StartDate = new DateTime(2025, 11, 15, 10, 00, 00),
                EndDate = new DateTime(2025, 11, 28, 10, 00, 00),
                StartSubscription = new DateTime(2025, 10, 1, 9, 55, 00),
                EndSubscription = new DateTime(2025, 10, 13, 10, 00, 00),
                Description = "The Mediterranean's most significant literary gathering, transforming Alexandria into a bibliophile's paradise with hundreds of publishers, authors, and literary enthusiasts converging in the historic city that once housed the ancient world's greatest library. The fair features extensive book displays in multiple languages, author signings with renowned writers, poetry readings, literary discussions, and panel debates on contemporary issues in publishing and literature. Educational workshops cover creative writing, translation techniques, and digital publishing, while cultural programs include theatrical adaptations of classic literature and musical performances inspired by literary works. The event also celebrates Alexandria's rich literary heritage with special exhibitions about famous writers who lived in the city, guided tours of literary landmarks, and discussions about the city's role in shaping Arab intellectual culture.",
                Location = "Alexandria, Egypt",
                Price = 100,
                EventId = 18,
            },
            new EventDate
            {
                Id = 19,
                StartDate = new DateTime(2025, 10, 15, 9, 00, 00),
                EndDate = new DateTime(2025, 10, 17, 9, 00, 00),
                StartSubscription = new DateTime(2025, 10, 1, 8, 00, 00),
                EndSubscription = new DateTime(2025, 10, 13, 8, 00, 00),
                Description = "An enchanting celebration in the remote Siwa Oasis that honors the legendary sweetness and quality of Siwan dates while showcasing the unique culture and traditions of this isolated desert community. The festival features extensive displays of different date varieties, traditional harvesting demonstrations using ancient techniques, and tastings of date-based products including wines, jams, and confections. Visitors experience authentic Siwan hospitality in traditional mud-brick houses, witness the crafting of palm frond baskets and other traditional handicrafts, and participate in desert excursions to natural springs and ancient ruins. Cultural performances include traditional Siwan music played on indigenous instruments, folk dances celebrating the harvest, and storytelling sessions sharing local legends and oral history. The festival also promotes environmental awareness about oasis conservation and sustainable agriculture practices.",
                Location = "Siwa, Egypt",
                Price = 200,
                EventId = 19,
            },
            new EventDate
            {
                Id = 20,
                StartDate = new DateTime(2025, 7, 3, 9, 00, 00),
                EndDate = new DateTime(2025, 7, 3, 10, 55, 00),
                StartSubscription = new DateTime(2025, 6, 15, 8, 00, 00),
                EndSubscription = new DateTime(2025, 6, 30, 8, 00, 00),
                Description = "A spectacular commemorative exhibition celebrating the Egyptian Museum's pivotal role in preserving and presenting Egypt's archaeological treasures, featuring rare artifacts rarely displayed to the public, newly discovered pieces, and interactive presentations about the museum's history and mission. The exhibition includes behind-the-scenes tours showing conservation laboratories, storage facilities, and restoration work in progress, providing visitors with insights into the complex process of maintaining ancient artifacts. Special presentations by leading Egyptologists reveal new research findings, recent archaeological discoveries, and ongoing excavation projects across Egypt. The event also features digital reconstructions of ancient sites, virtual reality experiences allowing visitors to explore tombs and temples, and educational programs designed for students and researchers interested in Egyptology and museum studies.",
                Location = "Cairo, Egypt",
                Price = 250,
                EventId = 20,
            },
            new EventDate
            {
                Id = 21,
                StartDate = new DateTime(2026, 1, 6, 12, 00, 00),
                EndDate = new DateTime(2026, 1, 7, 12, 00, 00),
                StartSubscription = new DateTime(2026, 1, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 1, 5, 8, 00, 00),
                Description = "A deeply meaningful religious celebration observed by Egypt's Coptic Christian community on January 7th, featuring special midnight masses in historic churches adorned with traditional decorations, community feasts that bring families together, and cultural events that highlight the rich heritage of Egyptian Christianity. The celebrations include beautiful choral performances of traditional Coptic hymns sung in ancient languages, processions through historic Coptic quarters of Cairo and other cities, and exhibitions showcasing Coptic art, manuscripts, and religious artifacts. Churches open their doors for cultural tours explaining Coptic history, architecture, and religious practices, while community centers host educational programs about the role of Coptic Christianity in Egyptian society. The festivities also include charity drives, community service projects, and interfaith dialogue events promoting understanding and coexistence among Egypt's diverse religious communities.",
                Location = "Egypt",
                Price = 100,
                EventId = 21,
            },
            new EventDate
            {
                Id = 22,
                StartDate = new DateTime(2026, 4, 16, 11, 00, 00),
                EndDate = new DateTime(2026, 4, 26, 10, 00, 00),
                StartSubscription = new DateTime(2026, 4, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 4, 13, 8, 00, 00),
                Description = "An adrenaline-pumping international competition that brings world-class kite surfers to Egypt's pristine Red Sea coast, featuring high-speed races, freestyle competitions, and big air contests in the consistently windy conditions that make this region a global kite surfing destination. The championship attracts professional athletes from around the world competing for substantial prize money and world ranking points, while the event atmosphere includes beach parties, live music performances, and water sports exhibitions. Beginners can participate in kite surfing lessons with certified instructors, while advanced riders can join coaching clinics with professional athletes. The event also features environmental awareness programs highlighting Red Sea conservation, local cultural performances, and food festivals showcasing coastal Egyptian cuisine. Spectators enjoy beachside viewing areas, water taxi services to optimal viewing positions, and VIP hospitality options.",
                Location = "Red Sea, Egypt",
                Price = 500,
                EventId = 22,
            },
            new EventDate
            {
                Id = 23,
                StartDate = new DateTime(2026, 7, 16, 9, 45, 00),
                EndDate = new DateTime(2026, 7, 21, 10, 55, 00),
                StartSubscription = new DateTime(2026, 7, 3, 8, 00, 00),
                EndSubscription = new DateTime(2026, 7, 12, 8, 00, 00),
                Description = "An inspiring annual showcase of contemporary Egyptian art set in the historically rich city of Luxor, where ancient temples and tombs provide a dramatic backdrop for modern artistic expression. The exhibition features works by established and emerging Egyptian artists across various media including painting, sculpture, photography, digital art, and mixed media installations that often incorporate themes from ancient Egyptian culture reimagined through contemporary perspectives. Gallery spaces in historic buildings and outdoor installations in archaeological sites create unique viewing experiences that bridge ancient and modern artistic traditions. The event includes artist talks, workshops on traditional and modern art techniques, guided tours that explore the connection between ancient Egyptian art and contemporary creativity, and cultural exchanges with international artists and curators.",
                Location = "Luxor, Egypt",
                Price = 450,
                EventId = 23,
            },
            new EventDate
            {
                Id = 24,
                StartDate = new DateTime(2026, 2, 8, 11, 00, 00),
                EndDate = new DateTime(2026, 2, 11, 12, 00, 00),
                StartSubscription = new DateTime(2026, 2, 1, 8, 00, 00),
                EndSubscription = new DateTime(2026, 2, 6, 8, 00, 00),
                Description = "A dynamic celebration of urban artistic expression that transforms Cairo's walls, buildings, and public spaces into an open-air gallery showcasing the creativity and social commentary of local and international street artists. The festival features live mural painting sessions where visitors can watch artists create large-scale works, graffiti workshops teaching various techniques and styles, and guided tours through neighborhoods known for their street art culture. Interactive performances combine visual art with music, dance, and spoken word poetry, while panel discussions explore street art's role in social movements and cultural change. The event also includes community engagement projects where residents collaborate with artists to beautify their neighborhoods, youth programs teaching artistic skills as alternatives to destructive graffiti, and exhibitions documenting the evolution of Cairo's street art scene.",
                Location = "Cairo, Egypt",
                Price = 150,
                EventId = 24,
            },
            new EventDate
            {
                Id = 25,
                StartDate = new DateTime(2025, 11, 29, 1, 00, 00),
                EndDate = new DateTime(2025, 11, 29, 10, 50, 00),
                StartSubscription = new DateTime(2025, 11, 20, 8, 00, 00),
                EndSubscription = new DateTime(2025, 11, 25, 12, 00, 00),
                Description = "A comprehensive academic and cultural gathering that explores the profound influence of Islamic civilization on Egyptian culture, architecture, art, literature, and social traditions through scholarly presentations, archaeological discoveries, and cultural exhibitions. The conference brings together leading historians, archaeologists, theologians, and cultural experts from around the world to present research on Islamic monuments, manuscript preservation, traditional crafts, and the evolution of Islamic thought in Egypt. Interactive workshops demonstrate traditional Islamic arts such as calligraphy, geometric pattern design, and manuscript illumination, while cultural performances feature traditional Islamic music, poetry recitations, and theatrical presentations. The event also includes guided tours of historic Islamic sites in Cairo, Alexandria, and other cities, educational programs for students and teachers, and interfaith dialogue sessions promoting understanding of Islamic contributions to world civilization.",
                Location = "Alexandria, Egypt",
                Price = 250,
                EventId = 25,
            },
        };

        builder.HasData(eventDate);
    }
}


public class EventDateImageConfiguration : IEntityTypeConfiguration<EventImage>
{    
    public void Configure(EntityTypeBuilder<EventImage> builder)
    {
        var eventImages = new List<EventImage>
        {
            new EventImage
            {
                Id = 1,
                ImageUrl="EventImages/Ismailia/1.webp",
                EventId = 1
            },
            new EventImage
            {
                Id = 2,
                ImageUrl="EventImages/Ismailia/2.webp",
                EventId = 1
            },
            new EventImage
            {
                Id = 3,
                ImageUrl="EventImages/Ismailia/3.webp",
                EventId = 1
            },

            new EventImage
            {
                Id = 4,
                ImageUrl="EventImages/Alexandria/1.webp",
                EventId = 2
            },
            new EventImage
            {
                Id = 5,
                ImageUrl="EventImages/Alexandria/2.webp",
                EventId = 2
            },
            new EventImage
            {
                Id = 6,
                ImageUrl="EventImages/Alexandria/3.webp",
                EventId = 2
            },

            new EventImage
            {
                Id = 7,
                ImageUrl="EventImages/Cairo/1.webp",
                EventId = 3
            },
            new EventImage
            {
                Id = 8,
                ImageUrl="EventImages/Cairo/2.webp",
                EventId = 3
            },
            new EventImage
            {
                Id = 9,
                ImageUrl="EventImages/Cairo/3.webp",
                EventId = 3
            },
            new EventImage
            {
                Id = 10,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/1.webp",
                EventId = 4
            },
            new EventImage
            {
                Id = 11,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/2.webp",
                EventId = 4
            },
            new EventImage
            {
                Id = 12,
                ImageUrl="EventImages/Karnak Temple, Luxor, Egypt/3.webp",
                EventId = 4
            },

            new EventImage
            {
                Id = 13,
                ImageUrl="EventImages/Cairo,Egypt/1.webp",
                EventId = 5
            },
            new EventImage
            {
                Id = 14,
                ImageUrl="EventImages/Cairo,Egypt/2.webp",
                EventId = 5
            },
            new EventImage
            {
                Id = 15,
                ImageUrl="EventImages/Cairo,Egypt/3.webp",
                EventId = 5
            },

            new EventImage
            {
                Id = 16,
                ImageUrl="EventImages/Giza Pyramids, Egypt/1.webp",
                EventId = 6
            },
            new EventImage
            {
                Id = 17,
                ImageUrl="EventImages/Giza Pyramids, Egypt/2.webp",
                EventId = 6
            },
            new EventImage
            {
                Id = 18,
                ImageUrl="EventImages/Giza Pyramids, Egypt/3.webp",
                EventId = 6
            },

            new EventImage
            {
                Id = 19,
                ImageUrl="EventImages/Cairo, Egypt2/1.webp",
                EventId = 7
            },
            new EventImage
            {
                Id = 20,
                ImageUrl="EventImages/Cairo, Egypt2/2.webp",
                EventId = 7
            },
            new EventImage
            {
                Id = 21,
                ImageUrl="EventImages/Cairo, Egypt2/3.webp",
                EventId = 7
            },

            new EventImage
            {
                Id = 22,
                ImageUrl="EventImages/Hurghada, Egypt/1.webp",
                EventId = 8
            },
            new EventImage
            {
                Id = 23,
                ImageUrl="EventImages/Hurghada, Egypt/2.webp",
                EventId = 8
            },
            new EventImage
            {
                Id = 24,
                ImageUrl="EventImages/Hurghada, Egypt/3.webp",
                EventId = 8
            },

            new EventImage
            {
                Id = 25,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/1.webp",
                EventId = 9
            },
            new EventImage
            {
                Id = 26,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/2.webp",
                EventId = 9
            },
            new EventImage
            {
                Id = 27,
                ImageUrl="EventImages/Sharm El Sheikh, Egypt/3.webp",
                EventId = 9
            },

            new EventImage
            {
                Id = 28,
                ImageUrl="EventImages/Cairo Museum/1.webp",
                EventId = 10
            },
            new EventImage
            {
                Id = 29,
                ImageUrl="EventImages/Cairo Museum/2.webp",
                EventId = 10
            },
            new EventImage
            {
                Id = 30,
                ImageUrl="EventImages/Cairo Museum/3.webp",
                EventId = 10
            },

            new EventImage
            {
                Id = 31,
                ImageUrl="EventImages/Al Azhar Mosque/1.webp",
                EventId = 11
            },
            new EventImage
            {
                Id = 32,
                ImageUrl="EventImages/Al Azhar Mosque/2.webp",
                EventId = 11
            },
            new EventImage
            {
                Id = 33,
                ImageUrl="EventImages/Al Azhar Mosque/3.webp",
                EventId = 11
            },

            new EventImage
            {
                Id = 34,
                ImageUrl="EventImages/Giza Plateau/1.webp",
                EventId = 12
            },
            new EventImage
            {
                Id = 35,
                ImageUrl="EventImages/Giza Plateau/2.webp",
                EventId = 12
            },
            new EventImage
            {
                Id = 36,
                ImageUrl="EventImages/Giza Plateau/3.webp",
                EventId = 12
            },

            new EventImage
            {
                Id = 37,
                ImageUrl="EventImages/El Gouna, Red Sea/1.webp",
                EventId = 13
            },
            new EventImage
            {
                Id = 38,
                ImageUrl="EventImages/El Gouna, Red Sea/2.webp",
                EventId = 13
            },
            new EventImage
            {
                Id = 39,
                ImageUrl="EventImages/El Gouna, Red Sea/3.webp",
                EventId = 13
            },new EventImage
            {
                Id = 40,
                ImageUrl="EventImages/40.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 41,
                ImageUrl="EventImages/41.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 42,
                ImageUrl="EventImages/42.jpg",
                EventId = 15
            },
            new EventImage
            {
                Id = 43,
                ImageUrl="EventImages/43.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 44,
                ImageUrl="EventImages/44.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 45,
                ImageUrl="EventImages/45.jpg",
                EventId = 16
            },
            new EventImage
            {
                Id = 46,
                ImageUrl="EventImages/46.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 47,
                ImageUrl="EventImages/47.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 48,
                ImageUrl="EventImages/48.jpg",
                EventId = 17
            },
            new EventImage
            {
                Id = 49,
                ImageUrl="EventImages/49.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 50,
                ImageUrl="EventImages/50.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 51,
                ImageUrl="EventImages/51.jpg",
                EventId = 18
            },
            new EventImage
            {
                Id = 52,
                ImageUrl="EventImages/52.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 53,
                ImageUrl="EventImages/53.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 54,
                ImageUrl="EventImages/54.jpg",
                EventId = 19
            },
            new EventImage
            {
                Id = 55,
                ImageUrl="EventImages/55.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 56,
                ImageUrl="EventImages/56.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 57,
                ImageUrl="EventImages/57.jpg",
                EventId = 20
            },
            new EventImage
            {
                Id = 58,
                ImageUrl="EventImages/58.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 59,
                ImageUrl="EventImages/59.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 60,
                ImageUrl="EventImages/60.jpg",
                EventId = 21
            },
            new EventImage
            {
                Id = 61,
                ImageUrl="EventImages/61.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 62,
                ImageUrl="EventImages/62.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 63,
                ImageUrl="EventImages/63.jpg",
                EventId = 22
            },
            new EventImage
            {
                Id = 64,
                ImageUrl="EventImages/64.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 65,
                ImageUrl="EventImages/65.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 66,
                ImageUrl="EventImages/66.jpg",
                EventId = 23
            },
            new EventImage
            {
                Id = 67,
                ImageUrl="EventImages/67.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 68,
                ImageUrl="EventImages/68.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 69,
                ImageUrl="EventImages/69.jpg",
                EventId = 24
            },
            new EventImage
            {
                Id = 70,
                ImageUrl="EventImages/70.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 71,
                ImageUrl="EventImages/71.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 72,
                ImageUrl="EventImages/72.jpg",
                EventId = 25
            },
            new EventImage
            {
                Id = 73,
                ImageUrl="EventImages/73.jpg",
                EventId = 14
            },
            new EventImage
            {
                Id = 74,
                ImageUrl="EventImages/74.jpg",
                EventId = 14
            },
            new EventImage
            {
                Id = 75,
                ImageUrl="EventImages/75.jpg",
                EventId = 14
            }
        };

        builder.HasData(eventImages);
    }
}
