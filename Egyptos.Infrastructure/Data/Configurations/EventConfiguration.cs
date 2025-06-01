using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Infrastructure.Data.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        var events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Name = "Grand Egyptian Museum Official Opening",
                Description = "The Grand Egyptian Museum will officially open on July 3, 2025, in a prestigious ceremony attended by world leaders, dignitaries, and cultural figures. This major cultural event marks the unveiling of the museum’s vast collection, including the complete treasures of King Tutankhamun displayed together for the first time. The museum represents a new era in showcasing Egypt’s ancient heritage on a global stage.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 2,
                Name = "Royal Mummies Parade",
                Description = "A spectacular cultural event where 22 royal mummies are transferred from the Egyptian Museum in Tahrir to the National Museum of Egyptian Civilization in Fustat. The parade features elaborate carriages, traditional music, light shows, and a grand procession through Cairo’s main streets, celebrating Egypt’s glorious ancient heritage and attracting global attention.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 3,
                Name = "FIFA World Cup 2030 – Egypt Host",
                Description = "Egypt will proudly co-host the FIFA World Cup 2030, welcoming football fans from around the globe to experience the world’s biggest sporting event. The tournament promises thrilling matches across multiple cities, showcasing Egypt’s rich culture, modern stadiums, and warm hospitality. This marks a historic milestone as Africa hosts the World Cup for the first time in decades.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 4,
                Name = "Cross Egypt Challenge",
                Description = "An exhilarating motorcycle rally spanning 8 stages over 2,900 km across Sinai, showcasing Egypt’s stunning natural landscapes and rich cultural heritage. Participants will experience challenging terrains and breathtaking views in this iconic endurance event.",
                EventTypeId = 1 
            },
            new Event
            {
                Id = 5,
                Name = "Zamna Festival",
                Description = "A globally renowned electronic music festival held for the first time in Egypt, set at the foot of the Giza Pyramids. The festival features top international and local artists performing immersive sets in a unique historic atmosphere.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 6,
                Name = "Giza Pyramids Sound and Light Show",
                Description = "A spectacular multimedia experience that brings ancient Egyptian history to life through state-of-the-art sound systems and dramatic light projections onto the Great Pyramids and Sphinx. This nightly show narrates the epic story of ancient Egypt, from the reign of the pharaohs to the construction of these eternal monuments. The production features multiple language options, with the pyramids serving as a colossal backdrop while colored lights dance across their surfaces, synchronized with a powerful musical score and compelling narration. The show covers 5,000 years of history in 45 minutes, creating an unforgettable journey through time that showcases the achievements, mysteries, and legends of ancient Egyptian civilization.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 7,
                Name = "Ramadan Lantern Festival",
                Description = "A magical celebration that illuminates Egyptian cities during the holy month of Ramadan with thousands of traditional fanous (lanterns) creating an enchanting atmosphere throughout historic neighborhoods. This beloved festival features elaborate lantern displays crafted by skilled artisans, showcasing both traditional designs and contemporary artistic interpretations. The event includes live performances of traditional Islamic music, Quranic recitations, storytelling sessions featuring tales from Islamic heritage, and family-oriented activities. Local markets sell handcrafted lanterns, traditional sweets, and Ramadan decorations. Cultural workshops teach visitors about the significance of Ramadan traditions, while nightly iftars (breaking of fast) bring communities together in celebration of unity and spiritual reflection.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 8,
                Name = "Hurghada Summer Festival",
                Description = "An exhilarating beachside celebration that transforms Hurghada into a vibrant festival destination with international music performances, dance competitions, water sports demonstrations, and beach parties that continue from sunset to sunrise. The festival features world-class DJs, live bands performing various genres from electronic dance music to traditional Arabic music, and cultural fusion performances. Water activities include jet ski exhibitions, windsurfing competitions, scuba diving experiences, and beach volleyball tournaments. The event also showcases Red Sea marine life through underwater photography exhibitions, environmental awareness programs, and coral reef conservation workshops. Local and international food vendors offer diverse culinary experiences, while beach clubs host exclusive parties and networking events.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 9,
                Name = "Sharm El Sheikh International Theatre Festival",
                Description = "A prestigious theatrical event that transforms the resort city of Sharm El Sheikh into a cultural hub, featuring outstanding international theatre productions performed against the backdrop of the Red Sea. The festival presents diverse theatrical works ranging from classical dramas to contemporary experimental performances, bringing together acclaimed theatre companies from across the globe. Professional workshops led by renowned directors and actors offer intensive training in various theatrical techniques, while panel discussions explore the evolution of modern theatre. The unique setting allows for both indoor venue performances and outdoor amphitheater shows under the stars, creating an intimate connection between performers and audiences in one of Egypt's most beautiful locations.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 10,
                Name = "Tutankhamun Exhibition",
                Description = "An extraordinary journey into the life and treasures of Egypt's most famous pharaoh, featuring an extensive collection of artifacts from Tutankhamun's tomb including golden sarcophagi, intricate jewelry, ceremonial weapons, and personal belongings that remained hidden for over 3,000 years. This comprehensive exhibition utilizes cutting-edge display technology, interactive multimedia presentations, and virtual reality experiences that transport visitors back to the Valley of the Kings. Expert Egyptologists provide guided tours revealing the latest archaeological discoveries and theories about the young pharaoh's mysterious death. The exhibition also includes replicas that visitors can touch, educational programs for students, and workshops on ancient Egyptian burial practices and the significance of the afterlife in pharaonic culture.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 11,
                Name = "Mawlid Al-Nabi Celebrations",
                Description = "A deeply spiritual and joyous celebration commemorating the birth of Prophet Muhammad, transforming mosques and neighborhoods across Egypt into centers of devotion and cultural expression. The festivities include special prayer services, recitations of the Quran and prophetic traditions, religious lectures exploring the Prophet's teachings, and community gatherings that strengthen bonds between families and neighbors. Colorful processions wind through historic streets featuring traditional Islamic banners, while nasheed (Islamic songs) performances create an atmosphere of reverence and celebration. Local communities organize charity drives, distribute food to the needy, and host educational programs about Islamic history and values. The celebrations also include traditional crafts workshops, calligraphy exhibitions, and storytelling sessions sharing tales from Islamic heritage.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 12,
                Name = "Sphinx Festival",
                Description = "A magnificent cultural celebration that honors Egypt's rich pharaonic heritage with traditional music performances, ancient storytelling traditions, folk dance exhibitions, and artisan craft demonstrations set against the iconic backdrop of the Great Sphinx of Giza. The festival features authentic recreations of ancient Egyptian ceremonies, with performers dressed in historically accurate costumes presenting dramatic interpretations of mythological tales and historical events. Master craftsmen demonstrate traditional techniques for creating papyrus, pottery, jewelry, and textiles using methods passed down through generations. Interactive workshops allow visitors to learn hieroglyphic writing, ancient Egyptian games, and traditional cooking methods. The event culminates in a grand procession recreating pharaonic pageantry, complete with horse-drawn chariots and ceremonial performances.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 13,
                Name = "El Gouna Film Festival",
                Description = "An exclusive international film festival held in the luxurious Red Sea resort town of El Gouna, combining high-quality cinema with stunning natural beauty and world-class hospitality. This boutique festival focuses on supporting emerging filmmakers from the Middle East and North Africa while attracting established international talent. The event features competitive screenings in state-of-the-art venues, exclusive premieres of highly anticipated films, and intimate industry gatherings that foster meaningful connections between filmmakers, distributors, and investors. Masterclasses with acclaimed directors, producers, and actors provide invaluable learning opportunities, while the festival's industry hub facilitates co-production deals and international collaborations. The unique resort setting allows for beachside screenings, yacht parties, and networking events that create an unforgettable festival experience.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 14,
                Name = "Pharaohs' Golden Parade",
                Description = "A once-in-a-lifetime spectacle that captivated the world as 22 royal mummies were transferred from the Egyptian Museum to their new home at the National Museum of Egyptian Civilization in a grand procession through the streets of Cairo. This historic event featured specially designed climate-controlled vehicles decorated with pharaonic motifs, accompanied by a stunning cultural program including orchestra performances, traditional Egyptian music, and theatrical presentations depicting ancient Egyptian funeral rites. The parade route was adorned with elaborate decorations inspired by ancient Egyptian art, while millions of viewers worldwide witnessed this unprecedented celebration of Egypt's archaeological treasures. The event included educational programs about each royal mummy, their historical significance, and the advanced preservation techniques used to protect these 3,000-year-old remains.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 15,
                Name = "Eid Al-Fitr Festivities",
                Description = "A nationwide celebration marking the joyous conclusion of Ramadan's month-long fasting period, transforming Egypt into a country-wide festival of gratitude, family reunions, and community solidarity. The festivities begin with special dawn prayers in mosques and public squares, followed by traditional family gatherings featuring elaborate feasts with special Eid delicacies, sweets, and traditional dishes. Children receive new clothes and gifts while families visit relatives and friends, strengthening social bonds. Public spaces host cultural performances, traditional music concerts, folk dance exhibitions, and carnival-style entertainment for children. Charity organizations coordinate food distribution to underprivileged families, ensuring everyone can participate in the celebration. Markets and bazaars stay open late, offering special Eid merchandise, handicrafts, and traditional sweets that are integral to the holiday traditions.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 16,
                Name = "Aswan Nubian Festival",
                Description = "A vibrant celebration of Nubian culture that showcases the rich traditions, music, art, and heritage of Egypt's Nubian community in the beautiful setting of Aswan and its surrounding villages. The festival features authentic Nubian music performances with traditional instruments like the oud and tabla, colorful folk dances that tell stories of Nubian history, and exhibitions of traditional crafts including intricate beadwork, pottery, and textiles with distinctive geometric patterns. Visitors can experience traditional Nubian hospitality in decorated houses painted in bright colors, participate in cooking workshops featuring Nubian cuisine, and learn about the community's unique customs and oral traditions. The festival also addresses contemporary Nubian issues, celebrates their contributions to Egyptian culture, and promotes cultural preservation efforts through educational programs and documentary screenings.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 17,
                Name = "Gouna Squash Open",
                Description = "A prestigious international squash tournament that attracts the world's top-ranked players to compete in the stunning resort town of El Gouna, featuring state-of-the-art glass courts with spectacular Red Sea views as the backdrop. This PSA World Tour event brings together elite athletes competing for significant prize money and world ranking points, while spectators enjoy world-class squash in an unparalleled setting. The tournament includes professional coaching clinics, junior development programs, and community outreach initiatives promoting squash among Egyptian youth. VIP hospitality packages offer exclusive access to player meet-and-greets, coaching sessions with professionals, and luxury accommodations. The event also features a festival atmosphere with beachside entertainment, water sports activities, and cultural performances celebrating both international sport and local Egyptian hospitality.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 18,
                Name = "Alexandria Book Fair",
                Description = "The Mediterranean's most significant literary gathering, transforming Alexandria into a bibliophile's paradise with hundreds of publishers, authors, and literary enthusiasts converging in the historic city that once housed the ancient world's greatest library. The fair features extensive book displays in multiple languages, author signings with renowned writers, poetry readings, literary discussions, and panel debates on contemporary issues in publishing and literature. Educational workshops cover creative writing, translation techniques, and digital publishing, while cultural programs include theatrical adaptations of classic literature and musical performances inspired by literary works. The event also celebrates Alexandria's rich literary heritage with special exhibitions about famous writers who lived in the city, guided tours of literary landmarks, and discussions about the city's role in shaping Arab intellectual culture.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 19,
                Name = "Siwa Date Festival",
                Description = "An enchanting celebration in the remote Siwa Oasis that honors the legendary sweetness and quality of Siwan dates while showcasing the unique culture and traditions of this isolated desert community. The festival features extensive displays of different date varieties, traditional harvesting demonstrations using ancient techniques, and tastings of date-based products including wines, jams, and confections. Visitors experience authentic Siwan hospitality in traditional mud-brick houses, witness the crafting of palm frond baskets and other traditional handicrafts, and participate in desert excursions to natural springs and ancient ruins. Cultural performances include traditional Siwan music played on indigenous instruments, folk dances celebrating the harvest, and storytelling sessions sharing local legends and oral history. The festival also promotes environmental awareness about oasis conservation and sustainable agriculture practices.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 20,
                Name = "Egyptian Museum Anniversary Exhibition",
                Description = "A spectacular commemorative exhibition celebrating the Egyptian Museum's pivotal role in preserving and presenting Egypt's archaeological treasures, featuring rare artifacts rarely displayed to the public, newly discovered pieces, and interactive presentations about the museum's history and mission. The exhibition includes behind-the-scenes tours showing conservation laboratories, storage facilities, and restoration work in progress, providing visitors with insights into the complex process of maintaining ancient artifacts. Special presentations by leading Egyptologists reveal new research findings, recent archaeological discoveries, and ongoing excavation projects across Egypt. The event also features digital reconstructions of ancient sites, virtual reality experiences allowing visitors to explore tombs and temples, and educational programs designed for students and researchers interested in Egyptology and museum studies.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 21,
                Name = "Coptic Christmas Celebrations",
                Description = "A deeply meaningful religious celebration observed by Egypt's Coptic Christian community on January 7th, featuring special midnight masses in historic churches adorned with traditional decorations, community feasts that bring families together, and cultural events that highlight the rich heritage of Egyptian Christianity. The celebrations include beautiful choral performances of traditional Coptic hymns sung in ancient languages, processions through historic Coptic quarters of Cairo and other cities, and exhibitions showcasing Coptic art, manuscripts, and religious artifacts. Churches open their doors for cultural tours explaining Coptic history, architecture, and religious practices, while community centers host educational programs about the role of Coptic Christianity in Egyptian society. The festivities also include charity drives, community service projects, and interfaith dialogue events promoting understanding and coexistence among Egypt's diverse religious communities.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 22,
                Name = "Red Sea Kite Surfing Championship",
                Description = "An adrenaline-pumping international competition that brings world-class kite surfers to Egypt's pristine Red Sea coast, featuring high-speed races, freestyle competitions, and big air contests in the consistently windy conditions that make this region a global kite surfing destination. The championship attracts professional athletes from around the world competing for substantial prize money and world ranking points, while the event atmosphere includes beach parties, live music performances, and water sports exhibitions. Beginners can participate in kite surfing lessons with certified instructors, while advanced riders can join coaching clinics with professional athletes. The event also features environmental awareness programs highlighting Red Sea conservation, local cultural performances, and food festivals showcasing coastal Egyptian cuisine. Spectators enjoy beachside viewing areas, water taxi services to optimal viewing positions, and VIP hospitality options.",
                EventTypeId = 1
            },
            new Event
            {
                Id = 23,
                Name = "Luxor Art Exhibition",
                Description = "An inspiring annual showcase of contemporary Egyptian art set in the historically rich city of Luxor, where ancient temples and tombs provide a dramatic backdrop for modern artistic expression. The exhibition features works by established and emerging Egyptian artists across various media including painting, sculpture, photography, digital art, and mixed media installations that often incorporate themes from ancient Egyptian culture reimagined through contemporary perspectives. Gallery spaces in historic buildings and outdoor installations in archaeological sites create unique viewing experiences that bridge ancient and modern artistic traditions. The event includes artist talks, workshops on traditional and modern art techniques, guided tours that explore the connection between ancient Egyptian art and contemporary creativity, and cultural exchanges with international artists and curators.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 24,
                Name = "Cairo Street Art Festival",
                Description = "A dynamic celebration of urban artistic expression that transforms Cairo's walls, buildings, and public spaces into an open-air gallery showcasing the creativity and social commentary of local and international street artists. The festival features live mural painting sessions where visitors can watch artists create large-scale works, graffiti workshops teaching various techniques and styles, and guided tours through neighborhoods known for their street art culture. Interactive performances combine visual art with music, dance, and spoken word poetry, while panel discussions explore street art's role in social movements and cultural change. The event also includes community engagement projects where residents collaborate with artists to beautify their neighborhoods, youth programs teaching artistic skills as alternatives to destructive graffiti, and exhibitions documenting the evolution of Cairo's street art scene.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 25,
                Name = "Islamic Heritage Conference",
                Description = "A comprehensive academic and cultural gathering that explores the profound influence of Islamic civilization on Egyptian culture, architecture, art, literature, and social traditions through scholarly presentations, archaeological discoveries, and cultural exhibitions. The conference brings together leading historians, archaeologists, theologians, and cultural experts from around the world to present research on Islamic monuments, manuscript preservation, traditional crafts, and the evolution of Islamic thought in Egypt. Interactive workshops demonstrate traditional Islamic arts such as calligraphy, geometric pattern design, and manuscript illumination, while cultural performances feature traditional Islamic music, poetry recitations, and theatrical presentations. The event also includes guided tours of historic Islamic sites in Cairo, Alexandria, and other cities, educational programs for students and teachers, and interfaith dialogue sessions promoting understanding of Islamic contributions to world civilization.",
                EventTypeId = 3
            },
            new Event
            {
                Id = 31,
                Name = "Ismailia Mango Festival",
                Description = "A delightful celebration of Ismailia's world-renowned mangoes, featuring extensive agricultural exhibitions showcasing different mango varieties, traditional harvesting demonstrations, cooking competitions with mango-based dishes, live folk music performances, and family-friendly entertainment. Local farmers display their finest produce while visitors can sample fresh mango juices, dried mango products, and traditional Egyptian sweets infused with mango flavors. The festival also includes cultural workshops on mango cultivation techniques and the fruit's significance in Egyptian agriculture.",
                EventTypeId = 4
            },
            new Event
            {
                Id = 32,
                Name = "Alexandria Short Film Festival",
                Description = "An internationally acclaimed film festival that transforms Alexandria into a cinematic hub, showcasing innovative short films from Egyptian and international filmmakers. The event features competitive screenings across multiple venues, masterclasses with renowned directors, industry networking sessions, and panel discussions on contemporary filmmaking techniques. Emerging filmmakers get the opportunity to present their work to industry professionals, critics, and cinema enthusiasts. The festival also includes workshops on digital filmmaking, script writing, and post-production techniques, making it a comprehensive learning experience for aspiring filmmakers.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 33,
                Name = "International Women Theatre Festival",
                Description = "A groundbreaking festival dedicated to celebrating women's contributions to theatre arts, featuring powerful performances by female playwrights, directors, and actresses from around the world. The festival presents thought-provoking plays addressing women's experiences, social issues, and contemporary challenges. Interactive workshops cover topics such as feminist theatre, directing techniques, and creative writing. Panel discussions bring together theatre professionals to explore gender representation in performing arts, while networking events connect women in theatre from different cultural backgrounds. The festival also includes community outreach programs promoting theatre education among young women.",
                EventTypeId = 5
            },
            new Event
            {
                Id = 34,
                Name = "The Solar Alignment on the Karnak Temple",
                Description = "A breathtaking astronomical phenomenon that occurs twice yearly when the rising sun perfectly aligns with the main axis of Karnak Temple, illuminating the sacred sanctuary in golden light. This ancient engineering marvel demonstrates the sophisticated astronomical knowledge of pharaonic architects who designed the temple to capture this celestial event. Visitors gather before dawn to witness this mystical moment, accompanied by expert Egyptologists who explain the religious and astronomical significance of the alignment. The event includes guided tours of the temple complex, lectures on ancient Egyptian astronomy, photography workshops, and cultural performances recreating ancient rituals that would have accompanied this sacred occurrence.",
                EventTypeId = 2
            },
            new Event
            {
                Id = 35,
                Name = "Cairo International Film Festival",
                Description = "The Arab world's most prestigious and longest-running film festival, transforming Cairo into the region's cinematic capital for two weeks each year. This internationally recognized event attracts A-list celebrities, renowned directors, producers, and film critics from around the globe. The festival screens hundreds of films across various categories including feature films, documentaries, and short films, with competitions for both regional and international productions. Red carpet galas, exclusive premieres, industry forums, and film market sessions provide networking opportunities for industry professionals. Educational programs include film workshops, master classes with acclaimed directors, and seminars on the future of Arab cinema.",
                EventTypeId = 1
            },
        };

        builder.HasData(events);
    }
}