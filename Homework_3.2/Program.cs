internal class Program
{
    private static int[] ArrayInput()
    {
        int size = 0;
        Console.WriteLine("---------------------");
        Console.Write("Please, type length of the array: ");
        size = SafeInput(size);
        int[] array = new int[size];
        Console.WriteLine("---------------------");

        for (int i = 0; i < size; i++)
        {
            Console.Write("Please, type {0} element of the array: ", i + 1);
            array[i] = SafeInput(array[i]);
        }

        return array;
    }

    private static int SafeInput(int value)
    {
        int result = 0;

        while (true)
        {
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.Write("Wrong input! Please, try again: ");
            }
        }

        return result;
    }

    private static void ArrayOutput(int[] array)
    {
        Console.WriteLine("---------------------");
        Console.Write("Reverse Array: ");

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");

        }

        Console.WriteLine("\n---------------------");
    }

    private static void Main(string[] args)
    {
        ArrayOutput(ArrayInput());
    }
}
