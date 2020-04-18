using Microsoft.Extensions.DependencyInjection;

namespace NetExtensions
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