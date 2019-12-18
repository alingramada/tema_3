using LibraryProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appclass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserAccount> accounts = new List<UserAccount>();
            var metode = new LibraryProject.Methodes();
            
            Console.WriteLine("Wellcome!");
            if (accounts.Count == 0)
            {
                Console.WriteLine("There is no account!");
                Console.WriteLine("Do you want to creat an account?(yes/no}");
                string answear = Console.ReadLine();


                do
                {
                    UserAccount userAccount = metode.CreateAccount();
                    accounts.Add(userAccount);
                    Console.WriteLine("Do you want to creat another account?(yes/no}");
                    answear = Console.ReadLine();
                } while (answear != "no");
            }

            Console.WriteLine("Do you want to login?");
            string l = Console.ReadLine();
            do
            {
                UserAccount ans = metode.LogIn(accounts);
                if (ans != null)
                {
                    Console.WriteLine("Do you want to write a message?(yes/no)");
                    string a = Console.ReadLine();
                    if (a == "yes")
                    {
                        metode.GetUserMessage(ans);
                    }
                }
            } while (l != "no");
            


        }
    }
}
