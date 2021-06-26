using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDepartment
{
    class EmplopyeeFactory
    {
        private List<Employee> _employees = new List<Employee>();
        // Created a list of employees for the program to use
        public List<Employee> CreateEmployees()
        {
           
            int id = 0;
            foreach (EmployeeType type in (EmployeeType[])Enum.GetValues(typeof(EmployeeType)))
            {
                id++;
                this._employees.Add(new Employee(id, type.ToString()));

            }
            return this._employees;
        }
    }
}
