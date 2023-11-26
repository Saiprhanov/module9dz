using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9HW
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary {  get; set; }
        public Employee(string name, int age,int salary) 
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public Employee(string v1, int v2, string v3)
        {
        }

        public void GetInfo() 
        {
            Console.WriteLine($"Name:{Name}, Age: {Age}, Salary: {Salary}");
        }
        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Nurkhadis", 20, 1000000, 500000);
            manager.GetInfo();
            decimal annualSalaryWithBonus = CalculateAnnualSalary();
            Console.WriteLine($"Annual Salary(With Bonus): {annualSalaryWithBonus}");
            Console.ReadKey();


        }

    }
}
