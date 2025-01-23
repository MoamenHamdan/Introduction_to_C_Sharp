using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Class3
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number of courses you have : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sumOfCredits = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the name of the course : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the number of " + name );
                int credits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Grade of " + name);
                int grade = Convert.ToInt32(Console.ReadLine());
                sum += credits * grade;
                sumOfCredits += credits;
            }
            double gpa =(double) sum / (sumOfCredits * 25);
            Console.WriteLine("Your total GPA is : " + gpa);

        }
    }
}
 