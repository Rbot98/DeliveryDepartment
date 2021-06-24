using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    // Professional Employees --------------------------------------------------------------------------------------
    class Paramedic : Employee
    {
        public Paramedic(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class Nurse : Employee
    {
        public Nurse(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class Medic : Employee
    {
        public Medic(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }

    class HeadNurse : Employee
    {
        public HeadNurse(string name)
        {
            base.NewEmployee(name);
            _ranks.Add("Senior", 5);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class OB : Employee
    {
        public OB(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("Senior", 5);
        }
    }
    class SpecialOB : Employee
    {
        public SpecialOB(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
            _ranks.Add("Expert", 30);
        }
    }
    class Intern : Employee
    {
        public Intern(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class SpecialOBIntern : Employee
    {
        public SpecialOBIntern(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("junior", 0);
            _ranks.Add("Expert", 30);
        }
    }
    class Doctor : Employee
    {
        public Doctor(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("Senior", 5);
        }
    }
    class SeniorDoc : Employee
    {
        public SeniorDoc(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("Senior", 5);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class ExpertDoc : Employee
    {
        public ExpertDoc(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
        }
    }
    class VPDepartmentManager : Employee
    {
        public VPDepartmentManager(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
        }
    }
    class DepartmentManager : Employee
    {
        public DepartmentManager(string name)
        {
            base.NewEmployee(name);
            _type = 1;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
            _ranks.Add("Risk", 100);
        }
    }
}
