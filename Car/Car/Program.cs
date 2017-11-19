using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazda Mazda1 = new Mazda(); //создание объекта Mazda1 класса Mazda
            Mazda Mazda2 = new Mazda();

            Mazda1.model = "model1";
            Mazda2.model = "model2";

            Console.WriteLine(Mazda1.model); // выводит на экран "model1"
            Console.Write(Mazda2.model);
            Console.ReadKey();
        }
    }
}
