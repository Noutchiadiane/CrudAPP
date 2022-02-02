using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrudAPP.DAL
{
    public static class DalDiContainer
    {
        public static IServiceCollection AddDALScoped(this IServiceCollection services, IConfiguration configuration)
        {
           return services.AddDbContext<RabbitmqContext>(opts =>
           opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")
                    )
              );
        }
           
    }
}
