// Напишите цикл,
//который принимает на вход два числа (A и B) и возводит
//число A в натуральную степень B.

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();

        int number = 3;
        int exponent = 5;
        int count = 1;
        int result = number;

        while (count < exponent)
        {
            result = result * number;
            count++;
        }
        Console.WriteLine($"{number} ^ {exponent} = {result} ");
        Console.WriteLine();
    }
}