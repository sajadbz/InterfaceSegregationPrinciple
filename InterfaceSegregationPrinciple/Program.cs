using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        public class Document
        {
            public string Content { get; set; }
        }

        public interface IMachine:IPrinter,IFax,IScan
        {
            
        }
        public interface IPrinter
        {
            void Print(Document d);
        }
        public interface IFax
        {
            void Fax(Document d);
        }
        public interface IScan
        {
            void Scan(Document d);
        }

        public class OldPrinter:IPrinter
        {
            public void Print(Document d)
            {
                Console.WriteLine("Old Printer Can Print.");
            }
        }
        
        public class MultiFunctionPrinter : IMachine
        {
            public void Print(Document d)
            {
                Console.WriteLine("Can Print ...");
            }

            public void Fax(Document d)
            {
                Console.WriteLine("Can Fax ...");
            }

            public void Scan(Document d)
            {
                Console.WriteLine("Can Scan ...");
            }
        }

        static void Main(string[] args)
        {
            IAccountRepository accountRepository = new AccountRepository();
            //accountRepository.Login()
            ILogin login = new AccountRepository();
            //login.Login()
            ILogin login2 = new LoginController();
            //login2.Logout();

        }
    }
}
