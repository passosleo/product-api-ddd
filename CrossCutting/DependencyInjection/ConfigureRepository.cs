using Data.Context;
using Data.Repository;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            //serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            var connectionString = "Server=localhost;Port=3360;Database=WEB_API;Uid=root;Pwd=root";
            
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)))
            );
        }
    }
}
