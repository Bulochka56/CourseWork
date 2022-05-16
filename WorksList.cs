using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using System.IO;

namespace Coursework
{
    class WorksList
    {
        List<Work> works = new List<Work>();
        public WorksList(EmployeesList employees, WorkTypesList workTypes)
        {
            AddWork(employees, workTypes);
        }


        public void AddWork(EmployeesList employees, WorkTypesList workTypes)
        {
            int typeIndex = -1;
            workTypes.DisplayListInfo();
            Console.WriteLine("Введите номер типа работы");
            Errors.CheckNumber(ref typeIndex);
            while (!(typeIndex >= 0 && typeIndex <= workTypes.WorkTypes.Count))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:Вида работы под таким номером нет");
                Console.ResetColor();
                Console.WriteLine("Введите номер типа работы");
                Errors.CheckNumber(ref typeIndex);
            }
            typeIndex--;


            List<Employee> employeesForWork = new List<Employee>();
            int employeesIndex = 0;
            employees.DisplayListInfo();
            Console.WriteLine("Рекомендуемые сотрудники:");
            for (int i = 0; i < employees.ListSize; i++)
            {
                if (employees.Employees[i].Title == workTypes.WorkTypes[typeIndex].Recommendation)
                {
                    employees.Employees[i].DisplayInfo();
                }
            }
            if (workTypes.WorkTypes[typeIndex].NumberOfEmployees == 1)
            {
                Console.WriteLine("Введите номер работника для этой работы:");
                Errors.CheckNumber(ref employeesIndex);
                while (!(typeIndex >= 0 && typeIndex <= employees.Employees.Count))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка:Сотрудника под таким номером нет");
                    Console.ResetColor();
                    Console.WriteLine("Введите номер работника для этой работы:");
                    Errors.CheckNumber(ref employeesIndex);
                }
                employeesIndex--;
            }
            else
            {
                while (employeesForWork.Count != workTypes.WorkTypes[typeIndex].NumberOfEmployees)
                {
                    Console.WriteLine("Введите номера работников для этой работы через пробел:");
                    string str = "";
                    Errors.CheckEmployeesNumbers(ref str, workTypes.WorkTypes[typeIndex].NumberOfEmployees);
                    string[] line = (str.Split(' '));
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(Errors.CheckNumber(line[i], ref employeesIndex)))
                        {
                            i = line.Length;
                            employeesForWork = null;
                        }
                        else
                        {
                            employeesForWork.Add(employees.Employees[employeesIndex - 1]);
                        }
                    }
                }
            }

            Console.WriteLine("Введите дату начала работы через точки:");
            string date = "";
            int day = 0;
            int mounth = 0;
            int year = 0;
            Errors.CheckDate(date, ref day, ref mounth, ref year);
            DateTime dateStart = new DateTime(year, mounth, day);

            Console.WriteLine("Введите дату окончания работы через точки:");
            Errors.CheckDate(date, ref day, ref mounth, ref year);
            DateTime dateEnd = new DateTime(year, mounth, day);

            if (workTypes.WorkTypes[typeIndex].NumberOfEmployees == 1)
            {
                works.Add(new Work(employees.Employees[employeesIndex], workTypes.WorkTypes[typeIndex], dateStart, dateEnd));
            }
            else
            {
                works.Add(new Work(employeesForWork, workTypes.WorkTypes[typeIndex], dateStart, dateEnd));
            }
            Console.Clear();

        }
        public void DisplayListInfo()
        {
            var table = new ConsoleTable("№", "Имя", "Описание работы", "Дата начала работы", "Дата окончания работы");
            for (int i = 0; i < works.Count; i++)
            {
                if (works[i].WorkType.NumberOfEmployees == 1)
                {
                    table.AddRow(i + 1, works[i].Employee.Name, works[i].WorkType.Description, works[i].DateStart.ToString("dd.MM.yyyy"), works[i].DateEnd.ToString("dd.MM.yyyy"));
                }
                else
                {
                    string names = "";
                    for (int j = 0; j < works[i].Employees.Count - 1; j++)
                    {
                        names += $"{works[i].Employees[j].Name}, ";
                    }
                    names += works[i].Employees[works[i].Employees.Count - 1].Name;
                    table.AddRow(i + 1, names, works[i].WorkType.Description, works[i].DateStart.ToString("dd.MM.yyyy"), works[i].DateEnd.ToString("dd.MM.yyyy"));
                }
            }
            table.Write(Format.Alternative);

        }
        public void RemoveWork()
        {
            Console.WriteLine("Введите номер работы:");
            int i = -1;
            Errors.CheckNumber(ref i);
            while (!(i >= 1 && i <= works.Count))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:Работы под таким номером нет");
                Console.ResetColor();
                Console.WriteLine("Введите номер работы");
                Errors.CheckNumber(ref i);
            }
            works.RemoveAt(i - 1);
        }
        public void WagesCalculation(EmployeesList employees)
        {
            List<Wages> wages = new List<Wages>();
            var table = new ConsoleTable("№", "Имя", "Зарплата", "Кол-во дополнительных работ");
            for (int i = 0; i < employees.Employees.Count; i++)
            {
                wages.Add(new Wages(employees.Employees[i].Name, employees.Employees[i].Salary));
                for (int j = 0; j < works.Count; j++)
                {
                    if (works[j].WorkType.NumberOfEmployees == 1)
                    {
                        if (employees.Employees[i].Name == works[j].Employee.Name)
                        {
                            wages[i].Wage += (works[j].WorkType.Payment * works[j].WorkDays);
                            wages[i].QuantityOfWork++;
                        }
                    }
                    else
                    {
                        for (int z = 0; z < works[j].Employees.Count; z++)
                        {
                            if (employees.Employees[i].Name == works[j].Employees[z].Name)
                            {
                                wages[i].Wage += works[j].WorkType.Payment * works[j].WorkDays;
                                wages[i].QuantityOfWork++;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < wages.Count; i++)
            {
                wages[i].CheckBonus();
                table.AddRow(i + 1, wages[i].Name, wages[i].Wage, wages[i].QuantityOfWork);
            }
            table.Write(Format.Alternative);
            Console.WriteLine($"Общая заработная плата всех сотрудников = {wages.Sum(x => x.Wage)}");
        }
        public void WriteToFile()
        {
            Console.WriteLine("Введите имя файла в который вы хотите записать работы");
            string filename = Console.ReadLine() + ".txt";
            StreamWriter output = new StreamWriter(filename);
            for (int i = 0; i < works.Count; i++)
            {
                if (works[i].WorkType.NumberOfEmployees == 1)
                {
                    output.WriteLine($"{works[i].Employee.Name}|{works[i].WorkType.Description}|{works[i].DateStart.ToString("dd.MM.yyyy")}|{works[i].DateEnd.ToString("dd.MM.yyyy")}");
                }
                else
                {
                    string names = "";
                    int lengthList = works[i].Employees.Count - 1;
                    for (int j = 0; j < lengthList; j++)
                    {
                        names += $"{works[i].Employees[j].Name},";
                    }
                    names += works[i].Employees[lengthList].Name;
                    output.WriteLine($"{names}|{works[i].WorkType.Description}|{works[i].DateStart.ToString("dd.MM.yyyy")}|{works[i].DateEnd.ToString("dd.MM.yyyy")}");
                }
            }
            output.Close();
        }
    }
}

