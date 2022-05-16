using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Coursework
{
    abstract class Lists
    {
        protected List<Employee> employees = new List<Employee>();
        protected List<WorkType> workTypes = new List<WorkType>();
        protected int listSize;
        public Lists(string filename,string listName) 
        {
            dynamic[] classFields = new dynamic[4];
            while (!Errors.CheckFile(filename))
            {
                Console.WriteLine("Введите имя файла для создания списка:");
                filename = Console.ReadLine() + ".txt";
            }
            
            StreamReader input = new StreamReader(filename);
            while (!(input.EndOfStream))
            {
                int number;
                string[] line = input.ReadLine().Split(';');
                for (int i = 0; i < 4; i++)
                {
                    if (Int32.TryParse(line[i], out number))
                    {
                        classFields[i] = number;
                    }
                    else
                    {
                        classFields[i] = line[i];
                    }
                    
                }
                if (listName == "WorkTypesList")
                {
                    try
                    {
                        workTypes.Add(new WorkType(classFields[0], classFields[1], classFields[2], classFields[3]));
                    }
                    catch(Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: Неверно заданы данные в файле типов работ");
                        Console.ResetColor();
                        workTypes = null;
                        return;
                    }
                }
                else
                {
                    try
                    {
                        employees.Add(new Employee(classFields[0], classFields[1], classFields[2], classFields[3]));
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: Неверно заданы данные одной из строчек в файле сотрудников");
                        Console.ResetColor();
                        employees = null;
                        return;
                    }
                }
            }
            input.Close();
        }
        public int ListSize
        {
            get { return listSize; }
        }
        public abstract void DisplayListInfo();

        public abstract void RemoveByIndex();

        public abstract void AddByConsole();

        public abstract void SortByField();
    }
}
