    using System;

class multiply
{
    public static void Main()
    {
        number();
        Console.ReadLine();

    }

    static void number()
    {
        int k, y, t, div, sum = 0;
        string kstring, ystring;
        Console.WriteLine("Please enter number 1 and 2");
        kstring = Console.ReadLine();
        k = int.Parse(kstring);
        ystring = Console.ReadLine();
        y = int.Parse(ystring);
        for (t = 0; t < 1000; t++)
        {
            div = t % k;

            if ((t % 5 == 0) || (t % 3 == 0))
            {
                sum = sum + t;
            }

        }
            Console.WriteLine("The sum of multiple of " + k + " and " + y + " is : " + sum);




        
    }
}