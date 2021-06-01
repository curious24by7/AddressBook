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
            Console.WriteLine("==================================================================\nPress 1 to Create AddressBook and add Contact. \nPress 2 to Exit Adress Book Application.\n==================================================================");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();
            addressBook.TestContactsData();
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
                    case "8":
                        addressBook.FindCityState();
                        break;
                    case "9":
                        addressBook.FindNumOfPerson();
                        break;
                    case "10":
                        addressBook.ChooseSort();
                        break;
                    case "11":
                        Json.ReadFromJson();
                        break;
                    case "12":
                        FileIO.ReadFromCSV();
                        break;
                    default:
                        Console.WriteLine("------------------------------------------------------------------\n!!! Choose valid operation !!!\n==================================================================");
                        break;
                }
                Console.WriteLine("==================================================================\nChoose the operation::\n------------------------------------------------------------------\n[3] View Saved Contacts.\n[4] Edit Existing Contact.\n[5] Delete Existing Contact.\n[6] Add Another Contact.\n[7] Search Person Name on Basis of City or State.\n[8] Find City and State of a Particular Person.\n[9] Find Number of Person found in a City or State.\n[10] Sort.\n[11] Read from Json.\n[12] Read from CSV.\n------------------------------------------------------------------\n...Press [2] to EXIT the Adress Book Application.\n==================================================================");
                userInput = Console.ReadLine();
            }
        }
    }    
}
