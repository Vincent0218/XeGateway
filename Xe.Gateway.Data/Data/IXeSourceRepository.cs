using System.Collections.Generic;
using XeGateWay.Domain;
using System;

namespace Xe.Gateway.data.Contract
{
    public interface IXeSourceRepository
    {
        void Add(XeGatewaySource src);
        XeGatewaySource Get(Int64 Id);
        IEnumerable<XeGatewaySource> GetAll();
        void Remove(XeGatewaySource src);
        void Update(XeGatewaySource src);
        XeGatewaySource GetByName(string name);
    }
}
