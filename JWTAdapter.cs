using AuthentificationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactor
{
    public class JWTAdapter : IAuthentication
    {
        private readonly JWT _jwt;

       

        public JWTAdapter(JWT _jwt) {
            this._jwt = _jwt;
        }
        public string GetToken()
        {
            return _jwt.GetTokenJWT();
        }

        public bool IsTokenValid(string token, string apiurl="")
        {
            return _jwt.IsTokenValidJWT(token);
        }
    }
}
