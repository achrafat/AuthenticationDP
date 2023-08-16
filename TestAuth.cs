using AuthentificationRefactor;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace AuthenticationRefactor
{
    public class TestAuth
    {
        static void Main(string[] args)
        {
            /* string token = null;
             AuthenticationProtocolFactory authenticationProtocol = new AuthenticationProtocolFactory();
             ITokenValidator tokenValidation = new TokenValidator(authenticationProtocol);

             Console.WriteLine("------------------when token is null------------------------------");
             tokenValidation.ValidateToken(token, AuthenticationProtocolEnum.OAUTH, "urlAPI");
             Console.WriteLine("****************************************************************");
             Console.WriteLine("------OAuth with an expired token----------");
             Console.WriteLine("so the IsTokenValid() will return false and the validate token will generate a new one");
             tokenValidation.ValidateToken("11111111", AuthenticationProtocolEnum.OAUTH, "urlAPI");
             Console.WriteLine("****************************************************************");
             Console.WriteLine("-------OAuth with valid Token---------");
             Console.WriteLine(":IsTokenValid() will return true an validateToken will return the same token 2023");
             tokenValidation.ValidateToken("2023", AuthenticationProtocolEnum.OAUTH, "urlAPI");
             Console.WriteLine("****************************************************************");

             Console.WriteLine("-----------JWT with an expired token -----");
             Console.WriteLine("so the IsTokenValid() will return false and the validate token will generate a new one");
             tokenValidation.ValidateToken("222222222", AuthenticationProtocolEnum.JWT, "urlAPI");
             Console.WriteLine("****************************************************************");
         Console.WriteLine("****************************************************************");

         Console.WriteLine(":JWT with optional param 2023");
             tokenValidation.ValidateToken("2023", AuthenticationProtocolEnum.JWT);
             Console.WriteLine("****************************************************************");*/

            var x1 = removeDuplicateString("ararabe");
            var x2 = removeDuplicateString("frfrancefrfr");
            Console.WriteLine(x1);
            Console.WriteLine(x2);
           static string removeDuplicateString(string input)
            {
                string result = string.Empty;
                foreach(char c in input)
                {
                    if (result.indexOf(c) == -1)
                    {
                        result += c;
                    }
                }
                return result;
            }

        }

    }
}
