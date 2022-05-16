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
        int salary; //оклад
        string title; //должность
        string phoneNumber; //телефон 
        public Employee(string name, string title, string phoneNumber, int salary)
        {
            this.name = name;
            this.title = title;
            this.salary = salary;
            this.phoneNumber = phoneNumber;
        }

        public Employee(string name,int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            
        }
        public int Salary
        {
            get{ return salary; }
        }
        public string Title
        {
            get { return title; }
            
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"| {name} | {title} | {phoneNumber} | {salary}|");
        }
    }
    class WorkType
    {
        string description; //Описание работы
        string recommendation; //Рекомендуемая должность на эту работу
        int payment; //Оплата за день
        int numberOfEmployees; //Количество работников
        public WorkType(string description, string recommendation, int payment, int numberOfEmployees)
        {
            this.description = description;
            this.recommendation = recommendation;
            this.payment = payment;
            this.numberOfEmployees = numberOfEmployees;
        }
        public string Description
        {
            get { return description; }
            
        }
        public string Recommendation
        {
            get { return recommendation; }
        }
        public int Payment
        {
            get { return payment; }
        }
        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
        }
    }
    class Work
    {
        Employee employee;//Сотрудник для этой работы
        List<Employee> employees;
        WorkType workType;//Тип работы
        DateTime dateStart;//Дата начал работы
        DateTime dateEnd;//Дата окончания работы
        int workDays;
        public Work(Employee employee,WorkType workType,DateTime dateStart,DateTime dateEnd)
        {
            this.employee = employee;
            this.workType = workType;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            workDays = (dateEnd - dateStart).Days + 1;
        }
        public Work(List<Employee> employees, WorkType workType, DateTime dateStart, DateTime dateEnd)
        {
            this.employees = employees;
            this.workType = workType;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            workDays = ((dateEnd - dateStart).Days) + 1;
        }
        public Employee Employee
        {
            get { return employee; }
        }
        public WorkType WorkType
        {
            get { return workType; }
        }
        public DateTime DateStart
        {
            get { return dateStart; }
        }
        public DateTime DateEnd
        {
            get { return dateEnd; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
        }
        public int WorkDays
        {
            get { return workDays; }
        }
    }
    class Wages : Employee
    {
        int wage;
        int quantityOfWork;
        public Wages(string name,int salary) : base(name, salary)
        {
            wage = salary;
        }
        public int Wage
        {
            get { return wage; }
            set { wage =  value; }
        }
        public int QuantityOfWork
        {
            get { return quantityOfWork; }
            set { quantityOfWork++; }
        }
        public void CheckBonus()
        {
            if (quantityOfWork >= 5)
            {
                wage += 7000;
            }
        }
    }
}
