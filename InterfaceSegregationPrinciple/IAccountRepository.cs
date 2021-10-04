using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IAccountRepository :ILogin, IRegister, IForgotPassword
    {

    }

    public interface ILogin
    {
        bool Login(string username, string password);
        void Logout(string username);
    }

    public interface IRegister
    {
        int Register(string username, string password, string email);
    }

    public interface IForgotPassword
    {
        void ForgotPassword(string username);
    }
    public class AccountRepository : IAccountRepository
    {
        public int Register(string username, string password, string email)
        {
            return 1;
        }

        public void ForgotPassword(string username)
        {
            Console.WriteLine("Email Sent.");
        }

        public bool Login(string username, string password)
        {
            return true;
        }

        public void Logout(string username)
        {
            Console.WriteLine("Logout.");
        }
    }


    public class LoginController : ILogin
    {
        public bool Login(string username, string password)
        {
            Console.WriteLine("Login");
            return true;
        }

        public void Logout(string username)
        {
            Console.WriteLine("Logout");
        }
    }
}
