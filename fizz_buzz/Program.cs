// fizz buzz

class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.Write("Enter starting number: ");
        int startNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        int endNum = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter divisor 1: ");
        int divisor1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter divisor 2: ");
        int divisor2 = Convert.ToInt32(Console.ReadLine());

        string[] values = { "Fizz", "Buzz", "FizzBuzz" };

        for (int i = startNum; i <= endNum; i++)
        {
            if (i % divisor1 == 0 && i % divisor2 == 0)
            {
                Console.WriteLine(values[2]);
            }
            else if (i % divisor1 == 0)
            {
                Console.WriteLine(values[0]);
            }
            else if (i % divisor2 == 0)
            {
                Console.WriteLine(values[1]);
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }
}


