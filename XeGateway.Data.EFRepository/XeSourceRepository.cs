﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Xe.Gateway.data.Contract;
using XeGateWay.Domain;

namespace XeGateway.Data.EFRepository
{
    public class XeSourceRepository : IXeSourceRepository
    {
        private readonly SqlDBContext _ctx;   
        public XeSourceRepository(SqlDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(XeGatewaySource src)
        {
            _ctx.Source.Add(src);
        }

        public XeGatewaySource Get(Int64 id)
        {
           return _ctx.Source.SingleOrDefault(x => x.Id == id);
        }
        public XeGatewaySource GetByName(string name)
        {
            return _ctx.Source.SingleOrDefault(x => x.Name == name);
        }

        public IEnumerable<XeGatewaySource> GetAll()
        {
          return  _ctx.Source.ToList();
        }

        public void Remove(XeGatewaySource src)
        {
            throw new NotImplementedException();
        }
        public void Update(XeGatewaySource src)
        {
            _ctx.Entry(src).State = EntityState.Modified;
            
        }
    }
}
