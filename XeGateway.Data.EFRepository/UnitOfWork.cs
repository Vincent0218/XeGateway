using System;
using Xe.Gateway.data.Contract;

namespace XeGateway.Data.EFRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlDBContext _context;
        
        public IXeSourceRepository XeSourceRepository { get; private set; }

        public UnitOfWork(SqlDBContext context)
        {
            _context = context;
            XeSourceRepository = new XeSourceRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Compleate()
        {
            _context.SaveChanges();
        }
    }
}