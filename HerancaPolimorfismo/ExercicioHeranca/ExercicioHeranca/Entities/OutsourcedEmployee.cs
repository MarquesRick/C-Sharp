using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHeranca.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) //Para reutilizar os parâmetros da classe Employee
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() //Reaproveitando a logica do pagamento comum; 
                + 1.1 * AdditionalCharge;
        }
    }
}
