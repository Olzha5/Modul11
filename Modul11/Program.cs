using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{

    public enum Vacancies
    {
        Manager,
        Developer,
        Accountant,
        // Другие должности по необходимости
    }

    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] HireDate;
        public int Salary;

        public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = hireDate;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();

            Console.Write("Введите должность (Manager, Developer, Accountant): ");
            Vacancies vacancy;
            while (!Enum.TryParse(Console.ReadLine(), out vacancy))
            {
                Console.Write("Некорректное значение. Введите должность (Manager, Developer, Accountant): ");
            }

            Console.Write("Введите дату приема на работу (гггг-мм-дд): ");
            string[] dateParts = Console.ReadLine().Split('-');
            int[] hireDate = Array.ConvertAll(dateParts, int.Parse);

            Console.Write("Введите зарплату: ");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, vacancy, hireDate, salary);

            // Вывод информации о сотруднике
            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Должность: {employee.Vacancy}");
            Console.WriteLine($"Дата приема на работу: {employee.HireDate[0]}-{employee.HireDate[1]:D2}-{employee.HireDate[2]:D2}");
            Console.WriteLine($"Зарплата: {employee.Salary}");
        }
    }

}
