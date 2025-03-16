using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeadingDataForHotelsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Facebook", "ImageUrl", "Location", "Name", "PhoneNumber", "PricePerHour", "WebSite" },
                values: new object[,]
                {
                    { 1, "Cairo international Airport  terminal 3, Heliopolis, 11341 Cairo, Egypt", "https://www.facebook.com/share/19xBNPS8M2/", "Hotels/Cairo/1.jpg", "https://maps.app.goo.gl/T1mGFtYJn9cJWD4D8", "Le Meridien Cairo Airport", "+202-22659600", 5812.0, "https://www.marriott.com/en-us/hotels/caiam-le-meridien-cairo-airport/overview/" },
                    { 2, "Corniche El Nile, Garden City,Cairo", "https://www.facebook.com/share/1EjVfEV71A/", "Hotels/Cairo/2.jpg", "https://maps.app.goo.gl/tVUyS3rJnpt5YJyE7", "Hilton Cairo Grand Nile", "0-223651234", 6400.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwj6lfPF_4uMAxXsa0ECHbnaFVMYABAEGgJ3cw&co=1&ase=2&gclid=EAIaIQobChMI-pXzxf-LjAMV7GtBAh252hVTEAAYASAAEgK3afD_BwE&ohost=www.google.com&cid=CAASJeRoTO3di9EUVIgV7C3WwqJMXHsOhdz4AF8DeGrvCpcDDz6EZx0&sig=AOD64_0sDqYVCCLNjHXPtzKU7Z81PrausA&q&nis=4&adurl&ved=2ahUKEwi2ie3F_4uMAxU9aqQEHbD2MR4Q0Qx6BAgmEAE" },
                    { 3, "1089 Corniche El Nil - Garden City, Garden City, 11519 Cairo, Egypt", "https://www.facebook.com/share/1D9key9seU/", "Hotels/Cairo/3.jpg", "https://maps.app.goo.gl/uLzPGyqS8B5zXwDz5", "Four Seasons Hotel Cairo at Nile Plaza", "20227917000", 14500.0, "https://www.fourseasons.com/caironp/" },
                    { 4, "1115 Corniche El Nile, Cairo, Egypt", "https://www.facebook.com/share/1BiBZudYV5/", "Hotels/Cairo/4.jpg", "https://maps.app.goo.gl/pAFd6BYRXbJDsDgm9", "Ramses Hilton Hotel & Casino", "+20225777444", 6500.0, "https://www.hilton.com/en/hotels/cairhtw-ramses-hilton/" },
                    { 5, "Kasr El Nile, Cairo, Egypt", "https://www.facebook.com/share/1ZTLj6XCvb/", "Hotels/Cairo/5.jpg", "https://maps.app.goo.gl/JekkeR5bGjgmv5my6", "Steigenberger Hotel El Tahrir Cairo", "0-225750777", 5500.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjSl4S_iIyMAxUrCqIDHUHaF3AYABAEGgJsZQ&co=1&gclid=EAIaIQobChMI0peEv4iMjAMVKwqiAx1B2hdwEAAYAiAAEgLKRvD_BwE&ohost=www.google.com&cid=CAASJeRoqb3A8_W_cCI2Psh5SfgGlWkPy5sBG63KSSJLTrvfQUMPBi4&sig=AOD64_1-nv5EhB35HIIna2-AlbmHpbeh7A&q&adurl&ved=2ahUKEwjpk_2-iIyMAxWhR_EDHZMFLEUQ0Qx6BAgUEAQ" },
                    { 6, "Al-Sahaby Lan,In Front Of Luxor Temple, East Bank, 99999 Luxor, Egypt", "https://www.facebook.com/share/1ADhARSWdh/", "Hotels/Luxor/6.jpg", "https://maps.app.goo.gl/taGD5XMjwVkLj5Bp8", "Nefertiti Hotel Luxor", "010 00329991", 2200.0, "https://www.nefertitihotel.com/" },
                    { 7, "Corniche El Nile Street, East Bank, Luxor, Egypt", "https://www.facebook.com/share/19x25D4GZe/", "Hotels/Luxor/7.jpg", "https://maps.app.goo.gl/2sp1DeDrgQ6bxC2m7", "Sonesta St. George Hotel - Convention Center", "0-952382575", 7000.0, "https://www.sonesta.com/sonesta-hotels-resorts/egy/luxor/sonesta-st-george-hotel-luxor" },
                    { 8, "Awameya Road, Kings Island, East Bank, Luxor, Egypt", "https://www.facebook.com/share/1AQsRLfAoM/", "Hotels/Luxor/8.jpg", "https://maps.app.goo.gl/SWxUCeSidWjqUVsM8", "Jolie Ville Hotel & Spa Kings Island Luxor", "0-952274855", 6000.0, "https://jolievilleluxor.com/" },
                    { 9, "17,Cornish El Nile Street,Beside Luxor Temple, East Bank, 99999 Luxor, Egypt", "https://www.facebook.com/share/15nAkdSbP8/", "Hotels/Luxor/9.jpg", "https://maps.app.goo.gl/4DsSer455PztnBGo8", "Pavillon Winter Luxor", "0-952380425", 7000.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjDgYfKmoyMAxV5BQYAHRrGM7wYABAEGgJ3cw&ae=2&aspm=1&co=1&ase=5&gclid=EAIaIQobChMIw4GHypqMjAMVeQUGAB0axjO8EAAYASAAEgLgRvD_BwE&ei=rYLVZ7vmL6SLxc8P9cOYkAw&ohost=www.google.com&cid=CAASJeRoS2XDjppD17JTFEutBMaPIvZPSH-pw60RI3ka_-LGXrL7l10&sig=AOD64_3re-b14AO6-AkKUHYmMwsAlmfK-w&q&sqi=2&adurl&ved=2ahUKEwj78IDKmoyMAxWkRfEDHfUhBsIQ0Qx6BAgSEAE" },
                    { 10, "Al Qarna Road, West Bank, 85951 Luxor, Egypt", "https://www.facebook.com/share/16QVjxXGGN/", "Hotels/Luxor/10.jpg", "https://maps.app.goo.gl/qWGCp6VA6TVvX8UX9", "Kemet House", "0-1016649967", 9000.0, "https://kemet-house.com/" },
                    { 11, "Aswan,Corniche El Nile Baharive, Abu El Rish Qebli, 81111 Aswan, Egypt", "https://www.facebook.com/share/15jBHzKKJn/", "Hotels/Aswan/11.jpg", "https://maps.app.goo.gl/Bq11U6FzbR8bpnFr9", "Sonesta Nouba Hotel Aswan", "011 18837500", 9000.0, "https://www.sonesta.com/sonesta-hotels-resorts/egy/qism-aswan/sonesta-nouba-hotel-aswan" },
                    { 12, "Corniche El Nil, 99999 Aswan, Egypt", "https://www.facebook.com/share/12JNbMmPysK/", "Hotels/Aswan/12.jpg", "https://maps.app.goo.gl/bFewEQ87bMmz5CTq5", "Pyramisa Island Hotel Aswan", "20 97-231-7400", 8500.0, "https://pyramisaislandaswan.com-egypt.com/" },
                    { 13, "Nile Corniche, Aswan, Egypt", "https://www.facebook.com/share/1DsSQWkGjK/", "Hotels/Aswan/13.jpg", "https://maps.app.goo.gl/DuvevXgLkJ62tYPS7", "Tolip Aswan Hotel", "097 2328828", 13000.0, "https://tolipgroup.com/tolip-hotel-aswan/" },
                    { 14, "Elephantine Island, 31911571 Aswan, Egypt", "https://www.facebook.com/share/19E12Rf3cU/", "Hotels/Aswan/14.jpg", "https://maps.app.goo.gl/wJiiJhk1kCyrvaAh7", "Labib Guest House", "011 12175285", 7000.0, "https://hotel-menara.com/accommodation/aswan/labib-guest-house/360902" },
                    { 15, "In Front Of The Nubian Museum,, 99999 Aswan, Egypt", "https://www.facebook.com/share/14anpY3Nho/", "Hotels/Aswan/15.jpg", "https://maps.app.goo.gl/mzodEEh8ssw7qx4c8", "Basma Hotel Aswan", "097 2484001", 7000.0, "https://basmahotel.com/contacts/" },
                    { 16, "Lake Karoun, 99999 Fayoum Center, Egypt", "https://www.facebook.com/share/19bAuXS1ex/", "Hotels/Fayoum/16.jpg", "https://maps.app.goo.gl/7wvDbfhGAhLni4Ce7", "Helnan Auberge Fayoum", "084 2981200", 10000.0, "https://www.helnan.com/en/Hotel/helnan-auberge-fayoum/?hid=a15a6247-ca00-4bba-86d6-854019538c8c&id=" },
                    { 17, "Tunes village, 29000 Fayoum Center, Egypt", "https://www.facebook.com/share/1H3xPZVxez/", "Hotels/Fayoum/17.jpg", "https://maps.app.goo.gl/MsafYu4quFJrALkv7", "Tzila Lodge", "010 05383653", 7000.0, "https://tzila.com/" },
                    { 18, "Wadi El Rayyan Road, 63511 Fayoum Center, Egypt", "https://www.facebook.com/tache.fayoumm/", "Hotels/Fayoum/18.jpg", "https://maps.app.goo.gl/gdrtZrNkBGMK5euC7", "Tache By The Lake", "010 03535100", 6000.0, "https://www.instagram.com/tache.fayoum/?hl=ar" },
                    { 19, "Tunis Village, 63626 Fayoum Center, Egypt", "https://www.facebook.com/tunisvillageOfficiel/?locale=hi_IN", "Hotels/Fayoum/19.jpg", "https://maps.app.goo.gl/8h8ig2tey58XwnXf6", "Tunis Village Chalet", "01080537444", 4000.0, "https://en.tunisvillage-eg.com/contact" },
                    { 20, "23 KM Port Said – Damyetta Road, El diba, Egypt, 10000 Port Said, Egypt", "https://www.facebook.com/PortoSaidResortOfficial/", "Hotels/Port Said/20.jpg", "https://maps.app.goo.gl/9fSCrKCPKRiW5ka28", "Porto Said Resort & Spa", "01278641045", 2000.0, "https://www.portohotelseg.com/said-resort/contact" },
                    { 21, "Sultan Hussein St, Port Said, Egypt", "https://www.facebook.com/restaportsaid/?locale=ar_AR", "Hotels/Port Said/21.jpg", "https://maps.app.goo.gl/ZUCtqTJbDAsjKBNR7", "Resta Port Said Hotel", "066 3200511", 6000.0, "https://www.booking.com/hotel/eg/resta-port-said.ar.html" },
                    { 22, "Port Said, Atef El-Sadat Street Madînet, Portsaid, Port Said Governorate 42511, 42511 Port Said, Egypt", "https://www.facebook.com/GrandHotel.eg/", "Hotels/Port Said/22.jpg", "https://maps.app.goo.gl/7hRWvSLypY1vF6gQ7", "Grand Hotel Port Said", "066 3267550", 3500.0, "https://www.instagram.com/grandhotelportsaid/" },
                    { 23, "Al Zaim Ghandi St Atef El Sadat St", "https://www.facebook.com/maromportsaid/", "Hotels/Port Said/23.jpg", "https://maps.app.goo.gl/ePCJL1sivDZkdzNr6", "Marom Port Said Resort & Beach", "012 22111321", 3100.0, "https://maromhotels.com/ar/" },
                    { 24, "Atef El Sadat Street , Port Fouad", "https://m.facebook.com/profile.php?id=117377931674556", "Hotels/Port Said/24.jpg", "https://maps.app.goo.gl/nPGd4LFhWH3i1VGy6", "Helnan Port Said", "0663456669", 2500.0, "https://www.helnan.com/fr/RoomDetails/helnan-port-said-hotel/?id=d64d57b3-0524-41ca-8411-2a8cb5333d80&hid=711bd3e2-7d02-49e4-8606-1e85d0aca2c9" },
                    { 25, "16, Mohamed aly street De Lesseps,ismailia,Egypt, 8361240 Ismailia, Egypt", "https://www.facebook.com/maisonmaximdelesseps/", "Hotels/Ismailia/25.jpg", "https://maps.app.goo.gl/CLEyccR8LMhYkquE6", "Maison Maxim De Lesseps", "010 94888121", 5500.0, "https://maisonmaximdelesseps.com/?lang=ar" },
                    { 26, "El-Shaheed Abd El-Moneim Riad Road, 41515 Ismailia, Egypt", "https://www.facebook.com/TOLIPELFORSAN/", "/Hotels/Ismailia/26.jpg", "https://maps.app.goo.gl/DUYKea7wjKHSpffQA", "Tolip El Forsan Hotel", "01060779118", 5600.0, "https://tolipgroup.com/tolip-resort-el-forsan-ismailia/" },
                    { 27, "Nemra 6, 41622 Ismailia, Egypt", "https://www.facebook.com/GOLJEWISM/?locale=ar_AR", "Hotels/Ismailia/27.jpg", "https://maps.app.goo.gl/B1vDRjbPg8NnwRhs9", "Golden Jewel Ismailia Resort", "011 52287777", 3900.0, "https://jewelhotels.net/hotel/golden-jewel-ismailia" },
                    { 28, "Forsan Island, 41511 Ismailia, Egypt", "https://www.facebook.com/MercureIsmailia/", "Hotels/Ismailia/28.jpg", "https://maps.app.goo.gl/BGn4yPBBUVd66YFMA", "Mercure Ismailia Forsan Island", "01227011086", 4700.0, "https://www.instagram.com/mercure_ismailia_forsan_island/?hl=ar" },
                    { 29, "Ismailia Cooperation Area, 11111 Ismailia, Egypt", "https://www.facebook.com/100057534216384/videos/villa-ali-ali-villas-tobago-plantations-estate/1142269550326102/", "Hotels/Ismailia/29.jpg", "https://maps.app.goo.gl/eb6x4MTTyc5pkdCK7", "VIP villa Ali", " 0792807762", 2600.0, "https://www.instagram.com/explore/locations/1762370497115752/vip-villa/" },
                    { 30, "El Galaa Street, behind Omar Effendi, Marsa Matruh, Egypt", "https://www.facebook.com/Adriaticahotel.marsamatruh/", "Hotels/Marsa Matrouh/30.jpg", "https://maps.app.goo.gl/SuaWHgf6tACZgtuV8", "Adriatica Hotel Marsa Matrouh", "046 4938696", 1570.0, "https://www.instagram.com/explore/locations/948309694/adriatica-hotel-marsa-matruh/" },
                    { 31, "Ras El hekma North Coast, Marsa Matruh, 51512 Marsa Matruh, Egypt", "https://www.facebook.com/MarmaricaBoutiqueCabanas/", "Hotels/Marsa Matrouh/31.jpg", "https://maps.app.goo.gl/aKRPLMDmbt4NPtJJ9", "Marmarica Boutique Cabanas - Ras El Hekma - North Coast", "011 00101919", 30500.0, "https://marmarica.com/" },
                    { 32, "P.O Box 51511 - Marsa Matrouh, 51511 Marsa Matruh, Egypt", "https://www.facebook.com/SafirMarsaMatrouhResort/", "Hotels/Marsa Matrouh/32.jpg", "https://maps.app.goo.gl/Dfu4ri44VrcWwWdL7", "Safir Marsa Matrouh Resort", "012 72409648", 2300.0, "https://www.safirhotels.com/en/press/New-Opening-Safir-Marsa-Matrouh" },
                    { 33, "120 Alexandria - Marsa Matrouh Road Beside Elhamraa Port, 51718 Marsa Matruh, Egypt", "https://www.facebook.com/p/Tolip-Resort-Paradise-New-Alamien-100092546733324/", "Hotels/Marsa Matrouh/33.jpg", "https://maps.app.goo.gl/SG8yYpntzBhZJaNh6", "Tolip Resort Paradise", "+20 100 981 5908", 7500.0, "https://tolipgroup.com/tolip-resort-paradise-new-alamein/contact-us/" },
                    { 34, "Almaza Bay, 37 km East Mersa Matruh,, Marsa Matruh, Egypt", "https://www.facebook.com/jazalmazabayresorts/", "Hotels/Marsa Matrouh/34.jpg", "https://maps.app.goo.gl/3tfMe7RbGgZ99rGr6", "JAZ Almaza Beach Resort, Almaza Bay", "010 66699942", 3400.0, "https://www.jazhotels.com/hoteldetail/30-egypt-almaza-bay-jaz-almaza-beach-resort" },
                    { 35, "0 km Safaga El Queseir Road Hurghada, 84711, Égypte, 84711 Hurghada, Egypt", "https://www.facebook.com/tuimagiclifekalawy/", "Hotels/Hurghada/35.jpg", "https://maps.app.goo.gl/oe9njhAxYUjBGvV8A", "TUI MAGIC LIFE Kalawy", "065 3200021", 10000.0, "https://tuimagiclifekalawy.com-hurghada.com/" },
                    { 36, "Sahl Hashish Road, 84521 Hurghada, Egypt", "https://www.facebook.com/SahlHasheesh.de/videos/flow-spectrum-resort-sahl-hasheesh/9498118343552521/", "Hotels/Hurghada/36.jpg", "https://maps.app.goo.gl/MewaZ5NqV1EZbzCM7", "Flow Spectrum Resort Sahl Hasheesh", "012 78575677", 4400.0, "https://resortflowspectrumhasheesh.hotelshurghada.com/en/" },
                    { 37, "El Helal District, 84511 Hurghada, Egypt", "https://www.facebook.com/p/Al-Dora-Residence-100067650841951/", "Hotels/Hurghada/37.jpg", "https://maps.app.goo.gl/9UHVv16NevVbSt5a6", "Al Dora Resort All Inclusive Hotel", "011 11167642", 3900.0, "https://resortaldorainclusive.hotelshurghada.com/en/" },
                    { 38, "El Helal District, Hurghada 2, Red Sea Governorate, 84511 Hurghada, Egypt", "https://www.facebook.com/p/Davinciresort-100067030293671/", "Hotels/Hurghada/38.jpg", "https://maps.app.goo.gl/7ErjzsrNA27dzcsT7", "Davinci Beach Resort", " 653557868 ", 1800.0, "https://da-vinci-beach.hotel-hurghada.com/en/" },
                    { 39, "El-Bahr, 1973706 Hurghada, Egypt", "https://www.facebook.com/p/Geisum-Village-Hurghada-100069093702673/", "Hotels/Hurghada/39.jpg", "https://maps.app.goo.gl/BojPre5JkyGf1HZ19", "New Gaisum Resort", "065 3546692", 2300.0, "https://el-geisum-village.hotel-hurghada.com/en/" },
                    { 40, "Moustafa Kamel, Corniche Road Roshdy, Alexandria, Egypt", "https://www.facebook.com/share/14q1Rp793o/", "Hotels/Alexandria/40.jpg", "https://maps.app.goo.gl/UhovkS9WJskex7ek6", "Tolip", "035419330", 5000.0, "https://tolipgroup.com/tolip-hotel-royal-alexandria/" },
                    { 41, "Corniche Road Sidi Gaber Alexandria Corniche Road Sidi Gaber Alexandria, 21523 Alexandria, Egypt", "https://www.facebook.com/share/1YgyBKhYXQ/", "Hotels/Alexandria/41.jpg", "https://maps.app.goo.gl/H8FVHuTmgLnfKW1QA", "Golden Jewel Beach&Hotel", "035442380", 3400.0, "https://www.jewelhotels.net/hotel/golden-jewel-hotel-alexandria" },
                    { 42, "14th May Avenue, Smouha, 21648 Alexandria, Egypt", "https://www.facebook.com/share/1ARavY4jGT/", "Hotels/Alexandria/42.jpg", "https://maps.app.goo.gl/AGW3nfkVgTBX24Jr9", "The Grand Plaza Hotel Smouha", "033786100", 2900.0, "https://www.tgphotels.com/" },
                    { 43, "1 Digla Street, Al Ramel Station, Corniche Road, 00203 Alexandria, EgyptAfter booking, all of the property’s details, including telephone and address, are provided in your booking confirmation and your account.", "https://www.facebook.com/share/15EyLh2pvi/", "Hotels/Alexandria/43.jpg", "https://maps.app.goo.gl/RFR5cGFmQzi5eAb7A", "Fouad Hotel", "034808308", 1100.0, "https://x.com/FouadResv?fbclid=IwZXh0bgNhZW0CMTEAAR1Kn6p5zx9-H-Ej1e6ggmCT87Yqq5iLaDlZQkii6EnYby1drETYgM33xeg_aem_Jv3QsJFIdeOw0K3uZ1Zrqw" },
                    { 44, "Al Montazah Palace, 99999 Alexandria, Egypt", "https://www.facebook.com/share/15Q5PCjSzD/", "Hotels/Alexandria/44.jpg", "https://maps.app.goo.gl/r3mmpEBwRzA3vHqS8", "Helnan", "01001710737", 4000.0, "https://www.helnan.com/en/Hotel/helnan-royal-alexandria/?hid=4e692ca5-519f-492f-9a2a-4079789b5877&id=" },
                    { 45, "LUSINDA HOTEL MANAGEMENT BY ZAD, Suez, Egypt", "https://www.facebook.com/lusinda.resort/", "Hotels/Suez/45.jpg", "https://maps.app.goo.gl/rDphdX2SYnJmAASt8", "LUSINDA", "01201680000", 3700.0, "https://www.instagram.com/lusinda.resort/" },
                    { 46, "25 KM After Ahmed Hamdy Tunnel, Ras Sedr, Egypt", "https://www.facebook.com/mousacoast.egy/", "Hotels/Suez/46.jpg", "https://maps.app.goo.gl/D8KEYAWegsJEaPT69", "Mousa Coast Hotel", "+20226775732", 1800.0, "https://mousacoasthotel.com-egypt.com/" },
                    { 47, "2 Sharie Bursaeid, Suez 43522 Egypt", "https://www.facebook.com/hotel.greenhouse/", "Hotels/Suez/47.jpg", "https://maps.app.goo.gl/xJXESEyc7p2Ri4kT6", "Green House", "0623191554", 1000.0, "https://greenhouse.com-egypt.com/" },
                    { 48, "Sharks Bay , 99999 Sharm El Sheikh, Egypt", "https://www.instagram.com/vhotelsharmelsheikh/", "Hotels/Sharm El Sheikh/48.jpg", "https://maps.app.goo.gl/exZMhMtQ9PP4R4XZA", "V Hotel", "0693601091", 7300.0, "https://thevhotelsegypt.com/v-sharm-el-sheikh/" },
                    { 49, "Naama Bay, Sharm El Sheikh, Egypt", "https://www.facebook.com/NovotelSharmElSheikh/,", "Hotels/Sharm El Sheikh/49.jpg", "https://maps.app.goo.gl/xpQ2k3nAcTmtpY9MA", "Novotel", "0693600172", 4400.0, "https://all.accor.com/hotel/1715/index.en.shtml" },
                    { 50, "Nabq bay, 11038 Sharm El Sheikh, Egyp", "https://www.facebook.com/albatroslagunavistaresort/", "Hotels/Sharm El Sheikh/50.jpg", "https://maps.app.goo.gl/3C7sKMpRxN4eDAoz5", "Pickalbatros Laguna Vista ", "+20693710121", 8600.0, "https://www.pickalbatros.com/laguna-vista-hotel-sharm-el-sheikh" },
                    { 51, "Om El Seid Cliff, Sharm El Sheikh, Egypt", "https://www.facebook.com/AmphorasHotels/", "Hotels/Sharm El Sheikh/51.jpg", "https://maps.app.goo.gl/iBdXX7891J7968796", "Amphoras", "01223932782", 6400.0, "https://www.amphorashotels.com/amphoras?gad_source=1&gclid=Cj0KCQjwytS-BhCKARIsAMGJyzoXN18tpgCfWuylL776fMQhxIDgxj67v9CRnxk-ZhgA79I5d1RLOmcaAiZREALw_wcB" },
                    { 52, "Naama Bay, 6019 Sharm El Sheikh, Egypt", "https://www.facebook.com/movenpicksharmelsheikh/", "Hotels/Sharm El Sheikh/52.jpg", "https://maps.app.goo.gl/gxrVZYu4byd2MWHZ7", "Movenpick", "+20693600081", 5700.0, "https://movenpick.accor.com/en/africa/egypt/sharm-el-sheikh/resort-sharm-el-sheikh.html" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52);
        }
    }
}
