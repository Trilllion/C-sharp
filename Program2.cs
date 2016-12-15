using System;

class multiply
{
    public static void Main()
    {
        long sum = 0, t1 = 1, t = 1, SUM = 0;
        Console.WriteLine("Please enter to start");
        while(t < 4000000)
        {
            sum = t + t1;
            t1 = t;
            t = sum;
            if (t%2 == 0)
            {
                SUM = t + SUM;
            }
        }
        Console.WriteLine(SUM);
        Console.ReadLine();
    }   
}