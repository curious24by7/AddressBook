using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
    class FileIO
    {
        public static void WriteDataToTxt(Dictionary<string,Contact> DictName)
        {
            const string PATH = @"C:\Users\soham\source\repos\AddressBook\AddressBook\StoredContact.txt";
            using (TextWriter tw = new StreamWriter(PATH))
            {
                tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email"));
                foreach(var element in DictName)
                {
                    tw.WriteLine(string.Format($"{element.Value.FirstName},{element.Value.LastName},{element.Value.Address},{element.Value.City},{element.Value.State},{element.Value.ZipCode},{element.Value.PhoneNumber},{element.Value.Email}"));
                }
            }
        }
    }
}
