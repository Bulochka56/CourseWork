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
                    Menu.DoEmployeesMenu(objectEmployees);
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
