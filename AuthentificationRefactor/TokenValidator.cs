using AuthenticationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationRefactor
{
    public  class TokenValidator:ITokenValidator
    {
        private readonly AuthenticationProtocolFactory protocolFactory;
          string _validToken = "";

        

        public TokenValidator(AuthenticationProtocolFactory protocolFactory)
        {
            this.protocolFactory = protocolFactory;
        }
        public string ValidateToken(string token,   AuthenticationProtocolEnum protocolType,string urlapi)
        {
            IAuthentication _authenticationProtocol;
            _authenticationProtocol = protocolFactory.InstantiateProtocol(protocolType);
            if (token == null)
            {
            _validToken = _authenticationProtocol.GetToken();
            }

            else if (_authenticationProtocol.IsTokenValid(token, urlapi) == false)
            {
             
                _validToken = _authenticationProtocol.GetToken();
            }
            else _validToken = token;
            Console.WriteLine(" after Token Validation : " + _validToken);
            return _validToken;
        }
    }
}
