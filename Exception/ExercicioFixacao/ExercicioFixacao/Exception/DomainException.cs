using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
