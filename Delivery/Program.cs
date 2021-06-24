using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../employees.json");
            string jsonString = sr.ReadToEnd();
            var dictionary = JsonConvert.DeserializeObject<List<dynamic>>(jsonString).ToDictionary ( x => (string)x.key, y => (string)y.value);
            
        }
            
   
    }
    
}
