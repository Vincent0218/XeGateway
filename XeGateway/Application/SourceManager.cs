using System;
using System.Collections.Generic;
using Xe.Gateway.data.Contract;
using XeGateway.Data.EFRepository;
using XeGateWay.Domain;

namespace XeGateway.ApplicationManager
{
    /// <summary>
    /// 
    /// </summary>
    public class SourceManager : ISourceManager
    {

        private readonly IUnitOfWork _unitOfWork;


        
        public SourceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;//new UnitOfWork(new SqlDBContext());
        }
        public IEnumerable<XeGatewaySource> GetSource()
        {
            return _unitOfWork.XeSourceRepository.getAll();
        }

        public XeGatewaySource GetSourceById(Int64 Id)
        {
            return _unitOfWork.XeSourceRepository.get(Id);
        }

        public void UpdateSource(XeGatewaySource Update)
        {
            var source = _unitOfWork.XeSourceRepository.get(Update.Id);
            source = Update;
          
            _unitOfWork.Compleate();
        }



    }
}
