
using System.Collections.Generic;

using System;
using XeGateWay.Domain;

namespace XeGateway.ApplicationManager
{
    public interface ISourceManager
    {
        IEnumerable<XeGatewaySource> GetSource();
        XeGatewaySource GetSourceById(Int64 Id);

        void UpdateSource(XeGatewaySource update);
    }
}
