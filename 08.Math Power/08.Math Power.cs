namespace _08.Math_Power;
class Program
{
    static void Main(string[] args)
    {
        double number = int.Parse(Console.ReadLine());
        double power = int.Parse(Console.ReadLine());

        double result = MathPowerCalculation(number, power);
        Console.WriteLine(result);
    }

    private static double MathPowerCalculation(double number, double power)
    {
        double result = Math.Pow((double)number, (double)power);
        return result;
    }

}


