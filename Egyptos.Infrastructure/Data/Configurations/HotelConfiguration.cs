using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Egyptos.Api.Controllers;
class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        var hotels = new List<Hotel>
        {
           // Cairo
            new Hotel
            {
                    Id = 1,
                    Name = "Le Meridien Cairo Airport",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3451.3169529673273!2d31.395847200000006!3d30.1137427!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14581655c2fefa93%3A0x855d24c50d9a251!2z2YTZiCDZhdmK2LHZitiv2YrYp9mGINmF2LfYp9ixINin2YTZgtin2YfYsdip!5e0!3m2!1sar!2seg!4v1742149560840!5m2!1sar!2seg" ,
                    Address = "Cairo international Airport  terminal 3, Heliopolis, 11341 Cairo, Egypt",
                    ImageUrl = "Hotels/Cairo/1.jpg",
                    WebSite = "https://www.marriott.com/en-us/hotels/caiam-le-meridien-cairo-airport/overview/",
                    Facebook = "https://www.facebook.com/share/19xBNPS8M2/",
                    PhoneNumber = "+202-22659600",
                    PricePerHour = 5812,
            },
            new Hotel
            {
                    Id = 2,
                    Name = "Hilton Cairo Grand Nile",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3454.076091286725!2d31.2294302!3d30.0346748!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145847eb19741479%3A0x6f4f4b9d21f639e1!2z2YfZitmE2KrZiNmGINin2YTZgtin2YfYsdipINis2LHYp9mG2K8g2YbYp9mK2YQ!5e0!3m2!1sar!2seg!4v1742149673321!5m2!1sar!2seg",
                    Address = "Corniche El Nile, Garden City,Cairo",
                    ImageUrl = "Hotels/Cairo/2.jpg",
                    WebSite = "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwj6lfPF_4uMAxXsa0ECHbnaFVMYABAEGgJ3cw&co=1&ase=2&gclid=EAIaIQobChMI-pXzxf-LjAMV7GtBAh252hVTEAAYASAAEgK3afD_BwE&ohost=www.google.com&cid=CAASJeRoTO3di9EUVIgV7C3WwqJMXHsOhdz4AF8DeGrvCpcDDz6EZx0&sig=AOD64_0sDqYVCCLNjHXPtzKU7Z81PrausA&q&nis=4&adurl&ved=2ahUKEwi2ie3F_4uMAxU9aqQEHbD2MR4Q0Qx6BAgmEAE",
                    Facebook = "https://www.facebook.com/share/1EjVfEV71A/",
                    PhoneNumber = "0-223651234",
                    PricePerHour = 6400,
            },
            new Hotel
            {
                    Id = 3,
                    Name = "Four Seasons Hotel Cairo at Nile Plaza",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3454.0216686198137!2d31.2320317!3d30.0362362!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840cd3ef57809%3A0xd7f50b4221f71eb0!2z2YHZhtiv2YIg2YHZiNixINiz2YrYstmI2YYg2YbYp9mK2YQg2KjZhNin2LLYpyDYp9mE2YLYp9mH2LHZhw!5e0!3m2!1sar!2seg!4v1742149822971!5m2!1sar!2seg",
                    Address = "1089 Corniche El Nil - Garden City, Garden City, 11519 Cairo, Egypt",
                    ImageUrl = "Hotels/Cairo/3.jpg",
                    WebSite = "https://www.fourseasons.com/caironp/",
                    Facebook = "https://www.facebook.com/share/1D9key9seU/",
                    PhoneNumber = "20227917000",
                    PricePerHour = 14500,
            },
            new Hotel
            {
                    Id = 4,
                    Name = "Ramses Hilton Hotel & Casino",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3453.5290920453067!2d31.234616!3d30.050365!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840c381a29537%3A0xf1d5b3a64a0e4de1!2z2YfZitmE2KrZiNmGINix2YXYs9mK2LM!5e0!3m2!1sar!2seg!4v1742149918000!5m2!1sar!2seg",
                    Address = "1115 Corniche El Nile, Cairo, Egypt",
                    ImageUrl = "Hotels/Cairo/4.jpg",
                    WebSite = "https://www.hilton.com/en/hotels/cairhtw-ramses-hilton/",
                    Facebook = "https://www.facebook.com/share/1BiBZudYV5/",
                    PhoneNumber = "+20225777444",
                    PricePerHour = 6500,
            },
            new Hotel
            {
                    Id = 5,
                    Name = "Steigenberger Hotel El Tahrir Cairo",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3453.655892501945!2d31.2378339!3d30.0467285!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840c6e7b40217%3A0xa56e70b7cb4fa53d!2z2LTYqtmK2KzZhtio2LHYrNix!5e0!3m2!1sar!2seg!4v1742149990173!5m2!1sar!2seg",
                    Address = "Kasr El Nile, Cairo, Egypt",
                    ImageUrl = "Hotels/Cairo/5.jpg",
                    WebSite = "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjSl4S_iIyMAxUrCqIDHUHaF3AYABAEGgJsZQ&co=1&gclid=EAIaIQobChMI0peEv4iMjAMVKwqiAx1B2hdwEAAYAiAAEgLKRvD_BwE&ohost=www.google.com&cid=CAASJeRoqb3A8_W_cCI2Psh5SfgGlWkPy5sBG63KSSJLTrvfQUMPBi4&sig=AOD64_1-nv5EhB35HIIna2-AlbmHpbeh7A&q&adurl&ved=2ahUKEwjpk_2-iIyMAxWhR_EDHZMFLEUQ0Qx6BAgUEAQ",
                    Facebook = "https://www.facebook.com/share/1ZTLj6XCvb/",
                    PhoneNumber = "0-225750777" ,
                    PricePerHour = 5500,
            },
            // Luxor
            new Hotel
            {
                    Id = 6,
                    Name = "Nefertiti Hotel Luxor",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.0867571344843!2d32.644454!3d25.7015514!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144915793ddb0125%3A0xe6577d403df25035!2sNefertiti%20Hotel%20Luxor!5e0!3m2!1sar!2seg!4v1742150165519!5m2!1sar!2seg",
                    Address = "Al-Sahaby Lan,In Front Of Luxor Temple, East Bank, 99999 Luxor, Egypt",
                    ImageUrl = "Hotels/Luxor/6.jpg",
                    WebSite = "https://www.nefertitihotel.com/",
                    Facebook = "https://www.facebook.com/share/1ADhARSWdh/",
                    PhoneNumber = "010 00329991",
                    PricePerHour = 2200,
            },
            new Hotel
            {
                    Id = 7,
                    Name = "Sonesta St. George Hotel - Convention Center",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.479246270187!2d32.6339694!3d25.6885519!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144914291e2ae293%3A0xa1bb33e69e24c44f!2z2YHZhtiv2YIg2LPZiNmG2LPYqtinINiz2KfZhiDYrNmI2LHYrCDYp9mE2KfZgti12LE!5e0!3m2!1sar!2seg!4v1742150217456!5m2!1sar!2seg",
                    Address = "Corniche El Nile Street, East Bank, Luxor, Egypt",
                    ImageUrl = "Hotels/Luxor/7.jpg",
                    WebSite = "https://www.sonesta.com/sonesta-hotels-resorts/egy/luxor/sonesta-st-george-hotel-luxor",
                    Facebook = "https://www.facebook.com/share/19x25D4GZe/",
                    PhoneNumber = "0-952382575",
                    PricePerHour = 7000,
            },
            new Hotel
            {
                    Id = 8,
                    Name = "Jolie Ville Hotel & Spa Kings Island Luxor",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3596.1693568342284!2d32.6242926!3d25.6656801!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144916af72fd4d79%3A0x57e2897fa81e3b0a!2z2YXZhtiq2KzYuSDZiNiz2KjYpyDYrNmI2YTZiiDZgdmK2YQg2YPZitmG2KzYsiDZgdin2YTZig!5e0!3m2!1sar!2seg!4v1742150332237!5m2!1sar!2seg",
                    Address = "Awameya Road, Kings Island, East Bank, Luxor, Egypt",
                    ImageUrl = "Hotels/Luxor/8.jpg",
                    WebSite = "https://jolievilleluxor.com/",
                    Facebook = "https://www.facebook.com/share/1AQsRLfAoM/",
                    PhoneNumber = "0-952274855",
                    PricePerHour = 6000,
            },
            new Hotel
            {
                    Id = 9,
                    Name = "Pavillon Winter Luxor",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.2265430706807!2d32.6386596!3d25.6969223!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840cfc0b0c23f%3A0xc5c45a5bffb2eec1!2sPavillon%20Winter%20Luxor!5e0!3m2!1sar!2seg!4v1742150453090!5m2!1sar!2seg",
                    Address = "17,Cornish El Nile Street,Beside Luxor Temple, East Bank, 99999 Luxor, Egypt",
                    ImageUrl = "Hotels/Luxor/9.jpg",
                    WebSite = "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjDgYfKmoyMAxV5BQYAHRrGM7wYABAEGgJ3cw&ae=2&aspm=1&co=1&ase=5&gclid=EAIaIQobChMIw4GHypqMjAMVeQUGAB0axjO8EAAYASAAEgLgRvD_BwE&ei=rYLVZ7vmL6SLxc8P9cOYkAw&ohost=www.google.com&cid=CAASJeRoS2XDjppD17JTFEutBMaPIvZPSH-pw60RI3ka_-LGXrL7l10&sig=AOD64_3re-b14AO6-AkKUHYmMwsAlmfK-w&q&sqi=2&adurl&ved=2ahUKEwj78IDKmoyMAxWkRfEDHfUhBsIQ0Qx6BAgSEAE",
                    Facebook = "https://www.facebook.com/share/15nAkdSbP8/",
                    PhoneNumber = "0-952380425",
                    PricePerHour = 7000,
            },
            new Hotel
            {
                    Id = 10,
                    Name = "Kemet House",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3594.9708363816444!2d32.6351208!3d25.7053896!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14491592df0f6151%3A0x6be287cee355d461!2sKEMET%20GUEST%20HOUSE!5e0!3m2!1sar!2seg!4v1742150577610!5m2!1sar!2seg",
                    Address = "Al Qarna Road, West Bank, 85951 Luxor, Egypt",
                    ImageUrl = "Hotels/Luxor/10.jpg",
                    WebSite = "https://kemet-house.com/",
                    Facebook = "https://www.facebook.com/share/16QVjxXGGN/",
                    PhoneNumber = "0-1016649967",
                    PricePerHour = 9000,
            },
            // Aswan
            new Hotel
            {
                    Id = 11,
                    Name = "Sonesta Nouba Hotel Aswan",
                Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3640.3629139021627!2d32.88114108501082!3d24.159001984389537!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1436651db3b6c23d%3A0xde30386aed0ad246!2z2LPZiNmG2LPYqtinINmG2YjYqNipINij2LPZiNin2YY!5e0!3m2!1sar!2seg!4v1742150701997!5m2!1sar!2seg",
                    Address = "Aswan,Corniche El Nile Baharive, Abu El Rish Qebli, 81111 Aswan, Egypt",
                    ImageUrl = "Hotels/Aswan/11.jpg",
                    WebSite = "https://www.sonesta.com/sonesta-hotels-resorts/egy/qism-aswan/sonesta-nouba-hotel-aswan",
                    Facebook = "https://www.facebook.com/share/15jBHzKKJn/",
                    PhoneNumber = "011 18837500",
                    PricePerHour = 9000,
            },
            new Hotel
            {
                    Id = 12,
                    Name = "Pyramisa Island Hotel Aswan",
                    Location = "8https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d29139.651365378886!2d32.9054227!3d24.0854396!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367b4e73fa6fcf%3A0x11847bbcad585364!2z2YHZhtiv2YIg2KjZitix2KfZhdmK2LLYpyDYpdmK2YTYp9mG2K8g2KPYs9mI2KfZhg!5e0!3m2!1sar!2seg!4v1742150765720!5m2!1sar!2seg",
                    Address = "Corniche El Nil, 99999 Aswan, Egypt",
                    ImageUrl = "Hotels/Aswan/12.jpg",
                    WebSite = "https://pyramisaislandaswan.com-egypt.com/",
                    Facebook = "https://www.facebook.com/share/12JNbMmPysK/",
                    PhoneNumber = "20 97-231-7400",
                    PricePerHour = 8500,
            },
            new Hotel
            {
                    Id = 13,
                    Name = "Tolip Aswan Hotel",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3641.77197299069!2d32.903635685011736!3d24.10951318441347!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367bce05036ea5%3A0x32b15d88103d4d62!2z2YHZhtiv2YIg2KrZiNmE2YrYqCDYo9iz2YjYp9mG!5e0!3m2!1sar!2seg!4v1742150830310!5m2!1sar!2seg",
                    Address = "Nile Corniche, Aswan, Egypt",
                    ImageUrl = "Hotels/Aswan/13.jpg",
                    WebSite = "https://tolipgroup.com/tolip-hotel-aswan/",
                    Facebook = "https://www.facebook.com/share/1DsSQWkGjK/",
                    PhoneNumber = "097 2328828",
                    PricePerHour = 13000,
            },
            new Hotel
            {
                    Id = 14,
                    Name = "Labib Guest House",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3642.3922497122853!2d32.887177!3d24.0876976!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1436656da11f668b%3A0xa6dc874bd9b0e6d1!2sLabib%20Guest%20House!5e0!3m2!1sar!2seg!4v1742150891936!5m2!1sar!2seg",
                    Address = "Elephantine Island, 31911571 Aswan, Egypt",
                    ImageUrl = "Hotels/Aswan/14.jpg",
                    WebSite = "https://hotel-menara.com/accommodation/aswan/labib-guest-house/360902",
                    Facebook = "https://www.facebook.com/share/19E12Rf3cU/",
                    PhoneNumber = "011 12175285",
                    PricePerHour = 7000,
            },
            new Hotel
            {
                    Id = 15,
                    Name = "Basma Hotel Aswan",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3642.6698326887117!2d32.88940698501253!3d24.077928784428988!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143664a7e2ac1ee9%3A0x2e0d4f4fbe61ac6b!2z2YHZhtiv2YIg2KjYs9mF2Kk!5e0!3m2!1sar!2seg!4v1742150950289!5m2!1sar!2seg",
                    Address = "In Front Of The Nubian Museum,, 99999 Aswan, Egypt",
                    ImageUrl = "Hotels/Aswan/15.jpg",
                    WebSite = "https://basmahotel.com/contacts/",
                    Facebook = "https://www.facebook.com/share/14anpY3Nho/",
                    PhoneNumber = "097 2484001",
                    PricePerHour = 7000,
            },
            // Fayoum
            new Hotel
            {
                    Id = 16,
                    Name = "Helnan Auberge Fayoum",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3473.627808130699!2d30.77279458489834!3d29.46887678209527!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145971cb8aa9c4bf%3A0x776fe8b3a4a83286!2z2YHZhtiv2YIg2YfZhNmG2KfZhiDYp9mI2KjYsdis!5e0!3m2!1sar!2seg!4v1742151019663!5m2!1sar!2seg",
                    Address = "Lake Karoun, 99999 Fayoum Center, Egypt",
                    ImageUrl = "Hotels/Fayoum/16.jpg",
                    WebSite = "https://www.helnan.com/en/Hotel/helnan-auberge-fayoum/?hid=a15a6247-ca00-4bba-86d6-854019538c8c&id=",
                    Facebook = "https://www.facebook.com/share/19bAuXS1ex/",
                    PhoneNumber = "084 2981200",
                    PricePerHour = 10000,
            },
            new Hotel
            {
                    Id = 17,
                    Name = "Tzila Lodge",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3476.1559037614206!2d30.497292!3d29.394995!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14595d834998b67f%3A0x8d0cf56618018ef7!2sTzila%20Lodge!5e0!3m2!1sar!2seg!4v1742151080175!5m2!1sar!2seg",
                    Address = "Tunes village, 29000 Fayoum Center, Egypt",
                    ImageUrl = "Hotels/Fayoum/17.jpg",
                    WebSite = "https://tzila.com/",
                    Facebook = "https://www.facebook.com/share/1H3xPZVxez/",
                    PhoneNumber = "010 05383653",
                    PricePerHour = 7000,
            },
            new Hotel
            {
                    Id = 18,
                    Name = "Tache By The Lake",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3482.2513170867737!2d30.4119641!3d29.2161614!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145be5f7ca19df45%3A0x80179c95b9ea3575!2sTache%20By%20The%20Lake!5e0!3m2!1sar!2seg!4v1742151145847!5m2!1sar!2seg",
                    Address = "Wadi El Rayyan Road, 63511 Fayoum Center, Egypt",
                    ImageUrl = "Hotels/Fayoum/18.jpg",
                    WebSite = "https://www.instagram.com/tache.fayoum/?hl=ar",
                    Facebook = "https://www.facebook.com/tache.fayoumm/",
                    PhoneNumber = "010 03535100",
                    PricePerHour = 6000,
            },
            new Hotel
            {
                    Id = 19,
                    Name = "Tunis Village Chalet",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d445094.4781190967!2d30.935844!3d29.3614861!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14595f21b4334797%3A0x42b38d8f31f80b1a!2zVHVuaXMgdmlsbGFnZSBFbC1GYXlvdW0gLyDZgtix2YrYqSDYqtmI2YbYsyDYp9mE2YHZitmI2YU!5e0!3m2!1sar!2seg!4v1742151200247!5m2!1sar!2seg",
                    Address = "Tunis Village, 63626 Fayoum Center, Egypt",
                    ImageUrl = "Hotels/Fayoum/19.jpg",
                    WebSite = "https://en.tunisvillage-eg.com/contact",
                    Facebook = "https://www.facebook.com/tunisvillageOfficiel/?locale=hi_IN",
                    PhoneNumber = "01080537444",
                    PricePerHour = 4000,
            },
            // Port Said
            new Hotel
            {
                    Id = 20,
                    Name = "Porto Said Resort & Spa",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d218059.8917912947!2d32.2154536!3d31.3538514!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f993a5744cdaef%3A0x384f1815df6d7eeb!2sPorto%20Said%20Resort%20%26%20Spa!5e0!3m2!1sar!2seg!4v1742151276874!5m2!1sar!2seg",
                    Address = "23 KM Port Said – Damyetta Road, El diba, Egypt, 10000 Port Said, Egypt",
                    ImageUrl = "Hotels/Port Said/20.jpg",
                    WebSite = "https://www.portohotelseg.com/said-resort/contact",
                    Facebook = "https://www.facebook.com/PortoSaidResortOfficial/",
                    PhoneNumber = "01278641045",
                    PricePerHour = 2000,
            },
            new Hotel
            {
                    Id = 21,
                    Name = "Resta Port Said Hotel",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.2431514337036!2d32.317764784855505!3d31.269368781453288!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99dd29f66fd7f%3A0x3a573da6a39b5c09!2z2YHZhtiv2YIg2LHYs9iq2Kcg2KjZiNix2LPYudmK2K8gUmVzdGEgUG9ydCBTYWlkIEhvdGVs!5e0!3m2!1sar!2seg!4v1742151328591!5m2!1sar!2seg",
                    Address = "Sultan Hussein St, Port Said, Egypt",
                    ImageUrl = "Hotels/Port Said/21.jpg",
                    WebSite = "https://www.booking.com/hotel/eg/resta-port-said.ar.html",
                    Facebook = "https://www.facebook.com/restaportsaid/?locale=ar_AR",
                    PhoneNumber = "066 3200511",
                    PricePerHour = 6000,
            },
            new Hotel
            {
                    Id = 22,
                    Name = "Grand Hotel Port Said",
                    Location = "https://maps.app.goo.gl/7hRWvSLypY1vF6gQ7",
                    Address = "Port Said, Atef El-Sadat Street Madînet, Portsaid, Port Said Governorate 42511, 42511 Port Said, Egypt",
                    ImageUrl = "Hotels/Port Said/22.jpg",
                    WebSite = "https://www.instagram.com/grandhotelportsaid/",
                    Facebook = "https://www.facebook.com/GrandHotel.eg/",
                    PhoneNumber = "066 3267550",
                    PricePerHour = 3500,
            },
            new Hotel
            {
                    Id = 23,
                    Name = "Marom Port Said Resort & Beach",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.1397178613893!2d32.30846088485543!3d31.272230281452348!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99df8e01a8d4d%3A0x7157294320b9c03!2sMarom%20Port%20Said%20Resort%20%26%20Beach!5e0!3m2!1sar!2seg!4v1742151398360!5m2!1sar!2seg",
                    Address = "Al Zaim Ghandi St Atef El Sadat St",
                    ImageUrl = "Hotels/Port Said/23.jpg",
                    WebSite = "https://maromhotels.com/ar/",
                    Facebook = "https://www.facebook.com/maromportsaid/",
                    PhoneNumber = "012 22111321",
                    PricePerHour = 3100,
            },
            new Hotel
            {
                    Id = 24,
                    Name = "Helnan Port Said",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.1844026944764!2d32.3148307!3d31.2709941!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99d03c6fd5229%3A0x8fbb517578e263eb!2sHelnan%20portsaid%20beach!5e0!3m2!1sar!2seg!4v1742151582485!5m2!1sar!2seg",
                    Address = "Atef El Sadat Street , Port Fouad",
                    ImageUrl = "Hotels/Port Said/24.jpg",
                    WebSite = "https://www.helnan.com/fr/RoomDetails/helnan-port-said-hotel/?id=d64d57b3-0524-41ca-8411-2a8cb5333d80&hid=711bd3e2-7d02-49e4-8606-1e85d0aca2c9",
                    Facebook = "https://m.facebook.com/profile.php?id=117377931674556",
                    PhoneNumber = "0663456669",
                    PricePerHour = 2500,
            },
            // Ismailia
            new Hotel
            {
                    Id = 25,
                    Name = "Maison Maxim De Lesseps",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.578365545696!2d32.27466188487197!3d30.589445881687254!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f859166dbcf2e1%3A0x1211a0cd16b1cc3c!2sMaison%20Maxim%20De%20Lesseps!5e0!3m2!1sar!2seg!4v1742151661482!5m2!1sar!2seg",
                    Address = "16, Mohamed aly street De Lesseps,ismailia,Egypt, 8361240 Ismailia, Egypt",
                    ImageUrl = "Hotels/Ismailia/25.jpg",
                    WebSite = "https://maisonmaximdelesseps.com/?lang=ar",
                    Facebook = "https://www.facebook.com/maisonmaximdelesseps/",
                    PhoneNumber = "010 94888121",
                    PricePerHour = 5500,
            },
            new Hotel
            {
                    Id = 26,
                    Name = "Tolip El Forsan Hotel",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.680587815631!2d32.294907684872044!3d30.586561081688355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f85939ef30b857%3A0xcc821483be9fa145!2z2YHZhtiv2YIg2KrZiNmE2YrYqCDYp9mE2YHYsdiz2KfZhg!5e0!3m2!1sar!2seg!4v1742152106565!5m2!1sar!2seg",
                    Address = "El-Shaheed Abd El-Moneim Riad Road, 41515 Ismailia, Egypt",
                    ImageUrl = "/Hotels/Ismailia/26.jpg",
                    WebSite = "https://tolipgroup.com/tolip-resort-el-forsan-ismailia/",
                    Facebook = "https://www.facebook.com/TOLIPELFORSAN/",
                    PhoneNumber = "01060779118",
                    PricePerHour = 5600 ,
            },
            new Hotel
            {
                    Id = 27,
                    Name = "Golden Jewel Ismailia Resort",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.6260618508227!2d32.30557968487199!3d30.588099881687803!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f859c1eb07d465%3A0x8a120d14d66b22fb!2z2KzZiNmE2K_ZhiDYrNmI2YrZhCDYp9mE2KPYs9mF2KfYudmK2YTZitip!5e0!3m2!1sar!2seg!4v1742152181691!5m2!1sar!2seg",
                    Address = "Nemra 6, 41622 Ismailia, Egypt",
                    ImageUrl = "Hotels/Ismailia/27.jpg",
                    WebSite = "https://jewelhotels.net/hotel/golden-jewel-ismailia",
                    Facebook = "https://www.facebook.com/GOLJEWISM/?locale=ar_AR",
                    PhoneNumber = "011 52287777",
                    PricePerHour = 3900,
            },
            new Hotel
            {
                    Id = 28,
                    Name = "Mercure Ismailia Forsan Island",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3434.7143616907956!2d32.2898186!3d30.5856079!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f8594808a17409%3A0xa0b58f85a1cbfb6f!2z2YHZhtiv2YIg2YXZitix2YPZitmI2LEg2KzYstmK2LHYqSDYp9mE2YHYsdiz2KfZhiDYp9mE2KXYs9mF2KfYudmK2YTZitip!5e0!3m2!1sar!2seg!4v1742152275470!5m2!1sar!2seg",
                    Address = "Forsan Island, 41511 Ismailia, Egypt",
                    ImageUrl = "Hotels/Ismailia/28.jpg",
                    WebSite = "https://www.instagram.com/mercure_ismailia_forsan_island/?hl=ar",
                    Facebook = "https://www.facebook.com/MercureIsmailia/",
                    PhoneNumber = "01227011086",
                    PricePerHour = 4700,
            },
            new Hotel
            {
                    Id = 29,
                    Name = "VIP villa Ali",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3550.157939690344!2d33.82256158494995!3d27.151320483025412!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1452814d419b4bbb%3A0x2c3f366343fc38b6!2zQWxp4oCZcyBWaWxsYQ!5e0!3m2!1sar!2seg!4v1742152338797!5m2!1sar!2seg",
                    Address = "Ismailia Cooperation Area, 11111 Ismailia, Egypt",
                    ImageUrl = "Hotels/Ismailia/29.jpg",
                    WebSite = "https://www.instagram.com/explore/locations/1762370497115752/vip-villa/",
                    Facebook = "https://www.facebook.com/100057534216384/videos/villa-ali-ali-villas-tobago-plantations-estate/1142269550326102/",
                    PhoneNumber = " 0792807762",
                    PricePerHour = 2600,
            },
            // Marsa Matrouh
            new Hotel
            {
                    Id = 30,
                    Name = "Adriatica Hotel Marsa Matrouh",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3407.192693464274!2d27.234511!3d31.3536614!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461fed2b13ff665%3A0x9ad16be5291440b2!2z2YHZhtiv2YIg2KfYr9ix2YrYqtmK2YPYpw!5e0!3m2!1sar!2seg!4v1742152471152!5m2!1sar!2seg",
                    Address = "El Galaa Street, behind Omar Effendi, Marsa Matruh, Egypt",
                    ImageUrl = "Hotels/Marsa Matrouh/30.jpg",
                    WebSite = "https://www.instagram.com/explore/locations/948309694/adriatica-hotel-marsa-matruh/",
                    Facebook = "https://www.facebook.com/Adriaticahotel.marsamatruh/",
                    PhoneNumber = "046 4938696",
                    PricePerHour = 1570,
            },
            new Hotel
            {
                    Id = 31,
                    Name = "Marmarica Boutique Cabanas - Ras El Hekma - North Coast",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3416.6300059684254!2d27.9300305!3d31.0922173!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14603302ded12bc9%3A0xa167edb8d434215c!2sMarmarica%20Boutique%20Cabanas!5e0!3m2!1sar!2seg!4v1742152936163!5m2!1sar!2seg",
                    Address = "Ras El hekma North Coast, Marsa Matruh, 51512 Marsa Matruh, Egypt",
                    ImageUrl = "Hotels/Marsa Matrouh/31.jpg",
                    WebSite = "https://marmarica.com/",
                    Facebook = "https://www.facebook.com/MarmaricaBoutiqueCabanas/",
                    PhoneNumber = "011 00101919",
                    PricePerHour = 30500,
            },
            new Hotel
            {
                    Id = 32,
                    Name = "Safir Marsa Matrouh Resort",
                    Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3406.531937882072!2d27.2005518!3d31.371893099999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461ffb92025d769%3A0x676bfa79fb218aab!2sSafir%20Marsa%20Matrouh%20Resort!5e0!3m2!1sar!2seg!4v1742152993016!5m2!1sar!2seg",
                    Address = "P.O Box 51511 - Marsa Matrouh, 51511 Marsa Matruh, Egypt",
                    ImageUrl = "Hotels/Marsa Matrouh/32.jpg",
                    WebSite = "https://www.safirhotels.com/en/press/New-Opening-Safir-Marsa-Matrouh",
                    Facebook = "https://www.facebook.com/SafirMarsaMatrouhResort/",
                    PhoneNumber = "012 72409648",
                    PricePerHour = 2300,
            },
            new Hotel
            {
                    Id = 33,
                    Name = "Tolip Resort Paradise",
                    Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3422.778585805699!2d28.8349375!3d30.9208125!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145ffbea0200d795%3A0x22f69e1fe2d16a70!2sTOLIP%20Resort%20Paradise%20New%20Alamein!5e0!3m2!1sar!2seg!4v1742153064059!5m2!1sar!2seg",
                    Address = "120 Alexandria - Marsa Matrouh Road Beside Elhamraa Port, 51718 Marsa Matruh, Egypt",
                    ImageUrl = "Hotels/Marsa Matrouh/33.jpg",
                    WebSite = "https://tolipgroup.com/tolip-resort-paradise-new-alamein/contact-us/",
                    Facebook = "https://www.facebook.com/p/Tolip-Resort-Paradise-New-Alamien-100092546733324/",
                    PhoneNumber = "+20 100 981 5908",
                    PricePerHour = 7500,
            },
            new Hotel
            {
                    Id = 34,
                    Name = "JAZ Almaza Beach Resort, Almaza Bay",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3412.8144910534843!2d27.5546091!3d31.1981566!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461dd53f1555555%3A0x50a0b1cb77aa4b0d!2sJAZ%20Almaza%20Beach%20Resort%2C%20Almaza%20Bay!5e0!3m2!1sar!2seg!4v1742153124653!5m2!1sar!2seg",
                    Address = "Almaza Bay, 37 km East Mersa Matruh,, Marsa Matruh, Egypt",
                    ImageUrl = "Hotels/Marsa Matrouh/34.jpg",
                    WebSite = "https://www.jazhotels.com/hoteldetail/30-egypt-almaza-bay-jaz-almaza-beach-resort",
                    Facebook = "https://www.facebook.com/jazalmazabayresorts/",
                    PhoneNumber = "010 66699942",
                    PricePerHour = 3400,
            },
            // Hurghada
            new Hotel
            {
                    Id = 35,
                    Name = "TUI MAGIC LIFE Kalawy",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3570.273973829099!2d34.0675947!3d26.5113117!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d198b1395a3a5%3A0x8fafdb50b5c09625!2sTUI%20MAGIC%20LIFE%20Kalawy!5e0!3m2!1sar!2seg!4v1742153171217!5m2!1sar!2seg",
                    Address = "0 km Safaga El Queseir Road Hurghada, 84711, Égypte, 84711 Hurghada, Egypt",
                    ImageUrl = "Hotels/Hurghada/35.jpg",
                    WebSite = "https://tuimagiclifekalawy.com-hurghada.com/",
                    Facebook = "https://www.facebook.com/tuimagiclifekalawy/",
                    PhoneNumber = "065 3200021",
                    PricePerHour = 10000,
            },
            new Hotel
            {
                    Id = 36,
                    Name = "Flow Spectrum Resort Sahl Hasheesh",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3553.7322551538464!2d33.8794394!3d27.0386252!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d7f004762bf8b%3A0x1fc9280a55997817!2sFlow%20Spectrum%20Resort!5e0!3m2!1sar!2seg!4v1742153208474!5m2!1sar!2seg",
                    Address = "Sahl Hashish Road, 84521 Hurghada, Egypt",
                    ImageUrl = "Hotels/Hurghada/36.jpg",
                    WebSite = "https://resortflowspectrumhasheesh.hotelshurghada.com/en/",
                    Facebook = "https://www.facebook.com/SahlHasheesh.de/videos/flow-spectrum-resort-sahl-hasheesh/9498118343552521/",
                    PhoneNumber = "012 78575677",
                    PricePerHour = 4400,
            },
            new Hotel
            {
                    Id = 37,
                    Name = "Al Dora Resort All Inclusive Hotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3546.5372517674928!2d33.802178!3d27.2650389!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287fdda77e4cb%3A0x2b619ec9710e07f4!2sAl%20Dora%20Residence!5e0!3m2!1sar!2seg!4v1742153239509!5m2!1sar!2seg",
                    Address = "El Helal District, 84511 Hurghada, Egypt",
                    ImageUrl = "Hotels/Hurghada/37.jpg",
                    WebSite = "https://resortaldorainclusive.hotelshurghada.com/en/",
                    Facebook = "https://www.facebook.com/p/Al-Dora-Residence-100067650841951/",
                    PhoneNumber = "011 11167642",
                    PricePerHour = 3900,
            },
            new Hotel
            {
                    Id = 38,
                    Name = "Davinci Beach Resort",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14187.060345489059!2d33.8203617!3d27.257896!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287e44b1a58cf%3A0x566333cc5ba3f395!2sNew%20DaVinci%20Beach%20%26%20Diving%20Resort!5e0!3m2!1sar!2seg!4v1742153281585!5m2!1sar!2seg",
                    Address = "El Helal District, Hurghada 2, Red Sea Governorate, 84511 Hurghada, Egypt",
                    ImageUrl = "Hotels/Hurghada/38.jpg",
                    WebSite = "https://da-vinci-beach.hotel-hurghada.com/en/",
                    Facebook = "https://www.facebook.com/p/Davinciresort-100067030293671/",
                    PhoneNumber = " 653557868 ",
                    PricePerHour = 1800,
            },
            new Hotel
            {
                    Id = 39,
                    Name = "New Gaisum Resort",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3546.688336422805!2d33.8214024!3d27.2603024!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287d92d6287f7%3A0x4abce40efc57c7a!2zTmV3IEdlaXN1bSDZhtmK2Ygg2KzZitiy2YjZhQ!5e0!3m2!1sar!2seg!4v1742153316715!5m2!1sar!2seg",
                    Address = "El-Bahr, 1973706 Hurghada, Egypt",
                    ImageUrl = "Hotels/Hurghada/39.jpg",
                    WebSite = "https://el-geisum-village.hotel-hurghada.com/en/",
                    Facebook = "https://www.facebook.com/p/Geisum-Village-Hurghada-100069093702673/",
                    PhoneNumber = "065 3546692",
                    PricePerHour = 2300,
            },
            //Alexendria
            new Hotel
            {
                    Id = 40,
                    Name = "Tolip",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d852.9016871781419!2d29.9440803!3d31.2316227!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c4e610b4e28d%3A0x55e0e76c064a00be!2sTOLIP%20Hotel%20Alexandria!5e0!3m2!1sar!2seg!4v1742153353585!5m2!1sar!2seg",
                    Address = "Moustafa Kamel, Corniche Road Roshdy, Alexandria, Egypt",
                    ImageUrl = "Hotels/Alexandria/40.jpg",
                    WebSite = "https://tolipgroup.com/tolip-hotel-royal-alexandria/",
                    Facebook = "https://www.facebook.com/share/14q1Rp793o/",
                    PhoneNumber = "035419330",
                    PricePerHour = 5000,
            },
            new Hotel
            {
                    Id = 41,
                    Name = "Golden Jewel Beach&Hotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3411.694075064414!2d29.941944999999993!3d31.229204!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c594317c499d%3A0xd8de85f6cd600a22!2sGolden%20Jewel%20Beach%20%26%20Hotel!5e0!3m2!1sar!2seg!4v1742153399218!5m2!1sar!2seg",
                    Address = "Corniche Road Sidi Gaber Alexandria Corniche Road Sidi Gaber Alexandria, 21523 Alexandria, Egypt",
                    ImageUrl = "Hotels/Alexandria/41.jpg",
                    WebSite = "https://www.jewelhotels.net/hotel/golden-jewel-hotel-alexandria",
                    Facebook = "https://www.facebook.com/share/1YgyBKhYXQ/",
                    PhoneNumber = "035442380",
                    PricePerHour = 3400,
            },
            new Hotel
            {
                    Id = 42,
                    Name = "The Grand Plaza Hotel Smouha",
                        Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3412.428921417258!2d29.9603911!3d31.2088441!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c4976eb3c991%3A0x82c3d973fe60b252!2z2YHZhtiv2YIg2KzYsdin2YbYryDYqNmE2KfYstinINiz2YXZiNit2Kk!5e0!3m2!1sar!2seg!4v1742153437367!5m2!1sar!2seg",
                    Address = "14th May Avenue, Smouha, 21648 Alexandria, Egypt",
                    ImageUrl = "Hotels/Alexandria/42.jpg",
                    WebSite = "https://www.tgphotels.com/",
                    Facebook = "https://www.facebook.com/share/1ARavY4jGT/",
                    PhoneNumber = "033786100",
                    PricePerHour= 2900,
            },
            new Hotel
            {
                    Id = 43,
                    Name = "Fouad Hotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3412.662304893747!2d29.9014263!3d31.2023754!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5db2eca0d7955%3A0x30a0eecda7d20f56!2z2YHZhtiv2YIg2YHYpNin2K8!5e0!3m2!1sar!2seg!4v1742153471487!5m2!1sar!2seg",
                    Address = "1 Digla Street, Al Ramel Station, Corniche Road, 00203 Alexandria, EgyptAfter booking, all of the property’s details, including telephone and address, are provided in your booking confirmation and your account.",
                    ImageUrl = "Hotels/Alexandria/43.jpg",
                    WebSite = "https://x.com/FouadResv?fbclid=IwZXh0bgNhZW0CMTEAAR1Kn6p5zx9-H-Ej1e6ggmCT87Yqq5iLaDlZQkii6EnYby1drETYgM33xeg_aem_Jv3QsJFIdeOw0K3uZ1Zrqw",
                    Facebook = "https://www.facebook.com/share/15EyLh2pvi/",
                    PhoneNumber = "034808308",
                    PricePerHour= 1100,
            },
            new Hotel
            {
                    Id = 44,
                    Name = "Helnan",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3409.5521515111423!2d30.0183078!3d31.2884809!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5d061fc11582d%3A0x12657103d509ea6c!2z2YHZhtiv2YIg2YfZhNmG2KfZhiDYsdmI2YrYp9mE!5e0!3m2!1sar!2seg!4v1742153525150!5m2!1sar!2seg",
                    Address = "Al Montazah Palace, 99999 Alexandria, Egypt",
                    ImageUrl = "Hotels/Alexandria/44.jpg",
                    WebSite = "https://www.helnan.com/en/Hotel/helnan-royal-alexandria/?hid=4e692ca5-519f-492f-9a2a-4079789b5877&id=",
                    Facebook = "https://www.facebook.com/share/15Q5PCjSzD/",
                    PhoneNumber = "01001710737",
                    PricePerHour= 4000,
            },
            // Suez
            new Hotel
            {
                    Id = 45,
                    Name = "LUSINDA",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3456.842921639098!2d32.5404515!3d29.9551965!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145625d589fe6b35%3A0x65f93388bc88c3fc!2sLUSINDA%20HOTEL!5e0!3m2!1sar!2seg!4v1742153558885!5m2!1sar!2seg",
                    Address = "LUSINDA HOTEL MANAGEMENT BY ZAD, Suez, Egypt",
                    ImageUrl = "Hotels/Suez/45.jpg",
                    WebSite = "https://www.instagram.com/lusinda.resort/",
                    Facebook = "https://www.facebook.com/lusinda.resort/",
                    PhoneNumber = "01201680000",
                    PricePerHour= 3700,
            },
            new Hotel
            {
                    Id = 46,
                    Name = "Mousa Coast Hotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3460.141684109636!2d32.6574876!3d29.8601875!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14563cf73f05475b%3A0xb3ea0e7664279635!2sMousa%20coast!5e0!3m2!1sar!2seg!4v1742153590564!5m2!1sar!2seg",
                    Address = "25 KM After Ahmed Hamdy Tunnel, Ras Sedr, Egypt",
                    ImageUrl = "Hotels/Suez/46.jpg",
                    WebSite = "https://mousacoasthotel.com-egypt.com/",
                    Facebook = "https://www.facebook.com/mousacoast.egy/",
                    PhoneNumber = "+20226775732",
                    PricePerHour= 1800,
            },
            new Hotel
            {
                    Id = 47,
                    Name = "Green House",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d13826.602232954514!2d32.5425553!3d29.9607284!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456250ca617e177%3A0x6daa7f828299e94f!2z2YHZhtiv2YIg2KzYsdmK2YYg2YfYp9mI2LM!5e0!3m2!1sar!2seg!4v1742153628730!5m2!1sar!2seg",
                    Address = "2 Sharie Bursaeid, Suez 43522 Egypt",
                    ImageUrl = "Hotels/Suez/47.jpg",
                    WebSite = "https://greenhouse.com-egypt.com/",
                    Facebook = "https://www.facebook.com/hotel.greenhouse/",
                    PhoneNumber = "0623191554",
                    PricePerHour= 1000,
            },
            //Sharm El-Sheikh
            new Hotel
            {
                    Id = 48,
                    Name = "V Hotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3524.4965767296762!2d34.3792281!3d27.9480745!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145349c9cc60221b%3A0xb4b82bc015ac6a56!2sV%20Hotel%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153665106!5m2!1sar!2seg",
                    Address = "Sharks Bay , 99999 Sharm El Sheikh, Egypt",
                    ImageUrl = "Hotels/Sharm El Sheikh/48.jpg",
                    WebSite = "https://thevhotelsegypt.com/v-sharm-el-sheikh/",
                    Facebook = "https://www.instagram.com/vhotelsharmelsheikh/",
                    PhoneNumber = "0693601091",
                    PricePerHour= 7300,
            },
            new Hotel
            {
                    Id = 49,
                    Name = "Novotel",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3525.5565569460086!2d34.3286542!3d27.9155784!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533787f83288e7%3A0x12499f16f664fbae!2z2YHZhtiv2YIg2YbZiNmB2YjYqtmK2YQg2LTYsdmFINin2YTYtNmK2K4!5e0!3m2!1sar!2seg!4v1742153698720!5m2!1sar!2seg",
                    Address = "Naama Bay, Sharm El Sheikh, Egypt",
                    ImageUrl = "Hotels/Sharm El Sheikh/49.jpg",
                    WebSite = "https://all.accor.com/hotel/1715/index.en.shtml",
                    Facebook = "https://www.facebook.com/NovotelSharmElSheikh/,",
                    PhoneNumber = "0693600172",
                    PricePerHour= 4400,
            },
            new Hotel
            {
                    Id = 50,
                    Name = "Pickalbatros Laguna Vista ",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3521.4126062109817!2d34.4287806!3d28.0424237!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533bca1528a70f%3A0xc0a3d3a55c1b5fe9!2sPickalbatros%20Laguna%20Vista%20Hotel%20-%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153730808!5m2!1sar!2seg",
                    Address = "Nabq bay, 11038 Sharm El Sheikh, Egyp",
                    ImageUrl = "Hotels/Sharm El Sheikh/50.jpg",
                    WebSite = "https://www.pickalbatros.com/laguna-vista-hotel-sharm-el-sheikh",
                    Facebook = "https://www.facebook.com/albatroslagunavistaresort/",
                    PhoneNumber = "+20693710121",
                    PricePerHour= 8600,
            },
            new Hotel
            {
                    Id = 51,
                    Name = "Amphoras",
                        Location = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3527.0801943707547!2d34.3172883!3d27.8688068!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145339f7ec25e6d1%3A0x77f8cfef69e38cc9!2z2YXZhtiq2KzYuSDYtNmI2LHYsiDYo9mF2YHZiNix2KfYsyDYqNmK2KrYtA!5e0!3m2!1sar!2seg!4v1742153763552!5m2!1sar!2seg",
                    Address = "Om El Seid Cliff, Sharm El Sheikh, Egypt",
                    ImageUrl = "Hotels/Sharm El Sheikh/51.jpg",
                    WebSite = "https://www.amphorashotels.com/amphoras?gad_source=1&gclid=Cj0KCQjwytS-BhCKARIsAMGJyzoXN18tpgCfWuylL776fMQhxIDgxj67v9CRnxk-ZhgA79I5d1RLOmcaAiZREALw_wcB",
                    Facebook = "https://www.facebook.com/AmphorasHotels/",
                    PhoneNumber = "01223932782",
                    PricePerHour= 6400,
            },
            new Hotel
            {
                    Id = 52,
                    Name = "Movenpick",
                        Location = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3525.6106056334993!2d34.34263598493347!3d27.9139204827069!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533bb92492a9af%3A0x9b7fa058a25aeac8!2sM%C3%B6venpick%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153794348!5m2!1sar!2seg",
                    Address = "Naama Bay, 6019 Sharm El Sheikh, Egypt",
                    ImageUrl = "Hotels/Sharm El Sheikh/52.jpg",
                    WebSite = "https://movenpick.accor.com/en/africa/egypt/sharm-el-sheikh/resort-sharm-el-sheikh.html",
                    Facebook = "https://www.facebook.com/movenpicksharmelsheikh/",
                    PhoneNumber = "+20693600081",
                    PricePerHour= 5700,
            }


        };

        builder.HasData(hotels);

    }
}