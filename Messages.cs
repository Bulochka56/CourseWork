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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("┌" + new string('┅', 14)+ "┐");
            Console.Write("┇" + new string(' ', 5));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Меню");
            Console.ResetColor();
            Console.Write(new string(' ', 5) + "┇\n");
            Console.WriteLine("└" + new string('┅', 14) + "┘");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы закрыть меню");

            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы работать с сотрудниками");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы работать с видами работ");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 3");
            Console.ResetColor();
            Console.WriteLine(", чтобы работать с распределением доп. работ");
        }
        static public void DisplayEndOfProgramm()
        {
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine(new string('-', 28));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа завершила свою работу.");
        }
        static public void CreatEmployeesList()
        {
            Console.WriteLine("Необходимо создать список сотрудников.\n" +
                "Введите имя файла для создания списка (Рекомендуемый файл Employees)");
        }
        static public void CreatWorkTypesList()
        {
            Console.WriteLine("Необходимо создать список видов работ.\n" +
                "Введите имя файла для создания списка(Рекомендуемый файл WorkTypes)");
        }
        static public void CreatWorksList()
        {
            Console.WriteLine("Для создания списка работ нужно назначить хотя бы 1 дополнительную работу\n");
        }
        static public void DisplayEmployeesMenu()
        {
            Console.WriteLine("┌" + new string('┅', 14) + "┐");
            Console.Write("┇" + new string(' ', 2)); ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Сотрудники");
            Console.ResetColor();
            Console.Write(new string(' ', 2) + "┇\n");
            Console.WriteLine("└" + new string('┅', 14) + "┘");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы вернуться в предыдущее меню");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы вывести список сотруднков");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы удалить сотрудника по введёному номеру");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 3");
            Console.ResetColor();
            Console.WriteLine(", чтобы добавить сотрудника");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 4");
            Console.ResetColor();
            Console.WriteLine(", чтобы отсортировать список сотрудников");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 5");
            Console.ResetColor();
            Console.WriteLine(", чтобы персобрать список сотрудников список сотрудников");
        }
        static public void DisplayWorkTypesMenu()
        {
            Console.WriteLine("┌" + new string('┅', 14) + "┐");
            Console.Write("┇" + new string(' ', 2)); ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Виды работ");
            Console.ResetColor();
            Console.Write(new string(' ', 2) + "┇\n");
            Console.WriteLine("└" + new string('┅', 14) + "┘");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы вернуться в предыдущее меню");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы вывести список вид работ");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы удалить вид работы по введёному номеру");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 3");
            Console.ResetColor();
            Console.WriteLine(", чтобы добавить вид работы");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 4");
            Console.ResetColor();
            Console.WriteLine(", чтобы отсортировать список видов работ");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 5");
            Console.ResetColor();
            Console.WriteLine(", чтобы персобрать список сотрудников список видов работ");
        }
        static public void DisplayWorksMenu()
        {
            Console.WriteLine("┌" + new string('┅', 14) + "┐");
            Console.Write("┇" + new string(' ', 4)); ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Работы");
            Console.ResetColor();
            Console.Write(new string(' ', 4) + "┇\n");
            Console.WriteLine("└" + new string('┅', 14) + "┘");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 0");
            Console.ResetColor();
            Console.WriteLine(", чтобы вернуться в предыдущее меню");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 1");
            Console.ResetColor();
            Console.WriteLine(", чтобы вывести список вид работ");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 2");
            Console.ResetColor();
            Console.WriteLine(", чтобы удалить доп. работу из списка (по введёному номеру)");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 3");
            Console.ResetColor();
            Console.WriteLine(", чтобы добавить вид работ");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 4");
            Console.ResetColor();
            Console.WriteLine(", чтобы высчитать зарплату сотрудников");
            Console.Write("Введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 5");
            Console.ResetColor();
            Console.WriteLine(", чтобы сохранить список дополнительных работ в файл");
        }
        static public void ErrorSalary()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Ошибка в формате оклада сотрудника\n");
            Console.ResetColor();
        }
        static public void ErrorFile()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Файл поврежден или данные заданы неправильно\n");
            Console.ResetColor();
        }
        static public void ErrorMenuConvert()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Неверный формат выбора пункта меню");
            Console.ResetColor();
        }
        static public void ErrorMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Нет такого пункта меню");
            Console.ResetColor();
        }
        static public void ErrorNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат числового поля");
            Console.ResetColor();
        }
        static public void ErrorName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат ФИО сотрудника");
            Console.ResetColor();
        }
        static public void ErrorStr()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат строкового поля");
            Console.ResetColor();
        }
        static public void ErrorPhoneNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат номера телефона сотрудника");
            Console.ResetColor();
        }
        static public void ErrorField()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат названия поля для сортировки");
            Console.ResetColor();
        }
        static public void ErrorEmployeesNumbers()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат введения номеров сотрудников");
            Console.ResetColor();
        }

        static public void ErrorDate()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка:Невеный формат введения даты");
            Console.ResetColor();
        }
    }
}
