using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Menu
    {
        static void CreatEmployees(ref EmployeesList objectEmployees)
        {
            if (objectEmployees == null)
            {
                Messages.CreatEmployeesList();
                string filename = Console.ReadLine() + ".txt";
                objectEmployees = new EmployeesList(filename);
            }
            if (objectEmployees.Employees == null)
            {
                objectEmployees = null;
                return;
            }
        }
        static void CreatWorkTypes(ref WorkTypesList objectWorkTypes)
        {
            if (objectWorkTypes == null)
            {
                Messages.CreatWorkTypesList();
                string filename = Console.ReadLine() + ".txt";
                objectWorkTypes = new WorkTypesList(filename);
            }
            if (objectWorkTypes.WorkTypes == null)
            {
                objectWorkTypes = null;
                return;
            }
        }
        public static void DoEmployeesMenu(ref EmployeesList objectEmployees)
        {
            int menu = 10;
            Console.Clear();
            CreatEmployees(ref objectEmployees);
            Console.Clear();
            while (menu != 0)
            {
                Messages.DisplayEmployeesMenu();
                Errors.CheckMenu(ref menu);
                if (!(menu >= 0 && menu <= 5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка:Нет такого пункта меню");
                    Console.ResetColor();
                }
                Console.Clear();
                if (menu == 1)
                {
                    objectEmployees.DisplayListInfo();
                }
                if (menu == 2)
                {
                    objectEmployees.DisplayListInfo();
                    objectEmployees.RemoveByIndex();
                    Console.Clear();
                    objectEmployees.DisplayListInfo();
                }
                if (menu == 3)
                {
                    objectEmployees.AddByConsole();
                    Console.Clear();
                    objectEmployees.DisplayListInfo();
                }
                if (menu == 4)
                {
                    objectEmployees.DisplayListInfo();
                    objectEmployees.SortByField();
                    Console.Clear();
                    objectEmployees.DisplayListInfo();
                }
                if (menu == 5)
                {
                    objectEmployees = null;
                    CreatEmployees(ref objectEmployees);
                    Console.Clear();
                    objectEmployees.DisplayListInfo();
                }
            }
            Console.Clear();
            menu = 10;
        }
        public static void DoWorkTypesMenu(ref WorkTypesList objectWorkTypes)
        {
            int menu = 10;
            Console.Clear();
            CreatWorkTypes(ref objectWorkTypes);
            Console.Clear();

            while (menu != 0)
            {
                Messages.DisplayWorkTypesMenu();
                Errors.CheckMenu(ref menu);
                if(!(menu >= 0 && menu <= 5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка:Нет такого пункта меню");
                    Console.ResetColor();
                }
                Console.Clear();

                if (menu == 1)
                {
                    objectWorkTypes.DisplayListInfo();
                }
                if (menu == 2)
                {
                    objectWorkTypes.DisplayListInfo();
                    objectWorkTypes.RemoveByIndex();
                    Console.Clear();
                    objectWorkTypes.DisplayListInfo();
                }
                if (menu == 3)
                {
                    objectWorkTypes.AddByConsole();
                    Console.Clear();
                    objectWorkTypes.DisplayListInfo();
                }
                if (menu == 4)
                {
                    objectWorkTypes.DisplayListInfo();
                    objectWorkTypes.SortByField();
                    objectWorkTypes.DisplayListInfo();
                }
                if (menu == 5)
                {
                    objectWorkTypes = null;
                    CreatWorkTypes(ref objectWorkTypes);
                    objectWorkTypes.DisplayListInfo();
                }
            }
            Console.Clear();
            menu = 10;
        }
        public static void DoWorksMenu(ref WorksList objextWork, ref EmployeesList employees, ref WorkTypesList workTypes)
        {
            int menu = 10;
            Console.Clear();
            if (objextWork == null)
            {
                CreatEmployees(ref employees);
                CreatWorkTypes(ref workTypes);
                Console.Clear();
                Messages.CreatWorksList();
            }
            if (objextWork == null)
            {
                objextWork = new WorksList(employees, workTypes);
            }

            while (menu != 0)
            {
                Messages.DisplayWorksMenu();
                Errors.CheckMenu(ref menu);
                if (!(menu >= 0 && menu <= 5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка:Нет такого пункта меню");
                    Console.ResetColor();
                }
                Console.Clear();
                if (menu == 1)
                {
                    objextWork.DisplayListInfo();
                }
                if (menu == 2)
                {
                    objextWork.DisplayListInfo();
                    objextWork.RemoveWork();
                    Console.Clear();
                    objextWork.DisplayListInfo();
                }
                if (menu == 3)
                {
                    objextWork.AddWork(employees, workTypes);
                    objextWork.DisplayListInfo();
                }
                if (menu == 4)
                {
                    objextWork.WagesCalculation(employees);
                }
                if(menu == 5)
                {
                    objextWork.WriteToFile();
                }
            }
            Console.Clear();
        }
    }
}
