namespace XeGateway.Application
{
    interface IAuthanticationService
    {
        bool Authanticate(string UserName, string Password);
    }
}
