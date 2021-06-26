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
            // All loops will run until user 

            // Calls creation methos - employees to use
            EmplopyeeFactory ef = new EmplopyeeFactory();
            List<Employee> employeeList = ef.CreateEmployees();
            int actionChoice;
            string action = "start";
            int employeeId;
            // exit option from main menu
            while (!action.Equals('q'))
            {
                Console.WriteLine("Menu:");
                Console.Write("1 - Add hours for employee, 2 - Calculate Employee Salary, 3 - Get employee Details,  q - Exit: ");
                action = Console.ReadLine();
                // checks if user wants to exit or if no input was given
                if (string.IsNullOrEmpty(action))
                    continue;
                else
                {
                    if (action.Equals("q"))
                        break;
                    else
                        actionChoice = Convert.ToInt32(action);
                }
                string input = "start";
                while (!input.Equals('q'))
                {
                    Console.WriteLine("Enter employee ID (1 - {0}) to take actions for, (q) to go back: ", employeeList.Count);
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        continue;
                    else
                    {
                        if (input.Equals("q"))
                            break;
                        else
                            employeeId = Convert.ToInt32(input);
                    }
                    if (employeeId < employeeList.Count + 1 && employeeId > 0)
                    {
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.ID.Equals(employeeId))
                            {
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
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorect ID...\n");
                        continue;
                    }

                }
            }
        }
        public static void EmployeeAddHours(Employee emp)
        {
            string startTime = "start";
            while (!startTime.Equals('q'))
            {
                Console.WriteLine("Enter start time (dd/MM/yyyy HH:mm), (q) - to go back: ");
                startTime = Console.ReadLine();
                if (string.IsNullOrEmpty(startTime))
                    continue;
                else
                {
                    if (startTime.Equals("q"))
                        break;
                }
                CultureInfo invariant = System.Globalization.CultureInfo.InvariantCulture;
                DateTime start;
                if (DateTime.TryParseExact(startTime, "dd/MM/yyyy HH:mm", invariant, DateTimeStyles.None, out start))
                {
                    while (!startTime.Equals('q'))
                    {
                        Console.WriteLine("Enter end time (dd/MM/yyyy HH:mm), (q) - to go back: ");
                        string endTime = Console.ReadLine();
                        if (string.IsNullOrEmpty(endTime))
                            continue;
                        else
                        {
                            if (endTime.Equals("q"))
                                break;
                        }
                        DateTime end;
                        if (DateTime.TryParseExact(endTime, "dd/MM/yyyy HH:mm", invariant, DateTimeStyles.None, out end))
                        {
                            TimeSpan hours = end - start;
                            if (hours.TotalHours < 0)
                                Console.WriteLine("End time has to be later than start time");
                            else
                            {
                                double totalHours = emp.AddHours(hours.TotalHours);
                                Console.WriteLine("Added {0} hours to employee {1}, Total hours so far: {2}", hours.TotalHours, emp.ID, totalHours);
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect End Time...");
                            continue;
                        }
                    }
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect Start Time...");
                    continue;
                }
            }
            
        }

        public static void CalculateSalary(Employee emp)
        {
            Console.WriteLine("Enter the wage for employees (global wage for management): ");
            int wage = Convert.ToInt32(Console.ReadLine());
            double salary = emp.CalcSalary(wage);
            Console.WriteLine("Employee {0} current salary is: {1} nis", emp.ID.ToString(), salary.ToString());
            
        }
    }
}
