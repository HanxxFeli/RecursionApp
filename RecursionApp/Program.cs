namespace RecursionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NumberSum
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int numSum  = numberSum(n, m);
            Console.WriteLine(numSum);

            // DividebyTwo
            Console.WriteLine("Division");
            Console.WriteLine("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int divideCount = divideByTwo(number);
            Console.WriteLine($"Total numbe of divisons: {divideCount}");
        }

        public static int numberSum(int n, int m)
        {
            if (n > m)
            {
                return 0;
            }

            return n + numberSum(n+1, m);
        }

        public static int divideByTwo(int num)
        {
            int count = 0;
            while (num != 0 && num % 2 ==0)
            {
                num = num / 2;
                count++;
            }

            return count;
        }
    }
}
