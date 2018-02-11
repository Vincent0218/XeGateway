using System.Data.Entity;
using XeGateWay.Domain;

namespace XeGateway.Data.EFRepository
{
    public class SqlDBContext : DbContext
    {
        public DbSet<XeGatewaySource> Source { get; set; }
    }
}
