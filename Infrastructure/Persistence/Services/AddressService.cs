using Application.Abstractions.Services;
using Application.DTOs.City;
using Application.Features.Commands.City.CreateCity;
using Application.Features.Queries.City.GetAllCities;
using Application.Repositories.City;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class AddressService : IAddressService
    {
        public readonly ICityReadRepository _cityReadRepository;
        public readonly ICityWriteRepository _cityWriteRepository;

        public AddressService(ICityReadRepository cityReadRepository, ICityWriteRepository cityWriteRepository)
        {
            _cityReadRepository = cityReadRepository;
            _cityWriteRepository = cityWriteRepository;
        }



        #region City
        public async Task<CreateCityCommandResponse> CreateCityAsync(CreateCityCommandRequest request)
        {
          CreateCityDto? city   = await _cityReadRepository.GetAll().Where(x=> x.CityName.Trim().ToLower() == request.CityName.Trim().ToLower() || x.CityName.Trim().ToUpper() == request.CityName.Trim().ToUpper()).Select(x=> new CreateCityDto()
          { 
              CityName = x.CityName,
              CreatedDate = x.CreatedDate,
              Id = x.Id,
              Status = x.Status,
              UpdatedDate = x.UpdatedDate
          }).FirstOrDefaultAsync();

            if (city != null)
            {
                city.Status = true;
                _cityWriteRepository.Update(new()
                {
                    Id = city.Id,
                    CityName = city.CityName,
                    CreatedDate = city.CreatedDate,
                    Status = city.Status,
                    UpdatedDate = DateTime.UtcNow
                });

                await _cityWriteRepository.SaveAsync();

                return new()
                {
                    Message = "Güncelleme işlemi başarıyla yapılmıştır.",
                    Status = true
                };
            }

            await _cityWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                CityName = request.CityName,
                CreatedDate = DateTime.UtcNow,
                Status = true,
                UpdatedDate = DateTime.UtcNow
            });

            await _cityWriteRepository.SaveAsync();

            return new()
            {
                Message = "Kayıt işlemi başarıyla yapılmıştır.",
                Status = true
            };

        }

        public async Task<GetAllCitiesCommandResponse> GetAllCitiesAsync(GetAllCitiesCommandRequest request)
        {
            List<GetAllCitiesDto> getAllCitiesDtos = await _cityReadRepository.GetAll().Select(x=> new GetAllCitiesDto { Id = x.Id, CityName = x.CityName}).ToListAsync();
            return new() 
            {
                GetAllCities = getAllCitiesDtos
            };
        }

        #endregion
    }
}
