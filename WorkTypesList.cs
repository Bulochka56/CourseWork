using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Coursework
{
    class WorkTypesList : Lists
    {
        public WorkTypesList(string filename) : base(filename, "WorkTypesList")
        {
            if (workTypes == null)
            {
                Messages.ErrorFile();
                return;
            }
            listSize = workTypes.Count();
        }
        public List<WorkType> WorkTypes
        {
            get { return workTypes; }
        }

        public override void DisplayListInfo()
        {
            var table = new ConsoleTable("№", "Описание", "Рекомендуемая должность", "Оплата за день", "Количество работников");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(i + 1, workTypes[i].Description, workTypes[i].Recommendation, workTypes[i].Payment, workTypes[i].NumberOfEmployees);
            }
            table.Write(Format.Alternative);
        }
        public override void RemoveByIndex()
        {
            Console.WriteLine("Введите номер типа работы:");
            int i = -1;
            Errors.CheckNumber(ref i);
            while (!(i >= 0 && i <= workTypes.Count))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:Вида работы под таким номером нет");
                Console.ResetColor();
                Console.WriteLine("Введите номер типа работы");
                Errors.CheckNumber(ref i);
            }
            workTypes.RemoveAt(i - 1);
            listSize--;
        }
        public override void AddByConsole()
        {
            string description = "";
            string recommendation = "";
            int payment = 0;
            int numberOfEmployees = 0;
            Console.WriteLine("Введите описание типа работы:");
            Errors.CheckStr(ref description);
            Console.WriteLine("Введите рекомендованную должность для типа работы:");
            Errors.CheckStr(ref recommendation);
            Console.WriteLine("Введите оплату за день типа работы:");
            Errors.CheckNumber(ref payment);
            Console.WriteLine("Введите кол-во сотрудников для данного типа работы:");
            Errors.CheckNumber(ref numberOfEmployees);
            workTypes.Add(new WorkType(description, recommendation, payment, numberOfEmployees));
            listSize++;
        }
        public override void SortByField()
        {
            Console.WriteLine("Введите назание поля, по которому нужно отсортировать: ");
            string field = "";
            Errors.CheckWorkTypesField(ref field);
            if (field == "Описание")
            {
                workTypes = workTypes.OrderBy(i => i.Description).ToList();
            }
            if (field == "Рекомендуемая должность")
            {
                workTypes = workTypes.OrderBy(i => i.Recommendation).ToList();
            }
            if (field == "Оплата за день")
            {
                workTypes = workTypes.OrderBy(i => i.Payment).ToList();
            }
            if (field == "Количество работников")
            {
                workTypes = workTypes.OrderBy(i => i.NumberOfEmployees).ToList();
            }
        }
    }
}
