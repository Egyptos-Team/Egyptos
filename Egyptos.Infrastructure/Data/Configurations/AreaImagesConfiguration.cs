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
            // 81
            new AreaImage
            {
                Id=1,
                Description="",
                ImageUrl="AreaImages/1.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=2,
                Description="",
                ImageUrl="AreaImages/2.jpg",
            AreaId=81
            },
            new AreaImage
            {
                Id=3,
                Description="",
                ImageUrl="AreaImages/3.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=4,
                Description="",
                ImageUrl="AreaImages/4.jpg",
                AreaId=81
            },
            new AreaImage
            {
                Id=5,
                Description="",
                ImageUrl="AreaImages/5.jpg",
                AreaId=81
            },
            // 82
            new AreaImage
            {
                Id=6,
                Description="",
                ImageUrl="AreaImages/6.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=7,
                Description="",
                ImageUrl="AreaImages/7.jpg",
            AreaId=82
            },
            new AreaImage
            {
                Id=8,
                Description="",
                ImageUrl="AreaImages/8.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=9,
                Description="",
                ImageUrl="AreaImages/9.jpg",
                AreaId=82
            },
            new AreaImage
            {
                Id=10,
                Description="",
                ImageUrl="AreaImages/10.jpg",
                AreaId=82
            },
            // 83
            new AreaImage
            {
                Id=11,
                Description="",
                ImageUrl="AreaImages/11.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=12,
                Description="",
                ImageUrl="AreaImages/12.jpg",
            AreaId=83
            },
            new AreaImage
            {
                Id=13,
                Description="",
                ImageUrl="AreaImages/13.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=14,
                Description="",
                ImageUrl="AreaImages/14.jpg",
                AreaId=83
            },
            new AreaImage
            {
                Id=15,
                Description="",
                ImageUrl="AreaImages/15.jpg",
                AreaId=83
            },
            // 84
            new AreaImage
            {
                Id=16,
                Description="",
                ImageUrl="AreaImages/16.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=17,
                Description="",
                ImageUrl="AreaImages/17.jpg",
            AreaId=84
            },
            new AreaImage
            {
                Id=18,
                Description="",
                ImageUrl="AreaImages/18.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=19,
                Description="",
                ImageUrl="AreaImages/19.jpg",
                AreaId=84
            },
            new AreaImage
            {
                Id=20,
                Description="",
                ImageUrl="AreaImages/20.jpg",
                AreaId=84
            },
            // 85
            new AreaImage
            {
                Id=21,
                Description="",
                ImageUrl="AreaImages/21.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=22,
                Description="",
                ImageUrl="AreaImages/22.jpg",
            AreaId=85
            },
            new AreaImage
            {
                Id=23,
                Description="",
                ImageUrl="AreaImages/23.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=24,
                Description="",
                ImageUrl="AreaImages/24.jpg",
                AreaId=85
            },
            new AreaImage
            {
                Id=25,
                Description="",
                ImageUrl="AreaImages/25.jpg",
                AreaId=85
            },
            // 86
            new AreaImage
            {
                Id=26,
                Description="",
                ImageUrl="AreaImages/26.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=27,
                Description="",
                ImageUrl="AreaImages/27.jpg",
            AreaId=86
            },
            new AreaImage
            {
                Id=28,
                Description="",
                ImageUrl="AreaImages/28.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=29,
                Description="",
                ImageUrl="AreaImages/29.jpg",
                AreaId=86
            },
            new AreaImage
            {
                Id=30,
                Description="",
                ImageUrl="AreaImages/30.jpg",
                AreaId=86
            },
            // 87
            new AreaImage
            {
                Id=31,
                Description="",
                ImageUrl="AreaImages/31.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=32,
                Description="",
                ImageUrl="AreaImages/32.jpg",
            AreaId=87
            },
            new AreaImage
            {
                Id=33,
                Description="",
                ImageUrl="AreaImages/33.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=34,
                Description="",
                ImageUrl="AreaImages/34.jpg",
                AreaId=87
            },
            new AreaImage
            {
                Id=35,
                Description="",
                ImageUrl="AreaImages/35.jpg",
                AreaId=87
            },
            // 88
            new AreaImage
            {
                Id=36,
                Description="",
                ImageUrl="AreaImages/36.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=37,
                Description="",
                ImageUrl="AreaImages/37.jpg",
            AreaId=88
            },
            new AreaImage
            {
                Id=38,
                Description="",
                ImageUrl="AreaImages/38.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=39,
                Description="",
                ImageUrl="AreaImages/39.jpg",
                AreaId=88
            },
            new AreaImage
            {
                Id=40,
                Description="",
                ImageUrl="AreaImages/40.jpg",
                AreaId=88
            },
            // 89
            new AreaImage
            {
                Id=41,
                Description="",
                ImageUrl="AreaImages/41.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=42,
                Description="",
                ImageUrl="AreaImages/42.jpg",
            AreaId=89
            },
            new AreaImage
            {
                Id=43,
                Description="",
                ImageUrl="AreaImages/43.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=44,
                Description="",
                ImageUrl="AreaImages/44.jpg",
                AreaId=89
            },
            new AreaImage
            {
                Id=45,
                Description="",
                ImageUrl="AreaImages/45.jpg",
                AreaId=89
            },
            // 90
            new AreaImage
            {
                Id=46,
                Description="",
                ImageUrl="AreaImages/46.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=47,
                Description="",
                ImageUrl="AreaImages/47.jpg",
            AreaId=90
            },
            new AreaImage
            {
                Id=48,
                Description="",
                ImageUrl="AreaImages/48.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=49,
                Description="",
                ImageUrl="AreaImages/49.jpg",
                AreaId=90
            },
            new AreaImage
            {
                Id=50,
                Description="",
                ImageUrl="AreaImages/50.jpg",
                AreaId=90
            },
            // 91
            new AreaImage
            {
                Id=51,
                Description="",
                ImageUrl="AreaImages/51.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=52,
                Description="",
                ImageUrl="AreaImages/52.jpg",
            AreaId=91
            },
            new AreaImage
            {
                Id=53,
                Description="",
                ImageUrl="AreaImages/53.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=54,
                Description="",
                ImageUrl="AreaImages/54.jpg",
                AreaId=91
            },
            new AreaImage
            {
                Id=55,
                Description="",
                ImageUrl="AreaImages/55.jpg",
                AreaId=91
            },
            // 92
            new AreaImage
            {
                Id=56,
                Description="",
                ImageUrl="AreaImages/56.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=57,
                Description="",
                ImageUrl="AreaImages/57.jpg",
            AreaId=92
            },
            new AreaImage
            {
                Id=58,
                Description="",
                ImageUrl="AreaImages/58.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=59,
                Description="",
                ImageUrl="AreaImages/59.jpg",
                AreaId=92
            },
            new AreaImage
            {
                Id=60,
                Description="",
                ImageUrl="AreaImages/60.jpg",
                AreaId=92
            },
            // 93
            new AreaImage
            {
                Id=61,
                Description="",
                ImageUrl="AreaImages/61.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=62,
                Description="",
                ImageUrl="AreaImages/62.jpg",
            AreaId=93
            },
            new AreaImage
            {
                Id=63,
                Description="",
                ImageUrl="AreaImages/63.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=64,
                Description="",
                ImageUrl="AreaImages/64.jpg",
                AreaId=93
            },
            new AreaImage
            {
                Id=65,
                Description="",
                ImageUrl="AreaImages/65.jpg",
                AreaId=93
            },
            // 94
            new AreaImage
            {
                Id=66,
                Description="",
                ImageUrl="AreaImages/66.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=67,
                Description="",
                ImageUrl="AreaImages/67.jpg",
            AreaId=94
            },
            new AreaImage
            {
                Id=68,
                Description="",
                ImageUrl="AreaImages/68.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=69,
                Description="",
                ImageUrl="AreaImages/69.jpg",
                AreaId=94
            },
            new AreaImage
            {
                Id=70,
                Description="",
                ImageUrl="AreaImages/70.jpg",
                AreaId=94
            },
            // 95
            new AreaImage
            {
                Id=71,
                Description="",
                ImageUrl="AreaImages/71.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=72,
                Description="",
                ImageUrl="AreaImages/72.jpg",
            AreaId=95
            },
            new AreaImage
            {
                Id=73,
                Description="",
                ImageUrl="AreaImages/73.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=74,
                Description="",
                ImageUrl="AreaImages/74.jpg",
                AreaId=95
            },
            new AreaImage
            {
                Id=75,
                Description="",
                ImageUrl="AreaImages/75.jpg",
                AreaId=95
            },
            // 96
            new AreaImage
            {
                Id=76,
                Description="",
                ImageUrl="AreaImages/76.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=77,
                Description="",
                ImageUrl="AreaImages/77.jpg",
            AreaId=96
            },
            new AreaImage
            {
                Id=78,
                Description="",
                ImageUrl="AreaImages/78.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=79,
                Description="",
                ImageUrl="AreaImages/79.jpg",
                AreaId=96
            },
            new AreaImage
            {
                Id=80,
                Description="",
                ImageUrl="AreaImages/80.jpg",
                AreaId=96
            },
            // 97
            new AreaImage
            {
                Id=81,
                Description="",
                ImageUrl="AreaImages/81.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=82,
                Description="",
                ImageUrl="AreaImages/82.jpg",
            AreaId=97
            },
            new AreaImage
            {
                Id=83,
                Description="",
                ImageUrl="AreaImages/83.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=84,
                Description="",
                ImageUrl="AreaImages/84.jpg",
                AreaId=97
            },
            new AreaImage
            {
                Id=85,
                Description="",
                ImageUrl="AreaImages/85.jpg",
                AreaId=97
            },
            // 98
            new AreaImage
            {
                Id=86,
                Description="",
                ImageUrl="AreaImages/86.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=87,
                Description="",
                ImageUrl="AreaImages/87.jpg",
            AreaId=98
            },
            new AreaImage
            {
                Id=88,
                Description="",
                ImageUrl="AreaImages/88.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=89,
                Description="",
                ImageUrl="AreaImages/89.jpg",
                AreaId=98
            },
            new AreaImage
            {
                Id=90,
                Description="",
                ImageUrl="AreaImages/90.jpg",
                AreaId=98
            },
            // 99
            new AreaImage
            {
                Id=91,
                Description="",
                ImageUrl="AreaImages/91.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=92,
                Description="",
                ImageUrl="AreaImages/92.jpg",
            AreaId=99
            },
            new AreaImage
            {
                Id=93,
                Description="",
                ImageUrl="AreaImages/93.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=94,
                Description="",
                ImageUrl="AreaImages/94.jpg",
                AreaId=99
            },
            new AreaImage
            {
                Id=95,
                Description="",
                ImageUrl="AreaImages/95.jpg",
                AreaId=99
            },
            // 100
            new AreaImage
            {
                Id=96,
                Description="",
                ImageUrl="AreaImages/96.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=97,
                Description="",
                ImageUrl="AreaImages/97.jpg",
            AreaId=100
            },
            new AreaImage
            {
                Id=98,
                Description="",
                ImageUrl="AreaImages/98.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=99,
                Description="",
                ImageUrl="AreaImages/99.jpg",
                AreaId=100
            },
            new AreaImage
            {
                Id=100,
                Description="",
                ImageUrl="AreaImages/100.jpg",
                AreaId=100
            },
            // 51
            new AreaImage
            {
                Id=101,
                Description="",
                ImageUrl="AreaImages/101.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=102,
                Description="",
                ImageUrl="AreaImages/102.jpg",
            AreaId=51
            },
            new AreaImage
            {
                Id=103,
                Description="",
                ImageUrl="AreaImages/103.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=104,
                Description="",
                ImageUrl="AreaImages/104.jpg",
                AreaId=51
            },
            new AreaImage
            {
                Id=105,
                Description="",
                ImageUrl="AreaImages/105.jpg",
                AreaId=51
            },
            // 52
            new AreaImage
            {
                Id=106,
                Description="",
                ImageUrl="AreaImages/106.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=107,
                Description="",
                ImageUrl="AreaImages/107.jpg",
            AreaId=52
            },
            new AreaImage
            {
                Id=108,
                Description="",
                ImageUrl="AreaImages/108.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=109,
                Description="",
                ImageUrl="AreaImages/109.jpg",
                AreaId=52
            },
            new AreaImage
            {
                Id=110,
                Description="",
                ImageUrl="AreaImages/110.jpg",
                AreaId=52
            },
            // 53
            new AreaImage
            {
                Id=111,
                Description="",
                ImageUrl="AreaImages/111.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=112,
                Description="",
                ImageUrl="AreaImages/112.jpg",
            AreaId=53
            },
            new AreaImage
            {
                Id=113,
                Description="",
                ImageUrl="AreaImages/113.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=114,
                Description="",
                ImageUrl="AreaImages/114.jpg",
                AreaId=53
            },
            new AreaImage
            {
                Id=115,
                Description="",
                ImageUrl="AreaImages/115.jpg",
                AreaId=53
            },
            // 54
            new AreaImage
            {
                Id=116,
                Description="",
                ImageUrl="AreaImages/116.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=117,
                Description="",
                ImageUrl="AreaImages/117.jpg",
            AreaId=54
            },
            new AreaImage
            {
                Id=118,
                Description="",
                ImageUrl="AreaImages/118.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=119,
                Description="",
                ImageUrl="AreaImages/119.jpg",
                AreaId=54
            },
            new AreaImage
            {
                Id=120,
                Description="",
                ImageUrl="AreaImages/120.jpg",
                AreaId=54
            },
            // 55
            new AreaImage
            {
                Id=121,
                Description="",
                ImageUrl="AreaImages/121.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=122,
                Description="",
                ImageUrl="AreaImages/122.jpg",
            AreaId=55
            },
            new AreaImage
            {
                Id=123,
                Description="",
                ImageUrl="AreaImages/123.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=124,
                Description="",
                ImageUrl="AreaImages/124.jpg",
                AreaId=55
            },
            new AreaImage
            {
                Id=125,
                Description="",
                ImageUrl="AreaImages/125.jpg",
                AreaId=55
            },
            // 56
            new AreaImage
            {
                Id=126,
                Description="",
                ImageUrl="AreaImages/126.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=127,
                Description="",
                ImageUrl="AreaImages/127.jpg",
            AreaId=56
            },
            new AreaImage
            {
                Id=128,
                Description="",
                ImageUrl="AreaImages/128.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=129,
                Description="",
                ImageUrl="AreaImages/129.jpg",
                AreaId=56
            },
            new AreaImage
            {
                Id=130,
                Description="",
                ImageUrl="AreaImages/130.jpg",
                AreaId=56
            },
            // 57
            new AreaImage
            {
                Id=131,
                Description="",
                ImageUrl="AreaImages/131.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=132,
                Description="",
                ImageUrl="AreaImages/132.jpg",
            AreaId=57
            },
            new AreaImage
            {
                Id=133,
                Description="",
                ImageUrl="AreaImages/133.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=134,
                Description="",
                ImageUrl="AreaImages/134.jpg",
                AreaId=57
            },
            new AreaImage
            {
                Id=135,
                Description="",
                ImageUrl="AreaImages/135.jpg",
                AreaId=57
            },
            // 58
            new AreaImage
            {
                Id=136,
                Description="",
                ImageUrl="AreaImages/136.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=137,
                Description="",
                ImageUrl="AreaImages/137.jpg",
            AreaId=58
            },
            new AreaImage
            {
                Id=138,
                Description="",
                ImageUrl="AreaImages/138.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=139,
                Description="",
                ImageUrl="AreaImages/139.jpg",
                AreaId=58
            },
            new AreaImage
            {
                Id=140,
                Description="",
                ImageUrl="AreaImages/140.jpg",
                AreaId=58
            },
            // 59
            new AreaImage
            {
                Id=141,
                Description="",
                ImageUrl="AreaImages/141.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=142,
                Description="",
                ImageUrl="AreaImages/142.jpg",
            AreaId=59
            },
            new AreaImage
            {
                Id=143,
                Description="",
                ImageUrl="AreaImages/143.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=144,
                Description="",
                ImageUrl="AreaImages/144.jpg",
                AreaId=59
            },
            new AreaImage
            {
                Id=145,
                Description="",
                ImageUrl="AreaImages/145.jpg",
                AreaId=59
            },
            // 60
            new AreaImage
            {
                Id=146,
                Description="",
                ImageUrl="AreaImages/146.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=147,
                Description="",
                ImageUrl="AreaImages/147.jpg",
            AreaId=60
            },
            new AreaImage
            {
                Id=148,
                Description="",
                ImageUrl="AreaImages/148.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=149,
                Description="",
                ImageUrl="AreaImages/149.jpg",
                AreaId=60
            },
            new AreaImage
            {
                Id=150,
                Description="",
                ImageUrl="AreaImages/150.jpg",
                AreaId=60
            },
        };
        builder.HasData();
    }
}
