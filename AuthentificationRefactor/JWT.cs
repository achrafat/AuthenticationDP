using AuthentificationRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRefactor
{
    public class JWT 
    {
       

        public string GetTokenJWT()
        {
            string message = "JWT Get New Token";
            Console.WriteLine(message);
            return message ;
        }

        public bool IsTokenValidJWT(string token)
        {
            if (token.Equals("2023"))
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }
    }
}
