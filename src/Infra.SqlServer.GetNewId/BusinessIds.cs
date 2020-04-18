using System;

namespace Infra.SqlServer.GetNewId
{
    public class BusinessIds
    {
        public int Id { get; set; }
        public long BusinessId { get; set; }
        public bool Used { get; set; }
        public DateTime Activated { get; set; }

    }
}