using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        private List<Contact> List { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            List.Add(contact);
        }

        public void DisplayAllContact()
        {
            foreach (var contact in List)
            {
                Console.WriteLine("---------\nCONTACT :\n---------\n" + contact.FirstName+" "+contact.LastName+ "\nAddress: " +contact.Address+ "\nCity: " +contact.City+ "\nState: " +contact.State+"\nZip Code: " +contact.ZipCode+ "\nPhone Number: " +contact.PhoneNumber+ "\nEmail: " +contact.Email);
            }
        }
        public void EditContact(string personName)
        { 
            foreach (var contact in List)
            {
                if (contact.FirstName == personName)
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    contact.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    contact.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    contact.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    contact.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    contact.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    contact.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    contact.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
                    contact.Email = newEmail;
                    Console.WriteLine("---------------------------------\n!!Contact Edited!!");
                }
            }
            
        }
        public void DeleteContact(string name)
        {
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
