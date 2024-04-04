namespace Homeork_Static_keyword__External_Method_04_04_2024.Models;

public static class Factoriall
{ 
    public static void Calculate(this int value)
    {
        int temp = 1;
        for (int i = value; i > 1; i--)
        {
            temp *= i;
        }
        Console.WriteLine(temp);
    }
}
