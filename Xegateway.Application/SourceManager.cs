using System;
using System.Collections.Generic;
using Xe.Gateway.data.Contract;
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
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<XeGatewaySource> GetSource()
        {
            return _unitOfWork.XeSourceRepository.GetAll();
        }

        public XeGatewaySource GetSourceById(Int64 Id)
        {
            return _unitOfWork.XeSourceRepository.Get(Id);
        }
        public XeGatewaySource GetSourceByName(string name)
        {
            return _unitOfWork.XeSourceRepository.GetByName(name);
        }

        public void AddSource(XeGatewaySource source)
        {
             _unitOfWork.XeSourceRepository.Add(source);
            _unitOfWork.Compleate();
        }

        public void UpdateSource(XeGatewaySource update)
        {
            _unitOfWork.XeSourceRepository.Update(update);
            _unitOfWork.Compleate();
        }



    }
}
