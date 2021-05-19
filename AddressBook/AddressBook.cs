using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook : Exception
    {
        public List<Contact> List = new List<Contact>();
        public void AddContact(Contact addcontact)
        {
            List.Add(addcontact);
        }
        public Dictionary<string, Contact> DictName = new Dictionary<string, Contact>();
        public void StoreContact()
        {
            Console.WriteLine("Enter a unique name to your Addressbook:");
            string addressbookName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();
            Console.WriteLine("City:");
            string city = Console.ReadLine();
            Console.WriteLine("State:");
            string state = Console.ReadLine();
            Console.WriteLine("Zip Code:");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("=================================\nCONTACT CREATED SUCCESSFULLY\n=================================");
            var newContact = new Contact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
            DictName.Add(addressbookName, newContact);
            FileIO.WriteDataToTxt(DictName);
            FileIO.WriteDataToCSV(DictName);
            Json.WriteToJson(DictName);
        }
        public void DisplayAllContact()
        {
            if (DictName.Count == 0)
            {
                Console.WriteLine("=================================\n!! ADDRESSBOOK EMPTY !!\n\nPress 1 to add contact...\n=================================");
            }
            foreach (var element in DictName)
            {
                Console.WriteLine("----------------\nADDRESSBOOK\n----------------\nAddressbook Key: " + element.Key + "\nPerson's Name: " + element.Value.FirstName + " " + element.Value.LastName + "\nAddress: " + element.Value.Address + "\nCity: " + element.Value.City + "\nState: " + element.Value.State + "\nZip Code: " + element.Value.ZipCode + "\nPhone Number: " + element.Value.PhoneNumber + "\nEmail: " + element.Value.Email);
                Console.WriteLine("=================================");
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Available Addressbooks are:: ");
            foreach(var key in DictName)
            {
                Console.WriteLine(key.Key+"\n-------");
            }
            Console.WriteLine("Enter Name of the AddressBook you want to edit:: ");
            string dictName = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Key == dictName)
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    element.Value.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    element.Value.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    element.Value.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    element.Value.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    element.Value.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    element.Value.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    element.Value.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
                    element.Value.Email = newEmail;
                    Console.WriteLine("=================================\nCONTACT EDITID SUCCESSFULLY\n=================================");
                }
            }
        }
        public void DeleteContact()
        {  
            Console.WriteLine("Enter First Name of the Contact you want to Delete:");
            string name = Console.ReadLine();
            foreach (var nameElement in DictName)
            {
                if (nameElement.Value.FirstName == name)
                {
                    DictName.Remove(nameElement.Key);
                    Console.WriteLine("=================================\n!! CONTACT DELETED SUCCESSFULLY !!\n=================================");
                    break;
                }
                else
                {
                    Console.WriteLine("=================================\n!! NO SUCH CONTACT FOUND YOUR ADDRESSBOOK !!\n=================================");
                }
            }
        }
        public void DuplicateChecker()
        {
            Console.WriteLine("Enter a unique name to your Addressbook:");
            string addressbookName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string name = Console.ReadLine();
            bool x = new bool();
            foreach (var element in DictName)
            {
                if (element.Value.FirstName.Equals(name))
                {
                    Console.WriteLine("=================================\nEntered Person Name already exist in Addressbook named::\n" + element.Key + "\n=================================");
                    x = true;
                }
            }
            if (x == true)
            {
                return;
            }
            if (x == false)
            {
                string newName = name;
                Console.WriteLine("Last Name:");
                string lastname = Console.ReadLine();
                Console.WriteLine("Address:");
                string address = Console.ReadLine();
                Console.WriteLine("City:");
                string city = Console.ReadLine();
                Console.WriteLine("State:");
                string state = Console.ReadLine();
                Console.WriteLine("Zip Code:");
                string zipcode = Console.ReadLine();
                Console.WriteLine("Phone Number:");
                string phonenumber = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                var newContact = new Contact(newName, lastname, address, city, state, zipcode, phonenumber, email);
                try
                {
                    DictName.Add(addressbookName, newContact);
                    FileIO.WriteDataToTxt(DictName);
                    FileIO.WriteDataToCSV(DictName);
                    Json.WriteToJson(DictName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("===========================================\nDuplicate checker passed contact added successfully.\n===========================================");
            }
        }
        public void SearchPerson()
        {
            Console.WriteLine("Enter City or State to search person::");
            string city = Console.ReadLine();
            foreach(var element in DictName)
            {
                if (element.Value.City.Equals(city.ToLower()))
                {
                    Console.WriteLine("Contact(s) in found in " + city + ":: " + element.Value.FirstName);
                }
                else if (element.Value.State.Equals(city))
                {
                    Console.WriteLine("Contact(s) in found in " + city + ":: " + element.Value.FirstName);
                }
                else
                {
                    Console.WriteLine("No such City or State stored in your addressbook.\nAvailable city and states are ::\n Cites:: " + element.Value.City + "\nStates:: " + element.Value.State);
                }
            }
        }
        public void FindCityState()
        {
            Console.WriteLine("Enter First Name of a Person to View his City and State::");
            string person = Console.ReadLine();
            bool x = new bool();
            foreach(var element in DictName)
            {
                if (element.Value.FirstName.Equals(person.ToLower()))
                {
                    x = true;
                }
            }
            if (x==true)
            {
                foreach (var element in DictName)
                {
                    Console.WriteLine("\n" + element.Value.FirstName + " lives in :: '" + element.Value.City + "' City and '" + element.Value.State + "' State.\n");
                }
            }
            if (x==false)
            {
                foreach (var element in DictName)
                {
                    Console.WriteLine("No such Person found in Addressbook.\n\nAvailable person in your addressbook are :: " + element.Value.FirstName + "\n");
                }
            }
        }
        public void FindNumOfPerson()
        {
            Console.WriteLine("Enter City or State ::");
            string cityState = Console.ReadLine();
            int countPerson = 0;
            foreach(var element in DictName)
            {
                if (element.Value.City.Equals(cityState.ToLower()))
                {
                    countPerson++;
                }
                if(element.Value.State.Equals(cityState.ToLower()))
                {
                    countPerson++;
                }

            }
            Console.WriteLine("\nNumber of Person found in " + cityState + " are " + countPerson);
        }
        public void ChooseSort()
        {
            Console.WriteLine("Sort By:-");
            Console.WriteLine("1.Name\n2.City\n3.State\n4.ZipCode");
            var choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Dictionary<string, Contact> sortList = DictName.OrderBy(x => x.Value.FirstName).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortList)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "2":
                    Dictionary<string, Contact> sortCity = DictName.OrderBy(x => x.Value.City).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortCity)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.City + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "3":
                    Dictionary<string, Contact> sortState = DictName.OrderBy(x => x.Value.State).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortState)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.PhoneNumber);
                    }
                    break;
                case "4":
                    Dictionary<string, Contact> sortZip = DictName.OrderBy(x => x.Value.ZipCode).ToDictionary(x => x.Key, x => x.Value);
                    foreach (var element in sortZip)
                    {
                        Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.ZipCode + " " + element.Value.PhoneNumber);
                    }
                    break;
                default:
                    Console.WriteLine("=================================\n!!! Choose valid operation !!!\n=================================");
                    break;
            }
        }
    }
}
