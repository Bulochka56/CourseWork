using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;
using System.Reflection;

namespace Coursework
{
    class EmployeesList : Lists
    {
        public EmployeesList(string filename) : base(filename, "EmployeesList") 
        {
            if (employees == null)
            {
                Messages.ErrorFile();
                return;
            }
            listSize = employees.Count();
        }
        
        public List<Employee> Employees
        {
            get { return employees; }
        }

        public override void DisplayListInfo()
        {
            var table = new ConsoleTable("№","Имя", "Должность","Номер телефона","Оклад");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(i+1,employees[i].Name, employees[i].Title, employees[i].PhoneNumber, employees[i].Salary);
            }
            table.Write(Format.Alternative);
        }
        public override void RemoveByIndex()
        {
            Console.WriteLine("Введите номер сотрудника:");
            int i = -1;
            Errors.CheckNumber(ref i);
            while (!(i >= -1 && i <= employees.Count))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:Cотрудника под таким номером нет");
                Console.ResetColor();
                Console.WriteLine("Введите номер сотрудника:");
                Errors.CheckNumber(ref i);
            }
            employees.RemoveAt(i-1);
            listSize--;
        }
        public override void AddByConsole()
        {
            string name = "";
            string title = "";
            int salary = -1;
            string phoneNumber = "";
            Console.WriteLine("Введите ФИО сотрудника:");
            Errors.CheckName(ref name);
            Console.WriteLine("Введите должность сотрудника:");
            Errors.CheckStr(ref title);
            Console.WriteLine("Введите телефонный номер сотрудника в формате +7(###)###-##-## : ");
            Errors.CheckPhoneNumber(ref phoneNumber);
            Console.WriteLine("Введите оклад сотрудника:");
            Errors.CheckNumber(ref salary);
            employees.Add(new Employee(name, title,phoneNumber,salary));
            listSize++;
        }
        public override void SortByField()
        {
            Console.WriteLine("Введите назание поля, по которому нужно отсортировать: ");
            string field = "";
            Errors.CheckEmployeeField(ref field);
            if (field == "Имя")
            {
                employees = employees.OrderBy(i => i.Name).ToList();
            }
            if (field == "Должность")
            {
                employees = employees.OrderBy(i => i.Title).ToList();
            }
            if (field == "Номер телефона")
            {
                employees = employees.OrderBy(i => i.PhoneNumber).ToList();
            }
            if (field == "Оклад")
            {
                employees = employees.OrderBy(i => i.Salary).ToList();
            }
        }
    }
}
