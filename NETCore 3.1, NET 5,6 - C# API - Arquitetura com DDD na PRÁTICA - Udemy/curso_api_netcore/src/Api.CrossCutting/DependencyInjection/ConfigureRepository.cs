
using Api.Data.Context;
using Api.Data.Implemetations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceColletion) {
            serviceColletion.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceColletion.AddScoped<IUserRepository, UserImplementation>();
            serviceColletion.AddDbContext<MyContext>(options => options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=thelord2411"));
        }
    }
}
