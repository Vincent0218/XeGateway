using System.Data.Entity;
using XeGateWay.Domain;

namespace XeGateway.Data.EFRepository
{
    public interface ISqlDBContext
    {
        DbSet<XeGatewaySource> Source { get; set; }
    }
}