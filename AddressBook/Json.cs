using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AddressBook
{
    class Json
    {
        const string JSONPATH = @"C:\Users\soham\source\repos\AddressBook\AddressBook\Files\StoredContactJson.json";
        public static void WriteToJson(Dictionary<string, Contact> DictName)
        {
            if (File.Exists(JSONPATH))
            {
                string Json = JsonConvert.SerializeObject(DictName);
                using (StreamWriter sw = new StreamWriter(JSONPATH))
                {
                    sw.WriteLine(Json);
                }
            }
        }
        public static void ReadFromJson()
        {
            string Json = File.ReadAllText(JSONPATH);
            var Data = JsonConvert.DeserializeObject<Dictionary<string, object>>(Json);
            foreach (var item in Data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
