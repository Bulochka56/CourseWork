using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleTables;

namespace Coursework
{
    class WorkTypesList
    {
        List<WorkType> BuildedEmployees = new List<WorkType>();
        int listSize;
        string filename = "WorkTypes.txt";

        

        public WorkTypesList()
        {
            string description = "";
            string recommendation = "";
            int payment = 0;

            Errors.CheckFile(filename);
            StreamReader input = new StreamReader(filename);
            while (!(input.EndOfStream))
            {
                string[] line = input.ReadLine().Split(';');
                description = line[0];
                recommendation = line[1];
                if (!Int32.TryParse(line[2], out payment))
                {
                    break;
                }

                BuildedEmployees.Add(new WorkType(description, recommendation,payment));
            }
            input.Close();
            listSize = BuildedEmployees.Count;
        }//конец конструктора


        public void DisplayWorkTypesInfo()
        {
            var table = new ConsoleTable("№", "Описание", "Оплата за день");
            for (int i = 0; i < listSize; i++)
            {
                table.AddRow(i + 1, BuildedEmployees[i].Description, BuildedEmployees[i].Payment);
            }
            table.Write(Format.Alternative);
        }
    }
}
