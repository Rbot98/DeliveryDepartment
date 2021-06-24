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

    class HeadNurse : Employee
    {
        public HeadNurse(int id, string name)
        {
            base.NewEmployee(id, name);
            _ranks.Add("Senior", 5);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class OB : Employee
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
    class Intern : Employee
    {
        public Intern(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 1;
            _ranks.Add("junior", 0);
        }
    }
    class SpecialOBIntern : Employee
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
