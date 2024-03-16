using Application.Repositories.City;
using Persistence.Contexts;
using C = Domain.Entities;

namespace Persistence.Repositories.City
{
    public class CityWriteRepository : WriteRepository<C.City>,ICityWriteRepository
    {
        public CityWriteRepository(AgricultureAndAnimalHusbandryWebAPIDbContext context) : base(context)
        {
        }

    }
}
