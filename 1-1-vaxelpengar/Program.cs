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
            uint changeBack;
            
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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Totalt          :{0, 12} kr", subTotal);
            Console.WriteLine("Öresavrunding   : {0, 12:c}", roundingOffAmount);
            Console.WriteLine("Att betala      : {0} kr", total);
            Console.WriteLine("Erhållet belopp : {0} kr", recievedAmount);
            Console.WriteLine("Växel tillbaka  : {0} kr", changeBack);
            Console.WriteLine("----------------------------------");



            if ((changeBack / 500) > 0)
            {
                Console.WriteLine("500-lappar: {0}", (changeBack / 500));
                changeBack = changeBack % 500;
            }
            if ((changeBack / 100) > 0)
            {
                Console.WriteLine("100-lappar: {0}", (changeBack / 100));
                changeBack = changeBack % 100;
            }
            if ((changeBack / 50) > 0)
            {
                Console.WriteLine("50-lappar: {0}", (changeBack / 50));
                changeBack = changeBack % 50;
            }
            if ((changeBack / 20) > 0)
            {
                Console.WriteLine("20-lappar: {0}", (changeBack / 20));
                changeBack = changeBack % 100;
            }
            if ((changeBack / 10) > 0)
            {
                Console.WriteLine("10-kronor: {0}", (changeBack / 10));
                changeBack = changeBack % 10;
            }
            if ((changeBack / 5) > 0)
            {
                Console.WriteLine("5-kronor: {0}", (changeBack / 5));
                changeBack = changeBack % 5;
            }
            if ((changeBack / 1) > 0)
            {
                Console.WriteLine("1-kronor: {0}", (changeBack / 1));
                changeBack = changeBack % 1;
            }
        }

    }
}
