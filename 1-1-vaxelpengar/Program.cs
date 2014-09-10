using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Declaring variables
            double subTotal = 0d;
            uint recievedAmount;
            uint total = 0;            
            double roundingOffAmount;
            double changeBack;
            
            // Request subtotal and recieved amount from user and load them in the variables subTotal and recievedAmount
            Console.Write("Ange totalsumma: ");
            subTotal = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp: ");
            recievedAmount = uint.Parse(Console.ReadLine());


            // Calculating rounded total, how much is is rounded off and the change
            total = (uint)Math.Round(subTotal);
            roundingOffAmount = total - subTotal;
            changeBack = recievedAmount - total;

            // Print data in console
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Totalt: {0} kr", subTotal);
            Console.WriteLine("Öresavrunding: {0:c} kr", roundingOffAmount);
            Console.WriteLine("Att betala: {0} kr", total);
            Console.WriteLine("Erhållet belopp(Kontant): {0} kr", recievedAmount);
            Console.WriteLine("Växel tillbaka: {0} kr", changeBack);
            Console.WriteLine("-------------------------------------------");




        }

    }
}
