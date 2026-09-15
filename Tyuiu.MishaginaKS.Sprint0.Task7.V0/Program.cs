using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MishaginaKS.Sprint0.Task7.V0.Lib;

namespace Tyuiu.MishaginaKS.Sprint0.Task7.V0

{
    class Program

    {
        static void Main(string[] args)

        {

            Console.Title = "Спринт #0 | Выполнила: Мишагина К. С. | АСОиУБ-26-1";

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #0                                                              *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                            *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #0                                                             *");
            Console.WriteLine("* Выполнила: Мишагина Ксения Сергеевна | АСОиУБ-26-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух   *");
            Console.WriteLine("* одинаковых массивов по длинне.                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");



            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива N№1");
            for (int i = 0; i < arrayNums1.Length; i++)

            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива N№2");
            for (int i = 0; i < arrayNums1.Length; i++)

            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             ");
            Console.WriteLine("**************************************************************************");

            {

                if (arrayNums1.Length == arrayNums2.Length)

                {
                    int[] resulArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                    Console.WriteLine("Сумма элементоа массива равна:");
                    for (int i = 0; i < resulArray.Length; i++)

                    {
                        Console.WriteLine(resulArray[i] + ", ");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");

                }
                Console.ReadKey();
            }

        }
    }
}
    