using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coursework
{
    class Errors
    {
        public static bool CheckFile(string filename) // Проверка на открытие файла
        {
            try
            {
                StreamReader test = new StreamReader(filename);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ResetColor();
                return false;
            }
            return true;
        }

        
    }
}
