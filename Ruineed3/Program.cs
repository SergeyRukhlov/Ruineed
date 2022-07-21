//Напишите программу, которая задаёт случайный массив 
//случайного размера  элементов  и выводит 
//на экран массив квадратов этих чисел.

namespace GB
{
    class Program
    {
        static Random random = new Random();
        static int[] FullRandomArrayGenerator()
        {
            int[] array = new int[random.Next(5,11)]; //[5, 10]
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(40) + 1; //[1, 40]
            }
            return array;
        }
        static void ViewArray(int[] array)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("{0}]", array.Last());
        }
        static void ViewArray(int[] array, int degree)
        {
            Console.Write("Массив: [");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write("{0}, ", Math.Pow(array[i], degree));
            }
            Console.WriteLine("{0}]", Math.Pow(array.Last(), degree));
        }
            
        static void Main(string[] asgs)
        {
            int[] array = FullRandomArrayGenerator();
            ViewArray(array);
            ViewArray(array, 2);
        }
    }
}