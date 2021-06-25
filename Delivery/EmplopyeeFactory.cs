using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDepartment
{
    class EmplopyeeFactory
    {
        public List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            int id = 0;
            foreach (EmployeeType type in (EmployeeType[])Enum.GetValues(typeof(EmployeeType)))
            {
                id++;
                employees.Add(new Employee(id, type.ToString()));

            }
            return employees;
        }
    }
}
