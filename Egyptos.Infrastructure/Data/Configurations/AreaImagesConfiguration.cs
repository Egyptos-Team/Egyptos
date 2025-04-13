using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Egyptos.Infrastructure.Data.Configurations;

public class AreaImagesConfiguration : IEntityTypeConfiguration<AreaImage>
{
    public void Configure(EntityTypeBuilder<AreaImage> builder)
    {
        var areaImages = new List<AreaImage>
        {
            //1
            new AreaImage
            {
                Id=1,
                Description="",
                ImageUrl="AreaImages/sphinx1.jpg",
                AreaId=1
            },
            new AreaImage
            {
                Id=2,
                Description="",
                ImageUrl="AreaImages/sphinx2.jpeg",
                AreaId=1
            },
            new AreaImage
            {
                Id=3,
                Description="",
                ImageUrl="AreaImages/sphinx3.jpeg",
            AreaId=1
            },
            new AreaImage
            {
                Id=4,
                Description="",
                ImageUrl="AreaImages/sphinx4.jpeg",
            AreaId=1
            },
            new AreaImage
            {
                Id=5,
                Description="",
                ImageUrl="AreaImages/sphinx5.jpeg",
            AreaId=1
            },
            //2
            new AreaImage
            {
                Id=6,
                Description="",
                ImageUrl="AreaImages/Roman well1.webp",
                AreaId=2
            },
            new AreaImage
            {
                Id=7,
                Description="",
                ImageUrl="AreaImages/Roman well2.webp",
            AreaId=2
            },
            new AreaImage
            {
                Id=8,
                Description="",
                ImageUrl="AreaImages/Roman well3.webp",
            AreaId=2
            },
            new AreaImage
            {
                Id=9,
                Description="",
                ImageUrl="AreaImages/Roman well4.jpeg",
            AreaId=2
            },
            new AreaImage
            {
                Id=10,
                Description="",
                ImageUrl="AreaImages/Roman well5.jpeg",
            AreaId=2
            },
            //3
            new AreaImage
            {
                Id=11,
                Description="",
                ImageUrl="AreaImages/Eastern and Western Cemeteries1.webp",
                AreaId=3
            },
            new AreaImage
            {
                Id=12,
                Description="",
                ImageUrl="AreaImages/Eastern and Western Cemeteries2.webp",
            AreaId=3
            },
            new AreaImage
            {
                Id=13,
                Description="",
                ImageUrl="AreaImages/Eastern and Western Cemeteries3.webp",
            AreaId=3
            },
            new AreaImage
            {
                Id=14,
                Description="",
                ImageUrl="AreaImages/Eastern and Western Cemeteries4.jpeg",
            AreaId=3
            },
            new AreaImage
            {
                Id=15,
                Description="",
                ImageUrl="AreaImages/Eastern and Western Cemeteries5.jpeg",
            AreaId=3
            },
            //4
            new AreaImage
            {
                Id=16,
                Description="",
                ImageUrl="AreaImages/Serapeum1.jpeg",
                AreaId=4
            },
            new AreaImage
            {
                Id=17,
                Description="",
                ImageUrl="AreaImages/Serapeum2.jpg",
            AreaId=4
            },
            new AreaImage
            {
                Id=18,
                Description="",
                ImageUrl="AreaImages/Serapeum3.jpeg",
            AreaId=4
            },
            new AreaImage
            {
                Id=19,
                Description="",
                ImageUrl="AreaImages/Serapeum4.jpeg",
            AreaId=4
            },
            new AreaImage
            {
                Id=20,
                Description="",
                ImageUrl="AreaImages/Serapeum5.jpeg",
            AreaId=4
            },
            //5
            new AreaImage
            {
                Id=21,
                Description="",
                ImageUrl="AreaImages/Titi pyramid set1.jpeg",
                AreaId=5
            },
            new AreaImage
            {
                Id=22,
                Description="",
                ImageUrl="AreaImages/Titi pyramid set2.webp",
            AreaId=5
            },
            new AreaImage
            {
                Id=23,
                Description="",
                ImageUrl="AreaImages/Titi pyramid set3.jpeg",
            AreaId=5
            },
            new AreaImage
            {
                Id=24,
                Description="",
                ImageUrl="AreaImages/Titi pyramid set4.jpeg",
            AreaId=5
            },
            new AreaImage
            {
                Id=25,
                Description="",
                ImageUrl="AreaImages/Titi pyramid set5.jpeg",
            AreaId=5
            },
            //6
            new AreaImage
            {
                Id=26,
                Description="",
                ImageUrl="AreaImages/Pyramid complex of King Menkaure6.jpeg",
                AreaId=6
            },
            new AreaImage
            {
                Id=27,
                Description="",
                ImageUrl="AreaImages/Pyramid complex of King Menkaure7.jpeg",
            AreaId=6
            },
            new AreaImage
            {
                Id=28,
                Description="",
                ImageUrl="AreaImages/Pyramid complex of King Menkaure8.jpeg",
            AreaId=6
            },
            new AreaImage
            {
                Id=29,
                Description="",
                ImageUrl="AreaImages/Pyramid complex of King Menkaure9.jpeg",
            AreaId=6
            },
            new AreaImage
            {
                Id=30,
                Description="",
                ImageUrl="AreaImages/Pyramid complex of King Menkaure10.jpg",
            AreaId=6
            },
            //7
            new AreaImage
            {
                Id=31,
                Description="",
                ImageUrl="AreaImages/The Unfinished Obelisk1.jpg",
                AreaId=7
            },
            new AreaImage
            {
                Id=32,
                Description="",
                ImageUrl="AreaImages/The Unfinished Obelisk1.jpg",
            AreaId=7
            },
            new AreaImage
            {
                Id=33,
                Description="",
                ImageUrl="AreaImages/The Unfinished Obelisk1.jpg",
            AreaId=7
            },
            new AreaImage
            {
                Id=34,
                Description="",
                ImageUrl="AreaImages/The Unfinished Obelisk1.jpg",
            AreaId=7
            },
            new AreaImage
            {
                Id=35,
                Description="",
                ImageUrl="AreaImages/The Unfinished Obelisk1.JPG",
            AreaId=7
            },
            //8
            new AreaImage
            {
                Id=36,
                Description="",
                ImageUrl="AreaImages/Rock carvings on Suhail Island1.jpg",
                AreaId=8
            },
            new AreaImage
            {
                Id=37,
                Description="",
                ImageUrl="AreaImages/Rock carvings on Suhail Island2.jpeg",
            AreaId=8
            },
            new AreaImage
            {
                Id=38,
                Description="",
                ImageUrl="AreaImages/Rock carvings on Suhail Island3.jpg",
            AreaId=8
            },
            new AreaImage
            {
                Id=39,
                Description="",
                ImageUrl="AreaImages/Rock carvings on Suhail Island4.jpg",
            AreaId=8
            },
            new AreaImage
            {
                Id=40,
                Description="",
                ImageUrl="AreaImages/Rock carvings on Suhail Island5.jpg",
            AreaId=8
            },
            //9
            new AreaImage
            {
                Id=41,
                Description="",
                ImageUrl="AreaImages/Howard Carter's house in Thebes1.jpg",
                AreaId=9
            },
            new AreaImage
            {
                Id=42,
                Description="",
                ImageUrl="AreaImages/Howard Carter's house in Thebes2.jpeg",
            AreaId=9
            },
            new AreaImage
            {
                Id=43,
                Description="",
                ImageUrl="AreaImages/Howard Carter's house in Thebes3.jpg",
            AreaId=9
            },
            new AreaImage
            {
                Id=44,
                Description="",
                ImageUrl="AreaImages/Howard Carter's house in Thebes4.avif",
            AreaId=9
            },
            new AreaImage
            {
                Id=45,
                Description="",
                ImageUrl="AreaImages/Howard Carter's house in Thebes5.jpeg",
            AreaId=9
            },
            //10
            new AreaImage
            {
                Id=46,
                Description="",
                ImageUrl="AreaImages/Statue of Meritamun (The White Queen)1.jpeg",
                AreaId=10
            },
            new AreaImage
            {
                Id=47,
                Description="",
                ImageUrl="AreaImages/AA1.avif",
            AreaId=10
            },
            new AreaImage
            {
                Id=48,
                Description="",
                ImageUrl="AreaImages/AA2.jpg",
            AreaId=10
            },
            new AreaImage
            {
                Id=49,
                Description="",
                ImageUrl="AreaImages/Statue of Meritamun (The White Queen)4.jpeg",
            AreaId=10
            },
            new AreaImage
            {
                Id=50,
                Description="",
                ImageUrl="AreaImages/Statue of Meritamun (The White Queen)5.jpg",
            AreaId=10
            },
            //11
            new AreaImage
            {
                Id=51,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Muayyad Sheikh Mosque1.jpeg",
                AreaId=11
            },
            new AreaImage
            {
                Id=52,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Muayyad Sheikh Mosque2.jpg",
            AreaId=11
            },
            new AreaImage
            {
                Id=53,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Muayyad Sheikh Mosque3.jpg",
            AreaId=11
            },
            new AreaImage
            {
                Id=54,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Muayyad Sheikh Mosque4.jpg",
            AreaId=11
            },
            new AreaImage
            {
                Id=55,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Muayyad Sheikh Mosque5.webp",
            AreaId=11
            },
            //12
            new AreaImage
            {
                Id=56,
                Description="",
                ImageUrl="AreaImages/Suleiman Agha Al-Selhadar Mosque1.jpeg",
                AreaId=12
            },
            new AreaImage
            {
                Id=57,
                Description="",
                ImageUrl="AreaImages/Suleiman Agha Al-Selhadar Mosque2.jpeg",
            AreaId=12
            },
            new AreaImage
            {
                Id=58,
                Description="",
                ImageUrl="AreaImages/Suleiman Agha Al-Selhadar Mosque3.webp",
            AreaId=12
            },
            new AreaImage
            {
                Id=59,
                Description="",
                ImageUrl="AreaImages/AA3.jpeg",
            AreaId=12
            },
            new AreaImage
            {
                Id=60,
                Description="",
                ImageUrl="AreaImages/Suleiman Agha Al-Selhadar Mosque5.avif",
            AreaId=12
            },
            //13
            new AreaImage
            {
                Id=61,
                Description="",
                ImageUrl="AreaImages/Amr ibn al-Aas Mosque1.jpeg",
                AreaId=13
            },
            new AreaImage
            {
                Id=62,
                Description="",
                ImageUrl="AreaImages/Amr ibn al-Aas Mosque2.jpeg",
            AreaId=13
            },
            new AreaImage
            {
                Id=63,
                Description="",
                ImageUrl="AreaImages/Amr ibn al-Aas Mosque3.jpg",
            AreaId=13
            },
            new AreaImage
            {
                Id=64,
                Description="",
                ImageUrl="AreaImages/Amr ibn al-Aas Mosque4.jpg",
            AreaId=13
            },
            new AreaImage
            {
                Id=65,
                Description="",
                ImageUrl="AreaImages/Amr ibn al-Aas Mosque5.jpeg",
            AreaId=13
            },
            //14
            new AreaImage
            {
                Id=66,
                Description="",
                ImageUrl="AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun1.jpg",
                AreaId=14
            },
            new AreaImage
            {
                Id=67,
                Description="",
                ImageUrl="AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun2.jpg",
            AreaId=14
            },
            new AreaImage
            {
                Id=68,
                Description="",
                ImageUrl="AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun3.jpg",
            AreaId=14
            },
            new AreaImage
            {
                Id=69,
                Description="",
                ImageUrl="AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun4.jpg",
            AreaId=14
            },
            new AreaImage
            {
                Id=70,
                Description="",
                ImageUrl="AreaImages/Mosque and School of Al-Nasir Muhammad ibn Qalawun5.webp",
            AreaId=14
            },
            //15
            new AreaImage
            {
                Id=71,
                Description="",
                ImageUrl="AreaImages/Cemetery and city of workers who built the pyramids1.jpg",
                AreaId=15
            },
            new AreaImage
            {
                Id=72,
                Description="",
                ImageUrl="AreaImages/Cemetery and city of workers who built the pyramids2.jpeg",
            AreaId=15
            },
            new AreaImage
            {
                Id=73,
                Description="",
                ImageUrl="AreaImages/Cemetery and city of workers who built the pyramids3.jpg",
            AreaId=15
            },
            new AreaImage
            {
                Id=74,
                Description="",
                ImageUrl="AreaImages/Cemetery and city of workers who built the pyramids4.jpg",
            AreaId=15
            },
            new AreaImage
            {
                Id=75,
                Description="",
                ImageUrl="AreaImages/Cemetery and city of workers who built the pyramids5.jpeg",
            AreaId=15
            },
            //16
            new AreaImage
            {
                Id=76,
                Description="",
                ImageUrl="AreaImages/Aswan Cemetery1.jpeg",
                AreaId=16
            },
            new AreaImage
            {
                Id=77,
                Description="",
                ImageUrl="AreaImages/Aswan Cemetery2.jpeg",
            AreaId=16
            },
            new AreaImage
            {
                Id=78,
                Description="",
                ImageUrl="AreaImages/Aswan Cemetery3.jpg",
            AreaId=16
            },
            new AreaImage
            {
                Id=79,
                Description="",
                ImageUrl="AreaImages/Aswan Cemetery4.jpeg",
            AreaId=16
            },
            new AreaImage
            {
                Id=80,
                Description="",
                ImageUrl="AreaImages/Aswan Cemetery5.jpg",
            AreaId=16
            },
            //17
            new AreaImage
            {
                Id=81,
                Description="",
                ImageUrl="AreaImages/Al-Bajwat Cemetery1.jpg",
                AreaId=17
            },
            new AreaImage
            {
                Id=82,
                Description="",
                ImageUrl="AreaImages/Al-Bajwat Cemetery2.jpeg",
            AreaId=17
            },
            new AreaImage
            {
                Id=83,
                Description="",
                ImageUrl="AreaImages/Al-Bajwat Cemetery3.jpeg",
            AreaId=17
            },
            new AreaImage
            {
                Id=84,
                Description="",
                ImageUrl="AreaImages/Al-Bajwat Cemetery4.jpg",
            AreaId=17
            },
            new AreaImage
            {
                Id=85,
                Description="",
                ImageUrl="AreaImages/Al-Bajwat Cemetery5.jpg",
            AreaId=17
            },
            //18
            new AreaImage
            {
                Id=86,
                Description="",
                ImageUrl="AreaImages/Shatby Cemetery1.jpeg",
                AreaId=18
            },
            new AreaImage
            {
                Id=87,
                Description="",
                ImageUrl="AreaImages/Shatby Cemetery2.jpg",
            AreaId=18
            },
            new AreaImage
            {
                Id=88,
                Description="",
                ImageUrl="AreaImages/Shatby Cemetery3.jpg",
            AreaId=18
            },
            new AreaImage
            {
                Id=89,
                Description="",
                ImageUrl="AreaImages/Shatby Cemetery4.jpg",
            AreaId=18
            },
            new AreaImage
            {
                Id=90,
                Description="",
                ImageUrl="AreaImages/Shatby Cemetery5.jpg",
            AreaId=18
            },
            //19
            new AreaImage
            {
                Id=91,
                Description="",
                ImageUrl="AreaImages/Sultan Inal's Bath1.jpg",
                AreaId=19
            },
            new AreaImage
            {
                Id=92,
                Description="",
                ImageUrl="AreaImages/Sultan Inal's Bath2.jpeg",
            AreaId=19
            },
            new AreaImage
            {
                Id=93,
                Description="",
                ImageUrl="AreaImages/Sultan Inal's Bath3.jpeg",
            AreaId=19
            },
            new AreaImage
            {
                Id=94,
                Description="",
                ImageUrl="AreaImages/Sultan Inal's Bath4.jpeg",
            AreaId=19
            },
            new AreaImage
            {
                Id=95,
                Description="",
                ImageUrl="AreaImages/Sultan Inal's Bath5.jpeg",
            AreaId=19
            },
            //20
            new AreaImage
            {
                Id=96,
                Description="",
                ImageUrl="AreaImages/Syriac Monastery1.jpeg",
                AreaId=20
            },
            new AreaImage
            {
                Id=97,
                Description="",
                ImageUrl="AreaImages/Syriac Monastery2.jpeg",
            AreaId=20
            },
            new AreaImage
            {
                Id=98,
                Description="",
                ImageUrl="AreaImages/Syriac Monastery3.webp",
            AreaId=20
            },
            new AreaImage
            {
                Id=99,
                Description="",
                ImageUrl="AreaImages/Syriac Monastery4.webp",
            AreaId=20
            },
            new AreaImage
            {
                Id=100,
                Description="",
                ImageUrl="AreaImages/Syriac Monastery5.jpg",
            AreaId=20
            },
            //21
            new AreaImage
            {
                Id=101,
                Description="",
                ImageUrl="AreaImages/The Way and the Writers of Nafisa Al-Bayda1.jpg",
                AreaId=21
            },
            new AreaImage
            {
                Id=102,
                Description="",
                ImageUrl="AreaImages/The Way and the Writers of Nafisa Al-Bayda2.jpg",
            AreaId=21
            },
            new AreaImage
            {
                Id=103,
                Description="",
                ImageUrl="AreaImages/The Way and the Writers of Nafisa Al-Bayda3.jpg",
            AreaId=21
            },
            new AreaImage
            {
                Id=104,
                Description="",
                ImageUrl="AreaImages/AA4.jpeg",
            AreaId=21
            },
            new AreaImage
            {
                Id=105,
                Description="",
                ImageUrl="AreaImages/The Way and the Writers of Nafisa Al-Bayda5.avif",
            AreaId=21
            },
            //22
            new AreaImage
            {
                Id=106,
                Description="",
                ImageUrl="AreaImages/Palace of King Amenemhat1.jpg",
                AreaId=22
            },
            new AreaImage
            {
                Id=107,
                Description="",
                ImageUrl="AreaImages/Palace of King Amenemhat2.jpeg",
            AreaId=22
            },
            new AreaImage
            {
                Id=108,
                Description="",
                ImageUrl="AreaImages/Palace of King Amenemhat3.jpg",
            AreaId=22
            },
            new AreaImage
            {
                Id=109,
                Description="",
                ImageUrl="AreaImages/Palace of King Amenemhat4.jpeg",
            AreaId=22
            },
            new AreaImage
            {
                Id=110,
                Description="",
                ImageUrl="AreaImages/Palace of King Amenemhat5.jpeg",
            AreaId=22
            },
            //23
            new AreaImage
            {
                Id=111,
                Description="",
                ImageUrl="AreaImages/Mohamed Ali Palace in Shubra1.jpeg",
                AreaId=23
            },
            new AreaImage
            {
                Id=112,
                Description="",
                ImageUrl="AreaImages/Mohamed Ali Palace in Shubra2.jpeg",
            AreaId=23
            },
            new AreaImage
            {
                Id=113,
                Description="",
                ImageUrl="AreaImages/Mohamed Ali Palace in Shubra3.jpeg",
            AreaId=23
            },
            new AreaImage
            {
                Id=114,
                Description="",
                ImageUrl="AreaImages/Mohamed Ali Palace in Shubra4.jpg",
            AreaId=23
            },
            new AreaImage
            {
                Id=115,
                Description="",
                ImageUrl="AreaImages/Mohamed Ali Palace in Shubra5.jpg",
            AreaId=23
            },
            //24
            new AreaImage
            {
                Id=116,
                Description="",
                ImageUrl="AreaImages/Church of the Burning Bush1.jpg",
                AreaId=24
            },
            new AreaImage
            {
                Id=117,
                Description="",
                ImageUrl="AreaImages/Church of the Burning Bush2.jpg",
            AreaId=24
            },
            new AreaImage
            {
                Id=118,
                Description="",
                ImageUrl="AreaImages/Church of the Burning Bush3.jpg",
            AreaId=24
            },
            new AreaImage
            {
                Id=119,
                Description="",
                ImageUrl="AreaImages/Church of the Burning Bush4.webp",
            AreaId=24
            },
            new AreaImage
            {
                Id=120,
                Description="",
                ImageUrl="AreaImages/Church of the Burning Bush5.jpeg",
            AreaId=24
            },
            //25
            new AreaImage
            {
                Id=121,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri Group1.jpg",
                AreaId=25
            },
            new AreaImage
            {
                Id=122,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri Group2.jpg",
            AreaId=25
            },
            new AreaImage
            {
                Id=123,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri Group3.jpg",
            AreaId=25
            },
            new AreaImage
            {
                Id=124,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri Group4.jpeg",
            AreaId=25
            },
            new AreaImage
            {
                Id=125,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri Group5.jpeg",
            AreaId=25
            },
            //26
            new AreaImage
            {
                Id=126,
                Description="",
                ImageUrl="AreaImages/Sultan Qaitbay Complex in the Mamluk Desert1.jpg",
                AreaId=26
            },
            new AreaImage
            {
                Id=127,
                Description="",
                ImageUrl="AreaImages/Sultan Qaitbay Complex in the Mamluk Desert2.jpg",
            AreaId=26
            },
            new AreaImage
            {
                Id=128,
                Description="",
                ImageUrl="AreaImages/Sultan Qaitbay Complex in the Mamluk Desert3.jpg",
            AreaId=26
            },
            new AreaImage
            {
                Id=129,
                Description="",
                ImageUrl="AreaImages/Sultan Qaitbay Complex in the Mamluk Desert4.jpeg",
            AreaId=26
            },
            new AreaImage
            {
                Id=130,
                Description="",
                ImageUrl="AreaImages/Sultan Qaitbay Complex in the Mamluk Desert5.jpg",
            AreaId=26
            },
            //27
            new AreaImage
            {
                Id=131,
                Description="",
                ImageUrl="AreaImages/Step Pyramid of Djoser1.jpeg",
                AreaId=27
            },
            new AreaImage
            {
                Id=132,
                Description="",
                ImageUrl="AreaImages/Step Pyramid of Djoser2.jpeg",
            AreaId=27
            },
            new AreaImage
            {
                Id=133,
                Description="",
                ImageUrl="AreaImages/Step Pyramid of Djoser2.jpg",
            AreaId=27
            },
            new AreaImage
            {
                Id=134,
                Description="",
                ImageUrl="AreaImages/Step Pyramid of Djoser4.avif",
            AreaId=27
            },
            new AreaImage
            {
                Id=135,
                Description="",
                ImageUrl="AreaImages/Step Pyramid of Djoser5.jpeg",
            AreaId=27
            },
            //28
            new AreaImage
            {
                Id=136,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri School1.jpg",
                AreaId=28
            },
            new AreaImage
            {
                Id=137,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri School2.jpg",
            AreaId=28
            },
            new AreaImage
            {
                Id=138,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri School3.jpeg",
            AreaId=28
            },
            new AreaImage
            {
                Id=139,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri School4.jpeg",
            AreaId=28
            },
            new AreaImage
            {
                Id=140,
                Description="",
                ImageUrl="AreaImages/Sultan Al-Ghouri School5.jpeg",
            AreaId=28
            },
            //29
            new AreaImage
            {
                Id=141,
                Description="",
                ImageUrl="AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun1.jpeg",
                AreaId=29
            },
            new AreaImage
            {
                Id=142,
                Description="",
                ImageUrl="AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun2.jpg",
            AreaId=29
            },
            new AreaImage
            {
                Id=143,
                Description="",
                ImageUrl="AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun3.jpeg",
            AreaId=29
            },
            new AreaImage
            {
                Id=144,
                Description="",
                ImageUrl="AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun4.jpeg",
            AreaId=29
            },
            new AreaImage
            {
                Id=145,
                Description="",
                ImageUrl="AreaImages/School, Mausoleum and Hospital of Al-Mansur Qalawun5.jpeg",
            AreaId=29
            },
            //30
            new AreaImage
            {
                Id=146,
                Description="",
                ImageUrl="AreaImages/School and Khanqah of Sultan al-Zahir Barquq1.jpeg",
                AreaId=30
            },
            new AreaImage
            {
                Id=147,
                Description="",
                ImageUrl="AreaImages/School and Khanqah of Sultan al-Zahir Barquq2.jpeg",
            AreaId=30
            },
            new AreaImage
            {
                Id=148,
                Description="",
                ImageUrl="AreaImages/School and Khanqah of Sultan al-Zahir Barquq3.jpg",
            AreaId=30
            },
            new AreaImage
            {
                Id=149,
                Description="",
                ImageUrl="AreaImages/School and Khanqah of Sultan al-Zahir Barquq4.jpg",
            AreaId=30
            },
            new AreaImage
            {
                Id=150,
                Description="",
                ImageUrl="AreaImages/School and Khanqah of Sultan al-Zahir Barquq5.jpeg",
            AreaId=30
            },
            // 81
            new AreaImage
            {
                Id=151,
                Description="",
                ImageUrl="AreaImages/1.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=152,
                Description="",
                ImageUrl="AreaImages/2.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=153,
                Description="",
                ImageUrl="AreaImages/3.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=154,
                Description="",
                ImageUrl="AreaImages/4.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=155,
                Description="",
                ImageUrl="AreaImages/5.jpg",
                AreaId=81
            },
            // 82
            new AreaImage
            {
                Id=156,
                Description="",
                ImageUrl="AreaImages/6.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=157,
                Description="",
                ImageUrl="AreaImages/7.jpg",
            AreaId=82
            },
            new AreaImage
            {
                Id=158,
                Description="",
                ImageUrl="AreaImages/8.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=159,
                Description="",
                ImageUrl="AreaImages/9.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=160,
                Description="",
                ImageUrl="AreaImages/10.jpg",
                AreaId=82
            },
            // 83
            new AreaImage
            {
                Id=161,
                Description="",
                ImageUrl="AreaImages/11.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=162,
                Description="",
                ImageUrl="AreaImages/12.jpg",
            AreaId=83
            },
            new AreaImage
            {
                Id=163,
                Description="",
                ImageUrl="AreaImages/13.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=164,
                Description="",
                ImageUrl="AreaImages/14.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=165,
                Description="",
                ImageUrl="AreaImages/15.jpg",
                AreaId=83
            },
            // 84
            new AreaImage
            {
                Id=166,
                Description="",
                ImageUrl="AreaImages/16.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=167,
                Description="",
                ImageUrl="AreaImages/17.jpg",
            AreaId=84
            },
            new AreaImage
            {
                Id=168,
                Description="",
                ImageUrl="AreaImages/18.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=169,
                Description="",
                ImageUrl="AreaImages/19.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=170,
                Description="",
                ImageUrl="AreaImages/20.jpg",
                AreaId=84
            },
            // 85
            new AreaImage
            {
                Id=171,
                Description="",
                ImageUrl="AreaImages/21.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=172,
                Description="",
                ImageUrl="AreaImages/22.jpg",
            AreaId=85
            },
            new AreaImage
            {
                Id=173,
                Description="",
                ImageUrl="AreaImages/23.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=174,
                Description="",
                ImageUrl="AreaImages/24.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=175,
                Description="",
                ImageUrl="AreaImages/25.jpg",
                AreaId=85
            },
            // 86
            new AreaImage
            {
                Id=176,
                Description="",
                ImageUrl="AreaImages/26.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=177,
                Description="",
                ImageUrl="AreaImages/27.jpg",
            AreaId=86
            },
            new AreaImage
            {
                Id=178,
                Description="",
                ImageUrl="AreaImages/28.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=179,
                Description="",
                ImageUrl="AreaImages/29.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=180,
                Description="",
                ImageUrl="AreaImages/30.jpg",
                AreaId=86
            },
            // 87
            new AreaImage
            {
                Id=181,
                Description="",
                ImageUrl="AreaImages/31.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=182,
                Description="",
                ImageUrl="AreaImages/32.jpg",
            AreaId=87
            },
            new AreaImage
            {
                Id=183,
                Description="",
                ImageUrl="AreaImages/33.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=184,
                Description="",
                ImageUrl="AreaImages/34.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=185,
                Description="",
                ImageUrl="AreaImages/35.jpg",
                AreaId=87
            },
            // 88
            new AreaImage
            {
                Id=186,
                Description="",
                ImageUrl="AreaImages/36.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=187,
                Description="",
                ImageUrl="AreaImages/37.jpg",
            AreaId=88
            },
            new AreaImage
            {
                Id=188,
                Description="",
                ImageUrl="AreaImages/38.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=189,
                Description="",
                ImageUrl="AreaImages/39.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=190,
                Description="",
                ImageUrl="AreaImages/40.jpg",
                AreaId=88
            },
            // 89
            new AreaImage
            {
                Id=191,
                Description="",
                ImageUrl="AreaImages/41.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=192,
                Description="",
                ImageUrl="AreaImages/42.jpg",
            AreaId=89
            },
            new AreaImage
            {
                Id=193,
                Description="",
                ImageUrl="AreaImages/43.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=194,
                Description="",
                ImageUrl="AreaImages/44.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=195,
                Description="",
                ImageUrl="AreaImages/45.jpg",
                AreaId=89
            },
            // 90
            new AreaImage
            {
                Id=196,
                Description="",
                ImageUrl="AreaImages/46.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=197,
                Description="",
                ImageUrl="AreaImages/47.jpg",
            AreaId=90
            },
            new AreaImage
            {
                Id=198,
                Description="",
                ImageUrl="AreaImages/48.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=199,
                Description="",
                ImageUrl="AreaImages/49.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=200,
                Description="",
                ImageUrl="AreaImages/50.jpg",
                AreaId=90
            },
            // 91
            new AreaImage
            {
                Id=201,
                Description="",
                ImageUrl="AreaImages/51.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=202,
                Description="",
                ImageUrl="AreaImages/52.jpg",
            AreaId=91
            },
            new AreaImage
            {
                Id=203,
                Description="",
                ImageUrl="AreaImages/53.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=204,
                Description="",
                ImageUrl="AreaImages/54.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=205,
                Description="",
                ImageUrl="AreaImages/55.jpg",
                AreaId=91
            },
            // 92
            new AreaImage
            {
                Id=206,
                Description="",
                ImageUrl="AreaImages/56.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=207,
                Description="",
                ImageUrl="AreaImages/57.jpg",
            AreaId=92
            },
            new AreaImage
            {
                Id=208,
                Description="",
                ImageUrl="AreaImages/58.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=209,
                Description="",
                ImageUrl="AreaImages/59.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=210,
                Description="",
                ImageUrl="AreaImages/60.jpg",
                AreaId=92
            },
            // 93
            new AreaImage
            {
                Id=211,
                Description="",
                ImageUrl="AreaImages/61.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=212,
                Description="",
                ImageUrl="AreaImages/62.jpg",
            AreaId=93
            },
            new AreaImage
            {
                Id=213,
                Description="",
                ImageUrl="AreaImages/63.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=214,
                Description="",
                ImageUrl="AreaImages/64.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=215,
                Description="",
                ImageUrl="AreaImages/65.jpg",
                AreaId=93
            },
            // 94
            new AreaImage
            {
                Id=216,
                Description="",
                ImageUrl="AreaImages/66.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=217,
                Description="",
                ImageUrl="AreaImages/67.jpg",
            AreaId=94
            },
            new AreaImage
            {
                Id=218,
                Description="",
                ImageUrl="AreaImages/68.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=219,
                Description="",
                ImageUrl="AreaImages/69.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=220,
                Description="",
                ImageUrl="AreaImages/70.jpg",
                AreaId=94
            },
            // 95
            new AreaImage
            {
                Id=221,
                Description="",
                ImageUrl="AreaImages/71.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=222,
                Description="",
                ImageUrl="AreaImages/72.jpg",
            AreaId=95
            },
            new AreaImage
            {
                Id=223,
                Description="",
                ImageUrl="AreaImages/73.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=224,
                Description="",
                ImageUrl="AreaImages/74.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=225,
                Description="",
                ImageUrl="AreaImages/75.jpg",
                AreaId=95
            },
            // 96
            new AreaImage
            {
                Id=226,
                Description="",
                ImageUrl="AreaImages/76.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=227,
                Description="",
                ImageUrl="AreaImages/77.jpg",
            AreaId=96
            },
            new AreaImage
            {
                Id=228,
                Description="",
                ImageUrl="AreaImages/78.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=229,
                Description="",
                ImageUrl="AreaImages/79.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=230,
                Description="",
                ImageUrl="AreaImages/80.jpg",
                AreaId=96
            },
            // 97
            new AreaImage
            {
                Id=231,
                Description="",
                ImageUrl="AreaImages/81.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=232,
                Description="",
                ImageUrl="AreaImages/82.jpg",
            AreaId=97
            },
            new AreaImage
            {
                Id=233,
                Description="",
                ImageUrl="AreaImages/83.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=234,
                Description="",
                ImageUrl="AreaImages/84.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=235,
                Description="",
                ImageUrl="AreaImages/85.jpg",
                AreaId=97
            },
            // 98
            new AreaImage
            {
                Id=236,
                Description="",
                ImageUrl="AreaImages/86.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=237,
                Description="",
                ImageUrl="AreaImages/87.jpg",
            AreaId=98
            },
            new AreaImage
            {
                Id=238,
                Description="",
                ImageUrl="AreaImages/88.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=239,
                Description="",
                ImageUrl="AreaImages/89.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=240,
                Description="",
                ImageUrl="AreaImages/90.jpg",
                AreaId=98
            },
            // 99
            new AreaImage
            {
                Id=241,
                Description="",
                ImageUrl="AreaImages/91.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=242,
                Description="",
                ImageUrl="AreaImages/92.jpg",
            AreaId=99
            },
            new AreaImage
            {
                Id=243,
                Description="",
                ImageUrl="AreaImages/93.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=244,
                Description="",
                ImageUrl="AreaImages/94.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=245,
                Description="",
                ImageUrl="AreaImages/95.jpg",
                AreaId=99
            },
            // 100
            new AreaImage
            {
                Id=246,
                Description="",
                ImageUrl="AreaImages/96.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=247,
                Description="",
                ImageUrl="AreaImages/97.jpg",
            AreaId=100
            },
            new AreaImage
            {
                Id=248,
                Description="",
                ImageUrl="AreaImages/98.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=249,
                Description="",
                ImageUrl="AreaImages/99.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=250,
                Description="",
                ImageUrl="AreaImages/100.jpg",
                AreaId=100
            },
            // 51
            new AreaImage
            {
                Id=251,
                Description="",
                ImageUrl="AreaImages/101.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=252,
                Description="",
                ImageUrl="AreaImages/102.jpg",
            AreaId=51
            },
            new AreaImage
            {
                Id=253,
                Description="",
                ImageUrl="AreaImages/103.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=254,
                Description="",
                ImageUrl="AreaImages/104.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=255,
                Description="",
                ImageUrl="AreaImages/105.jpg",
                AreaId=51
            },
            // 52
            new AreaImage
            {
                Id=256,
                Description="",
                ImageUrl="AreaImages/106.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=257,
                Description="",
                ImageUrl="AreaImages/107.jpg",
            AreaId=52
            },
            new AreaImage
            {
                Id=258,
                Description="",
                ImageUrl="AreaImages/108.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=259,
                Description="",
                ImageUrl="AreaImages/109.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=260,
                Description="",
                ImageUrl="AreaImages/110.jpg",
                AreaId=52
            },
            // 53
            new AreaImage
            {
                Id=261,
                Description="",
                ImageUrl="AreaImages/111.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=262,
                Description="",
                ImageUrl="AreaImages/112.jpg",
            AreaId=53
            },
            new AreaImage
            {
                Id=263,
                Description="",
                ImageUrl="AreaImages/113.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=264,
                Description="",
                ImageUrl="AreaImages/114.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=265,
                Description="",
                ImageUrl="AreaImages/115.jpg",
                AreaId=53
            },
            // 54
            new AreaImage
            {
                Id=266,
                Description="",
                ImageUrl="AreaImages/116.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=267,
                Description="",
                ImageUrl="AreaImages/117.jpg",
            AreaId=54
            },
            new AreaImage
            {
                Id=268,
                Description="",
                ImageUrl="AreaImages/118.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=269,
                Description="",
                ImageUrl="AreaImages/119.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=270,
                Description="",
                ImageUrl="AreaImages/120.jpg",
                AreaId=54
            },
            // 55
            new AreaImage
            {
                Id=271,
                Description="",
                ImageUrl="AreaImages/121.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=272,
                Description="",
                ImageUrl="AreaImages/122.jpg",
            AreaId=55
            },
            new AreaImage
            {
                Id=273,
                Description="",
                ImageUrl="AreaImages/123.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=274,
                Description="",
                ImageUrl="AreaImages/124.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=275,
                Description="",
                ImageUrl="AreaImages/125.jpg",
                AreaId=55
            },
            // 56
            new AreaImage
            {
                Id=276,
                Description="",
                ImageUrl="AreaImages/126.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=277,
                Description="",
                ImageUrl="AreaImages/127.jpg",
            AreaId=56
            },
            new AreaImage
            {
                Id=278,
                Description="",
                ImageUrl="AreaImages/128.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=279,
                Description="",
                ImageUrl="AreaImages/129.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=280,
                Description="",
                ImageUrl="AreaImages/130.jpg",
                AreaId=56
            },
            // 57
            new AreaImage
            {
                Id=281,
                Description="",
                ImageUrl="AreaImages/131.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=282,
                Description="",
                ImageUrl="AreaImages/132.jpg",
            AreaId=57
            },
            new AreaImage
            {
                Id=283,
                Description="",
                ImageUrl="AreaImages/133.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=284,
                Description="",
                ImageUrl="AreaImages/134.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=285,
                Description="",
                ImageUrl="AreaImages/135.jpg",
                AreaId=57
            },
            // 58
            new AreaImage
            {
                Id=286,
                Description="",
                ImageUrl="AreaImages/136.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=287,
                Description="",
                ImageUrl="AreaImages/137.jpg",
            AreaId=58
            },
            new AreaImage
            {
                Id=288,
                Description="",
                ImageUrl="AreaImages/138.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=289,
                Description="",
                ImageUrl="AreaImages/139.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=290,
                Description="",
                ImageUrl="AreaImages/140.jpg",
                AreaId=58
            },
            // 59
            new AreaImage
            {
                Id=291,
                Description="",
                ImageUrl="AreaImages/141.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=292,
                Description="",
                ImageUrl="AreaImages/142.jpg",
            AreaId=59
            },
            new AreaImage
            {
                Id=293,
                Description="",
                ImageUrl="AreaImages/143.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=294,
                Description="",
                ImageUrl="AreaImages/144.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=295,
                Description="",
                ImageUrl="AreaImages/145.jpg",
                AreaId=59
            },
            // 60
            new AreaImage
            {
                Id=296,
                Description="",
                ImageUrl="AreaImages/146.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=297,
                Description="",
                ImageUrl="AreaImages/147.jpg",
            AreaId=60
            },
            new AreaImage
            {
                Id=298,
                Description="",
                ImageUrl="AreaImages/148.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=299,
                Description="",
                ImageUrl="AreaImages/149.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=300,
                Description="",
                ImageUrl="AreaImages/150.jpg",
                AreaId=60
            },
            // 61
            new AreaImage
            {
                Id=301,
                Description="",
                ImageUrl="AreaImages/download (1).jpeg",
                AreaId=61
            },
            new AreaImage
            {
                Id=302,
                Description="",
                ImageUrl="AreaImages/xx.download (2).jpeg",
                AreaId=61
            },
            new AreaImage
            {
                Id=303,
                Description="",
                ImageUrl="AreaImages/download (4).jpeg",
                AreaId=61
            },
            new AreaImage
            {
                Id=304,
                Description="",
                ImageUrl="AreaImages/download (5).jpeg",
                AreaId=61
            },
            new AreaImage
            {
                Id=305,
                Description="",
                ImageUrl="AreaImages/download (6).jpeg",
                AreaId=61
            },
            //62
            new AreaImage
            {
                Id=306,
                Description="",
                ImageUrl="AreaImages/download (8).jpeg",
                AreaId=62
            },
            new AreaImage
            {
                Id=307,
                Description="",
                ImageUrl="AreaImages/download (9).jpeg",
                AreaId=62
            },
            new AreaImage
            {
                Id=308,
                Description="",
                ImageUrl="AreaImages/download (10).jpeg",
                AreaId=62
            },
            new AreaImage
            {
                Id=309,
                Description="",
                ImageUrl="AreaImages/images.jpeg",
                AreaId=62
            },
            new AreaImage
            {
                Id=310,
                Description="",
                ImageUrl="AreaImages/download (11).jpeg",
                AreaId=62
            },
            //63
            new AreaImage
            {
                Id=311,
                Description="",
                ImageUrl="AreaImages/download (11).jpeg",
                AreaId=63
            },
            new AreaImage
            {
                Id=312,
                Description="",
                ImageUrl="AreaImages/download (13).jpeg",
                AreaId=63
            },
            new AreaImage
            {
                Id=313,
                Description="",
                ImageUrl="AreaImages/download (14).jpeg",
                AreaId=63
            },
            new AreaImage
            {
                Id=314,
                Description="",
                ImageUrl="AreaImages/download (15).jpeg",
                AreaId=63
            },
            new AreaImage
            {
                Id=315,
                Description="",
                ImageUrl="AreaImages/images (1).jpeg",
                AreaId=63
            },
            //64
            new AreaImage
            {
                Id=316,
                Description="",
                ImageUrl="AreaImages/images (3).jpeg",
                AreaId=64
            },
            new AreaImage
            {
                Id=317,
                Description="",
                ImageUrl="AreaImages/images (4).jpeg",
                AreaId=64
            },
            new AreaImage
            {
                Id=318,
                Description="",
                ImageUrl="AreaImages/download (16).jpeg",
                AreaId=64
            },
            new AreaImage
            {
                Id=319,
                Description="",
                ImageUrl="AreaImages/download (17).jpeg",
                AreaId=64
            },
            new AreaImage
            {
                Id=320,
                Description="",
                ImageUrl="AreaImages/images (5).jpeg",
                AreaId=64
            },
            //65
            new AreaImage
            {
                Id=321,
                Description="",
                ImageUrl="AreaImages/download (19).jpeg",
                AreaId=65
            },
            new AreaImage
            {
                Id=322,
                Description="",
                ImageUrl="AreaImages/download (20).jpeg",
                AreaId=65
            },
            new AreaImage
            {
                Id=323,
                Description="",
                ImageUrl="AreaImages/download (21).jpeg",
                AreaId=65
            },
            new AreaImage
            {
                Id=324,
                Description="",
                ImageUrl="AreaImages/download (22).jpeg",
                AreaId=65
            },
            new AreaImage
            {
                Id=325,
                Description="",
                ImageUrl="AreaImages/download (23).jpeg",
                AreaId=65
            },
            //66
            new AreaImage
            {
                Id=326,
                Description="",
                ImageUrl="AreaImages/download (25).jpeg",
                AreaId=66
            },
            new AreaImage
            {
                Id=327,
                Description="",
                ImageUrl="AreaImages/download (26).jpeg",
                AreaId=66
            },
            new AreaImage
            {
                Id=328,
                Description="",
                ImageUrl="AreaImages/download (27).jpeg",
                AreaId=66
            },
            new AreaImage
            {
                Id=329,
                Description="",
                ImageUrl="AreaImages/download (28).jpeg",
                AreaId=66
            },
            new AreaImage
            {
                Id=330,
                Description="",
                ImageUrl="AreaImages/images (6).jpeg",
                AreaId=66
            },
            //67
            new AreaImage
            {
                Id=331,
                Description="",
                ImageUrl="AreaImages/download (30).jpeg",
                AreaId=67
            },
            new AreaImage
            {
                Id=332,
                Description="",
                ImageUrl="AreaImages/download (31).jpeg",
                AreaId=67
            },
            new AreaImage
            {
                Id=333,
                Description="",
                ImageUrl="AreaImages/download (32).jpeg",
                AreaId=67
            },
            new AreaImage
            {
                Id=334,
                Description="",
                ImageUrl="AreaImages/download (33).jpeg",
                AreaId=67
            },
            new AreaImage
            {
                Id=335,
                Description="",
                ImageUrl="AreaImages/download (34).jpeg",
                AreaId=67
            },
            //68
            new AreaImage
            {
                Id=336,
                Description="",
                ImageUrl="AreaImages/images (8).jpeg",
                AreaId=68
            },
            new AreaImage
            {
                Id=337,
                Description="",
                ImageUrl="AreaImages/images (9).jpeg",
                AreaId=68
            },
            new AreaImage
            {
                Id=338,
                Description="",
                ImageUrl="AreaImages/download (35).jpeg",
                AreaId=68
            },
            new AreaImage
            {
                Id=339,
                Description="",
                ImageUrl="AreaImages/download (36).jpeg",
                AreaId=68
            },
            new AreaImage
            {
                Id=340,
                Description="",
                ImageUrl="AreaImages/download (37).jpeg",
                AreaId=68
            },
            //69
            new AreaImage
            {
                Id=341,
                Description="",
                ImageUrl="AreaImages/download (39).jpeg",
                AreaId=69
            },
            new AreaImage
            {
                Id=342,
                Description="",
                ImageUrl="AreaImages/download (40).jpeg",
                AreaId=69
            },
            new AreaImage
            {
                Id=343,
                Description="",
                ImageUrl="AreaImages/download (41).jpeg",
                AreaId=69
            },
            new AreaImage
            {
                Id=344,
                Description="",
                ImageUrl="AreaImages/download (42).jpeg",
                AreaId=69
            },
            new AreaImage
            {
                Id=345,
                Description="",
                ImageUrl="AreaImages/images (10).jpeg",
                AreaId=69
            },
            //70
            new AreaImage
            {
                Id=346,
                Description="",
                ImageUrl="AreaImages/download (43).jpeg",
                AreaId=70
            },
            new AreaImage
            {
                Id=347,
                Description="",
                ImageUrl="AreaImages/download (44).jpeg",
                AreaId=70
            },
            new AreaImage
            {
                Id=348,
                Description="",
                ImageUrl="AreaImages/download (45).jpeg",
                AreaId=70
            },
            new AreaImage
            {
                Id=349,
                Description="",
                ImageUrl="AreaImages/download (46).jpeg",
                AreaId=70
            },
            new AreaImage
            {
                Id=350,
                Description="",
                ImageUrl="AreaImages/images (11).jpeg",
            AreaId=70
            },
            //31
            new AreaImage
            {
                Id=351,
                Description="",
                ImageUrl="AreaImages/2000.jpg",
                AreaId=31
            },
            new AreaImage
            {
                Id=352,
                Description="",
                ImageUrl="AreaImages/3000.jpg",
            AreaId=31
            },
            new AreaImage
            {
                Id=353,
                Description="",
                ImageUrl="AreaImages/4000.jpg",
                AreaId=31
            },
            new AreaImage
            {
                Id=354,
                Description="",
                ImageUrl="AreaImages/5000.jpg",
            AreaId=31
            },
            new AreaImage
            {
                Id=355,
                Description="",
                ImageUrl="AreaImages/6000.jpg",
                AreaId=31
            },
            new AreaImage
            {
                Id=356,
                Description="",
                ImageUrl="AreaImages/7000.jpg",
            AreaId=31
            },
            //32
            new AreaImage
            {
                Id=357,
                Description="",
                ImageUrl="AreaImages/8000.jpg",
                AreaId=32
            },
            new AreaImage
            {
                Id=358,
                Description="",
                ImageUrl="AreaImages/9000.jpg",
            AreaId=32
            },
            new AreaImage
            {
                Id=359,
                Description="",
                ImageUrl="AreaImages/10000.jpg",
                AreaId=32
            },
            new AreaImage
            {
                Id=360,
                Description="",
                ImageUrl="AreaImages/11000.jpg",
            AreaId=32
            },
            new AreaImage
            {
                Id=361,
                Description="",
                ImageUrl="AreaImages/12000.jpg",
                AreaId=32
            },
            new AreaImage
            {
                Id=362,
                Description="",
                ImageUrl="AreaImages/13000.jpg",
            AreaId=32
            },
            //33
            new AreaImage
            {
                Id=363,
                Description="",
                ImageUrl="AreaImages/15000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=364,
                Description="",
                ImageUrl="AreaImages/16000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=365,
                Description="",
                ImageUrl="AreaImages/17000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=366,
                Description="",
                ImageUrl="AreaImages/18000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=367,
                Description="",
                ImageUrl="AreaImages/19000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=368,
                Description="",
                ImageUrl="AreaImages/20000.jpg",
            AreaId=33
            },
            new AreaImage
            {
                Id=369,
                Description="",
                ImageUrl="AreaImages/21000.jpg",
            AreaId=33
            },
             //34
            new AreaImage
            {
                Id=370,
                Description="",
                ImageUrl="AreaImages/801000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=371,
                Description="",
                ImageUrl="AreaImages/802000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=372,
                Description="",
                ImageUrl="AreaImages/803000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=373,
                Description="",
                ImageUrl="AreaImages/804000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=374,
                Description="",
                ImageUrl="AreaImages/805000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=375,
                Description="",
                ImageUrl="AreaImages/806000.jpg",
            AreaId=34
            },
            new AreaImage
            {
                Id=376,
                Description="",
                ImageUrl="AreaImages/901000.jpg",
            AreaId=52
            },
            //35
            new AreaImage
            {
                Id=377,
                Description="",
                ImageUrl="AreaImages/22000.jpg",
            AreaId=35
            },
            new AreaImage
            {
                Id=378,
                Description="",
                ImageUrl="AreaImages/23000.jpg",
            AreaId=35
            },
            new AreaImage
            {
                Id=379,
                Description="",
                ImageUrl="AreaImages/24000.jpg",
            AreaId=35
            },
            new AreaImage
            {
                Id=380,
                Description="",
                ImageUrl="AreaImages/25000.jpg",
            AreaId=35
            },
            new AreaImage
            {
                Id=381,
                Description="",
                ImageUrl="AreaImages/26000.jpg",
            AreaId=35
            },
            new AreaImage
            {
                Id=382,
                Description="",
                ImageUrl="AreaImages/27000.jpg",
            AreaId=35
            },
            //36
            new AreaImage
            {
                Id=383,
                Description="",
                ImageUrl="AreaImages/30000.jpg",
            AreaId=36
            },
            new AreaImage
            {
                Id=384,
                Description="",
                ImageUrl="AreaImages/31000.jpg",
            AreaId=36
            },
            new AreaImage
            {
                Id=385,
                Description="",
                ImageUrl="AreaImages/32000.jpg",
            AreaId=36
            },
            new AreaImage
            {
                Id=386,
                Description="",
                ImageUrl="AreaImages/33000.jpg",
            AreaId=36
            },
            new AreaImage
            {
                Id=387,
                Description="",
                ImageUrl="AreaImages/34000.jpg",
            AreaId=36
            },
            new AreaImage
            {
                Id=388,
                Description="",
                ImageUrl="AreaImages/35000.jpg",
            AreaId=36
            },
            //37
            new AreaImage
            {
                Id=389,
                Description="",
                ImageUrl="AreaImages/38000.jpg",
            AreaId=37
            },
            new AreaImage
            {
                Id=390,
                Description="",
                ImageUrl="AreaImages/39000.jpg",
            AreaId=37
            },
            new AreaImage
            {
                Id=391,
                Description="",
                ImageUrl="AreaImages/40000.jpg",
            AreaId=37
            },
            new AreaImage
            {
                Id=392,
                Description="",
                ImageUrl="AreaImages/41000.jpg",
            AreaId=37
            },
            new AreaImage
            {
                Id=393,
                Description="",
                ImageUrl="AreaImages/42000.jpg",
            AreaId=37
            },
            new AreaImage
            {
                Id=394,
                Description="",
                ImageUrl="AreaImages/43000.avif",
            AreaId=37
            },
            //38
            new AreaImage
            {
                Id=395,
                Description="",
                ImageUrl="AreaImages/51000.jpg",
            AreaId=38
            },
            new AreaImage
            {
                Id=396,
                Description="",
                ImageUrl="AreaImages/52000.jpg",
            AreaId=38
            },
            new AreaImage
            {
                Id=397,
                Description="",
                ImageUrl="AreaImages/53000.jpg",
            AreaId=38
            },
            new AreaImage
            {
                Id=398,
                Description="",
                ImageUrl="AreaImages/54000.jpg",
            AreaId=38
            },
            new AreaImage
            {
                Id=399,
                Description="",
                ImageUrl="AreaImages/55000.jpg",
            AreaId=38
            },
            new AreaImage
            {
                Id=400,
                Description="",
                ImageUrl="AreaImages/50000.jpg",
            AreaId=38
            },
            //39
            new AreaImage
            {
                Id=401,
                Description="",
                ImageUrl="AreaImages/60000.jpg",
            AreaId=39
            },
            new AreaImage
            {
                Id=402,
                Description="",
                ImageUrl="AreaImages/62000.jpg",
            AreaId=39
            },
            new AreaImage
            {
                Id=403,
                Description="",
                ImageUrl="AreaImages/63000.jpg",
            AreaId=39
            },
            new AreaImage
            {
                Id=404,
                Description="",
                ImageUrl="AreaImages/64000.jpg",
            AreaId=39
            },
            new AreaImage
            {
                Id=405,
                Description="",
                ImageUrl="AreaImages/65000.jpg",
            AreaId=39
            },
            new AreaImage
            {
                Id=406,
                Description="",
                ImageUrl="AreaImages/66000.jpg",
            AreaId=39
            },
            //40
            new AreaImage
            {
                Id=407,
                Description="",
                ImageUrl="AreaImages/71000.jpg",
            AreaId=40
            },
            new AreaImage
            {
                Id=408,
                Description="",
                ImageUrl="AreaImages/72000.jpg",
            AreaId=40
            },
            new AreaImage
            {
                Id=409,
                Description="",
                ImageUrl="AreaImages/73000.jpg",
            AreaId=40
            },
            new AreaImage
            {
                Id=410,
                Description="",
                ImageUrl="AreaImages/74000.jpg",
            AreaId=40
            },
            new AreaImage
            {
                Id=411,
                Description="",
                ImageUrl="AreaImages/75000.jpg",
            AreaId=40
            },
            new AreaImage
            {
                Id=412,
                Description="",
                ImageUrl="AreaImages/76000.jpg",
            AreaId=40
            },
            //41
            new AreaImage
            {
                Id=413,
                Description="",
                ImageUrl="AreaImages/81000.jpg",
            AreaId=41
            },
            new AreaImage
            {
                Id=414,
                Description="",
                ImageUrl="AreaImages/82000.jpg",
            AreaId=41
            },
            new AreaImage
            {
                Id=415,
                Description="",
                ImageUrl="AreaImages/83000.jpg",
            AreaId=41
            },
            new AreaImage
            {
                Id=416,
                Description="",
                ImageUrl="AreaImages/84000.jpeg",
            AreaId=41
            },
            new AreaImage
            {
                Id=417,
                Description="",
                ImageUrl="AreaImages/85000.jpeg",
            AreaId=41
            },
            new AreaImage
            {
                Id=418,
                Description="",
                ImageUrl="AreaImages/86000.jpeg",
            AreaId=41
            },
            //42
            new AreaImage
            {
                Id=419,
                Description="",
                ImageUrl="AreaImages/91000.jpg",
            AreaId=42
            },
            new AreaImage
            {
                Id=420,
                Description="",
                ImageUrl="AreaImages/92000.jpg",
            AreaId=42
            },
            new AreaImage
            {
                Id=421,
                Description="",
                ImageUrl="AreaImages/93000.jpg",
            AreaId=42
            },
            new AreaImage
            {
                Id=422,
                Description="",
                ImageUrl="AreaImages/94000.jpg",
            AreaId=42
            },
            new AreaImage
            {
                Id=423,
                Description="",
                ImageUrl="AreaImages/95000.jpg",
            AreaId=42
            },
            new AreaImage
            {
                Id=424,
                Description="",
                ImageUrl="AreaImages/96000.jpg",
            AreaId=42
            },
            //43
            new AreaImage
            {
                Id=425,
                Description="",
                ImageUrl="AreaImages/902000.jpg",
            AreaId=43
            },
            new AreaImage
            {
                Id=426,
                Description="",
                ImageUrl="AreaImages/903000.jpg",
            AreaId=43
            },
            new AreaImage
            {
                Id=427,
                Description="",
                ImageUrl="AreaImages/904000.jpg",
            AreaId=43
            },
            new AreaImage
            {
                Id=428,
                Description="",
                ImageUrl="AreaImages/905000.jpg",
            AreaId=43
            },
            new AreaImage
            {
                Id=429,
                Description="",
                ImageUrl="AreaImages/906000.jpg",
            AreaId=43
            }, 
            //44
            new AreaImage
            {
                Id=430,
                Description="",
                ImageUrl="AreaImages/100000.jpg",
            AreaId=44
            },
            new AreaImage
            {
                Id=431,
                Description="",
                ImageUrl="AreaImages/101000.jpg",
            AreaId=44
            },
            new AreaImage
            {
                Id=432,
                Description="",
                ImageUrl="AreaImages/102000.jpg",
            AreaId=44
            },
            new AreaImage
            {
                Id=433,
                Description="",
                ImageUrl="AreaImages/103000.jpg",
            AreaId=44
            },
            new AreaImage
            {
                Id=434,
                Description="",
                ImageUrl="AreaImages/104000.jpg",
            AreaId=44
            },
            new AreaImage
            {
                Id=435,
                Description="",
                ImageUrl="AreaImages/105000.jpg",
            AreaId=44
            },
            //45
            new AreaImage
            {
                Id=436,
                Description="",
                ImageUrl="AreaImages/201000.jpg",
            AreaId=45
            },
            new AreaImage
            {
                Id=437,
                Description="",
                ImageUrl="AreaImages/202000.jpg",
            AreaId=45
            },
            new AreaImage
            {
                Id=438,
                Description="",
                ImageUrl="AreaImages/203000.jpg",
            AreaId=45
            },
            new AreaImage
            {
                Id=439,
                Description="",
                ImageUrl="AreaImages/204000.jpg",
            AreaId=45
            },
            new AreaImage
            {
                Id=440,
                Description="",
                ImageUrl="AreaImages/205000.jpg",
            AreaId=45
            },
            new AreaImage
            {
                Id=441,
                Description="",
                ImageUrl="AreaImages/206000.jpg",
            AreaId=45
            },
            //46
            new AreaImage
            {
                Id=442,
                Description="",
                ImageUrl="AreaImages/301000.jpg",
            AreaId=46
            },
            new AreaImage
            {
                Id=443,
                Description="",
                ImageUrl="AreaImages/302000.jpg",
            AreaId=46
            },
            new AreaImage
            {
                Id=444,
                Description="",
                ImageUrl="AreaImages/303000.jpg",
            AreaId=46
            },
            new AreaImage
            {
                Id=445,
                Description="",
                ImageUrl="AreaImages/304000.jpg",
            AreaId=46
            },
            new AreaImage
            {
                Id=446,
                Description="",
                ImageUrl="AreaImages/305000.jpg",
            AreaId=46
            },
            new AreaImage
            {
                Id=447,
                Description="",
                ImageUrl="AreaImages/306000.jpg",
            AreaId=46
            },
            //47
            new AreaImage
            {
                Id=448,
                Description="",
                ImageUrl="AreaImages/400000.jpg",
            AreaId=47
            },
            new AreaImage
            {
                Id=449,
                Description="",
                ImageUrl="AreaImages/401000.jpg",
            AreaId=47
            },
            new AreaImage
            {
                Id=450,
                Description="",
                ImageUrl="AreaImages/402000.jpg",
            AreaId=47
            },
            //48
            new AreaImage
            {
                Id=451,
                Description="",
                ImageUrl="AreaImages/501000.jpg",
            AreaId=48
            },
            new AreaImage
            {
                Id=452,
                Description="",
                ImageUrl="AreaImages/502000.jpg",
            AreaId=48
            },
            new AreaImage
            {
                Id=453,
                Description="",
                ImageUrl="AreaImages/503000.jpg",
            AreaId=48
            },
            new AreaImage
            {
                Id=454,
                Description="",
                ImageUrl="AreaImages/504000.jpg",
            AreaId=48
            },
            new AreaImage
            {
                Id=455,
                Description="",
                ImageUrl="AreaImages/505000.jpg",
            AreaId=48
            },
            new AreaImage
            {
                Id=456,
                Description="",
                ImageUrl="AreaImages/506000.jpg",
            AreaId=48
            },
            //49
            new AreaImage
            {
                Id=457,
                Description="",
                ImageUrl="AreaImages/601000.jpg",
            AreaId=49
            },
            new AreaImage
            {
                Id=458,
                Description="",
                ImageUrl="AreaImages/602000.jpg",
            AreaId=49
            },
            new AreaImage
            {
                Id=459,
                Description="",
                ImageUrl="AreaImages/603000.jpg",
            AreaId=49
            },
            new AreaImage
            {
                Id=460,
                Description="",
                ImageUrl="AreaImages/604000.jpg",
            AreaId=49
            },
            new AreaImage
            {
                Id=461,
                Description="",
                ImageUrl="AreaImages/605000.jpg",
            AreaId=49
            },
            new AreaImage
            {
                Id=462,
                Description="",
                ImageUrl="AreaImages/606000.jpg",
            AreaId=49
            },
            //50
            new AreaImage
            {
                Id=463,
                Description="",
                ImageUrl="AreaImages/701000.jpg",
            AreaId=50
            },
            new AreaImage
            {
                Id=464,
                Description="",
                ImageUrl="AreaImages/702000.jpg",
            AreaId=50
            },
            new AreaImage
            {
                Id=465,
                Description="",
                ImageUrl="AreaImages/703000.jpg",
            AreaId=50
            },
            new AreaImage
            {
                Id=466,
                Description="",
                ImageUrl="AreaImages/704000.jpg",
            AreaId=50
            },
            new AreaImage
            {
                Id=467,
                Description="",
                ImageUrl="AreaImages/705000.jpg",
                AreaId=50
            },
            new AreaImage
            {
                Id=468,
                Description="",
                ImageUrl="AreaImages/706000.jpg",
            AreaId=50
            },
            //71
            new AreaImage
            {
                Id=469,
                Description="",
                ImageUrl="AreaImages/wadialjarf-02f7c.jpg",
                AreaId=71
            },
            new AreaImage
            {
                Id=470,
                Description="",
                ImageUrl="AreaImages/AAimages (3).jpg",
                AreaId=71
            },
            new AreaImage
            {
                Id=471,
                Description="",
                ImageUrl="AreaImages/AAimages (2).jpg",
                AreaId=71
            },
            new AreaImage
            {
                Id=472,
                Description="",
                ImageUrl="AreaImages/Screenshot-2020-03-12-at-14.04.55-254x300.png",
                AreaId=71
            },
            //72
            new AreaImage
            {
                Id=473,
                Description="",
                ImageUrl="AreaImages/AAA480.jpg",
                AreaId=72
            },
            new AreaImage
            {
                Id=474,
                Description="",
                ImageUrl="AreaImages/Qaitbay-Citadel-Egypt-Tours-Portal.jpg",
                AreaId=72
            },
            new AreaImage
            {
                Id=475,
                Description="",
                ImageUrl="AreaImages/260px-CW_QaitbayCitadel_Front.jpg",
                AreaId=72
            },
            new AreaImage
            {
                Id=476,
                Description="",
                ImageUrl="AreaImages/free-photo-of-people-near-citadel-of-qaitbay.jpeg",
                AreaId=72
            },
            //73
            new AreaImage
            {
                Id=477,
                Description="",
                ImageUrl="AreaImages/202208181111301130.jpg",
                AreaId=73
            },
            new AreaImage
            {
                Id=478,
                Description="",
                ImageUrl="AreaImages/WhatsApp Image 2025-03-29 at 04.12.45_d6d103b7.jpg",
                AreaId=73
            },
            new AreaImage
            {
                Id=479,
                Description="",
                ImageUrl="AreaImages/1 AAAA(1).jpg",
                AreaId=73
            },
            new AreaImage
            {
                Id=480,
                Description="",
                ImageUrl="AreaImages/320654-320654.jpeg",
                AreaId=73
            },
            //74
            new AreaImage
            {
                Id=481,
                Description="",
                ImageUrl="AreaImages/6SDF8.jpg",
                AreaId=74
            },
            new AreaImage
            {
                Id=482,
                Description="",
                ImageUrl="AreaImages/6-cSSopy.jpg",
                AreaId=74
            },
            new AreaImage
            {
                Id=483,
                Description="",
                ImageUrl="AreaImages/46439485329.jpg",
                AreaId=74
            },
            new AreaImage
            {
                Id=484,
                Description="",
                ImageUrl="AreaImages/lovely-beaSch.jpg",
                AreaId=74
            },
            //75
            new AreaImage
            {
                Id=485,
                Description="",
                ImageUrl="AreaImages/00000319.jpg",
                AreaId=75
            },
            new AreaImage
            {
                Id=486,
                Description="",
                ImageUrl="AreaImages/AAAS12.jpg",
                AreaId=75
            },
            new AreaImage
            {
                Id=487,
                Description="",
                ImageUrl="AreaImages/gopr6937.jpg",
                AreaId=75
            },
            new AreaImage
            {
                Id=488,
                Description="",
                ImageUrl="AreaImages/15SDF.jpg",
                AreaId=75
            },
            new AreaImage
            {
                Id=489,
                Description="",
                ImageUrl="AreaImages/4-scaled.jpeg",
                AreaId=75
            },
            //76
            new AreaImage
            {
                Id=490,
                Description="",
                ImageUrl="AreaImages/images SSS(5).jpg",
                AreaId=76
            },
            new AreaImage
            {
                Id=491,
                Description="",
                ImageUrl="AreaImages/AA5.jpg",
                AreaId=76
            },
            new AreaImage
            {
                Id=492,
                Description="",
                ImageUrl="AreaImages/4744050e66e35b461ea7f22fb91da922.webp",
                AreaId=76
            },
            new AreaImage
            {
                Id=493,
                Description="",
                ImageUrl="AreaImages/port-of-alexandria-egypt-free-photo.jpg",
                AreaId=76
            },
            //77
            new AreaImage
            {
                Id=494,
                Description="",
                ImageUrl="AreaImages/unnamSSed.jpg",
                AreaId=77
            },
            new AreaImage
            {
                Id=495,
                Description="",
                ImageUrl="AreaImages/osirisima09.jpg",
                AreaId=77
            },
            new AreaImage
            {
                Id=496,
                Description="",
                ImageUrl="AreaImages/imagesAAA (6).jpg",
                AreaId=77
            },
            new AreaImage
            {
                Id=497,
                Description="",
                ImageUrl="AreaImages/abu-qir-sunken-cities-5-1.jpg",
                AreaId=77
            },
            //78
            new AreaImage
            {
                Id=498,
                Description="",
                ImageUrl="AreaImages/gebelSS.jpg",
                AreaId=78
            },
            new AreaImage
            {
                Id=499,
                Description="",
                ImageUrl="AreaImages/IMG_81SS65.jpg",
                AreaId=78
            },
            new AreaImage
            {
                Id=500,
                Description="",
                ImageUrl="AreaImages/50609072343_5ffe83s107d_b.jpg",
                AreaId=78
            },
            new AreaImage
            {
                Id=501,
                Description="",
                ImageUrl="AreaImages/dsc_WW5908.png",
                AreaId=78
            },
        };
        builder.HasData(areaImages);
    }
}