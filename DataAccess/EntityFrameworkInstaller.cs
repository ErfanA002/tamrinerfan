using Microsoft.EntityFrameworkCore;
namespace tamrinerfan.DataAccess;
public static class EntityFrameworkInstaller
{
    public static IServiceCollection AddDataAccess(this IServiceCollection services, string cnnString)
    {
        services.AddDbContext<TamrinErfanDbContext>(options =>
        {
            options.UseSqlServer(cnnString);
        });

        return services;
    }
}
