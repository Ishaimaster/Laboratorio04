using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2)
        {

            int Suma = 0;
            int maxLength = Math.Max(num1.Length, num2.Length);
            StringBuilder result = new StringBuilder(maxLength + 1);

            for (int i = 0; i < maxLength; i++)
            {
                int n1 = i < num1.Length ? num1[num1.Length - 1 - i] - '0' : 0;
                int n2 = i < num2.Length ? num2[num2.Length - 1 - i] - '0' : 0;
                int sum = n1 + n2 + Suma;
                Suma = sum / 10;
                result.Append(sum % 10);
            }

            if (Suma > 0)
            {
                result.Append(Suma);
            }

            char[] charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }

    
}
