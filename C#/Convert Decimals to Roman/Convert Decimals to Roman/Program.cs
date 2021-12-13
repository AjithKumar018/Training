using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Decimals_to_Roman
{
    class Program
    {
        static Rom[] Romn = new Rom[]
        {
                new Rom(1000, "M"),
                new Rom(900, "CM"),
                new Rom(500, "D"),
                new Rom(400, "CD"),
                new Rom(100, "C"),
                new Rom(90, "XC"),
                new Rom(50, "L"),
                new Rom(40, "XL"),
                new Rom(10, "X"),
                new Rom(9, "IX"),
                new Rom(5, "V"),
                new Rom(4, "IV"),
                new Rom(1, "I"),
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the Decimal Number: ");
                int nValue;
                if (Int32.TryParse(Console.ReadLine(), out nValue) && nValue > 0)               //try parse.
                {
                    Console.Write($"{nValue} in roman numerals is:  {Roman(nValue)}\n");        //interpolation.
                    break;
                }
                else
                {
                    Console.Write("Invalid Input!\n");
                }
            }
        }

        private static string Roman(int n)
        {
            foreach (var Rom in Romn)
                if (Rom.N <= n)
                {
                    return Rom.Symbol + Roman(n - Rom.N);                                       //recursion.
                }
            return "";
        }

        class Rom
        {
            public int N { get; set; }
            public string Symbol { get; set; }
            public Rom(int n, string symbol)
            {
                N = n;
                Symbol = symbol;
            }
        }
    }
}