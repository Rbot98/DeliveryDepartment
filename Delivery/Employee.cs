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
        private int _hours;
        protected EmployeeType _type;
        public string Name
        {
            get { return this._name; }
        }
        public int Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        public int Type
        {
            get { return (int)this._type; }
        }
        public void AddHours(int hours)
        {
            // method to add monthly working hours
            _hours += hours;
        }
        public Employee(string name, string type)
        {
            // Create new employee with generic properties, specific properties in child classes
            this._name = name;
            this._hours = 0; // starter of monthly hours
            this._type = (EmployeeType)Enum.Parse(typeof(EmployeeType), type, true);
        }
        public double CalcSalary(double wage)
        {
            int hours = this._hours;
            EmployeeType type = this._type;
            
            // method for calculating salary for generic employee
            Dictionary<EmployeeType, List<Ranks>> employeeRanks = new Dictionary<EmployeeType, List<Ranks>> ();
            employeeRanks.Add(EmployeeType.Cleaner, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.Paramedic, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.Medic, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.Nurse, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.FoodDistributer, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.Intern, new List<Ranks> { Ranks.Junior });
            employeeRanks.Add(EmployeeType.HeadCleaner, new List<Ranks> {Ranks.Senior });
            employeeRanks.Add(EmployeeType.Cook, new List<Ranks> { Ranks.Senior });
            employeeRanks.Add(EmployeeType.OB, new List<Ranks> { Ranks.Senior });
            employeeRanks.Add(EmployeeType.Doctor, new List<Ranks> { Ranks.Senior });
            employeeRanks.Add(EmployeeType.MasterCleaner, new List<Ranks> { Ranks.DecisionMaker });
            employeeRanks.Add(EmployeeType.BreachOB, new List<Ranks> { Ranks.Junior, Ranks.Expert });
            employeeRanks.Add(EmployeeType.ToxCleaner, new List<Ranks> { Ranks.Junior, Ranks.Expert, Ranks.DecisionMaker, Ranks.Risk });
            employeeRanks.Add(EmployeeType.SuChef, new List<Ranks> { Ranks.Senior, Ranks.Expert });
            employeeRanks.Add(EmployeeType.Chef, new List<Ranks> { Ranks.Senior, Ranks.Expert, Ranks.DecisionMaker });
            employeeRanks.Add(EmployeeType.ExpertDoctor, new List<Ranks> { Ranks.Senior, Ranks.Expert });
            employeeRanks.Add(EmployeeType.HeadOfManagement, new List<Ranks> { Ranks.Manager, Ranks.DecisionMaker });
            employeeRanks.Add(EmployeeType.VPDepartmentManager, new List<Ranks> { Ranks.Manager, Ranks.DecisionMaker });
            employeeRanks.Add(EmployeeType.BreachOBIntern, new List<Ranks> { Ranks.Junior, Ranks.Expert });
            employeeRanks.Add(EmployeeType.HeadNurse, new List<Ranks> { Ranks.Senior, Ranks.DecisionMaker });
            employeeRanks.Add(EmployeeType.DepartmentManager, new List<Ranks> { Ranks.Manager, Ranks.DecisionMaker, Ranks.Risk });

            double risk = 0;
            double bonus = 0;
            double baseSalary;
            // Check to see if employee is manager for global wage salary
            if (employeeRanks[type].Contains(Ranks.Manager))
                baseSalary = wage;
            else
                baseSalary = hours * wage;

            foreach (EmployeeType key in employeeRanks.Keys)
            {
                if (!key.Equals(type))
                    continue;
                // risk factor specifically for relevant employees.
                if (key.Equals(EmployeeType.ToxCleaner))
                    risk = 0.2;
                if (key.Equals(EmployeeType.DepartmentManager))
                    risk = 1;
                
                foreach (Ranks rank in employeeRanks[key])
                {
                    switch (rank)
                    {
                        // 5% bonus
                        case Ranks.Senior:
                            bonus += baseSalary * 0.05;
                            break;
                        // 30% bonus
                        case Ranks.Expert:
                            bonus += baseSalary * 0.3;
                            break;
                        // 50% bonus if over 50 working hours - regular worker gets bonus for 200 hrs, manager gets bonus over global wage
                        case Ranks.DecisionMaker:
                            if (hours > 50)
                                // checks if employee is manager
                                if (employeeRanks[type].Contains(Ranks.Manager))
                                    bonus += wage * 0.5;
                                else
                                    bonus += 200 * wage * 0.5;
                            break;
                        // risk bonus, specific for each risked employee
                        case Ranks.Risk:
                            if (type.Equals(EmployeeType.DepartmentManager))
                                bonus = + wage * risk;
                            else
                                bonus += wage * hours * risk;
                            break;
                    }
                }
            }
            
            return baseSalary + bonus;
        }
        public override string ToString()
        {

            return "Employee Setails:" + "\n"
                + "Name: " + this._name + "\n"
                + "Profession: " + this._type.ToString() + "\n"
                + "Hours worked so far: " + this._hours + "\n";
        }

    }

    enum EmployeeType
    {
        Cleaner,
        ToxCleaner,
        HeadCleaner,
        MasterCleaner,
        Cook,
        SuChef,
        Chef,
        FoodDistributer,
        HeadOfManagement,
        Paramedic,
        Nurse,
        Medic,
        HeadNurse,
        OB,
        BreachOB,
        Intern,
        BreachOBIntern,
        Doctor,
        SeniorDoctor,
        ExpertDoctor,
        VPDepartmentManager,
        DepartmentManager
    }

    enum Ranks
    {
        Junior,
        Senior,
        Expert,
        DecisionMaker,
        Manager,
        Risk
    }

    
}

