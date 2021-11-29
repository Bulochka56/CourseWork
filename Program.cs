using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 10;
            EmployeesList objectEmployees = null;
            WorkTypesList objectWorkTypes = null;
            while (menu !=0)
            {
                Messages.DisplayMenu();
                Console.Write("Введите значение: ");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.ResetColor();

                }

                if (menu == 1)
                {
                    Console.Clear();
                    if(objectEmployees == null)
                    {
                        Messages.CreatEmployeesList();
                        string filename = Console.ReadLine() + ".txt";
                        objectEmployees = new EmployeesList(filename);
                        Console.Clear();
                    }
                    Messages.DisplayEmployeesMenu();
                    while(menu != 0)
                    {

                        menu = Convert.ToInt32(Console.ReadLine());
                        if (menu == 1)
                        {
                            objectEmployees.DisplayEmployeesInfo();
                        }
                        if (menu == 2)
                        {
                            objectEmployees.RemoveEmployee();
                        }
                        if (menu == 3)
                        {
                            objectEmployees.AddEmployee();
                        }
                    }
                    Console.Clear();
                    menu = 10;
                }
                if (menu == 2)
                {
                    WorkTypesList objectContract = new WorkTypesList();
                    objectContract.DisplayWorkTypesInfo();
                }
                
                
            }
            Messages.DisplayEndOfProgramm();
            Console.ReadKey();
        }
    }
}
