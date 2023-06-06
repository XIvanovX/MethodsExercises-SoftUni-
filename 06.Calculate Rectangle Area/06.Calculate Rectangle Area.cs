namespace _06.Calculate_Rectangle_Area;
class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double result = GetRectangleArea(width, height);
        Console.WriteLine(result);


    }

    static double GetRectangleArea(double widhth, double height)
    {
        return widhth * height;
    }
}

