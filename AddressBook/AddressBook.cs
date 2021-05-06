using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
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
            var newContact = new Contact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
            DictName.Add(addressbookName, newContact);
        }
        public void DisplayAllContact()
        {
            foreach (var element in DictName)
            {
                Console.WriteLine("----------------\nADDRESSBOOK :\n----------------\nAddressbook Key: " +element.Key+ "\nPerson's Name: "+ element.Value.FirstName+" "+element.Value.LastName+ "\nAddress: " +element.Value.Address+ "\nCity: " +element.Value.City+ "\nState: " +element.Value.State+"\nZip Code: " +element.Value.ZipCode+ "\nPhone Number: " +element.Value.PhoneNumber+ "\nEmail: " +element.Value.Email);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("Available Addressbooks are:: ");
            foreach(var key in DictName)
            {
                Console.WriteLine(key.Key+"\n----------------");
            }
            Console.WriteLine("------------------\nEnter Name of the AddressBook you want to edit:: ");
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
                    Console.WriteLine("---------------------------------\n!!Contact Edited!!");
                }
            }
            
        }
        public void DeleteContact()
        {  
            Console.WriteLine("Enter First Name of the Contact you want to Delete:");
            string name = Console.ReadLine();
            foreach (var contact in List)
            {
                if (contact.FirstName == name)
                {
                    List.Remove(contact);
                    Console.WriteLine("---------------------------------\n!!Contact Removed!!");
                    break;
                }
            }
        }
    }
}
