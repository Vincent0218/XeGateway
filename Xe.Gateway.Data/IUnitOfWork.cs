namespace Xe.Gateway.data.Contract
{
    public interface IUnitOfWork
    {
        void Compleate();
        IXeSourceRepository XeSourceRepository { get; }
    }
}
