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
    class FoodDistributer : Employee
    {
        public FoodDistributer(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("junior", 0);
        }
    }
    class HeadOfManagement : Employee
    {
        public HeadOfManagement(int id, string name)
        {
            base.NewEmployee(id, name);
            _type = 0;
            _ranks.Add("DecisionMaker", 50);
            _ranks.Add("Manager", 0);
        }
    }
}
