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
            Employee e = new Employee("Olga", "DepartmentManager");
            e.AddHours(150);
            Console.WriteLine("Salary: " + e.CalcSalary(30000));
            Console.WriteLine(e.ToString());
        }
            
   
    }
    
}
