using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment() //Virtual necessário para permitir que a função seja sobrescrita
        {
            return Hours * ValuePerHour;
        }
    }

}
