using System;

namespace XeGateway.Application
{
    public class AuthanticationService : IAuthanticationService
    {
        public bool Authanticate(string UserName, string Password)
        {
          if(UserName == "Paritosh" && Password == "password")
            {
                return true;
            }
            return false;
        }
    }
}
