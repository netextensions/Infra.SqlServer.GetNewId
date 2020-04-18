using Microsoft.EntityFrameworkCore;

namespace NetExtensions
{

    public class BusinessIdContext : DbContext
    {
        public DbSet<BusinessIds> BusinessIds { get; set; }
    }
}
