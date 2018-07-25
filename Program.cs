using System;
using System.Collections.Generic;

namespace interfacepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // regular employee information
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.firstname = "Hazel";
            emp1.lastname = "Fry";
            emp1.id = 0;
            emp1.Employeeid = 101;
            emp1.Department = "Electronics";
            employees.Add(emp1);

            Employee emp2 = new Employee();
            emp2.firstname = "William";
            emp2.lastname = "Gardner";
            emp2.id = 1;
            emp2.Employeeid = 102;
            emp2.Department = "Outdoors";
            employees.Add(emp2);

            Employee emp3 = new Employee();
            emp3.firstname = "Gary";
            emp3.lastname = "Brown";
            emp3.id = 2;
            emp3.Employeeid = 103;
            emp3.Department = "Cashier";
            employees.Add(emp3);

            
            // manager information
            List<Manager> managers = new List<Manager>();
            Manager mgr1 = new Manager();
            mgr1.id = 3;
            mgr1.firstname = "Francis";
            mgr1.lastname = "Dabney";
            mgr1.Employeeid = 201;
            mgr1.Department = "Store Management";
            mgr1.Duty = "Supervise";
            managers.Add(mgr1);

            Manager mgr2 = new Manager();
            mgr2.id = 4;
            mgr2.firstname = "Paul";
            mgr2.lastname = "Stevens";
            mgr2.Employeeid = 202;
            mgr2.Department = "Human Resources";
            mgr2.Duty = "Payroll";
            managers.Add(mgr2);

            Manager mgr3 = new Manager();
            mgr3.id = 5;
            mgr3.firstname = "Wendy";
            mgr3.lastname = "Woods";
            mgr3.Employeeid = 203;
            mgr3.Department = "Human Resources";
            mgr3.Duty = "Behavioral Checks";
            managers.Add(mgr3);
            // customer information

            // foreach manager, call an approve or reject to all employee timesheets
            foreach(Manager mgr in managers)
            {
                foreach(Employee emp in employees)
                {
                    Console.Write($"Checking timesheet for {emp.firstname} {emp.lastname}\n");
                    if (emp.id < 2)
                    {
                        // approve
                        Console.Write(mgr.Approve());
                    }
                    else
                    {
                        Console.Write(mgr.Reject());
                    }
                }
            }
            // print out all employees
            Console.Write("\nList of employees... \n\n");
            foreach(Employee emp in employees)
            {
                Console.Write($"{emp.firstname} {emp.lastname}\n");
            }
        }
    }
}
