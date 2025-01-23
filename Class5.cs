using System;

class Program
{
    static void Main()
    {
        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Matrix Operations\n2. Fibonacci Series\n3. Factorial\n4. Number Patterns\n5. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    MatrixOperations();
                    break;
                case 2:
                    FibonacciSeries();
                    break;
                case 3:
                    Factorial();
                    break;
                case 4:
                    NumberPatterns();
                    break;
                case 5:
                    return;
            }
        }
    }

    static void MatrixOperations()
    {
        Console.Write("Enter size of matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("1. Transpose\n2. Sum of Diagonals\n3. Exit to Menu");
        int operation = int.Parse(Console.ReadLine());
        if (operation == 1)
        {
            int[,] transpose = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            Console.WriteLine("Transposed Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(transpose[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else if (operation == 2)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i] + matrix[i, n - i - 1];
            }
            if (n % 2 == 1)
            {
                sum -= matrix[n / 2, n / 2];
            }
            Console.WriteLine("Sum of Diagonals: " + sum);
        }
    }

    static void FibonacciSeries()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.Write("Fibonacci Series: {0} {1} ", a, b);
        for (int i = 2; i < terms; i++)
        {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Factorial()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        Console.WriteLine("Factorial: " + result);
    }

    static void NumberPatterns()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("1. Pyramid\n2. Reverse Pyramid\n3. Number Triangle\n4. Exit to Menu");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 2)
        {
            for (int i = rows; i >= 1; i--)
            {
                for (int j = rows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 3)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
