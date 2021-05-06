using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
        public Contact(string firstname, string lastname, string address, string city, string state, string zipcode, string phonenumber, string email)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipcode;
            PhoneNumber = phonenumber;
            Email = email;
        }
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
        public string PhoneNumber;
        public string Email;

    }
}
