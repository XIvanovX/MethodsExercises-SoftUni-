namespace _10.Multiply_Evens_by_Odds;
class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();

        int absValue = Math.Abs(int.Parse(number));

        int result = GetMultipleOfEvenAndOdds(absValue);
        Console.WriteLine(result);
        


    }

    private static int GetMultipleOfEvenAndOdds(int absValue)
    
    {
        int sumEvens = GetSumEven(absValue.ToString());
        int sumOdds = GetSumOdds(absValue.ToString());
        int result = sumEvens * sumOdds;
        return result;
       

    }

    private static int GetSumOdds(string absValue)
    {
        int sum = 0;

        for (int i = 0; i < absValue.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum += Math.Abs(int.Parse(absValue[i].ToString()));
            }

        }
        return sum;
    }

    private static int GetSumEven(string absValue)
    {

        int sum = 0;

        for(int i=0;i<absValue.Length;i++)
        {
            if(i%2!=0)
            {
                sum += Math.Abs(int.Parse(absValue[i].ToString()));
            }
            
        }
        return sum;
    }
}

