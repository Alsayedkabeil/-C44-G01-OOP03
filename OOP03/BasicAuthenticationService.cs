using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class BasicAuthenticationService : IAuthenticationService,IComparable
    {
        public string AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Authorization failed! Username or role cannot be empty.";
            }
            // Implementation for authenticating user with username and password
            Console.WriteLine($"Authenticating user: {username} with password: {password} .");
            if (username == "Alsayed" && password == "password123")
            {
                return "Authentication successful!";
            }
            else
            {
                return "Authentication failed! Invalid username or password.";
            }
        }

        public string AuthorizeUser(string username, string role)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                return "Authorization failed! Username or role cannot be empty.";
            }

            if (username == "Alsayed" && role == "admin")
            {
                return "Authorization successful! User has admin privileges.";
            }
            else if (username == "Ali" && role == "user")
            {
                return "Authorization successful! User has user privileges.";
            }
            else
            {
                return "Authorization failed! User does not have the required role.";
            }
        }

        int IComparable.CompareTo(object? obj)
        {
            if (obj == null) return 1;

            if (obj is BasicAuthenticationService otherService)
            {
                // Example comparison logic: compare based on the class name length
                return this.GetType().Name.Length.CompareTo(otherService.GetType().Name.Length);
            }

            throw new ArgumentException("Object is not a BasicAuthenticationService");
        }
    }
    

    
}
