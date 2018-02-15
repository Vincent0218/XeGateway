using System.Data.Entity;
using XeGateWay.Domain;

namespace XeGateway.Data.EFRepository
{
    public class SqlDBContext : DbContext, ISqlDBContext
    {
        public DbSet<XeGatewaySource> Source { get; set; }
    }
}
