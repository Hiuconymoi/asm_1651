
using ASM.Companyy;
using ASM.Employees;
using ASM.Experiences;
using ASM.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            // Experience
            IExperience intern = new Intern();
            IExperience junior = new Junior();
            IExperience senior = new Senior();
            IExperience leader = new Leader();
            //Position
            var businessAnalyst = new BusinessAnalyst("Business Analyst");
            var developer = new Developer("Developer");
            var tester = new Tester("Tester");          
            // Employee
            Employee e1 = new Employee("Dao Van Hieu", developer, junior, 190, 20, 1);
            Employee e2 = new Employee("Nguyen Van Hieu", developer, senior, 200, 0, 7);
            Employee e3 = new Employee("Le Anh Quan", tester, leader, 170, 25, 10);
            Employee e4 = new Employee("Tran Trung Kien", tester, senior, 180, 30, 5);
            Employee e5 = new Employee("Nguyen Thanh Nam", businessAnalyst, intern, 200, 40, 0);
            Employee e6 = new Employee("Dam Hong Hai", businessAnalyst, leader, 168, 0, 11);
            //company
            Company company = new Company();
            company.Add(e1);
            company.Add(e2);
            company.Add(e3);
            company.Add(e4);
            company.Add(e5);
            company.Add(e6);
            bool check = false;
            while (!check)
            {
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|                    MENU                    |");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("| 1. Employees Salary                        |");
                Console.WriteLine("| 2. Overtime Slary                          |");
                Console.WriteLine("| 3. Subtraction Salary                      |");
                Console.WriteLine("| 4. Exit                                    |");
                Console.WriteLine("+--------------------------------------------+");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        employeeSalary();
                        break;
                    case "2":
                        overtimeSalary();
                        break;
                    case "3":
                        subtractionSalary();
                        break;
                    case "4":
                        check = true;
                        break;
                    default:
                        break;
                }
            }
            // Employee Salary
            void employeeSalary()
            {
                Console.WriteLine("+----------------------+--------------------+---------------+---------------+------------+-------------+");
                Console.WriteLine("|         Name         |      Position      |     Level     |   Experience  |  Hourwork  |   Salary    |");
                Console.WriteLine("+----------------------+--------------------+---------------+---------------+------------+-------------+");

                foreach (var employee in company.Employees)
                {
                    Console.WriteLine("| " + employee.Name.PadRight(19) + "  | " +
                                      employee.Position.name.PadRight(17) + "  | " +

                                      employee.Level.ToString().Split('.').Last().PadRight(12) + "  | " +
                                      employee.Experience.ToString().PadRight(12) + "  | " +
                                      employee.HourWork.ToString().PadRight(10) + " | " +
                                      employee.CalculateSalary().ToString("C").PadRight(10) + "  | ");
                }

                Console.WriteLine("+----------------------+--------------------+---------------+---------------+------------+-------------+");

            }
            // Overtime Salary
            void overtimeSalary()
            {
                Console.WriteLine("+----------------------+------------+-------------+");
                Console.WriteLine("|         Name         |  Overtime  |   Salary    |");
                Console.WriteLine("+----------------------+------------+-------------+");

                foreach (var employee in company.Employees)
                {
                    Console.WriteLine("| " + employee.Name.PadRight(19) + "  | " +
                                      employee.OverTime.ToString().PadRight(10) + " | " +
                                      "$"+employee.OvertimeSalary().ToString().PadRight(10) + " | ");
                }

                Console.WriteLine("+----------------------+------------+-------------+");
            }
            // Employees Salary

            void subtractionSalary()
            {
                Console.WriteLine("+----------------------+------------+-------------+");
                Console.WriteLine("|         Name         |   Absent   | Subtraction |");
                Console.WriteLine("+----------------------+------------+-------------+");

                foreach (var employee in company.Employees)
                {
                    Console.WriteLine("| " + employee.Name.PadRight(19) + "  | " +
                                      (200 - employee.HourWork).ToString().PadRight(10) + " | " +
                                      "$"+employee.SubtractionSalary().ToString().PadRight(10) + "$ | ");
                }

                Console.WriteLine("+----------------------+------------+-------------+");
            }
        }
    }
}
