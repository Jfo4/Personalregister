using System;
using System.Collections.Generic;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            string regOrPrint = "";
            while (regOrPrint != null)
            {
                Console.Clear();
                Console.WriteLine("1. New Employee");
                Console.WriteLine("2. Print out register");
                Console.Write("<Enter> to exit: ");
                string menuChoice = Console.ReadLine();
                if (menuChoice.Length == 0 || menuChoice.Length > 1)
                    regOrPrint = null;

                if (menuChoice.Length > 0)
                {
                    if (int.Parse(menuChoice) == 1)
                    {

                        string newEmpplyee = "";
                        while (newEmpplyee != null)
                        {
                            Console.Clear();
                            Console.WriteLine("New Employee.");
                            Console.Write("Name (<Enter, Enter> to exit) : ");
                            string employeeName = Console.ReadLine();
                            Console.Write("Salary: ");
                            string employeeSalary = Console.ReadLine();
                            
                            if (employeeName.Length > 0 && int.Parse(employeeSalary) > 0)
                            {
                                Console.WriteLine("New Employee...");
                            }
                            else newEmpplyee = null;
                        }
                    }
                    if (int.Parse(menuChoice) == 2)
                    {
                        Console.WriteLine("Print list...");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
