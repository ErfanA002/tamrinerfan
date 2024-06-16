using tamrinerfan.Core.Application.Services;
using tamrinerfan.Core.Domain.IRepositorys;
using tamrinerfan.Core.Domain.IServices;
using tamrinerfan.Infra.Efsql.Repositorys;
namespace tamrinerfan.IOC
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
        }
    }
}
