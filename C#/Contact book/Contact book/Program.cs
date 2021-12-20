using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    public class ContactBook                                             
    {
        public string Name                                               
        { get; set; }
        public long MobileNumber
        { get; set; }
        public string EMail
        { get; set; }
        public string Location
        { get; set; }
    }
    public class Program
    {
        static List<ContactBook> BookList = new List<ContactBook>();     
        static void Main(string[] args)
        {
            Display();                                                   
        }
        static void Display()
        {
            Console.Write("\nChoose Your Option from:\n");
            Console.Write("\n1.Add Contact.");
            Console.Write("\n2.Edit Contact.");
            Console.Write("\n3.Show Saved Contacts.");
            Console.Write("\n4.Delete Contact.");
            Console.Write("\n5.Search Contacts.");
            Console.Write("\n6.Exit.");

            Console.Write("\n\nYour option is: ");
            int nOption = Convert.ToInt32(Console.ReadLine());

            if (nOption > 0)
            {
                switch (nOption)
                {
                    case 1:
                        Addcontact();
                        break;
                    case 2:
                        Editcontact();
                        break;
                    case 3:
                        Viewcontact(); ;
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        Searchcontact();
                        break;
                    case 6:
                        Console.Write("Thank You!\n");
                        return;
                    default:
                        Console.Write("Invalid Input!");
                        break;
                }
            }
            else
            {
                Console.Write("Invalid Input!");
            }

            Display();
        }

        static void Addcontact()
        {
            ContactBook List = new ContactBook();                         

            Console.Write("\nEnter Name: ");
            List.Name = Console.ReadLine();

            Console.Write("Enter Mob No: ");
            List.MobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter EMail: ");
            List.EMail = Console.ReadLine();

            Console.Write("Enter Location: ");
            List.Location = Console.ReadLine();

            BookList.Add(List);
            Console.Write("\nContact Saved Successfully!...\n");

            Display();

        }

        static void Editcontact()
        {
            Console.Write("\nEnter the Mob No to Search: ");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());

            ContactBook Cbook = new ContactBook();                        
            bool bSavedContact = false;
            foreach (ContactBook Contact in BookList)
            {
                if (Contact.MobileNumber == PhoneNumber)
                {
                    Cbook = Contact;
                    bSavedContact = true;
                    break;
                }
            }
            if (bSavedContact)
            {
                Console.Write("\nWhich field you want to Change:");
                Console.Write("\n1.Name");
                Console.Write("\n2.Mob No");
                Console.Write("\n3.EMail");
                Console.Write("\n4.Location");
                Console.Write("\n5.Exit");

                Console.Write("\nChoose your option: ");
                int nOption = Convert.ToInt32(Console.ReadLine());

                switch (nOption)
                {
                    case 1:
                        Console.Write("\nEnter the Name: ");
                        Cbook.Name = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("\nEnter Mobile Number: ");
                        Cbook.MobileNumber = Convert.ToInt64(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("\nEnter EMail: ");
                        Cbook.EMail = Console.ReadLine();
                        break;

                    case 4:
                        Console.Write("\nEnter the Location: ");
                        Cbook.Location = Console.ReadLine();
                        break;

                    case 5:
                        return;

                    default:
                        Console.Write("Invalid Input!");
                        break;
                }
                Console.Write("\nContact Edited Successfully!\n");
            }
            else
            {
                Console.Write("\nNo Contact is available for this information!");
            }
        }

        static void Viewcontact()
        {
            if (BookList.Count == 0)
            {
                Console.Write("\nNo Contacts Added yet!");
            }
            else
            {
                Console.Write("\nHere is your Contacts:");
                foreach (ContactBook Contact in BookList)
                {
                    Console.Write("\n\nName: " + Contact.Name);
                    Console.Write("\nMob No: " + Contact.MobileNumber);
                    Console.Write("\nEMail: " + Contact.EMail);
                    Console.Write("\nLocation: " + Contact.Location);
                }
                Console.Write("\n\nContacts successfully Displayed!\n");
            }
        }

        static void DeleteContact()
        {
            Console.Write("\nEnter Mob No to Delete Contact: ");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            bool bSavedContact = false;

            foreach (ContactBook Contact in BookList)
            {
                if (Contact.MobileNumber == PhoneNumber)
                {
                    BookList.Remove(Contact);
                    bSavedContact = true;
                    break;
                }
            }
            if (bSavedContact)
            {
                Console.Write("\nContact Deleted Successfully!\n");
            }
            else
            {
                Console.Write("\nThere is no Contact to delete:");
            }
        }

        static void Searchcontact()
        {
            Console.Write("\nEnter Mobile Number to Search: ");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());

            ContactBook Cbook = null;                        

            foreach (ContactBook Contact in BookList)
            {
                if (Contact.MobileNumber == PhoneNumber)
                {
                    Cbook = Contact;
                    break;
                }
            }
            if (Cbook != null)
            {
                Console.Write("\nName: " + Cbook.Name);
                Console.Write("\nNumber: " + Cbook.MobileNumber);
                Console.Write("\nEMail: " + Cbook.EMail);
                Console.Write("\nLocation: " + Cbook.Location + "\n");
            }
            else
            {
                Console.Write("\nNo Contacts available with this information.\n");
            }
        }
    }
}