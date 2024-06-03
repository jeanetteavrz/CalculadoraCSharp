using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            /// El siguiente programa realiza las funciones de una calculadora.

            /// Variables
            int numberOne;
            int numberTwo;
            int result;
            string symbol;

            /// Solicitar los datos al usuario.
            Console.WriteLine("Ingrese el primer número");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            numberTwo = Convert.ToInt32(Console.ReadLine());

            /// Realizar las operaciones.

            switch (symbol) 
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    break;
                case "/":
                    result = numberOne / numberTwo;
                    break;
                default: Console.WriteLine("No se puede realizar la operación solicitada.");
                    break;
             }






        }
    }
}
