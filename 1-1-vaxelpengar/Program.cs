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
            uint recievedAmount = 0;
            uint total = 0;            
            double roundingOffAmount;
            uint changeBack;
            
            // Request subtotal and recieved amount from user and load them in the variables subTotal and recievedAmount
            while (true)
            {    
                try
                {
                    Console.Write("Ange totalsumma: ");
                    subTotal = double.Parse(Console.ReadLine());

                    total = (uint)Math.Round(subTotal);// Calculating rounded total                    
                    if (total < 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else { break; }
                }
                catch (System.FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Felaktigt belopp.");
                    Console.ResetColor();
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Okänt fel. Programmet avslutas.");
                    Console.ResetColor();
                    return;

                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    recievedAmount = uint.Parse(Console.ReadLine());


                    if (recievedAmount < total)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erhållet belopp är för litet. Köp kunde inte genonföras");
                        Console.ResetColor();
                        return;
                    }
                    else { break; }
                }

                catch (System.FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Felaktigt belopp.");
                    Console.ResetColor();
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Okänt fel. Programmet avslutas.");
                    Console.ResetColor();
                    return;
                }
            }   

            // Calculating how much is rounded off and the change
            
            roundingOffAmount = total - subTotal;
            changeBack = recievedAmount - total;


            
            
            // Print data in console
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Totalt          : {0, 15:c}", subTotal);
            Console.WriteLine("Öresavrunding   : {0, 15:c}", roundingOffAmount);
            Console.WriteLine("Att betala      : {0, 15:c}", total);
            Console.WriteLine("Erhållet belopp : {0, 15:c}", recievedAmount);
            Console.WriteLine("Växel tillbaka  : {0, 15:c}", changeBack);
            Console.WriteLine("----------------------------------");


            // Calculating the change in respective denomination
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
