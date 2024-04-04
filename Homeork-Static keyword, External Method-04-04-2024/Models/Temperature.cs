namespace Homeork_Static_keyword__External_Method_04_04_2024.Models;

public static class Temperature
{
    public static double Fahranheit(this int temperature)
    {
        return (temperature * 1.8) + 32;
    }
    public static double Celsius(this double temperature)
    {
        return (int)Math.Round((temperature - 32) / 1.8);
    }
}
