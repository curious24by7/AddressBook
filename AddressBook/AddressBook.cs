using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        private List<Contact> Pcontacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            Pcontacts.Add(contact);
        }

        public void DisplayAllContact()
        {
            foreach (var contact in Pcontacts)
            {
                Console.WriteLine("---------\nCONTACT :\n---------\n" + contact.FirstName+" "+contact.LastName+ "\nAddress: " +contact.Address+ "\nCity: " +contact.City+ "\nState: " +contact.State+"\nZip Code: " +contact.ZipCode+ "\nPhone Number: " +contact.PhoneNumber+ "\nEmail: " +contact.Email);
                //to represent info in 1 line 
                //{contact.LastName}, {contact.Address}, {contact.City}, {contact.State}, {contact.ZipCode}, {contact.PhoneNumber}, {contact.Email}
            }
        }
        public void EditContact(string Name)
        { 
            foreach (var contact in Pcontacts)
            {
                if (contact.FirstName == Name)
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
                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}
