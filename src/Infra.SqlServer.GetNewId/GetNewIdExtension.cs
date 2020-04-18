using Microsoft.Extensions.DependencyInjection;
using NetExtensions;

namespace Infra.SqlServer.GetNewId
{
    public static class GetNewIdExtension
    {
        public static IServiceCollection AddGetNewId(this IServiceCollection services, string connectionString)
        {
            services.AddSqlServerDb<BusinessIdContext>(connectionString);
            return services;
        } 
    }
}