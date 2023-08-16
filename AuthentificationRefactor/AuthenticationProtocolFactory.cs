using AuthentificationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactor
{
    public class AuthenticationProtocolFactory
    {
       private  IAuthentication _authenticationProtocol;
        //public AuthenticationProtocolFactory() { }
        public IAuthentication InstantiateProtocol(AuthenticationProtocolEnum protocolType)
        {
          
            if (protocolType==AuthenticationProtocolEnum.OAUTH)
                { _authenticationProtocol = new OAuth();
                Console.WriteLine("creating an Oauth Instance");
            }
            if (protocolType==AuthenticationProtocolEnum.JWT)
            { 
                 JWT _jwt= new JWT();
                _authenticationProtocol = new JWTAdapter(_jwt);
                Console.WriteLine("creating a JWT Instance");
            }
            
           return _authenticationProtocol;
        }
    }
}
