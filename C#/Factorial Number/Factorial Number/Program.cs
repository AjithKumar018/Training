using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumber;
            double dfactorial;

            Console.Write("Enter a Number: ");
            nNumber = Convert.ToInt32(Console.ReadLine());

            dfactorial = Factorial(nNumber);
            Console.WriteLine("factorial number of " + nNumber + " = " + dfactorial.ToString());

        }

        public static double Factorial(int nNumber)
        {
            if (nNumber == 0)
                return 1;
            return nNumber * Factorial(nNumber - 1);
        }
    }
}
