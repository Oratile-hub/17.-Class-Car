using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();//creation of the book1  object, it gets all the attributes of the Book class

            //create the first book

            car1.name = "Mercedes Benz";
            car1.colour = "Mate Black";
            car1.year = 2023;



            //create the second book
            Car car2 = new Car();
            car2.name = "BMW";
            car2.colour = "Magenta";
            car2.year = 2022;

            Console.WriteLine(car1.name);
            Console.WriteLine(car1.colour);
            Console.WriteLine(car1.year);
            Console.WriteLine(car2.name);
            Console.WriteLine(car2.colour);
            Console.WriteLine(car2.year);

            //freeze console
            Console.ReadLine();

        }
    }
}
