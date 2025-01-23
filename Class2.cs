using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 or 2 : \n\t1.From C to F\n\t2.From F to C");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Temp : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (number) {
                case 1:
                    Console.WriteLine(temp + " Fahrenheit is " + (((temp - 32) * 5) / 9) + " Celsius ");
                    break;
                case 2:
                    Console.WriteLine(temp + " Celsius is " + (((temp - 32) / 1.8)) + " Fahrenheit");
                    break;

            }
        }
    }
}
