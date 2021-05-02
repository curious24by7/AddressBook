using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        private List<Contact> pcontacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            pcontacts.Add(contact);
        }

        public void DisplayAllContact()
        {
            foreach (var contact in pcontacts)
            {
                Console.WriteLine("---------\nCONTACT :\n---------\n" + contact.FirstName +contact.LastName+ "\nAddress: " +contact.Address+ "\nCity: " +contact.City+ "\nState: " +contact.State+"\nZip Code: " +contact.ZipCode+ "\nPhone Number: " +contact.PhoneNumber+ "\nEmail: " +contact.Email);
                //to represent info in 1 line 
                //{contact.LastName}, {contact.Address}, {contact.City}, {contact.State}, {contact.ZipCode}, {contact.PhoneNumber}, {contact.Email}
            }
        }
    }
}
