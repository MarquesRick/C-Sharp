using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacaoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> list = new List<Employees>();
            Console.WriteLine("How many employees will be registered?");
            int qnt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qnt; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employees(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());
            Employees searchEmp = list.Find(x => x.Id == searchId);

            if(searchEmp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                searchEmp.IncreaseSalary(percentage);
                Console.WriteLine($"Data of Employe: {searchEmp} Increase in {percentage}%");
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }

            foreach(Employees obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
