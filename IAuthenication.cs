using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationRefactor
{
    public interface IAuthentication
    {
       public string GetToken();
        public bool IsTokenValid(string token,string apiurl);
    }
}
