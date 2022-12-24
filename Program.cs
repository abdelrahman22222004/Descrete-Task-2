using System;
public class Exercise28
{
    public static void Main()
    {
        int n, i, sum;
        int min, max;


        Console.WriteLine("We put perfect numbers within a given number of range:");
        Console.Write("------------------------------------------------------");
        Console.WriteLine("");

        Console.Write("please ,input the starting range or number : ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("please ,input the ending range of number : ");
        max = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");
        for (n = min; n <= max; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }

    }
}