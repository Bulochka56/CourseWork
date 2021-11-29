using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Coursework
{
    class Employee
    {
        string name; //ФИО сотруднка
        int salary; //должность
        string title; //оклад
        string phoneNumber; //телефон 
        public Employee(string name, string title,int salary,string phoneNumber)
        {
            this.name = name;
            this.title = title;
            this.salary = salary;
            this.phoneNumber = phoneNumber;
        }
        public string Name
        {
            get { return this.name; }
            
        }
        public int Salary
        {
            get{ return this.salary; }
        }
        public string Title
        {
            get { return this.title; }
            
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
        }
        
    }
    class WorkType
    {
        string description; //Описание работы
        string recommendation; //Рекомендуемая должность на эту работу
        int payment; //Оплата за день 
        public WorkType(string description, string recommendation, int payment)
        {
            this.description = description;
            this.recommendation = recommendation;
            this.payment = payment;
        }
        public string Description
        {
            get { return this.description; }
            
        }
        public string Recommendation
        {
            get { return this.recommendation; }
        }
        public int Payment
        {
            get { return this.payment; }
        }

    }
    class Works
    {
        Employee employee;
        WorkType workType;
        DateTime dateStart;
        DateTime dateEnd;
        public Employee Employee
        {
            get
            {
                return this.employee;
            }
        }
        public WorkType WorkType
        {
            get
            {
                return this.workType;
            }
        }
        public DateTime DateStart
        {
            get
            {
                return this.dateStart;
            }
        }
        public DateTime DateEnd
        {
            get
            {
                return this.dateEnd;
            }
        }
    }
}
