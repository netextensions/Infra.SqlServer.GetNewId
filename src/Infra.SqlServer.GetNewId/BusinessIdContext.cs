using Microsoft.EntityFrameworkCore;

namespace Infra.SqlServer.GetNewId
{

    public class BusinessIdContext : DbContext
    {
        public DbSet<BusinessIds> BusinessIds { get; set; }
    }
}
