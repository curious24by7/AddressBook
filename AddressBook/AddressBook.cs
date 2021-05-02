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
                Console.WriteLine($"SAVED CONTACT IS : {contact.FirstName}, {contact.LastName}, {contact.Address}, {contact.City}, {contact.State}, {contact.ZipCode}, {contact.PhoneNumber}, {contact.Email}");
            }
        }
    }
}
