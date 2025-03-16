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
            new Hotel
            {
                 Id = 1,
                 Name = "Le Meridien Cairo Airport",
                 Location = "https://maps.app.goo.gl/T1mGFtYJn9cJWD4D8",
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
                 Location = "https://maps.app.goo.gl/tVUyS3rJnpt5YJyE7",
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
                 Location = "https://maps.app.goo.gl/uLzPGyqS8B5zXwDz5",
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
                 Location = "https://maps.app.goo.gl/pAFd6BYRXbJDsDgm9",
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
                 Location = "https://maps.app.goo.gl/JekkeR5bGjgmv5my6",
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
                 Location = "https://maps.app.goo.gl/taGD5XMjwVkLj5Bp8",
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
                 Location = "https://maps.app.goo.gl/2sp1DeDrgQ6bxC2m7",
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
                 Location = "https://maps.app.goo.gl/SWxUCeSidWjqUVsM8",
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
                 Location = "https://maps.app.goo.gl/4DsSer455PztnBGo8",
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
                 Location = "https://maps.app.goo.gl/qWGCp6VA6TVvX8UX9",
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
                 Location = "https://maps.app.goo.gl/Bq11U6FzbR8bpnFr9",
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
                 Location = "https://maps.app.goo.gl/bFewEQ87bMmz5CTq5",
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
                 Location = "https://maps.app.goo.gl/DuvevXgLkJ62tYPS7",
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
                 Location = "https://maps.app.goo.gl/wJiiJhk1kCyrvaAh7",
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
                 Location = "https://maps.app.goo.gl/mzodEEh8ssw7qx4c8",
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
                 Location = "https://maps.app.goo.gl/7wvDbfhGAhLni4Ce7",
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
                 Location = "https://maps.app.goo.gl/MsafYu4quFJrALkv7",
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
                 Location = "https://maps.app.goo.gl/gdrtZrNkBGMK5euC7",
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
                 Location = "https://maps.app.goo.gl/8h8ig2tey58XwnXf6",
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
                 Location = "https://maps.app.goo.gl/9fSCrKCPKRiW5ka28",
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
                 Location = "https://maps.app.goo.gl/ZUCtqTJbDAsjKBNR7",
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
                 Location = "https://maps.app.goo.gl/ePCJL1sivDZkdzNr6",
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
                 Location = "https://maps.app.goo.gl/nPGd4LFhWH3i1VGy6",
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
                 Location = "https://maps.app.goo.gl/CLEyccR8LMhYkquE6",
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
                 Location = "https://maps.app.goo.gl/DUYKea7wjKHSpffQA",
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
                 Location = "https://maps.app.goo.gl/B1vDRjbPg8NnwRhs9",
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
                 Location = "https://maps.app.goo.gl/BGn4yPBBUVd66YFMA",
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
                 Location = "https://maps.app.goo.gl/eb6x4MTTyc5pkdCK7",
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
                 Location = "https://maps.app.goo.gl/SuaWHgf6tACZgtuV8",
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
                 Location = "https://maps.app.goo.gl/aKRPLMDmbt4NPtJJ9",
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
                 Location = "https://maps.app.goo.gl/Dfu4ri44VrcWwWdL7",
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
                 Location = "https://maps.app.goo.gl/SG8yYpntzBhZJaNh6",
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
                 Location = "https://maps.app.goo.gl/3tfMe7RbGgZ99rGr6",
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
                 Location = "https://maps.app.goo.gl/oe9njhAxYUjBGvV8A",
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
                 Location = "https://maps.app.goo.gl/MewaZ5NqV1EZbzCM7",
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
                 Location = "https://maps.app.goo.gl/9UHVv16NevVbSt5a6",
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
                 Location = "https://maps.app.goo.gl/7ErjzsrNA27dzcsT7",
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
                 Location = "https://maps.app.goo.gl/BojPre5JkyGf1HZ19",
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
                 Location = "https://maps.app.goo.gl/UhovkS9WJskex7ek6",
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
                 Location = "https://maps.app.goo.gl/H8FVHuTmgLnfKW1QA",
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
                 Location = "https://maps.app.goo.gl/AGW3nfkVgTBX24Jr9",
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
                 Location = "https://maps.app.goo.gl/RFR5cGFmQzi5eAb7A",
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
                 Location = "https://maps.app.goo.gl/r3mmpEBwRzA3vHqS8",
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
                 Location = "https://maps.app.goo.gl/rDphdX2SYnJmAASt8",
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
                 Location = "https://maps.app.goo.gl/D8KEYAWegsJEaPT69",
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
                 Location = "https://maps.app.goo.gl/xJXESEyc7p2Ri4kT6",
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
                 Location = "https://maps.app.goo.gl/exZMhMtQ9PP4R4XZA",
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
                 Location = "https://maps.app.goo.gl/xpQ2k3nAcTmtpY9MA",
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
                 Location = "https://maps.app.goo.gl/3C7sKMpRxN4eDAoz5",
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
                 Location = "https://maps.app.goo.gl/iBdXX7891J7968796",
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
                 Location = "https://maps.app.goo.gl/gxrVZYu4byd2MWHZ7",
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