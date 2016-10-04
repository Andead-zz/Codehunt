using System;
public class Program
{
    public static int Main()
    {
        Console.WriteLine(Puzzle(7));
        Console.WriteLine(Puzzle(7));

    }

    public static int Puzzle(int n)
    {
        var result = 0;
        for (var i = 1; i < n; i += 13)
        {
            result += i;
        }

        return result;
    }
}