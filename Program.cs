using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Function you need to Run : ");
            Console.WriteLine("1. Exercise 1 \n2. Exercise 2 \n3. Exercise 3");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    int ex1 = Ex1();
                    Console.WriteLine("The index of your searching number is : " + ex1);
                    break;
                case 2:
                    Ex2();
                    break;
                case 3:
                    if (Ex3()) { Console.WriteLine("The array is Palindrom "); }
                    else { Console.WriteLine("The array is not palindrom "); }
                    break;
                default:
                    Console.WriteLine("Please enter valid number ");
                    break;
            }
        }
        //function to count the occurrence  number 
        public static void Ex2()
        {
            Console.WriteLine("Enter 10 values of elements :");
            int[] ints = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("A [" + (i + 1) + "]= ");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element that you want to check its occurrence:");
            int search = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == search)
                {
                    count++;
                }
            }
            Console.WriteLine("The element " + search + " is repeated " + count + " times");
        }
        //function that return the index of the searching number 
        //if not found reutrn -1 
        public static int Ex1()
        {
            Console.WriteLine("Enter the size of the array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element [" + (i + 1) + "]");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the number you're searching for ? ");
            int search = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == search)
                {
                    index = i; break;
                }
            }
            return index;
        }
        //function to return if the array is palindrom or not 
        public static bool Ex3()
        {
            Console.WriteLine("Enter the size of the array : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[number];
            Console.WriteLine("Enter elements of the array : ");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter element [" + (i + 1) + "]");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            int left = 0;
            int right = ints.Length - 1;
            bool flag = true;
            for (int i = 0; left < right; i++)
            {
                if (ints[left] == ints[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
    
    
public bool Ex5()
        {
            Console.WriteLine("Enter the size of the array : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[number];
            Console.WriteLine("Enter elements of the array : ");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter element [" + (i + 1) + "]");
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            int left = 0;
            int right = ints.Length - 1;
            bool flag = true;
            for (int i = 0; left < right; i++)
            {
                if (ints[left] == ints[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

    }
}