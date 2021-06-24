using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    class Employee
    {
        protected string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        protected int _hours;
        public int Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        public void AddHours(int hours)
        {
            // method to add monthly working hours
            _hours += hours;
        }
        protected int _type; // 0 - management, 1 - professional
        public int Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        protected Dictionary<string, int> _ranks; // dictionairy of employee ranks
        public Dictionary<string, int> Ranks
        {
            get { return this._ranks; }
            set { this._ranks = value; }
        }
        public void NewEmployee(string name)
        {
            // Create new employee with generic properties, specific properties in child classes
            _name = name;
            _hours = 0; // starter of monthly hours
            _ranks = new Dictionary<string, int>();
        }
        public double CalcSalary(Dictionary<string, int> ranks, int hours)
        {
            // method for calculating salary for generic employee
            return 0;
        }
        public override string ToString()
        {
            string typestr;
            if (this._type == 0)
                typestr = "Management"; 
            else
                typestr = "Professional";
            
            List<string> allRanks = new List<string>(this._ranks.Keys);

            return "Employee Name: " + this._name + "\n" +
                "Employee Type:" + typestr + "\n" +
                "Employee Monthly Hours: " + this._hours + "\n" +
                "Employee Ranks: " + string.Join(", ", allRanks);
                ;
        }

    }
}

