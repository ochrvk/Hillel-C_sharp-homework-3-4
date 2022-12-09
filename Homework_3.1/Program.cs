using System;

internal class Program
{
    private static String Perimeter(int a, int b, int c)
    {
        return Convert.ToString(a + b + c);
    }

    private static void Result(int arraySize, int[] array, int methodCount)
    {
        for (int i = 0; i < methodCount; i++)
        {
            Console.WriteLine("-------------------");
            for (int j = 0; j < arraySize; j++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Please, type {0} side of {1} triangle: ", j + 1, i + 1);
                        array[j] = Convert.ToInt16(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong input! Please, try again!");
                    }
                }
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("|| Perimeter of the {0} triangle: {1} ||", i + 1, Perimeter(array[0], array[1], array[2]));
        }

    }

    private static void Main(string[] args)
    {
        int arraySize = 3;
        int methodCount = arraySize;
        int[] array = new int[arraySize];

        Result(arraySize, array, methodCount);
    }
}