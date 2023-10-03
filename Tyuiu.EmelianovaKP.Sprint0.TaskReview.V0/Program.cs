using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.EmelianovaKP.Sprint0.TaskReview.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: TaskReview                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Cоздать метод с именами и параметрами: Calc(int x, int y, int z),       *");
            Console.WriteLine("* который вычисляет следующее выражение (x+y+z)*5 и возвращает            *");
            Console.WriteLine("* целочисленное значение.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y, z;

            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите z: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + DataService.Calc(x, y, z));

            Console.ReadKey();
        }
    }
}
