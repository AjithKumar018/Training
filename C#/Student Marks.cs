﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSno, nMark1, nMark2, nMark3, nMark4, nMark5, nTotal, nAverage;
            string strName;

            Console.WriteLine("Enter The Student Details");

            Console.WriteLine("Enter The Student No");
            nSno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Student Name");
            strName = Console.ReadLine();

            Console.WriteLine("Enter The Marks of 5 Subjects");
            nMark1 = int.Parse(Console.ReadLine());
            nMark2 = int.Parse(Console.ReadLine());
            nMark3 = int.Parse(Console.ReadLine());
            nMark4 = int.Parse(Console.ReadLine());
            nMark5 = int.Parse(Console.ReadLine());

            nTotal = nMark1 + nMark2 + nMark3 + nMark4 + nMark5;

            nAverage = nTotal / 5;

            Console.WriteLine("\n\n\nThe Student Details are Given Below :");
            Console.WriteLine("The Student No is: " + nSno);
            Console.WriteLine("The Student Name is: " + strName);
            Console.WriteLine("Total Marks is: " + nTotal + "/500");
            Console.WriteLine("Average is: " + nAverage);
            Console.ReadKey();
        }
    }
}
