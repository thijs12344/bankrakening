using System.Xml;
using static BankSimulator;

namespace bankSimulator
{
    class bankSimulator
    {
        internal class BankSimulator
        {
            static void Main(string[] args)
            {
                bankAccount account = new bankAccount();


                while (true)
                {
                    Console.WriteLine("welkom bij de bank. maak uw keuze");
                    Console.WriteLine("1. geld storten");
                    Console.WriteLine("2. geld opnemen");
                    Console.WriteLine("3. saldo bekijken");
                    Console.WriteLine("4. exit");
                    Console.WriteLine("maak een keuze");

                    string keuze = Console.ReadLine();

                    if (keuze == "1")
                    {
                        account.Storten();
                    }
                    if (keuze == "2")
                    {
                        account.Opnemen();
                    }
                    if (keuze == "3")
                    {
                       account.Saldo();
                    }
                    if(keuze == "4") 
                    {
                        break;
                    }




                }
            }

        }
    }
}