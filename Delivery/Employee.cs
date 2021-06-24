using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    abstract class Employee
    {
        protected int _id { get; set; }
        protected string _name { get; set; }
        protected int _hours { get; set; }
        protected int _type { get; set; } // 0 - management, 1 - professional
        protected Dictionary<string, int> _ranks { get; set; } // dictionairy of employee ranks
        public int AddHours(DateTime startTime, DateTime endTime)
        {
            // method to add monthly working hours by start and finish time
            return 0;
        }
        public double CalcSalary(Dictionary<string, int> ranks, int hours)
        {
            // method for calculating salary for generic employee
            return 0;
        }
        public void NewEmployee(int id, string name)
        {
            // Create new employee with generic properties, specific properties in child classes
            _id = id;
            _name = name;
            _hours = 0; // starter of monthly hours
        }

    }

}
