using Egyptos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyptos.Infrastructure.Data.Configurations;
internal class TripConfigrution : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        var Trips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                DepartureTime = new DateTime(2025, 7, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 10, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 10, 17, 00, 00),
                Price = 1000,
                AreaId = 1,
                PublicTransportId = 1,
                AvailableSeats = 30
            },
            new Trip
            {
                Id = 2,
                DepartureTime = new DateTime(2025, 7, 11, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 11, 13, 30, 00),
                BackTime = new DateTime(2025, 7, 11, 18, 00, 00),
                Price = 1100,
                AreaId = 2,
                PublicTransportId = 2,
                AvailableSeats = 30 
            },
            new Trip
            {
                Id = 3,
                DepartureTime = new DateTime(2025, 7, 12, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 12, 16, 00, 00),
                BackTime = new DateTime(2025, 7, 12, 20, 00, 00),
                Price = 1200,
                AreaId = 3,
                PublicTransportId = 3,
                AvailableSeats = 30 
            },
            new Trip
            {
                Id = 4,
                DepartureTime = new DateTime(2025, 7, 13, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 13, 17, 30, 00),
                BackTime = new DateTime(2025, 7, 13, 22, 00, 00),
                Price = 1300,
                AreaId = 4,
                PublicTransportId = 4,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 5,
                DepartureTime = new DateTime(2025, 7, 14, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 14, 18, 00, 00),
                BackTime = new DateTime(2025, 7, 14, 23, 00, 00),
                Price = 1400,
                AreaId = 5,
                PublicTransportId = 5,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 6,
                DepartureTime = new DateTime(2025, 7, 15, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 15, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 15, 17, 00, 00),
                Price = 1500,
                AreaId = 6,
                PublicTransportId = 6,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 7,
                DepartureTime = new DateTime(2025, 7, 16, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 16, 13, 30, 00),
                BackTime = new DateTime(2025, 7, 16, 18, 00, 00),
                Price = 1600,
                AreaId = 7,
                PublicTransportId = 7,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 8,
                DepartureTime = new DateTime(2025, 7, 17, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 17, 16, 00, 00),
                BackTime = new DateTime(2025, 7, 17, 20, 00, 00),
                Price = 1700,
                AreaId = 8,
                PublicTransportId = 8,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 9,
                DepartureTime = new DateTime(2025, 7, 18, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 18, 17, 30, 00),
                BackTime = new DateTime(2025, 7, 18, 22, 00, 00),
                Price = 1800,
                AreaId = 9,
                PublicTransportId = 9,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 10,
                DepartureTime = new DateTime(2025, 7, 19, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 19, 18, 00, 00),
                BackTime = new DateTime(2025, 7, 19, 23, 00, 00),
                Price = 1900,
                AreaId = 10,
                PublicTransportId = 10,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 11,
                DepartureTime = new DateTime(2025, 7, 20, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 20, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 20, 17, 00, 00),
                Price = 2000,
                AreaId = 11,
                PublicTransportId = 11,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 12,
                DepartureTime = new DateTime(2025, 7, 21, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 21, 13, 30, 00),
                BackTime = new DateTime(2025, 7, 21, 18, 00, 00),
                Price = 2100,
                AreaId = 12,
                PublicTransportId = 12,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 13,
                DepartureTime = new DateTime(2025, 7, 22, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 22, 16, 00, 00),
                BackTime = new DateTime(2025, 7, 22, 20, 00, 00),
                Price = 2200,
                AreaId = 13,
                PublicTransportId = 13,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 14,
                DepartureTime = new DateTime(2025, 7, 23, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 23, 17, 30, 00),
                BackTime = new DateTime(2025, 7, 23, 22, 00, 00),
                Price = 2300,
                AreaId = 14,
                PublicTransportId = 14,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 15,
                DepartureTime = new DateTime(2025, 7, 24, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 24, 18, 00, 00),
                BackTime = new DateTime(2025, 7, 24, 23, 00, 00),
                Price = 2400,
                AreaId = 15,
                PublicTransportId = 15,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 16,
                DepartureTime = new DateTime(2025, 7, 25, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 25, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 25, 17, 00, 00),
                Price = 2500,
                AreaId = 16,
                PublicTransportId = 16,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 17,
                DepartureTime = new DateTime(2025, 7, 26, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 26, 13, 30, 00),
                BackTime = new DateTime(2025, 7, 26, 18, 00, 00),
                Price = 2600,
                AreaId = 17,
                PublicTransportId = 17,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 18,
                DepartureTime = new DateTime(2025, 7, 27, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 27, 16, 00, 00),
                BackTime = new DateTime(2025, 7, 27, 20, 00, 00),
                Price = 2700,
                AreaId = 18,
                PublicTransportId = 18,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 19,
                DepartureTime = new DateTime(2025, 7, 28, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 7, 28, 17, 30, 00),
                BackTime = new DateTime(2025, 7, 28, 22, 00, 00),
                Price = 2800,
                AreaId = 19,
                PublicTransportId = 19,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 20,
                DepartureTime = new DateTime(2025, 7, 29, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 29, 18, 00, 00),
                BackTime = new DateTime(2025, 7, 29, 23, 00, 00),
                Price = 2900,
                AreaId = 20,
                PublicTransportId = 20,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 21,
                DepartureTime = new DateTime(2025, 7, 30, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 7, 30, 12, 00, 00),
                BackTime = new DateTime(2025, 7, 30, 17, 00, 00),
                Price = 3000,
                AreaId = 21,
                PublicTransportId = 21,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 22,
                DepartureTime = new DateTime(2025, 8, 1, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 1, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 1, 18, 00, 00),
                Price = 3100,
                AreaId = 22,
                PublicTransportId = 22,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 23,
                DepartureTime = new DateTime(2025, 8, 2, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 2, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 2, 20, 00, 00),
                Price = 3200,
                AreaId = 23,
                PublicTransportId = 23,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 24,
                DepartureTime = new DateTime(2025, 8, 3, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 3, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 3, 22, 00, 00),
                Price = 3300,
                AreaId = 24,
                PublicTransportId = 24,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 25,
                DepartureTime = new DateTime(2025, 8, 4, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 4, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 4, 23, 00, 00),
                Price = 3400,
                AreaId = 25,
                PublicTransportId = 25,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 26,
                DepartureTime = new DateTime(2025, 8, 5, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 5, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 5, 17, 00, 00),
                Price = 3500,
                AreaId = 26,
                PublicTransportId = 26,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 27,
                DepartureTime = new DateTime(2025, 8, 6, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 6, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 6, 18, 00, 00),
                Price = 3600,
                AreaId = 27,
                PublicTransportId = 27,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 28,
                DepartureTime = new DateTime(2025, 8, 7, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 7, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 7, 20, 00, 00),
                Price = 3700,
                AreaId = 28,
                PublicTransportId = 28,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 29,
                DepartureTime = new DateTime(2025, 8, 8, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 8, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 8, 22, 00, 00),
                Price = 3800,
                AreaId = 29,
                PublicTransportId = 29,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 30,
                DepartureTime = new DateTime(2025, 8, 9, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 9, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 9, 23, 00, 00),
                Price = 3900,
                AreaId = 30,
                PublicTransportId = 30,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 31,
                DepartureTime = new DateTime(2025, 8, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 10, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 10, 17, 00, 00),
                Price = 4000,
                AreaId = 31,
                PublicTransportId = 31,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 32,
                DepartureTime = new DateTime(2025, 8, 11, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 11, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 11, 18, 00, 00),
                Price = 4100,
                AreaId = 32,
                PublicTransportId = 32,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 33,
                DepartureTime = new DateTime(2025, 8, 12, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 12, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 12, 20, 00, 00),
                Price = 4200,
                AreaId = 33,
                PublicTransportId = 33,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 34,
                DepartureTime = new DateTime(2025, 8, 13, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 13, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 13, 22, 00, 00),
                Price = 4300,
                AreaId = 34,
                PublicTransportId = 34,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 35,
                DepartureTime = new DateTime(2025, 8, 14, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 14, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 14, 23, 00, 00),
                Price = 4400,
                AreaId = 35,
                PublicTransportId = 35,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 36,
                DepartureTime = new DateTime(2025, 8, 15, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 15, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 15, 17, 00, 00),
                Price = 4500,
                AreaId = 36,
                PublicTransportId = 36,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 37,
                DepartureTime = new DateTime(2025, 8, 16, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 16, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 16, 18, 00, 00),
                Price = 4600,
                AreaId = 37,
                PublicTransportId = 37,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 38,
                DepartureTime = new DateTime(2025, 8, 17, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 17, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 17, 20, 00, 00),
                Price = 4700,
                AreaId = 38,
                PublicTransportId = 38,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 39,
                DepartureTime = new DateTime(2025, 8, 18, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 18, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 18, 22, 00, 00),
                Price = 4800,
                AreaId = 39,
                PublicTransportId = 39,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 40,
                DepartureTime = new DateTime(2025, 8, 19, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 19, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 19, 23, 00, 00),
                Price = 4900,
                AreaId = 40,
                PublicTransportId = 40,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 41,
                DepartureTime = new DateTime(2025, 8, 20, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 20, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 20, 17, 00, 00),
                Price = 5000,
                AreaId = 41,
                PublicTransportId = 41,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 42,
                DepartureTime = new DateTime(2025, 8, 21, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 21, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 21, 18, 00, 00),
                Price = 5100,
                AreaId = 42,
                PublicTransportId = 42,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 43,
                DepartureTime = new DateTime(2025, 8, 22, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 22, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 22, 20, 00, 00),
                Price = 5200,
                AreaId = 43,
                PublicTransportId = 43,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 44,
                DepartureTime = new DateTime(2025, 8, 23, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 23, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 23, 22, 00, 00),
                Price = 5300,
                AreaId = 44,
                PublicTransportId = 44,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 45,
                DepartureTime = new DateTime(2025, 8, 24, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 24, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 24, 23, 00, 00),
                Price = 5400,
                AreaId = 45,
                PublicTransportId = 45,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 46,
                DepartureTime = new DateTime(2025, 8, 25, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 25, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 25, 17, 00, 00),
                Price = 5500,
                AreaId = 46,
                PublicTransportId = 46,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 47,
                DepartureTime = new DateTime(2025, 8, 26, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 26, 13, 30, 00),
                BackTime = new DateTime(2025, 8, 26, 18, 00, 00),
                Price = 5600,
                AreaId = 47,
                PublicTransportId = 47,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 48,
                DepartureTime = new DateTime(2025, 8, 27, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 27, 16, 00, 00),
                BackTime = new DateTime(2025, 8, 27, 20, 00, 00),
                Price = 5700,
                AreaId = 48,
                PublicTransportId = 48,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 49,
                DepartureTime = new DateTime(2025, 8, 28, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 8, 28, 17, 30, 00),
                BackTime = new DateTime(2025, 8, 28, 22, 00, 00),
                Price = 5800,
                AreaId = 49,
                PublicTransportId = 49,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 50,
                DepartureTime = new DateTime(2025, 8, 29, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 29, 18, 00, 00),
                BackTime = new DateTime(2025, 8, 29, 23, 00, 00),
                Price = 5900,
                AreaId = 50,
                PublicTransportId = 50,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 51,
                DepartureTime = new DateTime(2025, 8, 30, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 8, 30, 12, 00, 00),
                BackTime = new DateTime(2025, 8, 30, 17, 00, 00),
                Price = 6000,
                AreaId = 51,
                PublicTransportId = 51,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 52,
                DepartureTime = new DateTime(2025, 9, 1, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 9, 1, 13, 30, 00),
                BackTime = new DateTime(2025, 9, 1, 18, 00, 00),
                Price = 6100,
                AreaId = 52,
                PublicTransportId = 52,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 53,
                DepartureTime = new DateTime(2025, 9, 2, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 2, 16, 00, 00),
                BackTime = new DateTime(2025, 9, 2, 20, 00, 00),
                Price = 6200,
                AreaId = 53,
                PublicTransportId = 53,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 54,
                DepartureTime = new DateTime(2025, 9, 3, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 9, 3, 17, 30, 00),
                BackTime = new DateTime(2025, 9, 3, 22, 00, 00),
                Price = 6300,
                AreaId = 54,
                PublicTransportId = 54,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 55,
                DepartureTime = new DateTime(2025, 9, 4, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 4, 18, 00, 00),
                BackTime = new DateTime(2025, 9, 4, 23, 00, 00),
                Price = 6400,
                AreaId = 55,
                PublicTransportId = 55,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 56,
                DepartureTime = new DateTime(2025, 9, 5, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 5, 12, 00, 00),
                BackTime = new DateTime(2025, 9, 5, 17, 00, 00),
                Price = 6500,
                AreaId = 56,
                PublicTransportId = 56,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 57,
                DepartureTime = new DateTime(2025, 9, 6, 11, 30, 00),
                ArrivalTime = new DateTime(2025, 9, 6, 13, 30, 00),
                BackTime = new DateTime(2025, 9, 6, 18, 00, 00),
                Price = 6600,
                AreaId = 57,
                PublicTransportId = 57,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 58,
                DepartureTime = new DateTime(2025, 9, 7, 14, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 7, 16, 00, 00),
                BackTime = new DateTime(2025, 9, 7, 20, 00, 00),
                Price = 6700,
                AreaId = 58,
                PublicTransportId = 58,
            AvailableSeats = 30 },
            new Trip
            {
                Id = 59,
                DepartureTime = new DateTime(2025, 9, 8, 15, 30, 00),
                ArrivalTime = new DateTime(2025, 9, 8, 17, 30, 00),
                BackTime = new DateTime(2025, 9, 8, 22, 00, 00),
                Price = 6800,
                AreaId = 59,
                PublicTransportId = 59,
                AvailableSeats = 30 
            },
            new Trip
            {
                Id = 60,
                DepartureTime = new DateTime(2025, 9, 9, 16, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 9, 18, 00, 00),
                BackTime = new DateTime(2025, 9, 9, 23, 00, 00),
                Price = 6900,
                AreaId = 60,
                PublicTransportId = 60,
                AvailableSeats = 30
            },
            new Trip
            {
                Id = 61,
                DepartureTime = new DateTime(2025, 9, 12, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 10, 33, 00),
                BackTime = new DateTime(2025, 9, 12, 17, 20, 00),
                Price = 7392,
                AreaId = 61,
                PublicTransportId = 61,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 62,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 11, 24, 00),
                BackTime = new DateTime(2025, 9, 10, 19, 25, 00),
                Price = 6803,
                AreaId = 62,
                PublicTransportId = 62,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 63,
                DepartureTime = new DateTime(2025, 9, 12, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 14, 08, 00),
                BackTime = new DateTime(2025, 9, 12, 23, 20, 00),
                Price = 7165,
                AreaId = 63,
                PublicTransportId = 63,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 64,
                DepartureTime = new DateTime(2025, 9, 12, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 11, 58, 00),
                BackTime = new DateTime(2025, 9, 12, 19, 40, 00),
                Price = 6710,
                AreaId = 64,
                PublicTransportId = 64,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 65,
                DepartureTime = new DateTime(2025, 9, 11, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 12, 31, 00),
                BackTime = new DateTime(2025, 9, 11, 18, 52, 00),
                Price = 7219,
                AreaId = 65,
                PublicTransportId = 65,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 66,
                DepartureTime = new DateTime(2025, 9, 12, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 13, 47, 00),
                BackTime = new DateTime(2025, 9, 12, 19, 26, 00),
                Price = 7091,
                AreaId = 66,
                PublicTransportId = 66,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 67,
                DepartureTime = new DateTime(2025, 9, 13, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 14, 17, 00),
                BackTime = new DateTime(2025, 9, 13, 23, 24, 00),
                Price = 6882,
                AreaId = 67,
                PublicTransportId = 67,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 68,
                DepartureTime = new DateTime(2025, 9, 11, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 10, 27, 00),
                BackTime = new DateTime(2025, 9, 11, 16, 52, 00),
                Price = 6827,
                AreaId = 68,
                PublicTransportId = 68,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 69,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 11, 10, 00),
                BackTime = new DateTime(2025, 9, 10, 17, 27, 00),
                Price = 6812,
                AreaId = 69,
                PublicTransportId = 69,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 70,
                DepartureTime = new DateTime(2025, 9, 11, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 10, 54, 00),
                BackTime = new DateTime(2025, 9, 11, 17, 24, 00),
                Price = 6833,
                AreaId = 70,
                PublicTransportId = 70,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 71,
                DepartureTime = new DateTime(2025, 9, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 13, 30, 00),
                BackTime = new DateTime(2025, 9, 10, 19, 05, 00),
                Price = 7343,
                AreaId = 71,
                PublicTransportId = 71,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 72,
                DepartureTime = new DateTime(2025, 9, 10, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 30, 00),
                BackTime = new DateTime(2025, 9, 10, 20, 51, 00),
                Price = 6912,
                AreaId = 72,
                PublicTransportId = 72,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 73,
                DepartureTime = new DateTime(2025, 9, 13, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 12, 30, 00),
                BackTime = new DateTime(2025, 9, 13, 22, 31, 00),
                Price = 7140,
                AreaId = 73,
                PublicTransportId = 73,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 74,
                DepartureTime = new DateTime(2025, 9, 13, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 12, 05, 00),
                BackTime = new DateTime(2025, 9, 13, 21, 31, 00),
                Price = 7012,
                AreaId = 74,
                PublicTransportId = 74,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 75,
                DepartureTime = new DateTime(2025, 9, 13, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 11, 11, 00),
                BackTime = new DateTime(2025, 9, 13, 21, 38, 00),
                Price = 6931,
                AreaId = 75,
                PublicTransportId = 75,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 76,
                DepartureTime = new DateTime(2025, 9, 11, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 10, 30, 00),
                BackTime = new DateTime(2025, 9, 11, 17, 37, 00),
                Price = 6876,
                AreaId = 76,
                PublicTransportId = 76,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 77,
                DepartureTime = new DateTime(2025, 9, 11, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 12, 00, 00),
                BackTime = new DateTime(2025, 9, 11, 21, 53, 00),
                Price = 7234,
                AreaId = 77,
                PublicTransportId = 77,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 78,
                DepartureTime = new DateTime(2025, 9, 12, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 14, 13, 00),
                BackTime = new DateTime(2025, 9, 12, 23, 49, 00),
                Price = 7163,
                AreaId = 78,
                PublicTransportId = 78,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 81,
                DepartureTime = new DateTime(2025, 9, 10, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 07, 00),
                BackTime = new DateTime(2025, 9, 10, 19, 50, 00),
                Price = 6965,
                AreaId = 81,
                PublicTransportId = 81,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 82,
                DepartureTime = new DateTime(2025, 9, 10, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 13, 52, 00),
                BackTime = new DateTime(2025, 9, 10, 19, 35, 00),
                Price = 6744,
                AreaId = 82,
                PublicTransportId = 82,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 83,
                DepartureTime = new DateTime(2025, 9, 12, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 10, 09, 00),
                BackTime = new DateTime(2025, 9, 12, 20, 59, 00),
                Price = 6950,
                AreaId = 83,
                PublicTransportId = 83,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 84,
                DepartureTime = new DateTime(2025, 9, 10, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 08, 00),
                BackTime = new DateTime(2025, 9, 10, 17, 06, 00),
                Price = 7366,
                AreaId = 84,
                PublicTransportId = 84,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 85,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 10, 29, 00),
                BackTime = new DateTime(2025, 9, 10, 20, 48, 00),
                Price = 7109,
                AreaId = 85,
                PublicTransportId = 85,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 86,
                DepartureTime = new DateTime(2025, 9, 13, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 10, 57, 00),
                BackTime = new DateTime(2025, 9, 13, 17, 13, 00),
                Price = 7193,
                AreaId = 86,
                PublicTransportId = 86,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 87,
                DepartureTime = new DateTime(2025, 9, 11, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 13, 31, 00),
                BackTime = new DateTime(2025, 9, 11, 19, 40, 00),
                Price = 6932,
                AreaId = 87,
                PublicTransportId = 87,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 88,
                DepartureTime = new DateTime(2025, 9, 13, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 13, 45, 00),
                BackTime = new DateTime(2025, 9, 13, 19, 48, 00),
                Price = 7242,
                AreaId = 88,
                PublicTransportId = 88,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 89,
                DepartureTime = new DateTime(2025, 9, 12, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 11, 38, 00),
                BackTime = new DateTime(2025, 9, 12, 17, 11, 00),
                Price = 6967,
                AreaId = 89,
                PublicTransportId = 89,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 90,
                DepartureTime = new DateTime(2025, 9, 11, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 14, 12, 00),
                BackTime = new DateTime(2025, 9, 11, 19, 03, 00),
                Price = 7114,
                AreaId = 90,
                PublicTransportId = 90,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 91,
                DepartureTime = new DateTime(2025, 9, 11, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 12, 37, 00),
                BackTime = new DateTime(2025, 9, 11, 20, 42, 00),
                Price = 7236,
                AreaId = 91,
                PublicTransportId = 91,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 92,
                DepartureTime = new DateTime(2025, 9, 13, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 12, 54, 00),
                BackTime = new DateTime(2025, 9, 13, 22, 45, 00),
                Price = 6739,
                AreaId = 92,
                PublicTransportId = 92,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 93,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 11, 19, 00),
                BackTime = new DateTime(2025, 9, 10, 17, 51, 00),
                Price = 6953,
                AreaId = 93,
                PublicTransportId = 93,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 94,
                DepartureTime = new DateTime(2025, 9, 12, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 12, 23, 00),
                BackTime = new DateTime(2025, 9, 12, 18, 20, 00),
                Price = 6817,
                AreaId = 94,
                PublicTransportId = 94,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 95,
                DepartureTime = new DateTime(2025, 9, 13, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 10, 41, 00),
                BackTime = new DateTime(2025, 9, 13, 19, 29, 00),
                Price = 6783,
                AreaId = 95,
                PublicTransportId = 95,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 96,
                DepartureTime = new DateTime(2025, 9, 12, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 13, 31, 00),
                BackTime = new DateTime(2025, 9, 12, 23, 37, 00),
                Price = 7277,
                AreaId = 96,
                PublicTransportId = 96,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 97,
                DepartureTime = new DateTime(2025, 9, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 13, 01, 00),
                BackTime = new DateTime(2025, 9, 10, 21, 29, 00),
                Price = 7315,
                AreaId = 97,
                PublicTransportId = 97,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 98,
                DepartureTime = new DateTime(2025, 9, 10, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 07, 00),
                BackTime = new DateTime(2025, 9, 10, 20, 48, 00),
                Price = 6833,
                AreaId = 98,
                PublicTransportId = 98,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 99,
                DepartureTime = new DateTime(2025, 9, 12, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 12, 10, 00),
                BackTime = new DateTime(2025, 9, 12, 18, 06, 00),
                Price = 6802,
                AreaId = 99,
                PublicTransportId = 99,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 100,
                DepartureTime = new DateTime(2025, 9, 13, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 14, 10, 00),
                BackTime = new DateTime(2025, 9, 13, 22, 21, 00),
                Price = 7249,
                AreaId = 100,
                PublicTransportId = 100,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 101,
                DepartureTime = new DateTime(2025, 9, 12, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 10, 53, 00),
                BackTime = new DateTime(2025, 9, 12, 16, 47, 00),
                Price = 6728,
                AreaId = 101,
                PublicTransportId = 101,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 102,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 11, 07, 00),
                BackTime = new DateTime(2025, 9, 10, 16, 13, 00),
                Price = 7270,
                AreaId = 102,
                PublicTransportId = 102,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 103,
                DepartureTime = new DateTime(2025, 9, 11, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 13, 44, 00),
                BackTime = new DateTime(2025, 9, 11, 20, 26, 00),
                Price = 6938,
                AreaId = 103,
                PublicTransportId = 103,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 104,
                DepartureTime = new DateTime(2025, 9, 12, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 10, 14, 00),
                BackTime = new DateTime(2025, 9, 12, 16, 09, 00),
                Price = 7044,
                AreaId = 104,
                PublicTransportId = 104,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 105,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 10, 16, 00),
                BackTime = new DateTime(2025, 9, 10, 19, 20, 00),
                Price = 7075,
                AreaId = 105,
                PublicTransportId = 105,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 106,
                DepartureTime = new DateTime(2025, 9, 10, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 10, 44, 00),
                BackTime = new DateTime(2025, 9, 10, 17, 54, 00),
                Price = 6846,
                AreaId = 106,
                PublicTransportId = 106,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 107,
                DepartureTime = new DateTime(2025, 9, 13, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 12, 32, 00),
                BackTime = new DateTime(2025, 9, 13, 21, 52, 00),
                Price = 6942,
                AreaId = 107,
                PublicTransportId = 107,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 108,
                DepartureTime = new DateTime(2025, 9, 12, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 11, 04, 00),
                BackTime = new DateTime(2025, 9, 12, 19, 53, 00),
                Price = 6825,
                AreaId = 108,
                PublicTransportId = 108,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 109,
                DepartureTime = new DateTime(2025, 9, 10, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 13, 14, 00),
                BackTime = new DateTime(2025, 9, 10, 22, 37, 00),
                Price = 7046,
                AreaId = 109,
                PublicTransportId = 109,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 110,
                DepartureTime = new DateTime(2025, 9, 10, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 14, 21, 00),
                BackTime = new DateTime(2025, 9, 10, 22, 35, 00),
                Price = 6862,
                AreaId = 110,
                PublicTransportId = 110,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 111,
                DepartureTime = new DateTime(2025, 9, 11, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 13, 11, 00),
                BackTime = new DateTime(2025, 9, 11, 18, 14, 00),
                Price = 7111,
                AreaId = 111,
                PublicTransportId = 111,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 112,
                DepartureTime = new DateTime(2025, 9, 13, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 11, 36, 00),
                BackTime = new DateTime(2025, 9, 13, 17, 36, 00),
                Price = 6876,
                AreaId = 112,
                PublicTransportId = 112,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 113,
                DepartureTime = new DateTime(2025, 9, 10, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 13, 49, 00),
                BackTime = new DateTime(2025, 9, 10, 21, 53, 00),
                Price = 7315,
                AreaId = 113,
                PublicTransportId = 113,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 114,
                DepartureTime = new DateTime(2025, 9, 12, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 12, 15, 00),
                BackTime = new DateTime(2025, 9, 12, 20, 59, 00),
                Price = 7214,
                AreaId = 114,
                PublicTransportId = 114,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 115,
                DepartureTime = new DateTime(2025, 9, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 30, 00),
                BackTime = new DateTime(2025, 9, 10, 18, 19, 00),
                Price = 6940,
                AreaId = 115,
                PublicTransportId = 115,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 116,
                DepartureTime = new DateTime(2025, 9, 12, 11, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 13, 21, 00),
                BackTime = new DateTime(2025, 9, 12, 21, 19, 00),
                Price = 7192,
                AreaId = 116,
                PublicTransportId = 116,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 117,
                DepartureTime = new DateTime(2025, 9, 11, 08, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 11, 02, 00),
                BackTime = new DateTime(2025, 9, 11, 20, 24, 00),
                Price = 7155,
                AreaId = 117,
                PublicTransportId = 117,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 118,
                DepartureTime = new DateTime(2025, 9, 13, 09, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 13, 12, 06, 00),
                BackTime = new DateTime(2025, 9, 13, 19, 20, 00),
                Price = 6988,
                AreaId = 118,
                PublicTransportId = 118,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 119,
                DepartureTime = new DateTime(2025, 9, 11, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 11, 13, 10, 00),
                BackTime = new DateTime(2025, 9, 11, 18, 26, 00),
                Price = 7329,
                AreaId = 119,
                PublicTransportId = 119,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 120,
                DepartureTime = new DateTime(2025, 9, 12, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 12, 11, 00),
                BackTime = new DateTime(2025, 9, 12, 18, 20, 00),
                Price = 7358,
                AreaId = 120,
                PublicTransportId = 120,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 121,
                DepartureTime = new DateTime(2025, 9, 12, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 12, 12, 12, 00),
                BackTime = new DateTime(2025, 9, 12, 20, 52, 00),
                Price = 6851,
                AreaId = 121,
                PublicTransportId = 121,
                AvailableSeats = 30
            },

            new Trip
            {
                Id = 122,
                DepartureTime = new DateTime(2025, 9, 10, 10, 00, 00),
                ArrivalTime = new DateTime(2025, 9, 10, 12, 04, 00),
                BackTime = new DateTime(2025, 9, 10, 22, 01, 00),
                Price = 7308,
                AreaId = 122,
                PublicTransportId = 122,
                AvailableSeats = 30
            }

        };
        builder.HasData(Trips);
    }
}