namespace Homeork_Static_keyword__External_Method_04_04_2024.Models;

public static class Simple
{
    public static void Simplle(this int value)
    {
        int count = 0;
        for (int i = 2; i * i < value; i++)
        {
            if(value % i == 0)
            {
                count++;
            }
        }
        if (count == 0) Console.WriteLine($"Sade {value}");
        else Console.WriteLine($"Murekkeb {value}");
    }
}
