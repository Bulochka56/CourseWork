using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Coursework
{
    class EmployeesList
    {
        List<Employee> Employees = new List<Employee>();
        int listSize;

        public EmployeesList(string filename)
        {
            string name = "";
            string title = "";
            int salary = 0;
            string phoneNumber = "";

            Errors.CheckFile(filename);
            StreamReader input = new StreamReader(filename);
            while (!(input.EndOfStream))
            {
                string[] line = input.ReadLine().Split(';');
                name = line[0];

                title = line[1];
                phoneNumber = line[2];
                if (!Int32.TryParse(line[3], out salary))
                {
                    break;
                }

                Employees.Add(new Employee(name, title,salary,phoneNumber));
            }
            input.Close();
            listSize = Employees.Count;
            
        }//конец конструктора


        public void DisplayEmployeesInfo()
        {
            var table = new ConsoleTable("№","Имя", "Должность","Номер телефона","Оклад");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(i+1,Employees[i].Name, Employees[i].Title, Employees[i].PhoneNumber, Employees[i].Salary);
            }
            table.Write(Format.Alternative);
        }
        public void RemoveEmployee()
        {
            Console.WriteLine("Введите номер сотрудника:");
            int i = Convert.ToInt32(Console.ReadLine());
            Employees.RemoveAt(i-1);
            listSize--;
        }
        public void AddEmployee()
        {
            string name = "";
            string title = "";
            int salary = 0;
            string phoneNumber = "";
            Console.WriteLine("Введите ФИО сотрудника:");
            name = Console.ReadLine();
            Console.WriteLine("Введите должность сотрудника:");
            title = Console.ReadLine();
            Console.WriteLine("Введите телефонный номер сотрудника:");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Введите оклад сотрудника:");
            if (!Int32.TryParse(Console.ReadLine(), out salary))
            {
                Messages.ErrorSalary();
                return;
            }
            Employees.Add(new Employee(name, title, salary, phoneNumber));
            listSize++;
        }
        public void SortEmployees()
        {
            Console.WriteLine("Введите назание поля, по которому нужно отсортировать: ");
            string param = Console.ReadLine();
            if (param == "ФИО")
            {
                Employees =
                    (from employee in Employees
                     orderby employee.Name
                     select employee).ToList();
            }
            if (param == "Должность")
            {
                Employees =
                    (from employee in Employees
                     orderby employee.Title
                     select employee).ToList();
            }
            if (param == "Номер телефона")
            {
                Employees =
                    (from employee in Employees
                     orderby employee.PhoneNumber
                     select employee).ToList();
            }
            if (param == "Оклад")
            {
                Employees =
                    (from employee in Employees
                     orderby employee.Salary
                     select employee).ToList();
            }
        }
        
    }
}
