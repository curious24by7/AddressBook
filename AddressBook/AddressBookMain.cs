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
            Console.WriteLine("=================================\nPress 1 to Create AddressBook and add Contact. \nPress 2 to Exit Adress Book Application.\n=================================");
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
                        return;
                    case "3":
                        addressBook.DisplayAllContact();
                        break;
                    case "4":
                        addressBook.EditContact();
                        break;
                    case "5":
                        addressBook.DeleteContact();
                        break;
                    case "6":
                        addressBook.DuplicateChecker();
                        break;
                    case "7":
                        addressBook.SearchPerson();
                        break;
                    default:
                        Console.WriteLine("!!! Choose valid operation !!!");
                        break;
                }
                Console.WriteLine("Choose the operation::\n3.View Saved Contacts.\n4.Edit Existing Contact.\n5.Delete Existing Contact.\n6.Add Another Contact.\n7.Search Person Name on Basis of City or State.\n...Press 2 for exiting the Adress Book Application.\n=================================");
                userInput = Console.ReadLine();
            }
        }
    }    
}
