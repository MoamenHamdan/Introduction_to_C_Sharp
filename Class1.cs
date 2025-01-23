using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Class1
    {
 

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your midterm grade :"); 
            string input = Console.ReadLine();     
            int midterm = int.Parse(input);         
            Console.WriteLine("Enter your Final grade : ");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your lab grade : ");
            int lab = Convert.ToInt32(Console.ReadLine());  
            int total = midterm + lab + final ;
            Console.WriteLine("Your Course mark = " + total); 

        }
    }


}
