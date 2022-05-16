using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Coursework
{
    class Errors
    {
        public static bool CheckFile(string filename) 
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
        public static void CheckMenu(ref int menu)
        {
            while(!Int32.TryParse(Console.ReadLine(),out menu))
            {
                Messages.ErrorMenuConvert();
            }
        }
        public static void CheckNumber(ref int number)
        {
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Messages.ErrorNumber();
            }
        }
        public static void CheckName(ref string name)
        {
            name = Console.ReadLine();
            Regex r = new Regex(@".+ .+ .+");
            while (!(r.Match(name).Success))
            {
                Messages.ErrorName();
                name = Console.ReadLine();
            }
        }
        public static void CheckStr(ref string str)
        {
            str = Console.ReadLine();
            while (str == "")
            {
                Messages.ErrorStr();
                str = Console.ReadLine();
            }
        }
        public static void CheckPhoneNumber(ref string phoneNumber)
        {
            phoneNumber = Console.ReadLine();
            while (phoneNumber == "")
            {
                Messages.ErrorPhoneNumber();
                phoneNumber = Console.ReadLine();
            }
        }
        public static void CheckEmployeeField(ref string field)
        {
            field = Console.ReadLine();
            while (field != "Имя" && field != "Должность" && field != "Номер телефона" && field != "Оклад")
            {
                Messages.ErrorField();
                field = Console.ReadLine();
            }
        }
        public static void CheckWorkTypesField(ref string field)
        {
            field = Console.ReadLine();
            while (field != "Описание" && field != "Рекомендуемая должность" && field != "Оплата за день" && field != "Количество работников")
            {
                Messages.ErrorField();
                field = Console.ReadLine();
            }
        }
        public static void CheckEmployeesNumbers(ref string str,int numberOfEmployees)
        {
            str = Console.ReadLine();
            while (str.Count(x => x == ' ') != numberOfEmployees-1)
            {
                Messages.ErrorEmployeesNumbers();
                str = Console.ReadLine();
            }
        }
        public static bool CheckNumber(string line,ref int number)
        {
            if (!Int32.TryParse(line, out number))
            {
                Messages.ErrorNumber();
                return false;
            }
            return true;
        }
        public static void CheckDate(string str, ref int day, ref int mounth, ref int year)
        {
            bool flag = true;
            Regex r = new Regex(@"[0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[0-9]{4}");
            while (flag)
            {
                str = Console.ReadLine();
                while (!r.Match(str).Success)
                {
                    Messages.ErrorDate();
                    str = Console.ReadLine();
                }
                string[] date = str.Split('.');
                if (!CheckNumber(date[0],ref day) || day>31)
                {
                    flag = true;
                    Messages.ErrorDate();
                }
                else if(!CheckNumber(date[1], ref mounth) || mounth>12)
                {
                    flag = true;
                    Messages.ErrorDate();
                }
                else if (!CheckNumber(date[2], ref year)) 
                {
                    flag = true;
                    Messages.ErrorDate();
                }
                else
                {
                    flag = false;
                }
            }
        }  
    }
}
