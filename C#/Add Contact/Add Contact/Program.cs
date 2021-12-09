using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPhoneNumber;
            string strFName, strLName, strEMail;

            Console.WriteLine("ADD NEW CONTACT");

            Console.WriteLine("FName");
            strFName = Console.ReadLine();

            Console.WriteLine("LName");
            strLName = Console.ReadLine();

            Console.WriteLine("PhoneNumber");
            nPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("EMail");
            strEMail = Console.ReadLine();

            Console.WriteLine("\nNew Contact Added: ");
            Console.WriteLine("FName: " + strFName);
            Console.WriteLine("LName: " + strLName);
            Console.WriteLine("EMail: " + strEMail);
            Console.WriteLine("PhoneNumber: " + nPhoneNumber);
            Console.ReadKey();
        }
    }
}
