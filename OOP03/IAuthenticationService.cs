using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal interface IAuthenticationService
    {
       
        public string AuthenticateUser(string username, string password);

        public string AuthorizeUser(string username, string role);

        
    }
}
