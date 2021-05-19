using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Sort
    {
        public AddressBook addressBook = new AddressBook();
        public void SortByPersonName()
        {
            Dictionary<string, Contact> sortList = addressBook.DictName.OrderBy(x => x.Value.FirstName).ToDictionary(x => x.Key, x => x.Value);
            foreach (var element in sortList)
            {
                Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.PhoneNumber);
            }
        }
        public void SortByCity()
        {
            Dictionary<string, Contact> sortList = addressBook.DictName.OrderBy(x => x.Value.City).ToDictionary(x => x.Key, x => x.Value);
            foreach (var element in sortList)
            {
                Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.City + " " + element.Value.PhoneNumber);
            }
        }
        public void SortByState()
        {
            Dictionary<string, Contact> sortList = addressBook.DictName.OrderBy(x => x.Value.State).ToDictionary(x => x.Key, x => x.Value);
            foreach (var element in sortList)
            {
                Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.PhoneNumber);
            }
        }
        public void SortByZip()
        {
            Dictionary<string, Contact> sortList = addressBook.DictName.OrderBy(x => x.Value.ZipCode).ToDictionary(x => x.Key, x => x.Value);
            foreach (var element in sortList)
            {
                Console.WriteLine(element.Value.FirstName + " " + element.Value.LastName + " " + element.Value.State + " " + element.Value.ZipCode + " " + element.Value.PhoneNumber);
            }
        }
    }
}
