using System.Collections.Generic;
using XeGateWay.Domain;
using System;

namespace Xe.Gateway.data.Contract
{
    public interface IXeSourceRepository
    {
        void Add(XeGatewaySource src);
        XeGatewaySource get(Int64 Id);
        IEnumerable<XeGatewaySource> getAll();
        void Remove(XeGatewaySource src);
    }
}
