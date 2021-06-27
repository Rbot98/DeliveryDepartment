using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDepartment
{
    public enum EmployeeType
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

    public enum Ranks
    {
        Junior,
        Senior,
        Expert,
        DecisionMaker,
        Manager,
        Risk
    }
    class Employee
    {
        protected int _id;
        private double _hours;
        protected EmployeeType _type;
        private double _wage;
        public int ID
        {
            get { return this._id; }
        }
        public double Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        public int Type
        {
            get { return (int)this._type; }
        }
        public Employee(int id, string type, double wage)
        {
            // Create new employee with generic properties, specific properties in child classes
            this._id = id;
            this._hours = 0; // starter of monthly hours
            this._wage = wage;
            this._type = (EmployeeType)Enum.Parse(typeof(EmployeeType), type, true);
        }
        public double AddHours(DateTime start, DateTime end)
        {
            // method to add monthly working hours
            TimeSpan hours = end - start;
            this._hours += hours.TotalHours;
            return hours.TotalHours;

        }
        public double CalcSalary()
        {
            double hours = this._hours;
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
                baseSalary = this._wage;
            else
                baseSalary = hours * this._wage;

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
                                    bonus += this._wage * 0.5;
                                else
                                    bonus += 200 * this._wage * 0.5;
                            break;
                        // risk bonus, specific for each risked employee
                        case Ranks.Risk:
                            if (type.Equals(EmployeeType.DepartmentManager))
                                bonus += this._wage * risk;
                            else
                                bonus += this._wage * hours * risk;
                            break;
                    }
                }
            }
            
            return baseSalary + bonus;
        }
        public override string ToString()
        {

            return "Employee Details:" + "\n"
                + "ID: " + this._id + "\n"
                + "Profession: " + this._type.ToString() + "\n"
                + "Hours worked so far: " + this._hours + "\n"
                + "Wage: " + this._wage;
        }

    }
    
}

