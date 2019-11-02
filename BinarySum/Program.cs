using System;

namespace BinarySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Enter two numbers to get the sum in binary form.");
            Console.WriteLine("First number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
           // Console.WriteLine(sum);
            string binary = Convert.ToString(sum,2);
            Console.WriteLine($"Binary sum: {binary}" );
        }
    }
}
