using System;

class Program
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        while (true)
        {
            Console.WriteLine("1. Calculate Sum\n2. Reverse Array\n3. Find Maximum\n4. Check Prime\n5. Sort Array\n6. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CalculateSum();
                    break;
                case 2:
                    ReverseArray();
                    break;
                case 3:
                    FindMaximum();
                    break;
                case 4:
                    CheckPrime();
                    break;
                case 5:
                    SortArray();
                    break;
                case 6:
                    return;
            }
        }
    }

    static void CalculateSum()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum: " + sum);
    }

    static void ReverseArray()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
        Console.WriteLine("Reversed Array: " + string.Join(" ", arr));
    }

    static void FindMaximum()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("Maximum: " + max);
    }

    static void CheckPrime()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num < 2) isPrime = false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }

    static void SortArray()
    {
        Console.Write("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
    }
}
