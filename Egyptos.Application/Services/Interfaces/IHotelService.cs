using Egyptos.Application.Contracts.Hotels;
using Egyptos.Application.Contracts.Transport.TransportTypes;

namespace Egyptos.Application.Services.Interfaces;

public interface IHotelService
{
    Task<Result<List<HotelResponse>>> GetAllAsync();
    Task<Result<HotelResponse>> GetAsync(int id);
    Task<Result<HotelResponse>> CreateAsync(HotelRequest request);
    Task<Result> UpdateAsync(int id, HotelRequest request);
    Task<Result> DeleteAsync(int id);




}
