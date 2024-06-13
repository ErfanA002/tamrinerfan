using tamrinerfan.Core.Application;
using tamrinerfan.Core.DomainServices;
using tamrinerfan.Core.IRepositorys;
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
