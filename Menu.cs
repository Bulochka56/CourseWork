using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Menu
    {
        public static void DoEmployeesMenu(EmployeesList objectEmployees)
        {
            int menu = 10;
            Console.Clear();
            if (objectEmployees == null)
            {
                Messages.CreatEmployeesList();
                string filename = Console.ReadLine() + ".txt";
                objectEmployees = new EmployeesList(filename);
                Console.Clear();
            }
            
            while (menu != 0)
            {
                Messages.DisplayEmployeesMenu();
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
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
                if (menu == 4)
                {
                    objectEmployees.SortEmployees();
                    objectEmployees.DisplayEmployeesInfo();
                }
            }
            Console.Clear();
            menu = 10;
        }
    }
}
