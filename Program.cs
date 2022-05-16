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
            WorksList objextWork = null;
            while (menu !=0)
            {
                Messages.DisplayMenu();
                Console.Write("Введите значение: ");
                Errors.CheckMenu(ref menu);
                if (!(menu >= 0 && menu <= 3))
                {
                    Messages.ErrorMenu();
                }
                if (menu == 1)
                {
                    Menu.DoEmployeesMenu(ref objectEmployees);
                }
                if (menu == 2)
                {
                    Menu.DoWorkTypesMenu(ref objectWorkTypes);
                }
                if(menu == 3)
                {
                    Menu.DoWorksMenu(ref objextWork, ref objectEmployees, ref objectWorkTypes);
                }


            }
            Messages.DisplayEndOfProgramm();
            Console.ReadKey();
        }
    }
}
