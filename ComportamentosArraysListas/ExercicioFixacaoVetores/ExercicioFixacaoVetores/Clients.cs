using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoVetores
{
    class Clients
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Clients(string name, string email)
        {

            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + "," + Email;
        }
    }
}

