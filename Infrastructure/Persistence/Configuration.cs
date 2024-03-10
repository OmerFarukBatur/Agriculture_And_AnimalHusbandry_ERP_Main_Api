using Microsoft.Extensions.Configuration;

namespace Persistence
{
    static class Configuration
    {
        static public string ConfigurationString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "./../../Presentation/ETicaretAPI.API"));
                // bu kısımda dosya yolu uzantısı hatası var
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
