using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Egyptos.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHoteltData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Facebook", "ImageUrl", "Location", "Name", "PhoneNumber", "PricePerHour", "WebSite" },
                values: new object[,]
                {
                    { 1, "Cairo international Airport  terminal 3, Heliopolis, 11341 Cairo, Egypt", "https://www.facebook.com/share/19xBNPS8M2/", "Hotels/Cairo/1.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3451.3169529673273!2d31.395847200000006!3d30.1137427!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14581655c2fefa93%3A0x855d24c50d9a251!2z2YTZiCDZhdmK2LHZitiv2YrYp9mGINmF2LfYp9ixINin2YTZgtin2YfYsdip!5e0!3m2!1sar!2seg!4v1742149560840!5m2!1sar!2seg", "Le Meridien Cairo Airport", "+202-22659600", 5812.0, "https://www.marriott.com/en-us/hotels/caiam-le-meridien-cairo-airport/overview/" },
                    { 2, "Corniche El Nile, Garden City,Cairo", "https://www.facebook.com/share/1EjVfEV71A/", "Hotels/Cairo/2.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3454.076091286725!2d31.2294302!3d30.0346748!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145847eb19741479%3A0x6f4f4b9d21f639e1!2z2YfZitmE2KrZiNmGINin2YTZgtin2YfYsdipINis2LHYp9mG2K8g2YbYp9mK2YQ!5e0!3m2!1sar!2seg!4v1742149673321!5m2!1sar!2seg", "Hilton Cairo Grand Nile", "0-223651234", 6400.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwj6lfPF_4uMAxXsa0ECHbnaFVMYABAEGgJ3cw&co=1&ase=2&gclid=EAIaIQobChMI-pXzxf-LjAMV7GtBAh252hVTEAAYASAAEgK3afD_BwE&ohost=www.google.com&cid=CAASJeRoTO3di9EUVIgV7C3WwqJMXHsOhdz4AF8DeGrvCpcDDz6EZx0&sig=AOD64_0sDqYVCCLNjHXPtzKU7Z81PrausA&q&nis=4&adurl&ved=2ahUKEwi2ie3F_4uMAxU9aqQEHbD2MR4Q0Qx6BAgmEAE" },
                    { 3, "1089 Corniche El Nil - Garden City, Garden City, 11519 Cairo, Egypt", "https://www.facebook.com/share/1D9key9seU/", "Hotels/Cairo/3.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3454.0216686198137!2d31.2320317!3d30.0362362!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840cd3ef57809%3A0xd7f50b4221f71eb0!2z2YHZhtiv2YIg2YHZiNixINiz2YrYstmI2YYg2YbYp9mK2YQg2KjZhNin2LLYpyDYp9mE2YLYp9mH2LHZhw!5e0!3m2!1sar!2seg!4v1742149822971!5m2!1sar!2seg", "Four Seasons Hotel Cairo at Nile Plaza", "20227917000", 14500.0, "https://www.fourseasons.com/caironp/" },
                    { 4, "1115 Corniche El Nile, Cairo, Egypt", "https://www.facebook.com/share/1BiBZudYV5/", "Hotels/Cairo/4.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3453.5290920453067!2d31.234616!3d30.050365!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840c381a29537%3A0xf1d5b3a64a0e4de1!2z2YfZitmE2KrZiNmGINix2YXYs9mK2LM!5e0!3m2!1sar!2seg!4v1742149918000!5m2!1sar!2seg", "Ramses Hilton Hotel & Casino", "+20225777444", 6500.0, "https://www.hilton.com/en/hotels/cairhtw-ramses-hilton/" },
                    { 5, "Kasr El Nile, Cairo, Egypt", "https://www.facebook.com/share/1ZTLj6XCvb/", "Hotels/Cairo/5.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3453.655892501945!2d31.2378339!3d30.0467285!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840c6e7b40217%3A0xa56e70b7cb4fa53d!2z2LTYqtmK2KzZhtio2LHYrNix!5e0!3m2!1sar!2seg!4v1742149990173!5m2!1sar!2seg", "Steigenberger Hotel El Tahrir Cairo", "0-225750777", 5500.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjSl4S_iIyMAxUrCqIDHUHaF3AYABAEGgJsZQ&co=1&gclid=EAIaIQobChMI0peEv4iMjAMVKwqiAx1B2hdwEAAYAiAAEgLKRvD_BwE&ohost=www.google.com&cid=CAASJeRoqb3A8_W_cCI2Psh5SfgGlWkPy5sBG63KSSJLTrvfQUMPBi4&sig=AOD64_1-nv5EhB35HIIna2-AlbmHpbeh7A&q&adurl&ved=2ahUKEwjpk_2-iIyMAxWhR_EDHZMFLEUQ0Qx6BAgUEAQ" },
                    { 6, "Al-Sahaby Lan,In Front Of Luxor Temple, East Bank, 99999 Luxor, Egypt", "https://www.facebook.com/share/1ADhARSWdh/", "Hotels/Luxor/6.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.0867571344843!2d32.644454!3d25.7015514!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144915793ddb0125%3A0xe6577d403df25035!2sNefertiti%20Hotel%20Luxor!5e0!3m2!1sar!2seg!4v1742150165519!5m2!1sar!2seg", "Nefertiti Hotel Luxor", "010 00329991", 2200.0, "https://www.nefertitihotel.com/" },
                    { 7, "Corniche El Nile Street, East Bank, Luxor, Egypt", "https://www.facebook.com/share/19x25D4GZe/", "Hotels/Luxor/7.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.479246270187!2d32.6339694!3d25.6885519!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144914291e2ae293%3A0xa1bb33e69e24c44f!2z2YHZhtiv2YIg2LPZiNmG2LPYqtinINiz2KfZhiDYrNmI2LHYrCDYp9mE2KfZgti12LE!5e0!3m2!1sar!2seg!4v1742150217456!5m2!1sar!2seg", "Sonesta St. George Hotel - Convention Center", "0-952382575", 7000.0, "https://www.sonesta.com/sonesta-hotels-resorts/egy/luxor/sonesta-st-george-hotel-luxor" },
                    { 8, "Awameya Road, Kings Island, East Bank, Luxor, Egypt", "https://www.facebook.com/share/1AQsRLfAoM/", "Hotels/Luxor/8.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3596.1693568342284!2d32.6242926!3d25.6656801!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144916af72fd4d79%3A0x57e2897fa81e3b0a!2z2YXZhtiq2KzYuSDZiNiz2KjYpyDYrNmI2YTZiiDZgdmK2YQg2YPZitmG2KzYsiDZgdin2YTZig!5e0!3m2!1sar!2seg!4v1742150332237!5m2!1sar!2seg", "Jolie Ville Hotel & Spa Kings Island Luxor", "0-952274855", 6000.0, "https://jolievilleluxor.com/" },
                    { 9, "17,Cornish El Nile Street,Beside Luxor Temple, East Bank, 99999 Luxor, Egypt", "https://www.facebook.com/share/15nAkdSbP8/", "Hotels/Luxor/9.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3595.2265430706807!2d32.6386596!3d25.6969223!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145840cfc0b0c23f%3A0xc5c45a5bffb2eec1!2sPavillon%20Winter%20Luxor!5e0!3m2!1sar!2seg!4v1742150453090!5m2!1sar!2seg", "Pavillon Winter Luxor", "0-952380425", 7000.0, "https://www.googleadservices.com/pagead/aclk?sa=L&ai=DChcSEwjDgYfKmoyMAxV5BQYAHRrGM7wYABAEGgJ3cw&ae=2&aspm=1&co=1&ase=5&gclid=EAIaIQobChMIw4GHypqMjAMVeQUGAB0axjO8EAAYASAAEgLgRvD_BwE&ei=rYLVZ7vmL6SLxc8P9cOYkAw&ohost=www.google.com&cid=CAASJeRoS2XDjppD17JTFEutBMaPIvZPSH-pw60RI3ka_-LGXrL7l10&sig=AOD64_3re-b14AO6-AkKUHYmMwsAlmfK-w&q&sqi=2&adurl&ved=2ahUKEwj78IDKmoyMAxWkRfEDHfUhBsIQ0Qx6BAgSEAE" },
                    { 10, "Al Qarna Road, West Bank, 85951 Luxor, Egypt", "https://www.facebook.com/share/16QVjxXGGN/", "Hotels/Luxor/10.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3594.9708363816444!2d32.6351208!3d25.7053896!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14491592df0f6151%3A0x6be287cee355d461!2sKEMET%20GUEST%20HOUSE!5e0!3m2!1sar!2seg!4v1742150577610!5m2!1sar!2seg", "Kemet House", "0-1016649967", 9000.0, "https://kemet-house.com/" },
                    { 11, "Aswan,Corniche El Nile Baharive, Abu El Rish Qebli, 81111 Aswan, Egypt", "https://www.facebook.com/share/15jBHzKKJn/", "Hotels/Aswan/11.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3640.3629139021627!2d32.88114108501082!3d24.159001984389537!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1436651db3b6c23d%3A0xde30386aed0ad246!2z2LPZiNmG2LPYqtinINmG2YjYqNipINij2LPZiNin2YY!5e0!3m2!1sar!2seg!4v1742150701997!5m2!1sar!2seg", "Sonesta Nouba Hotel Aswan", "011 18837500", 9000.0, "https://www.sonesta.com/sonesta-hotels-resorts/egy/qism-aswan/sonesta-nouba-hotel-aswan" },
                    { 12, "Corniche El Nil, 99999 Aswan, Egypt", "https://www.facebook.com/share/12JNbMmPysK/", "Hotels/Aswan/12.jpg", "8https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d29139.651365378886!2d32.9054227!3d24.0854396!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367b4e73fa6fcf%3A0x11847bbcad585364!2z2YHZhtiv2YIg2KjZitix2KfZhdmK2LLYpyDYpdmK2YTYp9mG2K8g2KPYs9mI2KfZhg!5e0!3m2!1sar!2seg!4v1742150765720!5m2!1sar!2seg", "Pyramisa Island Hotel Aswan", "20 97-231-7400", 8500.0, "https://pyramisaislandaswan.com-egypt.com/" },
                    { 13, "Nile Corniche, Aswan, Egypt", "https://www.facebook.com/share/1DsSQWkGjK/", "Hotels/Aswan/13.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3641.77197299069!2d32.903635685011736!3d24.10951318441347!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14367bce05036ea5%3A0x32b15d88103d4d62!2z2YHZhtiv2YIg2KrZiNmE2YrYqCDYo9iz2YjYp9mG!5e0!3m2!1sar!2seg!4v1742150830310!5m2!1sar!2seg", "Tolip Aswan Hotel", "097 2328828", 13000.0, "https://tolipgroup.com/tolip-hotel-aswan/" },
                    { 14, "Elephantine Island, 31911571 Aswan, Egypt", "https://www.facebook.com/share/19E12Rf3cU/", "Hotels/Aswan/14.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3642.3922497122853!2d32.887177!3d24.0876976!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1436656da11f668b%3A0xa6dc874bd9b0e6d1!2sLabib%20Guest%20House!5e0!3m2!1sar!2seg!4v1742150891936!5m2!1sar!2seg", "Labib Guest House", "011 12175285", 7000.0, "https://hotel-menara.com/accommodation/aswan/labib-guest-house/360902" },
                    { 15, "In Front Of The Nubian Museum,, 99999 Aswan, Egypt", "https://www.facebook.com/share/14anpY3Nho/", "Hotels/Aswan/15.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3642.6698326887117!2d32.88940698501253!3d24.077928784428988!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x143664a7e2ac1ee9%3A0x2e0d4f4fbe61ac6b!2z2YHZhtiv2YIg2KjYs9mF2Kk!5e0!3m2!1sar!2seg!4v1742150950289!5m2!1sar!2seg", "Basma Hotel Aswan", "097 2484001", 7000.0, "https://basmahotel.com/contacts/" },
                    { 16, "Lake Karoun, 99999 Fayoum Center, Egypt", "https://www.facebook.com/share/19bAuXS1ex/", "Hotels/Fayoum/16.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3473.627808130699!2d30.77279458489834!3d29.46887678209527!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145971cb8aa9c4bf%3A0x776fe8b3a4a83286!2z2YHZhtiv2YIg2YfZhNmG2KfZhiDYp9mI2KjYsdis!5e0!3m2!1sar!2seg!4v1742151019663!5m2!1sar!2seg", "Helnan Auberge Fayoum", "084 2981200", 10000.0, "https://www.helnan.com/en/Hotel/helnan-auberge-fayoum/?hid=a15a6247-ca00-4bba-86d6-854019538c8c&id=" },
                    { 17, "Tunes village, 29000 Fayoum Center, Egypt", "https://www.facebook.com/share/1H3xPZVxez/", "Hotels/Fayoum/17.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3476.1559037614206!2d30.497292!3d29.394995!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14595d834998b67f%3A0x8d0cf56618018ef7!2sTzila%20Lodge!5e0!3m2!1sar!2seg!4v1742151080175!5m2!1sar!2seg", "Tzila Lodge", "010 05383653", 7000.0, "https://tzila.com/" },
                    { 18, "Wadi El Rayyan Road, 63511 Fayoum Center, Egypt", "https://www.facebook.com/tache.fayoumm/", "Hotels/Fayoum/18.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3482.2513170867737!2d30.4119641!3d29.2161614!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145be5f7ca19df45%3A0x80179c95b9ea3575!2sTache%20By%20The%20Lake!5e0!3m2!1sar!2seg!4v1742151145847!5m2!1sar!2seg", "Tache By The Lake", "010 03535100", 6000.0, "https://www.instagram.com/tache.fayoum/?hl=ar" },
                    { 19, "Tunis Village, 63626 Fayoum Center, Egypt", "https://www.facebook.com/tunisvillageOfficiel/?locale=hi_IN", "Hotels/Fayoum/19.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d445094.4781190967!2d30.935844!3d29.3614861!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14595f21b4334797%3A0x42b38d8f31f80b1a!2zVHVuaXMgdmlsbGFnZSBFbC1GYXlvdW0gLyDZgtix2YrYqSDYqtmI2YbYsyDYp9mE2YHZitmI2YU!5e0!3m2!1sar!2seg!4v1742151200247!5m2!1sar!2seg", "Tunis Village Chalet", "01080537444", 4000.0, "https://en.tunisvillage-eg.com/contact" },
                    { 20, "23 KM Port Said – Damyetta Road, El diba, Egypt, 10000 Port Said, Egypt", "https://www.facebook.com/PortoSaidResortOfficial/", "Hotels/Port Said/20.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d218059.8917912947!2d32.2154536!3d31.3538514!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f993a5744cdaef%3A0x384f1815df6d7eeb!2sPorto%20Said%20Resort%20%26%20Spa!5e0!3m2!1sar!2seg!4v1742151276874!5m2!1sar!2seg", "Porto Said Resort & Spa", "01278641045", 2000.0, "https://www.portohotelseg.com/said-resort/contact" },
                    { 21, "Sultan Hussein St, Port Said, Egypt", "https://www.facebook.com/restaportsaid/?locale=ar_AR", "Hotels/Port Said/21.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.2431514337036!2d32.317764784855505!3d31.269368781453288!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99dd29f66fd7f%3A0x3a573da6a39b5c09!2z2YHZhtiv2YIg2LHYs9iq2Kcg2KjZiNix2LPYudmK2K8gUmVzdGEgUG9ydCBTYWlkIEhvdGVs!5e0!3m2!1sar!2seg!4v1742151328591!5m2!1sar!2seg", "Resta Port Said Hotel", "066 3200511", 6000.0, "https://www.booking.com/hotel/eg/resta-port-said.ar.html" },
                    { 22, "Port Said, Atef El-Sadat Street Madînet, Portsaid, Port Said Governorate 42511, 42511 Port Said, Egypt", "https://www.facebook.com/GrandHotel.eg/", "Hotels/Port Said/22.jpg", "https://maps.app.goo.gl/7hRWvSLypY1vF6gQ7", "Grand Hotel Port Said", "066 3267550", 3500.0, "https://www.instagram.com/grandhotelportsaid/" },
                    { 23, "Al Zaim Ghandi St Atef El Sadat St", "https://www.facebook.com/maromportsaid/", "Hotels/Port Said/23.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.1397178613893!2d32.30846088485543!3d31.272230281452348!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99df8e01a8d4d%3A0x7157294320b9c03!2sMarom%20Port%20Said%20Resort%20%26%20Beach!5e0!3m2!1sar!2seg!4v1742151398360!5m2!1sar!2seg", "Marom Port Said Resort & Beach", "012 22111321", 3100.0, "https://maromhotels.com/ar/" },
                    { 24, "Atef El Sadat Street , Port Fouad", "https://m.facebook.com/profile.php?id=117377931674556", "Hotels/Port Said/24.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3410.1844026944764!2d32.3148307!3d31.2709941!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f99d03c6fd5229%3A0x8fbb517578e263eb!2sHelnan%20portsaid%20beach!5e0!3m2!1sar!2seg!4v1742151582485!5m2!1sar!2seg", "Helnan Port Said", "0663456669", 2500.0, "https://www.helnan.com/fr/RoomDetails/helnan-port-said-hotel/?id=d64d57b3-0524-41ca-8411-2a8cb5333d80&hid=711bd3e2-7d02-49e4-8606-1e85d0aca2c9" },
                    { 25, "16, Mohamed aly street De Lesseps,ismailia,Egypt, 8361240 Ismailia, Egypt", "https://www.facebook.com/maisonmaximdelesseps/", "Hotels/Ismailia/25.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.578365545696!2d32.27466188487197!3d30.589445881687254!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f859166dbcf2e1%3A0x1211a0cd16b1cc3c!2sMaison%20Maxim%20De%20Lesseps!5e0!3m2!1sar!2seg!4v1742151661482!5m2!1sar!2seg", "Maison Maxim De Lesseps", "010 94888121", 5500.0, "https://maisonmaximdelesseps.com/?lang=ar" },
                    { 26, "El-Shaheed Abd El-Moneim Riad Road, 41515 Ismailia, Egypt", "https://www.facebook.com/TOLIPELFORSAN/", "/Hotels/Ismailia/26.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.680587815631!2d32.294907684872044!3d30.586561081688355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f85939ef30b857%3A0xcc821483be9fa145!2z2YHZhtiv2YIg2KrZiNmE2YrYqCDYp9mE2YHYsdiz2KfZhg!5e0!3m2!1sar!2seg!4v1742152106565!5m2!1sar!2seg", "Tolip El Forsan Hotel", "01060779118", 5600.0, "https://tolipgroup.com/tolip-resort-el-forsan-ismailia/" },
                    { 27, "Nemra 6, 41622 Ismailia, Egypt", "https://www.facebook.com/GOLJEWISM/?locale=ar_AR", "Hotels/Ismailia/27.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3434.6260618508227!2d32.30557968487199!3d30.588099881687803!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f859c1eb07d465%3A0x8a120d14d66b22fb!2z2KzZiNmE2K_ZhiDYrNmI2YrZhCDYp9mE2KPYs9mF2KfYudmK2YTZitip!5e0!3m2!1sar!2seg!4v1742152181691!5m2!1sar!2seg", "Golden Jewel Ismailia Resort", "011 52287777", 3900.0, "https://jewelhotels.net/hotel/golden-jewel-ismailia" },
                    { 28, "Forsan Island, 41511 Ismailia, Egypt", "https://www.facebook.com/MercureIsmailia/", "Hotels/Ismailia/28.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3434.7143616907956!2d32.2898186!3d30.5856079!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f8594808a17409%3A0xa0b58f85a1cbfb6f!2z2YHZhtiv2YIg2YXZitix2YPZitmI2LEg2KzYstmK2LHYqSDYp9mE2YHYsdiz2KfZhiDYp9mE2KXYs9mF2KfYudmK2YTZitip!5e0!3m2!1sar!2seg!4v1742152275470!5m2!1sar!2seg", "Mercure Ismailia Forsan Island", "01227011086", 4700.0, "https://www.instagram.com/mercure_ismailia_forsan_island/?hl=ar" },
                    { 29, "Ismailia Cooperation Area, 11111 Ismailia, Egypt", "https://www.facebook.com/100057534216384/videos/villa-ali-ali-villas-tobago-plantations-estate/1142269550326102/", "Hotels/Ismailia/29.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3550.157939690344!2d33.82256158494995!3d27.151320483025412!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1452814d419b4bbb%3A0x2c3f366343fc38b6!2zQWxp4oCZcyBWaWxsYQ!5e0!3m2!1sar!2seg!4v1742152338797!5m2!1sar!2seg", "VIP villa Ali", " 0792807762", 2600.0, "https://www.instagram.com/explore/locations/1762370497115752/vip-villa/" },
                    { 30, "El Galaa Street, behind Omar Effendi, Marsa Matruh, Egypt", "https://www.facebook.com/Adriaticahotel.marsamatruh/", "Hotels/Marsa Matrouh/30.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3407.192693464274!2d27.234511!3d31.3536614!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461fed2b13ff665%3A0x9ad16be5291440b2!2z2YHZhtiv2YIg2KfYr9ix2YrYqtmK2YPYpw!5e0!3m2!1sar!2seg!4v1742152471152!5m2!1sar!2seg", "Adriatica Hotel Marsa Matrouh", "046 4938696", 1570.0, "https://www.instagram.com/explore/locations/948309694/adriatica-hotel-marsa-matruh/" },
                    { 31, "Ras El hekma North Coast, Marsa Matruh, 51512 Marsa Matruh, Egypt", "https://www.facebook.com/MarmaricaBoutiqueCabanas/", "Hotels/Marsa Matrouh/31.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3416.6300059684254!2d27.9300305!3d31.0922173!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14603302ded12bc9%3A0xa167edb8d434215c!2sMarmarica%20Boutique%20Cabanas!5e0!3m2!1sar!2seg!4v1742152936163!5m2!1sar!2seg", "Marmarica Boutique Cabanas - Ras El Hekma - North Coast", "011 00101919", 30500.0, "https://marmarica.com/" },
                    { 32, "P.O Box 51511 - Marsa Matrouh, 51511 Marsa Matruh, Egypt", "https://www.facebook.com/SafirMarsaMatrouhResort/", "Hotels/Marsa Matrouh/32.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3406.531937882072!2d27.2005518!3d31.371893099999998!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461ffb92025d769%3A0x676bfa79fb218aab!2sSafir%20Marsa%20Matrouh%20Resort!5e0!3m2!1sar!2seg!4v1742152993016!5m2!1sar!2seg", "Safir Marsa Matrouh Resort", "012 72409648", 2300.0, "https://www.safirhotels.com/en/press/New-Opening-Safir-Marsa-Matrouh" },
                    { 33, "120 Alexandria - Marsa Matrouh Road Beside Elhamraa Port, 51718 Marsa Matruh, Egypt", "https://www.facebook.com/p/Tolip-Resort-Paradise-New-Alamien-100092546733324/", "Hotels/Marsa Matrouh/33.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3422.778585805699!2d28.8349375!3d30.9208125!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145ffbea0200d795%3A0x22f69e1fe2d16a70!2sTOLIP%20Resort%20Paradise%20New%20Alamein!5e0!3m2!1sar!2seg!4v1742153064059!5m2!1sar!2seg", "Tolip Resort Paradise", "+20 100 981 5908", 7500.0, "https://tolipgroup.com/tolip-resort-paradise-new-alamein/contact-us/" },
                    { 34, "Almaza Bay, 37 km East Mersa Matruh,, Marsa Matruh, Egypt", "https://www.facebook.com/jazalmazabayresorts/", "Hotels/Marsa Matrouh/34.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3412.8144910534843!2d27.5546091!3d31.1981566!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1461dd53f1555555%3A0x50a0b1cb77aa4b0d!2sJAZ%20Almaza%20Beach%20Resort%2C%20Almaza%20Bay!5e0!3m2!1sar!2seg!4v1742153124653!5m2!1sar!2seg", "JAZ Almaza Beach Resort, Almaza Bay", "010 66699942", 3400.0, "https://www.jazhotels.com/hoteldetail/30-egypt-almaza-bay-jaz-almaza-beach-resort" },
                    { 35, "0 km Safaga El Queseir Road Hurghada, 84711, Égypte, 84711 Hurghada, Egypt", "https://www.facebook.com/tuimagiclifekalawy/", "Hotels/Hurghada/35.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3570.273973829099!2d34.0675947!3d26.5113117!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d198b1395a3a5%3A0x8fafdb50b5c09625!2sTUI%20MAGIC%20LIFE%20Kalawy!5e0!3m2!1sar!2seg!4v1742153171217!5m2!1sar!2seg", "TUI MAGIC LIFE Kalawy", "065 3200021", 10000.0, "https://tuimagiclifekalawy.com-hurghada.com/" },
                    { 36, "Sahl Hashish Road, 84521 Hurghada, Egypt", "https://www.facebook.com/SahlHasheesh.de/videos/flow-spectrum-resort-sahl-hasheesh/9498118343552521/", "Hotels/Hurghada/36.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3553.7322551538464!2d33.8794394!3d27.0386252!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x144d7f004762bf8b%3A0x1fc9280a55997817!2sFlow%20Spectrum%20Resort!5e0!3m2!1sar!2seg!4v1742153208474!5m2!1sar!2seg", "Flow Spectrum Resort Sahl Hasheesh", "012 78575677", 4400.0, "https://resortflowspectrumhasheesh.hotelshurghada.com/en/" },
                    { 37, "El Helal District, 84511 Hurghada, Egypt", "https://www.facebook.com/p/Al-Dora-Residence-100067650841951/", "Hotels/Hurghada/37.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3546.5372517674928!2d33.802178!3d27.2650389!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287fdda77e4cb%3A0x2b619ec9710e07f4!2sAl%20Dora%20Residence!5e0!3m2!1sar!2seg!4v1742153239509!5m2!1sar!2seg", "Al Dora Resort All Inclusive Hotel", "011 11167642", 3900.0, "https://resortaldorainclusive.hotelshurghada.com/en/" },
                    { 38, "El Helal District, Hurghada 2, Red Sea Governorate, 84511 Hurghada, Egypt", "https://www.facebook.com/p/Davinciresort-100067030293671/", "Hotels/Hurghada/38.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14187.060345489059!2d33.8203617!3d27.257896!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287e44b1a58cf%3A0x566333cc5ba3f395!2sNew%20DaVinci%20Beach%20%26%20Diving%20Resort!5e0!3m2!1sar!2seg!4v1742153281585!5m2!1sar!2seg", "Davinci Beach Resort", " 653557868 ", 1800.0, "https://da-vinci-beach.hotel-hurghada.com/en/" },
                    { 39, "El-Bahr, 1973706 Hurghada, Egypt", "https://www.facebook.com/p/Geisum-Village-Hurghada-100069093702673/", "Hotels/Hurghada/39.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3546.688336422805!2d33.8214024!3d27.2603024!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145287d92d6287f7%3A0x4abce40efc57c7a!2zTmV3IEdlaXN1bSDZhtmK2Ygg2KzZitiy2YjZhQ!5e0!3m2!1sar!2seg!4v1742153316715!5m2!1sar!2seg", "New Gaisum Resort", "065 3546692", 2300.0, "https://el-geisum-village.hotel-hurghada.com/en/" },
                    { 40, "Moustafa Kamel, Corniche Road Roshdy, Alexandria, Egypt", "https://www.facebook.com/share/14q1Rp793o/", "Hotels/Alexandria/40.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d852.9016871781419!2d29.9440803!3d31.2316227!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c4e610b4e28d%3A0x55e0e76c064a00be!2sTOLIP%20Hotel%20Alexandria!5e0!3m2!1sar!2seg!4v1742153353585!5m2!1sar!2seg", "Tolip", "035419330", 5000.0, "https://tolipgroup.com/tolip-hotel-royal-alexandria/" },
                    { 41, "Corniche Road Sidi Gaber Alexandria Corniche Road Sidi Gaber Alexandria, 21523 Alexandria, Egypt", "https://www.facebook.com/share/1YgyBKhYXQ/", "Hotels/Alexandria/41.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3411.694075064414!2d29.941944999999993!3d31.229204!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c594317c499d%3A0xd8de85f6cd600a22!2sGolden%20Jewel%20Beach%20%26%20Hotel!5e0!3m2!1sar!2seg!4v1742153399218!5m2!1sar!2seg", "Golden Jewel Beach&Hotel", "035442380", 3400.0, "https://www.jewelhotels.net/hotel/golden-jewel-hotel-alexandria" },
                    { 42, "14th May Avenue, Smouha, 21648 Alexandria, Egypt", "https://www.facebook.com/share/1ARavY4jGT/", "Hotels/Alexandria/42.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3412.428921417258!2d29.9603911!3d31.2088441!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5c4976eb3c991%3A0x82c3d973fe60b252!2z2YHZhtiv2YIg2KzYsdin2YbYryDYqNmE2KfYstinINiz2YXZiNit2Kk!5e0!3m2!1sar!2seg!4v1742153437367!5m2!1sar!2seg", "The Grand Plaza Hotel Smouha", "033786100", 2900.0, "https://www.tgphotels.com/" },
                    { 43, "1 Digla Street, Al Ramel Station, Corniche Road, 00203 Alexandria, EgyptAfter booking, all of the property’s details, including telephone and address, are provided in your booking confirmation and your account.", "https://www.facebook.com/share/15EyLh2pvi/", "Hotels/Alexandria/43.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3412.662304893747!2d29.9014263!3d31.2023754!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5db2eca0d7955%3A0x30a0eecda7d20f56!2z2YHZhtiv2YIg2YHYpNin2K8!5e0!3m2!1sar!2seg!4v1742153471487!5m2!1sar!2seg", "Fouad Hotel", "034808308", 1100.0, "https://x.com/FouadResv?fbclid=IwZXh0bgNhZW0CMTEAAR1Kn6p5zx9-H-Ej1e6ggmCT87Yqq5iLaDlZQkii6EnYby1drETYgM33xeg_aem_Jv3QsJFIdeOw0K3uZ1Zrqw" },
                    { 44, "Al Montazah Palace, 99999 Alexandria, Egypt", "https://www.facebook.com/share/15Q5PCjSzD/", "Hotels/Alexandria/44.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3409.5521515111423!2d30.0183078!3d31.2884809!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f5d061fc11582d%3A0x12657103d509ea6c!2z2YHZhtiv2YIg2YfZhNmG2KfZhiDYsdmI2YrYp9mE!5e0!3m2!1sar!2seg!4v1742153525150!5m2!1sar!2seg", "Helnan", "01001710737", 4000.0, "https://www.helnan.com/en/Hotel/helnan-royal-alexandria/?hid=4e692ca5-519f-492f-9a2a-4079789b5877&id=" },
                    { 45, "LUSINDA HOTEL MANAGEMENT BY ZAD, Suez, Egypt", "https://www.facebook.com/lusinda.resort/", "Hotels/Suez/45.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3456.842921639098!2d32.5404515!3d29.9551965!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145625d589fe6b35%3A0x65f93388bc88c3fc!2sLUSINDA%20HOTEL!5e0!3m2!1sar!2seg!4v1742153558885!5m2!1sar!2seg", "LUSINDA", "01201680000", 3700.0, "https://www.instagram.com/lusinda.resort/" },
                    { 46, "25 KM After Ahmed Hamdy Tunnel, Ras Sedr, Egypt", "https://www.facebook.com/mousacoast.egy/", "Hotels/Suez/46.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3460.141684109636!2d32.6574876!3d29.8601875!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14563cf73f05475b%3A0xb3ea0e7664279635!2sMousa%20coast!5e0!3m2!1sar!2seg!4v1742153590564!5m2!1sar!2seg", "Mousa Coast Hotel", "+20226775732", 1800.0, "https://mousacoasthotel.com-egypt.com/" },
                    { 47, "2 Sharie Bursaeid, Suez 43522 Egypt", "https://www.facebook.com/hotel.greenhouse/", "Hotels/Suez/47.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d13826.602232954514!2d32.5425553!3d29.9607284!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1456250ca617e177%3A0x6daa7f828299e94f!2z2YHZhtiv2YIg2KzYsdmK2YYg2YfYp9mI2LM!5e0!3m2!1sar!2seg!4v1742153628730!5m2!1sar!2seg", "Green House", "0623191554", 1000.0, "https://greenhouse.com-egypt.com/" },
                    { 48, "Sharks Bay , 99999 Sharm El Sheikh, Egypt", "https://www.instagram.com/vhotelsharmelsheikh/", "Hotels/Sharm El Sheikh/48.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3524.4965767296762!2d34.3792281!3d27.9480745!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145349c9cc60221b%3A0xb4b82bc015ac6a56!2sV%20Hotel%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153665106!5m2!1sar!2seg", "V Hotel", "0693601091", 7300.0, "https://thevhotelsegypt.com/v-sharm-el-sheikh/" },
                    { 49, "Naama Bay, Sharm El Sheikh, Egypt", "https://www.facebook.com/NovotelSharmElSheikh/,", "Hotels/Sharm El Sheikh/49.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3525.5565569460086!2d34.3286542!3d27.9155784!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533787f83288e7%3A0x12499f16f664fbae!2z2YHZhtiv2YIg2YbZiNmB2YjYqtmK2YQg2LTYsdmFINin2YTYtNmK2K4!5e0!3m2!1sar!2seg!4v1742153698720!5m2!1sar!2seg", "Novotel", "0693600172", 4400.0, "https://all.accor.com/hotel/1715/index.en.shtml" },
                    { 50, "Nabq bay, 11038 Sharm El Sheikh, Egyp", "https://www.facebook.com/albatroslagunavistaresort/", "Hotels/Sharm El Sheikh/50.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3521.4126062109817!2d34.4287806!3d28.0424237!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533bca1528a70f%3A0xc0a3d3a55c1b5fe9!2sPickalbatros%20Laguna%20Vista%20Hotel%20-%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153730808!5m2!1sar!2seg", "Pickalbatros Laguna Vista ", "+20693710121", 8600.0, "https://www.pickalbatros.com/laguna-vista-hotel-sharm-el-sheikh" },
                    { 51, "Om El Seid Cliff, Sharm El Sheikh, Egypt", "https://www.facebook.com/AmphorasHotels/", "Hotels/Sharm El Sheikh/51.jpg", "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d3527.0801943707547!2d34.3172883!3d27.8688068!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x145339f7ec25e6d1%3A0x77f8cfef69e38cc9!2z2YXZhtiq2KzYuSDYtNmI2LHYsiDYo9mF2YHZiNix2KfYsyDYqNmK2KrYtA!5e0!3m2!1sar!2seg!4v1742153763552!5m2!1sar!2seg", "Amphoras", "01223932782", 6400.0, "https://www.amphorashotels.com/amphoras?gad_source=1&gclid=Cj0KCQjwytS-BhCKARIsAMGJyzoXN18tpgCfWuylL776fMQhxIDgxj67v9CRnxk-ZhgA79I5d1RLOmcaAiZREALw_wcB" },
                    { 52, "Naama Bay, 6019 Sharm El Sheikh, Egypt", "https://www.facebook.com/movenpicksharmelsheikh/", "Hotels/Sharm El Sheikh/52.jpg", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3525.6106056334993!2d34.34263598493347!3d27.9139204827069!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14533bb92492a9af%3A0x9b7fa058a25aeac8!2sM%C3%B6venpick%20Sharm%20El%20Sheikh!5e0!3m2!1sar!2seg!4v1742153794348!5m2!1sar!2seg", "Movenpick", "+20693600081", 5700.0, "https://movenpick.accor.com/en/africa/egypt/sharm-el-sheikh/resort-sharm-el-sheikh.html" }
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
