using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Program
    {
        public class Employee
        {

            private string fullName;
            private DateTime birthDate;
            private string phoneNumber;
            private string workEmail;
            private string position;
            private string jobDescription;


            public Employee() { }


            public Employee(string fullName, DateTime birthDate, string phoneNumber, string workEmail, string position, string jobDescription)
            {
                this.fullName = fullName;
                this.birthDate = birthDate;
                this.phoneNumber = phoneNumber;
                this.workEmail = workEmail;
                this.position = position;
                this.jobDescription = jobDescription;
            }


            public void SetFullName(string fullName)
            {
                this.fullName = fullName;
            }

            public void SetBirthDate(DateTime birthDate)
            {
                this.birthDate = birthDate;
            }

            public void SetPhoneNumber(string phoneNumber)
            {
                this.phoneNumber = phoneNumber;
            }

            public void SetWorkEmail(string workEmail)
            {
                this.workEmail = workEmail;
            }

            public void SetPosition(string position)
            {
                this.position = position;
            }

            public void SetJobDescription(string jobDescription)
            {
                this.jobDescription = jobDescription;
            }


            public string GetFullName()
            {
                return fullName;
            }

            public DateTime GetBirthDate()
            {
                return birthDate;
            }

            public string GetPhoneNumber()
            {
                return phoneNumber;
            }

            public string GetWorkEmail()
            {
                return workEmail;
            }

            public string GetPosition()
            {
                return position;
            }

            public string GetJobDescription()
            {
                return jobDescription;
            }


            public void PrintInfo()
            {
                Console.WriteLine($"ФИО: {fullName}");
                Console.WriteLine($"Дата рождения: {birthDate.ToShortDateString()}");
                Console.WriteLine($"Телефон: {phoneNumber}");
                Console.WriteLine($"Рабочий Email: {workEmail}");
                Console.WriteLine($"Должность: {position}");
                Console.WriteLine($"Описание обязанностей: {jobDescription}");
            }

        }
        static void Main(string[] args)
        {

            Employee emp = new Employee("Иванов Иван Иванович", new DateTime(1985, 5, 20), "89001234567", "ivanov@company.com", "Менеджер", "Управление командой");


            emp.PrintInfo();

            emp.SetPosition("Старший менеджер");
            emp.SetJobDescription("Управление проектами и командой");

            emp.PrintInfo();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

