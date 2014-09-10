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
            double subTotal = 0;
            uint total = 0;
            double recievedAmount;
            double roundingOffAmount;
            
            Console.Write("Ange totalsumma: ");
            subTotal = double.Parse(Console.ReadLine());

            Console.Write("Ange erhållet belopp: ");
            recievedAmount = uint.Parse(Console.ReadLine());


            total = (uint)Math.Round(subTotal);
            roundingOffAmount = total - subTotal;


            Console.WriteLine("Totalt: {0}", subTotal);
            Console.WriteLine("Erhållet belopp: {0}", recievedAmount);
            Console.WriteLine("Att betala: {0}", total);
            Console.WriteLine("Öresavrunding: {0}", roundingOffAmount);




        }

    }
}
