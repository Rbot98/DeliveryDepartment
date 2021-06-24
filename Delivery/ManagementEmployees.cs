using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    // Management Employees --------------------------------------------------------------------------------------
    class Cleaner : Employee
    {
        public Cleaner(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("junior", 0);

        }
    }

    class ToxicCleaner : Employee
    {
        public ToxicCleaner(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("junior", 0);
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Expert", 30);
            _ranks.Add("Risk", 20);
        }
    }

    class HeadCleaner : Employee
    {
        public HeadCleaner(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("Senior", 5);
        }
    }

    class MasterCleaner : Employee
    {
        public MasterCleaner(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("DecisionMaker", 50);
        }
    }

    class Cook : Employee
    {
        public Cook(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("Senior", 5);
        }
    }
    class SuChef : Employee
    {
        public SuChef(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
        }
    }
    class Chef : Employee
    {
        public Chef(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("Senior", 5);
            _ranks.Add("Expert", 30);
            _ranks.Add("DecisionMaker", 50);
        }
    }
    class FoodDistributer : Employee
    {
        public FoodDistributer(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("junior", 0);
        }
    }
    class HeadOfManagement : Employee
    {
        public HeadOfManagement(string name)
        {
            base.NewEmployee(name);
            _type = 0;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
        }
    }
}
