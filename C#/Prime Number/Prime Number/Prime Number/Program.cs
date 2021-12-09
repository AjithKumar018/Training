using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumb;
            bool bIsPrime;

            Console.Write(" Enter the number: ");
            nNumb = Convert.ToInt32(Console.ReadLine());
            
            bIsPrime = true;

            for (int i = 2; i <= nNumb / 2; i++)
            {
                if (nNumb % i == 0)
                {
                    bIsPrime = false;
                    break;
                }
            }
            if (bIsPrime)
            {
                Console.Write(" Number " + nNumb + " is a PrimeNumber.\n\n");
            }
            else
            {
                Console.Write(" Number " + nNumb + " is not a PrimeNumber.\n\n");
            }
        }
    }
}
