using AuthentificationRefactor;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace AuthenticationRefactor
{
    public class OAuth : IAuthentication
    {
        public OAuth() { }
       public  string GetToken()
       {
           
            string message = "Oauth Get New Token";
            Console.WriteLine(message);
            return message;
        }

        public bool IsTokenValid(string token, string apiurl)
        {
            if (token.Equals("2023")){ 
            Console.WriteLine(true);
            return true;
        }
        else {
                Console.WriteLine(false);
                return false;}
       }
    }
}
