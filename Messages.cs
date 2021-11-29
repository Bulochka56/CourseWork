using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Messages
    {
        static public void DisplayMenu()
        {
            Console.WriteLine(new string('-', 28));
            Console.WriteLine();
            Console.Write(new string(' ', 10));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Меню");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы закрыть меню");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы работать с сотрудниками");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы показать все виды работ");
        }
        static public void DisplayEndOfProgramm()
        {
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Программа завершила свою работу.");
        }
        static public void CreatEmployeesList()
        {
            Console.WriteLine("Необходимо создать список сотрудников.\n" +
                "Введите имя файла для создания списка");
        }
        static public void DisplayEmployeesMenu()
        {
            Console.WriteLine(new string('-', 28));
            Console.WriteLine();
            Console.Write(new string(' ', 10));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сотрудники");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы вывести список сотруднков");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы удалить сотрудника по введёному номеру");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" 3");
            Console.ResetColor();
            Console.WriteLine(", чтобы добавить сотрудника");
        }
        static public void ErrorSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[!] Ошибка в формате оклада сотрудника\n");
            Console.ResetColor();
        }

    }
}
