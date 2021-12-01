using System;

namespace AddContact
{
    class Program
    {
        static void Main(string[] args)
        {
            int PhoneNumber;
            string FName, LName, EMail;

            Console.WriteLine("ADD NEW CONTACT");

            Console.WriteLine("Fname");
            FName = Console.ReadLine();

            Console.WriteLine("LName");
            LName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            PhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("E-Mail");
            EMail = Console.ReadLine();

            Console.WriteLine("\n\n\nNew Contact Added:");
            Console.WriteLine("FName : " + FName);
            Console.WriteLine("LName : " + LName);
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("E-Mail : " + EMail);
            Console.ReadKey();
        }
    }
}