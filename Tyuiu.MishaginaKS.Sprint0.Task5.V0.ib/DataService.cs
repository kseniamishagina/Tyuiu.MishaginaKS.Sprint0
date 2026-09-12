using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MishaginaKS.Sprint0.Task5.V0.Lib;


namespace Tyuiu.MishaginaKS.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)

        {
            return a + b;
        }

        public static int Subtraction(int a, int b)

        {
            return a - b;
        }

        public static int Multiplication(int a, int b)

        {
            return a * b;
        }

        public static double Division(int a, int b)

        {
            if (b == 0)
            { 
                Console.WriteLine("Переменная b = {0} на ноль делать нельзя", b);
            return -1;
        }

        else

        {
            return a / b;
        }
    }
}
}