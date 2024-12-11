using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankSimulator
{
    internal class bankAccount
    {
        decimal totaalSaldo;
        public void Storten()
        {
            do 
            {
                Console.WriteLine("hoeveel wil je storten");
                if (decimal.TryParse(Console.ReadLine(), out decimal storten))
                {
                    totaalSaldo += storten;
                    Console.WriteLine($"je hebt {storten} gestort, je hebt nu {totaalSaldo} euro");
                    break;
                }
                else 
                {
                    Console.WriteLine("ongeldige invoer");
                }
            } while (true);
        }
        public void Opnemen() 
        {
            do
            {
                Console.WriteLine("hoeveel geld wil je opnemen?");
                if (decimal.TryParse(Console.ReadLine(), out decimal opnemen))
                {
                    if (totaalSaldo < opnemen)
                    {
                        Console.WriteLine("te weinig saldo");
                    }
                    else 
                    {
                        totaalSaldo -= opnemen;
                        Console.WriteLine($"je hebt {opnemen} opgenomen, je totaalsaldo is nu {totaalSaldo} euro"); 
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("ongeldige invoer");
                }
            } while (true);   
        }
        public void Saldo() 
        {
            {
                Console.WriteLine($"je saldo is {totaalSaldo} euro");
            }
        }
    }
}
