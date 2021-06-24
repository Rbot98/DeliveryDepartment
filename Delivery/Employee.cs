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

    // Management Employees --------------------------------------------------------------------------------------
    class Cleaner : Employee
    {
        public Cleaner(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0; 
            _ranks.Add("junior", 0);

        }
    }

    class ToxicCleaner : Employee
    {
        public ToxicCleaner(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("junior", 0);
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Expert", 30);
            _ranks.Add("Risk", 20);
        }
    }

    class HeadCleaner : Employee
    {
        public HeadCleaner(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("Senior", 5);
        }
    }

    class MasterCleaner : Employee
    {
        public MasterCleaner(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("DecisionMaker", 50);
        }
    }

    class Cook : Employee
    {
        public Cook(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("Senior", 5);
        }
    }
    class SuChef : Employee
    {
        public SuChef(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
        }
    }
    class Chef : Employee
    {
        public Chef(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class FoodDistributer: Employee
    {
        public FoodDistributer(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("junior", 0);
        }
    }
    class HeadOfManagement: Employee
    {
        public HeadOfManagement(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
        }
    }

    // Professional Employees --------------------------------------------------------------------------------------
    class Paramedic : Employee
    {
        public Paramedic(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class Nurse : Employee
    {
        public Nurse(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class Medic : Employee
    {
        public Medic(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }

    class HeadNurse: Employee
    {
        public HeadNurse(int id, string name)
        {
            base.NewEmployee(id, name);
            _ranks.Add("Senior", 5);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class OB: Employee
    {
        public OB(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("Senior", 5);
        }
    }
    class SpecialOB : Employee
    {
        public SpecialOB(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
            _ranks.Add("Expert", 30);
        }
    }
    class Intern: Employee
    {
        public Intern(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class SpecialOBIntern: Employee
    {
        public SpecialOBIntern(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
            _ranks.Add("Expert", 30);
        }
    }
    class Doctor : Employee
    {
        public Doctor(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("Senior", 5);
        }
    }
    class SeniorDoc : Employee
    {
        public SeniorDoc(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("Senior", 5);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class ExpertDoc : Employee
    {
        public ExpertDoc(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
        }
    }
    class VPDepartmentManager : Employee
    {
        public VPDepartmentManager(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
        }
    }
    class DepartmentManager : Employee
    {
        public DepartmentManager(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
            _ranks.Add("Risk", 100);
        }
    }
}
