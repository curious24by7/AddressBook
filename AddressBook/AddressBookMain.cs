using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Address Book.");
            Console.WriteLine("=================================\nChoose the operation:\n1.Add Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n7.Search Person via City.\n6.Exit Adress Book Application.\n=================================");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();
            
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        addressBook.StoreContact();
                        break;
                    case "2":
                        addressBook.DisplayAllContact();
                        break;
                    case "3":
                        addressBook.EditContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        addressBook.DuplicateChecker();
                        break;
                    case "6":
                        return;
                    case "7":
                        addressBook.SearchPerson();
                        break;
                    default:
                        Console.WriteLine("!!! Choose valid operation !!!");
                        break;
                }
                Console.WriteLine("Choose the operation::\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Add Another Contact.\n6.Exit Adress Book Application.\n=================================");
                userInput = Console.ReadLine();
            }
        }
    }    
}
