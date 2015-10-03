using System;

internal class Solution
{
    private static void Main(String[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            string r = (i%3 == 0 && i%5 == 0) 
                ? "FizzBuzz" : (i%5 == 0) 
                ? "Buzz" : (i%3 == 0) 
                ? "Fizz" : i.ToString();
            Console.WriteLine(r);
        }
    }
}