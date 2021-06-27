using System;   
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DeliveryDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employeeDict = CreateEmployees();
            Console.WriteLine("Created employees!\nWhich employee would you like to check out?");
            string idChoice = "";
            int employeeId = 0;
            // exit option from main menu
            while (!idChoice.Equals("q"))
            {
                
                Console.WriteLine("Enter employee ID (1 - {0}) to take actions for, (q) to go back: ", employeeDict.Count);
                idChoice = Console.ReadLine();
                try
                {
                    employeeId = int.Parse(idChoice);
                }
                catch
                {
                    continue;
                }

                // Start variable for second loop
                string action = "";
                int actionChoice = 0;
                if (employeeId < employeeDict.Count + 1 && employeeId > 0)
                {
                    Employee emp = employeeDict[employeeId];
                    while (!action.Equals("q"))
                    {

                        Console.Write("1 - Add hours for employee, 2 - Calculate Employee Salary, 3 - Get employee Details,  q - Exit: ");
                        action = Console.ReadLine();
                        try
                        {
                            actionChoice = int.Parse(action);
                        }
                        catch
                        {
                            continue;
                        }


                        switch (actionChoice)
                        {
                            // Add Hours
                            case 1:
                                EmployeeAddHours(emp);
                                break;
                            // Calculate employee salary
                            case 2:
                                CalculateSalary(emp);
                                break;
                            // print employee details
                            case 3:
                                Console.WriteLine(emp.ToString());
                                break;
                        }
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Incorect ID...\n");
                    continue;
                }
            }
        }
        public static Dictionary<int, Employee> CreateEmployees()
        {
            Dictionary<int, Employee> employeeDict = new Dictionary<int, Employee>();
            EmplopyeeFactory ef = new EmplopyeeFactory();
            string employeeChoice = "";
            Console.WriteLine("Menu:");
            string exit = "";
            int id = 0;
            Console.WriteLine("Choose 1 to create new Employee list Or 2 to use random list of employees: ");
            employeeChoice = Console.ReadLine();
            while (!exit.Equals("n"))
            {

                if (employeeChoice.Equals("1"))
                {

                    id++;
                    Console.WriteLine("Enter employee type(1-21): ");
                    try
                    {
                        int type = Convert.ToInt32(Console.ReadLine());
                        if (!Enum.IsDefined(typeof(EmployeeType), type))
                        {
                            Console.WriteLine("Invalid employee type");
                            continue;
                        }
                        try
                        {
                            Console.WriteLine("Enter employee wage for {0}: ", ((EmployeeType)type).ToString());
                            double wage = Convert.ToDouble(Console.ReadLine());
                            employeeDict.Add(id, new Employee(id, ((EmployeeType)type).ToString(), wage));
                            exit = "";
                            while (!(exit.Equals("n") || exit.Equals("y")))
                            {
                                Console.WriteLine("Would you like to continue adding employees? (y/n)");
                                exit = Console.ReadLine();
                            }
                                
                        }
                        catch
                        {
                            Console.WriteLine("Invalid wage");
                            continue;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid type");
                        continue;
                    }
                    

                    

                }
                if (employeeChoice.Equals("2"))
                {
                    // Calls creation methos - employees to use
                    employeeDict = ef.CreateEmployees();
                    break;
                }
                else
                {
                    continue;
                }
            }
            return employeeDict;
        }

        public static void EmployeeAddHours(Employee emp)
        {
            string startTime = "";
            while (!startTime.Equals("q"))
            {
                Console.WriteLine("Enter start time (dd/MM/yyyy HH:mm), (q) - to go back to action menu: ");
                startTime = Console.ReadLine();
                //if (string.IsNullOrEmpty(startTime))
                //    continue;
                CultureInfo invariant = System.Globalization.CultureInfo.InvariantCulture;
                DateTime start;
                try
                {
                    if (startTime.Equals("q"))
                        break;
                    start = DateTime.ParseExact(startTime, "dd/MM/yyyy HH:mm", invariant, DateTimeStyles.None);
                }
                catch
                { 
                    Console.WriteLine("Incorrect Start Time...");
                    continue;
                }
                string endTime = "";
                while (!endTime.Equals("q"))
                {
                    Console.WriteLine("Enter end time (dd/MM/yyyy HH:mm), (q) - to go back to action menu: ");
                    endTime = Console.ReadLine();
                    DateTime end;
                    try
                    {
                        if (endTime.Equals("q"))
                            break;
                        end = DateTime.ParseExact(endTime, "dd/MM/yyyy HH:mm", invariant, DateTimeStyles.None);
                    }
                    catch
                    {
                        
                        Console.WriteLine("Incorrect End Time...");
                        continue;
                    }

                    if (end > start)
                    {
                        // check if more hours than in a month
                        if (!((end - start).TotalHours + emp.Hours > 744))
                        {
                            double hours = emp.AddHours(start, end);
                            double totalHours = emp.Hours;
                            Console.WriteLine("Added {0} hours to employee {1}, Total hours so far: {2}", hours, emp.ID, totalHours);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Maximum hours in month is 744, you are trying to add {0} hours to {1} hours already worked", (end - start).TotalHours, emp.Hours);
                            break;
                        }

                    }
                    else
                        Console.WriteLine("End time has to be later than start time");
                }

                break;

            }
            
        }

        public static void CalculateSalary(Employee emp)
        {
            double salary = emp.CalcSalary();
            Console.WriteLine("Employee {0} current salary is: {1} nis", emp.ID.ToString(), salary.ToString());
            
        }
        
    }
}