using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NetExtensions;

namespace Infra.SqlServer.GetNewId
{
    public class GetNewId : ContextHandler<BusinessIdContext> 
    {
         public GetNewId(ILogger<GetNewId> logger, DbContextOptions<BusinessIdContext> options) : base(logger, options)
        {
        }
 
         public async Task<long> GetAsync(CancellationToken token)
        {
            return await ExecuteSaveAsync(async c =>
            {
                var newId = await c.BusinessIds.Where(x => !x.Used).FirstAsync(token);
                 newId.Used = true;
                newId.Activated = DateTime.UtcNow;
                return newId.BusinessId;
            });
        }
    }
}
