using Domain.Entities;
using Domain.Entities.Common;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class AgricultureAndAnimalHusbandryWebAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AgricultureAndAnimalHusbandryWebAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Endpoint> Endpoints { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<PlantingSupport> PlantingSupports { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPlanted> ProductPlanteds { get; set; }
        public DbSet<ProductRecommended> ProductRecommendeds { get; set; }
        public DbSet<SoilAnalysis> SoilAnalyses { get; set; }
        public DbSet<SupportCategory> SupportCategories { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Village> Villages { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder); // Bunun çağırılma sebebi IdentityDbContext dekiyle karıştığı için base den geleni kullanmak isteğimizi belirtiyoruz.
        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker: Entityler üzerinden yapılan değişiklikleri ya da yeni eklenen verinin yakalanmasını sağlayan propertdir.
            //Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.
            var datas = ChangeTracker
                .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
