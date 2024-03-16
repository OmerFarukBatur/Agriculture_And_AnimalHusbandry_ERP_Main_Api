using Application.Repositories.City;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using C = Domain.Entities;

namespace Persistence.Repositories.City
{
    public class CityReadRepository : ReadRepository<C.City>, ICityReadRepository
    {
        public CityReadRepository(AgricultureAndAnimalHusbandryWebAPIDbContext context) : base(context)
        {
        }
    }
}
