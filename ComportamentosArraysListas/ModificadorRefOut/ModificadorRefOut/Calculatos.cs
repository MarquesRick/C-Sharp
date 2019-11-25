using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorRefOut
{
    class Calculatos
    {
        public static void Triple1(ref int number)
        {
            number = number * 3;
        }

        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
