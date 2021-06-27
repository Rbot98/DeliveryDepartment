using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDepartment
{
    class EmplopyeeFactory
    {
        private Dictionary<int,Employee> _employees = new Dictionary<int, Employee>();
        // Created a list of employees for the program to use
        public Dictionary<int,Employee> CreateEmployees()
        {
           
            int id = 0;
            double wage = 0;
            Random rand = new Random();
            foreach (EmployeeType type in (EmployeeType[])Enum.GetValues(typeof(EmployeeType)))
            {
                id++;
                if ((int)type==8 || (int)type==20 || (int)type==21)
                    wage = rand.Next(25000, 35000);
                else
                    wage = rand.Next(27, 50);
                this._employees.Add(id, new Employee(id, type.ToString(), wage));

            }
            return this._employees;
        }
    }
}
